using Thread_Safe_Example;

internal class Program
{
    private static void Main(string[] args)
    {
        // Thread-safe OLMAYAN test:
        NotThreadSafeSingleton.instance = null;
        NotThreadSafeSingleton.counter = 0;
        Thread[] threads = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                var instance = NotThreadSafeSingleton.GetInstance();
            });
            threads[i].Start();
        }
        foreach (var t in threads)
            t.Join();
        Console.WriteLine($"NotThreadSafeSingleton oluşturulan instance sayısı: {NotThreadSafeSingleton.counter}");

        // Thread-safe olan test:
        ThreadSafeSingleton.counter = 0;
        threads = new Thread[10];
        for (int i = 0; i < 10; i++)
        {
            threads[i] = new Thread(() =>
            {
                var instance = ThreadSafeSingleton.GetInstance();
            });
            threads[i].Start();
        }
        foreach (var t in threads)
            t.Join();
        Console.WriteLine($"ThreadSafeSingleton oluşturulan instance sayısı: {ThreadSafeSingleton.counter}");

        Console.ReadKey();

    }
}