namespace ConsoleAppSortArray;

using System;
using System.Diagnostics;

public class Timer
{
    public static TimeSpan Time(Action action)
    {
        var stopwatch = Stopwatch.StartNew();
        action();
        stopwatch.Stop();
        return stopwatch.Elapsed;
    }
}