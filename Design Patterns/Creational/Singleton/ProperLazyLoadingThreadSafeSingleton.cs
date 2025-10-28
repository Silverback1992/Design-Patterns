namespace Singleton;
public sealed class ProperLazyLoadingThreadSafeSingleton
{
    private static readonly Lazy<ProperLazyLoadingThreadSafeSingleton> _instance = new(() => new ProperLazyLoadingThreadSafeSingleton());

    public static ProperLazyLoadingThreadSafeSingleton Instance => _instance.Value;

    private ProperLazyLoadingThreadSafeSingleton()
    {
        Console.WriteLine("Initializing singleton");
    }
}
