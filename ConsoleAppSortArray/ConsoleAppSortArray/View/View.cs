namespace ConsoleAppSortArray;

public static class View
{
    public static void InputTextDisplayArray()
    {
        Console.WriteLine("Welcome to the random array sorter!!");
        Console.Write("Please Choose the length of the array: ");
    }

    public static void InputTextDisplaySort()
    {
        Console.WriteLine("Press 1 for BubbleSort");
        Console.WriteLine("Press 2 for MergeSort");
        Console.WriteLine("Press 3 for DotNetSort");
        Console.Write("Choice: ");
    }

    public static void Output(int[] unsortedArray, int[] sortedArray, string elapsedTime)
    {
        Console.WriteLine();
        Console.WriteLine("Unsorted Array: " + string.Join(", ", unsortedArray));
        Console.WriteLine();
        Console.WriteLine("Sorted Array: " + string.Join(", ", sortedArray));

        string seconds = elapsedTime.Substring(7);

        Console.WriteLine();
        Console.WriteLine("Elapsed Time: " + seconds + "s");
    }
}

