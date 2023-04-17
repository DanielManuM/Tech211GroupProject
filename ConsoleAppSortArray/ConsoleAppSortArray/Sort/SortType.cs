namespace ConsoleAppSortArray;

using System;

public abstract class SortType 
{
    public abstract string SortName { get; set; }
    public abstract int[] Sort(int[] unsortedArray);
}