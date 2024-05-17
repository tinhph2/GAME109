using System;

// Định nghĩa một class có chứa partial method
public partial class PartialMethodExample
{
    partial void DisplayMessage(string message); // Khai báo partial method
}

public partial class PartialMethodExample
{
    public void CallPartialMethod()
    {
        DisplayMessage("Hello, this is a partial method example.");
    }

    partial void DisplayMessage(string message) // Triển khai partial method
    {
        Console.WriteLine(message);
    }
}

public class Program
{
    static void Main()
    {
        PartialMethodExample example = new PartialMethodExample();
        example.CallPartialMethod();
    }
}