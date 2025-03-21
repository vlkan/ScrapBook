internal class Program
{
    private static void Main(string[] args)
    {
        int value = 5;
        Console.WriteLine("Main: Before Call Method: {0}", value);
        ChangeValue(ref value);
        Console.WriteLine("Main: After Call Method: {0}", value);
    }

    public static void ChangeValue(ref int value)
    {
        Console.WriteLine("ChangeValue: Before Changing Value: {0}", value);
        value = 10;
        Console.WriteLine("ChangeValue: After Changing Value: {0}", value);

    }
}