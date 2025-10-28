using Singleton;

Console.WriteLine("Choose an option:");
Console.WriteLine("1 - Naive Lazy Loading Singleton Demo");
Console.WriteLine("2 - Naive Lazy Loading Singleton Thread Unsafe Demo");
Console.WriteLine("3 - Naive Thread Safe Lazy Loading Singleton Demo");
Console.WriteLine("4 - Proper Lazy Loading Thread Safe Singleton Demo");
Console.WriteLine("0 - Exit");
Console.Write("\nEnter a number: ");

string? input = Console.ReadLine();

Console.WriteLine("\nDemo:\n");

switch (input)
{
    case "1":
        NaiveLazyLoadingSingletonDemo();
        break;
    case "2":
        NaiveLazyLoadingSingletonThreadUnsafeDemo();
        break;
    case "3":
        NaiveThreadSafeLazyLoadingSingletonDemo();
        break;
    case "4":
        ProperLazyLoadingThreadSafeSingletonDemo();
        break;
    default:
        return;
}

static void NaiveLazyLoadingSingletonDemo()
{
    Console.WriteLine("Before accessing instance");
    var singleton = NaiveLazyLoadingSingleton.Instance;
    Console.WriteLine("After accessing instance");
    var singleton2 = NaiveLazyLoadingSingleton.Instance;
}

static void NaiveLazyLoadingSingletonThreadUnsafeDemo()
{
    ParallelEnumerable.Range(0, 1000).ForAll(_ =>
    {
        var singleton = NaiveLazyLoadingSingleton.Instance;
    });
}

static void NaiveThreadSafeLazyLoadingSingletonDemo()
{
    ParallelEnumerable.Range(0, 1000).ForAll(_ =>
    {
        var singleton = NaiveThreadSafeLazyLoadingSingleton.Instance;
    });
}

static void ProperLazyLoadingThreadSafeSingletonDemo()
{
    ParallelEnumerable.Range(0, 1000).ForAll(_ =>
    {
        var singleton = ProperLazyLoadingThreadSafeSingleton.Instance;
    });
}
