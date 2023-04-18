using System.Diagnostics;

namespace ConsoleAppSortArray;

public class Controller
{
    public static void RunApp()
    {
        View.InputTextDisplayArray();
        var arrayLength = InputCollector.InputArrayLength();
        View.InputTextDisplaySort();
        int sortType = InputCollector.InputSortType();

        var sortObject = Sorter.GetSortClass(sortType);
        var randArray = ArrayGenerator.RandomArrayGenerator(arrayLength);

        var fixedRandArray = new int[arrayLength];
        randArray.CopyTo(fixedRandArray, 0);

        var stopwatch = Stopwatch.StartNew();
        var sortedArray = sortObject.Sort(randArray);
        stopwatch.Stop();

        var elapsedTime = stopwatch.Elapsed.ToString();

        View.Output(fixedRandArray, sortedArray, elapsedTime);
    }

}
