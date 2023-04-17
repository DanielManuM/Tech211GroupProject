namespace ConsoleAppSortArray;

using System;

public class BubbleSortClass
{
    public static int[] BubbleSort(int[] inputArray)
    {
        int n = inputArray.Length;
        bool swapped = false;
        do
        {
            swapped = false;
            for (int i = 1; i <= n - 1; i++)
            {
                if (inputArray[i - 1] > inputArray[i])
                {
                    int a = inputArray[i - 1];
                    inputArray[i - 1] = inputArray[i];
                    inputArray[i] = a;
                    swapped = true;
                }
            }
        } while (swapped);
        return inputArray;
    }
}
