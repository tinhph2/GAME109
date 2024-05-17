using System;

public static class MathUtility
{
    public static int Add(int a, int b)
    {
        return a + b;
    }

    public static int Subtract(int a, int b)
    {
        return a - b;
    }
}

public class Program
{
    public static void Main()
    {
        int result1 = MathUtility.Add(5, 3);
        Console.WriteLine("5 + 3 = " + result1);

        int result2 = MathUtility.Subtract(10, 4);
        Console.WriteLine("10 - 4 = " + result2);

        // Không thể tạo một phiên bản của lớp tĩnh
        // MathUtility utility = new MathUtility(); // Sẽ gây lỗi biên dịch
    }
}