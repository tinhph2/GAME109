using System;

public class Demo2
{
    private static int count = 0; // Khai báo một thành viên tĩnh

    public Demo2()
    {
        count++; // Mỗi lần tạo một đối tượng, tăng giá trị count lên 1
    }

    public static void ShowCount()
    {
        Console.WriteLine("Number of instances created: " + count);
    }

    public static void Main()
    {
        Demo2 obj1 = new Demo2(); // Tạo một đối tượng
        Demo2 obj2 = new Demo2(); // Tạo một đối tượng khác

        Demo2.ShowCount(); // In ra số lượng đối tượng đã được tạo
    }
}