namespace Singleton;
public sealed class CoolWayToImplementSingleton
{
    public static string ClassName => "class";
    public static CoolWayToImplementSingleton Instance => Nested.Instance;

    private CoolWayToImplementSingleton()
    {

    }

    static CoolWayToImplementSingleton()
    {

    }

    private class Nested
    {
        internal static CoolWayToImplementSingleton Instance { get; } = new();

        static Nested()
        {

        }
    }
}
