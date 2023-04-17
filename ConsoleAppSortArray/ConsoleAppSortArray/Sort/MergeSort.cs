namespace ConsoleAppSortArray;

using System;

public class MergeSortClass
{
    public static int[] MergeSort(int[] input1, int[] input2)
    {
        if (input1 is null || input2 is null) throw new ArgumentException("Null");
        if (input1.Length == 0) return input2;
        if (input2.Length == 0) return input1;
        int[] result = new int[input1.Length + input2.Length];
        int pointer = 0;
        int index1 = 0;
        int index2 = 0;
        while (index1 < input1.Length && index2 < input2.Length)
        {
            if (input1[index1] < input2[index2])
            {
                result[pointer] = input1[index1];
                index1++;
            }
            else
            {
                result[pointer] = input2[index2];
                index2++;
            }
            pointer++;
        }
        while (index1 < input1.Length)
        {
            result[pointer] = input1[index1];
            index1++;
            pointer++;
        }
        while (index2 < input2.Length)
        {
            result[pointer] = input2[index2];
            index2++;
            pointer++;
        }

        return result;
    }
}
