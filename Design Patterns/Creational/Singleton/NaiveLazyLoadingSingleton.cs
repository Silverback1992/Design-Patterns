namespace Singleton;

//Not thread safe
public sealed class NaiveLazyLoadingSingleton
{
    private static NaiveLazyLoadingSingleton _instance = default!;

    public static NaiveLazyLoadingSingleton Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new NaiveLazyLoadingSingleton();
            }

            return _instance;
        }
    }

    private NaiveLazyLoadingSingleton()
    {
        Console.WriteLine("Initializing singleton.");
    }
}
