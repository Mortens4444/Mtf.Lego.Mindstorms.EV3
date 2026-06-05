using Mtf.Lego.Mindstorms.EV3.Enums;
using Mtf.Lego.Mindstorms.EV3.Extensions;

namespace Mtf.Lego.Mindstorms.EV3.Commands.System;

public class SetBrickName : Command
{
    public SetBrickName(string brickName)
    {
        data = DirectCommandNoReply;
        data.Add(OpCode.ComSet);
        data.Add(ComSetSubCommand.SetBrickName);
        data.AppendStringParameter(brickName);
    }
}
