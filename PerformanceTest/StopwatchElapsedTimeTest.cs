// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using System.Diagnostics;
using System.Runtime.CompilerServices;

namespace PerformanceTest;

[SimpleJob]
[MemoryDiagnoser]
public class StopwatchElapsedTimeTest
{
    private static readonly long StartTime = System.Diagnostics.Stopwatch.GetTimestamp();
    
    [Benchmark(Baseline = true)]
    public TimeSpan StopwatchTest()
    {
        return Stopwatch.GetElapsedTime(StartTime);
    }
    
    [Benchmark]
    public TimeSpan WatchGetElapsedTimeTest()
    {
        return StopwatchHelper.WatchGetElapsedTime(StartTime);
    }
    
    [Benchmark]
    public TimeSpan WatchGetElapsedTime2Test()
    {
        return StopwatchHelper.WatchGetElapsedTime2(StartTime);
    }
    
    [Benchmark]
    public TimeSpan CustomGetElapsedTimeTest()
    {
        return StopwatchHelper.CustomGetElapsedTime(StartTime);
    }
    
    [Benchmark]
    public TimeSpan CustomGetElapsedTime2Test()
    {
        return StopwatchHelper.CustomGetElapsedTime2(StartTime);
    }
}

file static class StopwatchHelper
{
    private static readonly double TickFrequency = (double)TimeSpan.TicksPerSecond / Stopwatch.Frequency;

    public static TimeSpan CustomGetElapsedTime(long startTimestamp) => new((long)((Stopwatch.GetTimestamp() - startTimestamp) * TickFrequency));
    
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TimeSpan CustomGetElapsedTime2(long startTimestamp) => new((long)((Stopwatch.GetTimestamp() - startTimestamp) * TickFrequency));
    
    public static TimeSpan WatchGetElapsedTime(long startTimestamp) => Stopwatch.GetElapsedTime(startTimestamp);
    [MethodImpl(MethodImplOptions.AggressiveInlining)]
    public static TimeSpan WatchGetElapsedTime2(long startTimestamp) => Stopwatch.GetElapsedTime(startTimestamp);

}
