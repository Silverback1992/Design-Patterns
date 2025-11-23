namespace Singleton;

//Double checked locking is necessary to improve performance
//Apart from that this is called naive because it is longer that it needs to be - it is a functional and ok implementation
public sealed class NaiveThreadSafeLazyLoadingSingleton
{
    private static NaiveThreadSafeLazyLoadingSingleton _instance = default!;
    private static readonly Lock _lock = new();

    public static NaiveThreadSafeLazyLoadingSingleton Instance
    {
        get
        {

            //Console.WriteLine("Locking...");

            //lock (_lock)
            //{
            //    if (_instance == null)
            //    {
            //        _instance = new NaiveThreadSafeLazyLoadingSingleton();
            //    }
            //}


            if (_instance == null)
            {
                Console.WriteLine("Locking...");

                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new NaiveThreadSafeLazyLoadingSingleton();
                    }
                }
            }

            return _instance;
        }
    }

    private NaiveThreadSafeLazyLoadingSingleton()
    {
        Console.WriteLine("Initializing singleton");
    }
}
