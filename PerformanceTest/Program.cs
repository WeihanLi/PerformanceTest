using System;
using BenchmarkDotNet.Running;
using PerformanceTest.ReflectionTests;

namespace PerformanceTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // BenchmarkRunner.Run<RandomListPerfTest>();
            // BenchmarkRunner.Run<NewInstanceTest>();
            // BenchmarkRunner.Run<RedisSetMembersTest>();
            // BenchmarkRunner.Run<FluentFormatterTest>();

            BenchmarkRunner.Run<DelegateInvokeTest>();

            Console.Read();
        }
    }
}
