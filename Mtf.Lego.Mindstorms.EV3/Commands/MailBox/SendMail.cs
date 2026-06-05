using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.MailBox;

public class SendMail : Command
{
#warning This command must be tested.
    public SendMail(string name, string message)
    {
        data = SystemCommandNoReply;
        data.Add(SystemCommand.WriteMailbox);
        data.Add((byte)name.Length);
        data.Append(name);
        data.Append((ushort)message.Length);
        data.Append(message);
    }
}
