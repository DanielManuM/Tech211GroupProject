using System.Diagnostics;

namespace ConsoleAppSortArray;

public class Controller
{
    public static void RunApp()
    {
        
        View.DisplayGreeting();

        string run = "y";
        while (run == "y")
        {
            View.InputTextDisplayArray();
            int arrayLength = InputCollector.InputArrayLength();
            View.InputTextDisplaySort();
            int sortType = InputCollector.InputSortType();

            SortType? sortObject = Sorter.GetSortClass(sortType);

            int[] randArray = ArrayGenerator.RandomArrayGenerator(arrayLength);

            int[] originalRandArray = (int[])randArray.Clone();

            int[] sortedArray;
            string elapsedTime = GetTime(sortObject, randArray, out sortedArray);

            View.Output(sortObject, originalRandArray, sortedArray, elapsedTime);

            run = InputCollector.InputDecision();
        }

        View.DisplayExitMessage();
    }

    public static string GetTime(SortType sortObject, int[] randArray, out int[] sortedArray)
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        sortedArray = sortObject.Sort(randArray);
        stopwatch.Stop();
        return stopwatch.Elapsed.ToString();
    }
}