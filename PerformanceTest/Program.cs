using BenchmarkDotNet.Running;
using PerformanceTest.EnumerableTest;
using PerformanceTest.SerializerTest;
using System;

namespace PerformanceTest
{
    public class Program
    {
        public static void Main(string[] args)
        {
            BenchmarkRunner.Run<JsonSerializeTest>();
            BenchmarkRunner.Run<EnumerableEmptyTest>();
            Console.Read();
        }
    }
}