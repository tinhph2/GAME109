using System;

public class Example
{
    // Khai báo một trường readonly
    private readonly int id;

    // Hàm tạo của lớp Example
    public Example(int initialId)
    {
        id = initialId; // Gán giá trị cho trường readonly trong hàm tạo
    }

    // Phương thức để in giá trị của trường readonly
    public void DisplayId()
    {
        Console.WriteLine("ID: " + id);
    }

    public static void Main()
    {
        // Tạo một đối tượng Example
        Example example = new Example(100);

        // Gọi phương thức để in giá trị của trường readonly
        example.DisplayId();

        // Không thể gán lại giá trị cho trường readonly
        // example.id = 200; // Sẽ gây lỗi biên dịch
    }
}