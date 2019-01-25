using System;
using BenchmarkDotNet.Running;
using PerformanceTest.RandomTest;

namespace PerformanceTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<RandomListPerfTest>();
            // BenchmarkRunner.Run<NewInstanceTest>();
            Console.Read();
        }
    }
}