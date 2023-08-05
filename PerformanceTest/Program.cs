// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using BenchmarkDotNet.Running;

namespace PerformanceTest;

public static class Program
{
    public static void Main(string[] args)
    {
        // BenchmarkRunner.Run<RandomListPerfTest>();
        // BenchmarkRunner.Run<NewInstanceTest>();
        // BenchmarkRunner.Run<RedisSetMembersTest>();
        // BenchmarkRunner.Run<EnumerableEmptyTest>();
        // BenchmarkRunner.Run<DelegateInvokeTest>();
        // BenchmarkRunner.Run<ConcurrentSetTest>();
        // BenchmarkRunner.Run<JsonPrettifyTest>();
        // BenchmarkRunner.Run<DummyTests.StopwatchPerfTest>();
        // BenchmarkRunner.Run<EnumerableChuckTest>();
        
        BenchmarkRunner.Run<TimeProviderLocalTimeTest>();

        Console.Read();
    }
}
