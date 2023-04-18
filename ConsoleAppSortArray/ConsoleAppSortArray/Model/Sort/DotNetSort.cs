namespace ConsoleAppSortArray;

using System;

public class DotNetSortClass : SortType
{
    public override string SortName => "DotNetSort";
    public override int[] Sort(int[] inputArray)
    {
        Array.Sort(inputArray);
        return inputArray;
    }
}
