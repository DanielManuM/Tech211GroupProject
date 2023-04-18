namespace ConsoleAppSortArray;

public class DotNetSortClass : SortType
{
    public override int[] Sort(int[] inputArray)
    {
        Array.Sort(inputArray);
        return inputArray;
    }
}
