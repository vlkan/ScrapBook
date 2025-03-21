internal class Program
{
    private static void Main(string[] args)
    {
        #region ref
        int value = 5;
        Console.WriteLine("Main: Before Call Method: {0}", value);
        ChangeValue(ref value);
        Console.WriteLine("Main: After Call Method: {0}", value);
        #endregion

        #region out
        int resSquare, resCube;
        CalcSquareAndCube(5, out resSquare, out resCube);
        Console.WriteLine("For: {0}, Square: {1}, Cube: {2}", 5, resSquare, resCube);
        #endregion

        /*
         ref ile out farkı:
            ref: Değişkenin metot çağrılmadan önce bir değer almış olması gerekir.
            out: Değişkenin metot içinde mutlaka atanması gerekir.
         */

        #region params
        AddWithParams(1, 2, 3);
        AddWithParams(6, 7, 8, 9, 0);
        #endregion
    }

    public static void ChangeValue(ref int value)
    {
        Console.WriteLine("ChangeValue: Before Changing Value: {0}", value);
        value = 10;
        Console.WriteLine("ChangeValue: After Changing Value: {0}", value);
    }

    public static void CalcSquareAndCube(int value, out int square, out int cube)
    {
        square = value * value;
        cube = value * value * value;
    }

    public static void AddWithParams(params int[] values)
    {
        int sum = 0;
        foreach (var value in values)
        {
            sum += value;
        }
        Console.WriteLine("Sum: {0}", sum);
    }
}