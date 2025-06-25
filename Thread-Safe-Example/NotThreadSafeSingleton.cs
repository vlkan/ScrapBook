namespace Thread_Safe_Example;

public class NotThreadSafeSingleton
{
    public static NotThreadSafeSingleton instance;
    public static int counter = 0;

    public NotThreadSafeSingleton()
    {
        counter++;
    }

    public static NotThreadSafeSingleton GetInstance()
    {
        if (instance == null)
        {
            System.Threading.Thread.Sleep(10); // For Testing
            instance = new NotThreadSafeSingleton();
        }
        return instance;
    }
}
