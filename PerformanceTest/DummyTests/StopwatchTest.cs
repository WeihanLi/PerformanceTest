using System.Diagnostics;
using WeihanLi.Common.Helpers;

namespace PerformanceTest.DummyTests;

[MemoryDiagnoser]
public class StopwatchPerfTest
{
    [Benchmark(Baseline = true)]
    public TimeSpan StopwatchTest()
    {
        var watch = Stopwatch.StartNew();
        DoWork();
        watch.Stop();
        return watch.Elapsed;
    }

    [Benchmark]
    public TimeSpan ValueStopwatchTest()
    {
        var watch = ValueStopwatch.StartNew();
        DoWork();
        return watch.Elapsed;
    }

    [Benchmark]
    public TimeSpan GetElapsedTimeTest()
    {
        var start = Stopwatch.GetTimestamp();
        DoWork();
        return ProfilerHelper.GetElapsedTime(start);
    }

    private static void DoWork()
    {
        Thread.Sleep(1000);
    }
}