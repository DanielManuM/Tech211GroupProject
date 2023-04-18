namespace ConsoleAppSortArray;

using System;

public static class InputCollector
{
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
