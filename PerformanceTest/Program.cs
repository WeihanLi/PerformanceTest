using System;
using BenchmarkDotNet.Running;
using PerformanceTest.ExcelTest;

namespace PerformanceTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // BenchmarkRunner.Run<RandomListPerfTest>();
            // BenchmarkRunner.Run<NewInstanceTest>();

            // BenchmarkRunner.Run<RedisSetMembersTest>();

            // BenchmarkRunner.Run<DelegateInvokeTest>();

            BenchmarkRunner.Run<FluentFormatterTest>();

            Console.Read();
        }
    }
}
