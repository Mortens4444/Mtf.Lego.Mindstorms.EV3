using System.Collections;
using System.Runtime.CompilerServices;

namespace Mtf.Lego.Mindstorms.EV3.Enums;

public abstract class EnumLikeObject<T>(byte value, string name)
{
    private static bool initialized;

    public static readonly Dictionary<byte, T> Values = [];

    public byte Value { get; private set; } = value;

    public string Name { get; private set; } = String.IsNullOrEmpty(name) ? value.ToString() : name;

    public override string ToString()
    {
        return Name;
    }

    public static IList GetValues()
    {
        EnsureInitialized();
        return Values.Values.ToList();
    }

    public static IList GetNotCombinedValues()
    {
        EnsureInitialized();
        var powersOfTwo = new List<byte>();
        for (int i = 0; i < 8; i++)
        {
            powersOfTwo.Add((byte)Math.Pow(2, i));
        }
        return Values.Where(kvp => powersOfTwo.Contains(kvp.Key)).Select(kvp => kvp.Value).ToList();
    }

    public static T? Parse(string name)
    {
        EnsureInitialized();
        var fields = typeof(T).GetFields();
        var fieldInfo = fields.Single(field => String.Equals(field.Name, name, StringComparison.OrdinalIgnoreCase));
        return (T?)fieldInfo.GetValue(null);
    }

    private static void EnsureInitialized()
    {
        if (!initialized)
        {
            initialized = true;
            var type = typeof(T);
            RuntimeHelpers.RunClassConstructor(type.TypeHandle);
        }
    }
}
