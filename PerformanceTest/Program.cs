using System;
using BenchmarkDotNet.Running;
using PerformanceTest.RedisTest;

namespace PerformanceTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // BenchmarkRunner.Run<RandomListPerfTest>();
            // BenchmarkRunner.Run<NewInstanceTest>();

            BenchmarkRunner.Run<RedisSetMembersTest>();

            Console.Read();
        }
    }
}
