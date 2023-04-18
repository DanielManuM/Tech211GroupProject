namespace ConsoleAppSortArray;

using System;

public static class InputCollector
{
    public static int InputArrayLength()
    {
        bool isNumber = Int32.TryParse(Console.ReadLine(), out int value);
        while (!isNumber)
        {
            Console.WriteLine("Please input numbers!!");
            isNumber = Int32.TryParse(Console.ReadLine(), out value);           
        }
        return value;
    }

    public static int InputSortType()
    {
        bool isNumber = Int32.TryParse(Console.ReadLine(), out int value);
        while (!isNumber || value > 4 || value < 1 )
        {
            Console.WriteLine("Please input numbers between 1 and 3!!");
            isNumber = Int32.TryParse(Console.ReadLine(), out value);
        }
        return value;
    }

}
