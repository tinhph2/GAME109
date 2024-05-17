using System;
using System.Collections.Generic;

// Định nghĩa lớp Student
public class Student
{
    public string Name { get; set; }
    public int Age { get; set; }
    public Student(string name, int age)
    {
        Name = name;
        Age = age;
    }
    // Phương thức để hiển thị thông tin sinh viên
    public void DisplayInfo()
    {
        Console.WriteLine($"Name: {Name}, Age: {Age}");
    }
}

class Program
{
    static void Main()
    {
        // Tạo một List để lưu trữ các đối tượng Student
        List<Student> studentList = new List<Student>();

        // Thêm các đối tượng Student vào List
        studentList.Add(new Student("Alice", 20));
        studentList.Add(new Student("Bob", 22));
        studentList.Add(new Student("Charlie", 21));

        // Duyệt qua List để hiển thị thông tin của các sinh viên
        foreach (var student in studentList)
        {
            student.DisplayInfo();
        }
    }
}