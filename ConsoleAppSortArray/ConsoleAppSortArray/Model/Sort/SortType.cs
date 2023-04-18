namespace ConsoleAppSortArray;

using System;

public abstract class SortType 
{
    public abstract string SortName { get; }
    public abstract int[] Sort(int[] unsortedArray);
}