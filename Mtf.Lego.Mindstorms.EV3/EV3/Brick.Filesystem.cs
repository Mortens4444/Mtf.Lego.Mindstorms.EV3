using Mtf.Lego.Mindstorms.EV3.Commands.File;
using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.FileWriter;
using System.Globalization;
using System.Text;

namespace Mtf.Lego.Mindstorms.EV3.EV3;

public partial class Brick
{
    public IEnumerable<string> GetFolderContent(string path)
    {
        var response = ExecuteSystemCommand(new ListFiles(path));
        var rawDataWithOffset = response.RawResponseData.Skip(SystemCommandReply.SystemCommandResponseHeaderLength).ToArray();
        var folderContentStringBuilder = new StringBuilder(Encoding.UTF8.GetString(rawDataWithOffset));

        while (response.CommandReplyStatus != CommandReplyStatus.EndOfFile)
        {
            response = ExecuteSystemCommand(new ContinueListFiles(response.Handle));
            rawDataWithOffset = response.RawResponseData.Skip(SystemCommandReply.ContinueSystemCommandResponseHeaderLength).ToArray();
            folderContentStringBuilder.Append(Encoding.UTF8.GetString(rawDataWithOffset));
        }

        return folderContentStringBuilder.ToString().Split(new[] { '\n' }, StringSplitOptions.RemoveEmptyEntries);
    }

    public int GetSize(string filePath)
    {
        var folder = filePath[..filePath.LastIndexOf('/')];
        var fileName = Path.GetFileName(filePath);
        var folderContent = GetFolderContent(folder);
        foreach (var item in folderContent)
        {
            var properties = item.Split(' ');
            if ((properties.Length > 2) && (fileName == String.Join(" ", properties.Skip(2))))
            {
                return Int32.Parse(properties[1], NumberStyles.HexNumber);
            }
        }

        throw new FileNotFoundException($"Can't find file: {filePath}");
    }

    public bool IsExists(string filePath)
    {
        var result = Execute(new IsExists(filePath));
        return Convert.ToBoolean(result.RawResponseData[3]);
    }

    public void CopyFileToBrick(string sourceFilePath, string destinationFilePath)
    {
        var fileContentToSend = File.ReadAllBytes(sourceFilePath);
        var fileSize = fileContentToSend.Length;

        var uploadFileToBrick = new UploadFileToBrick(destinationFilePath, fileSize);
        var reply = ExecuteSystemCommand(uploadFileToBrick);
        var fileHandle = reply.Handle;

        var bytesToSend = 0;
        var skippedBytes = 0;

        while ((fileSize -= bytesToSend) > 0)
        {
            skippedBytes += bytesToSend;
            bytesToSend = Math.Min(fileSize, Constants.ChunkSize);
            var dataBytes = fileContentToSend.Skip(skippedBytes).Take(bytesToSend);
            Execute(new ContinueUploadFileToBrick(fileHandle, dataBytes));
        }
    }

    public bool CopyFileFromBrick(string sourceFilePath, int fileSize, IWriter writer)
    {
        int chunkSize = 0;
        byte fileHandle = 0;
        SystemCommandReply? reply;

        while ((fileSize -= chunkSize) > 0)
        {
            var notFirstChunk = chunkSize != 0;
            if (notFirstChunk)
            {
                reply = ExecuteSystemCommand(new ContinueDownloadFileFromBrick(fileHandle));
            }
            else
            {
                reply = ExecuteSystemCommand(new DownloadFileFromBrick(sourceFilePath, fileSize));
                fileHandle = reply?.Handle ?? 0;
            }

            if (reply != null)
            {
                chunkSize = GetChunkSize(fileSize, reply.RawResponseData.Length, notFirstChunk);
                writer.Write(reply.RawResponseData, SystemCommandReply.ContinueSystemCommandResponseHeaderLength, chunkSize);
            }
        }

        return true;
    }

    private static int GetChunkSize(int fileSize, int rawResponseDataLength, bool @continue)
    {
        var modifier = @continue ? SystemCommandReply.ContinueSystemCommandResponseHeaderLength : SystemCommandReply.SystemCommandResponseHeaderLength;
        return Math.Min(Math.Min(fileSize, Constants.ChunkSize), rawResponseDataLength - modifier);
    }

    public void CreateDirectory(string fullPathDirectoryName)
    {
        Execute(new CreateDirectory(fullPathDirectoryName));
    }

    public bool DeleteFile(string fullPathFileName)
    {
        var result = Execute(new DeleteFile(fullPathFileName));
        return result?.CommandReplyStatus == CommandReplyStatus.Success;
    }
}
