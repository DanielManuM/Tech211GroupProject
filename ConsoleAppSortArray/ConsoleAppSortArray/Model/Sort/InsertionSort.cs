﻿namespace ConsoleAppSortArray;

public class InsertionSort : SortType
{
    public override string MethodName => "insertion sort";
    public override int[] Sort(int[] arr)
    {
        if (arr is null)
        {
            throw new ArgumentNullException(nameof(arr), "Input cannot be null.");
        };

        int i = 1;
        while (i < arr.Length)
        {
            int j = i;
            while (j > 0 && arr[j - 1] > arr[j])
            {
                (arr[j - 1], arr[i]) = (arr[i], arr[j - 1]);
                i = j - 1;
            }
            i++;
        }

        return arr;
    }
}
