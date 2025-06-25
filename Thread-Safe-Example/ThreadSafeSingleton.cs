namespace Thread_Safe_Example;

public class ThreadSafeSingleton
{
    private static ThreadSafeSingleton instance;
    private static readonly object lockObj = new object();
    public static int counter = 0;

    public ThreadSafeSingleton()
    {
        counter++;
    }

    public static ThreadSafeSingleton GetInstance()
    {
        lock (lockObj)
        {
            if (instance == null)
            {
                // Thread.Sleep ekleyerek, iki thread'in yarışmasını simüle ediyoruz.
                System.Threading.Thread.Sleep(10);
                instance = new ThreadSafeSingleton();
            }
            return instance;
        }
    }
}
