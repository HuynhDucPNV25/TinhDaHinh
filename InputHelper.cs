using System;

public static class InputHelper
{
    public static double ReadDouble(string prompt)
    {
        Console.Write(prompt);
        string input = Console.ReadLine();
        double value;
        while (!double.TryParse(input, out value))
        {
            Console.WriteLine("Giá trị không hợp lệ. Vui lòng nhập lại.");
            Console.Write(prompt);
            input = Console.ReadLine();
        }
        return value;
    }
}