/* Nếu file example.txt không ở cùng thư mục với chương trình, cần cung cấp đường dẫn đầy đủ đến file. 
 * Dưới đây là một ví dụ về cách chỉ định đường dẫn tới file trong một thư mục cụ thể: string filePath = @"C:\Users\YourUsername\Documents\example.txt";
*/

using System;
using System.IO;
using System.Reflection.PortableExecutable;

class Program
{
    static void reaFileWriteFile()
    {
        string filePath1 = "example.txt";
        string filePath2 = "output.txt";

        // Mở file để đọc với FileStream và StreamReader ở chế độ đọc
        using (FileStream fileStream1 = new FileStream(filePath1, FileMode.Open, FileAccess.Read))
        using (StreamReader reader = new StreamReader(fileStream1))

        // Mở file để ghi với FileStream và StreamWriter ở chế độ ghi
        using (FileStream fileStream2 = new FileStream(filePath2, FileMode.Create, FileAccess.Write))
        using (StreamWriter writer = new StreamWriter(fileStream2))
        {
            string line;
            while ((line = reader.ReadLine()) != null) // đọc từng dòng dữ liệu từ file example.txt
            {
                // Ghi dữ liệu từ file example sang file output
                writer.WriteLine(line);
            }

            Console.WriteLine("Dữ liệu được sao chép từ file input sang file output.");
        }
    }

    static void Main()
    {
        reaFileWriteFile();
  
    }
}