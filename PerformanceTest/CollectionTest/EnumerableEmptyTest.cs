using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;

namespace PerformanceTest.CollectionTest
{
    public class EnumerableEmptyTest
    {
        [Benchmark]
        public string[] Array()
        {
            return new string[0];
        }

        [Benchmark]
        public string[] Enumerable_EmptyArray()
        {
            return Enumerable.Empty<string>().ToArray();
        }

        [Benchmark(Baseline = true)]
        public string[] EmptyArray()
        {
            return System.Array.Empty<string>();
        }

        [Benchmark]
        public List<string> List()
        {
            return new List<string>();
        }

        [Benchmark]
        public List<string> EmptyList()
        {
            return Enumerable.Empty<string>().ToList();
        }
    }
}
