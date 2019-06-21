using System;
using System.Collections.Generic;
using System.Linq;
using BenchmarkDotNet.Attributes;
using WeihanLi.Extensions;

namespace PerformanceTest.RandomTest
{
    public class RandomListPerfTest
    {
        private readonly int[] _testData = Enumerable.Range(0, 1000).ToArray();

        [Benchmark]
        public int[] RandomOrderByRandom0()
        {
            var random = new Random();
            return _testData.OrderBy(_ => random.Next(_testData.Length)).ToArray();
        }

        [Benchmark]
        public int[] RandomOrderByRandom()
        {
            var random = new Random();
            return Enumerable.Range(0, _testData.Length).OrderBy(_ => random.Next(_testData.Length)).Select(i => _testData[i]).ToArray();
        }

        [Benchmark]
        public int[] RandomOrderByGuid()
        {
            return Enumerable.Range(0, _testData.Length).OrderBy(_ => Guid.NewGuid()).Select(i => _testData[i]).ToArray();
        }

        [Benchmark]
        public int[] RandomOrderByGuidHash()
        {
            return Enumerable.Range(0, _testData.Length).OrderBy(_ => Guid.NewGuid().GetHashCode()).Select(i => _testData[i]).ToArray();
        }

        [Benchmark]
        public int[] RandomOrderByStupidRandomIndex()
        {
            var random = new Random();
            var indexes = new List<int>();
            while (indexes.Count < _testData.Length)
            {
                var index = random.Next(0, _testData.Length);
                if (!indexes.Contains(index))
                    indexes.Add(index);
            }
            return indexes.Select(i => _testData[i]).ToArray();
        }
    }
}
