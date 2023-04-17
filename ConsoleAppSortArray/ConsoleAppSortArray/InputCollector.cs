namespace ConsoleAppSortArray;

using System;

public class InputCollector
{
    public static void InputTextDisplayArray()
    {
        Console.WriteLine("Please Choose the length of the array");
    }

    public static int InputArrayLength()
    {

        bool isNumber = Int32.TryParse(Console.ReadLine(), out int value);
        if (isNumber == false)
        {
            throw new FormatException("Please input numbers!!");
        }
        else
        {
            return value;
        }
    }

    public static void InputTextDisplaySort()
    {
        Console.WriteLine("Press 1 for BubbleSort");
        Console.WriteLine("Press 2 for MergeSort");
        Console.WriteLine("Press 3 for DotNetSort");
    }

    public static int InputSortType()
    {

        bool isNumber = Int32.TryParse(Console.ReadLine(), out int value);
        if (isNumber == false)
        {
            throw new FormatException("Please input numbers!!");
        }
        else
        {
            return value;
        }
    }

}
