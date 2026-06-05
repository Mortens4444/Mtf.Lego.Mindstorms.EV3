using Mtf.Lego.Mindstorms.EV3.Enums;

namespace Mtf.Lego.Mindstorms.EV3;

public interface ICommandReply
{
    ushort MessageCounter { get; }

    CommandType CommandType { get; }

    CommandReplyStatus CommandReplyStatus { get; }

    byte[] RawResponseData { get; }

    string GetResponseAsString();
}
