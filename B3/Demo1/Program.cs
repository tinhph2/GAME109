using System;
using System.IO;

class Program
{
    static void Main()
    {
        string inputFilePath = "input.txt";
        string outputFilePath = "output.txt";

        // Đọc dữ liệu từ file input và ghi vào file output
        using (FileStream inputFileStream = new FileStream(inputFilePath, FileMode.Open, FileAccess.Read))
        using (StreamReader reader = new StreamReader(inputFileStream))
        using (FileStream outputFileStream = new FileStream(outputFilePath, FileMode.Create, FileAccess.Write))
        using (StreamWriter writer = new StreamWriter(outputFileStream))
        {
            string line;
            while ((line = reader.ReadLine()) != null)
            {
                // Ghi dữ liệu từ file input sang file output
                writer.WriteLine(line);
            }

            Console.WriteLine("Dữ liệu được sao chép từ file input sang file output.");
        }
    }
}