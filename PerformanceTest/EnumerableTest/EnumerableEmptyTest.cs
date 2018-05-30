using BenchmarkDotNet.Attributes;
using System.Collections.Generic;
using System.Linq;

namespace PerformanceTest.EnumerableTest
{
    public class EnumerableEmptyTest
    {
        [Benchmark]
        public IEnumerable<string> Empty()
        {
            return Enumerable.Empty<string>();
        }

        [Benchmark]
        public IEnumerable<string> Array()
        {
            return new string[0];
        }

        [Benchmark]
        public IEnumerable<string> EmptyArray()
        {
            return System.Array.Empty<string>();
        }

        [Benchmark]
        public IEnumerable<string> List()
        {
            return new List<string>();
        }

        [Benchmark]
        public IEnumerable<string> EmptyList()
        {
            return Enumerable.Empty<string>().ToList();
        }
    }
}