namespace ConsoleAppSortArray;

public static class Sorter
{
    public static SortType? GetSortClass(string method) => method switch
    {
        "merge" => new MergeSort(),
        "bubble" => new BubbleSortClass(),
        "dotnet" => new DotNetSortClass(),
        _ => null
    };
}