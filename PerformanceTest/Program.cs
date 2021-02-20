using System;
using BenchmarkDotNet.Running;
using PerformanceTest.CollectionTest;

namespace PerformanceTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // BenchmarkRunner.Run<RandomListPerfTest>();
            // BenchmarkRunner.Run<NewInstanceTest>();
            // BenchmarkRunner.Run<RedisSetMembersTest>();
            // BenchmarkRunner.Run<EnumerableEmptyTest>();
            // BenchmarkRunner.Run<DelegateInvokeTest>();

            BenchmarkRunner.Run<ConcurrentSetTest>();
            Console.Read();
        }
    }
}
