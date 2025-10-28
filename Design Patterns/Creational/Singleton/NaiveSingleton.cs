namespace Singleton;

//Problem here is that if we have a long running task beforehand the Instance may be initialized even though we are not using it at that moment
public sealed class NaiveSingleton
{
    public static NaiveSingleton Instance { get; } = new();

    private NaiveSingleton()
    {
        //Console.WriteLine("Initializing singleton");
    }
}
