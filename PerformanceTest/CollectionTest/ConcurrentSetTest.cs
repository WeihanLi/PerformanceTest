using System.Collections;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BenchmarkDotNet.Attributes;

namespace PerformanceTest.CollectionTest
{
    [MemoryDiagnoser]
    public class ConcurrentSetTest
    {
        private class ConcurrentSet<T, TValue> : IEnumerable<T>
        {
            private readonly ConcurrentDictionary<T, TValue> _store = new();

            public bool TryAdd(T t) => _store.TryAdd(t, default);

            public bool TryRemove(T t) => _store.TryRemove(t, out _);

            public bool Contains(T t) => _store.ContainsKey(t);

            public int Count => _store.Count;

            public IEnumerator<T> GetEnumerator()
            {
                return _store.Keys.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }

        [Benchmark(Baseline = true)]
        public int BooleanTest()
        {
            var set = new ConcurrentSet<int, bool>();
            Parallel.For(1, 1000, i => set.TryAdd(i%400));
            return set.Count;
        }

        [Benchmark]
        public int ByteTest()
        {
            var set = new ConcurrentSet<int, byte>();
            Parallel.For(1, 1000, i => set.TryAdd(i%400));
            return set.Count;
        }

        
        [Benchmark]
        public int IntegerTest()
        {
            var set = new ConcurrentSet<int, int>();
            Parallel.For(1, 1000, i => set.TryAdd(i%400));
            return set.Count;
        }

        [Benchmark]
        public int ObjectTest()
        {
            var set = new ConcurrentSet<int, object>();
            Parallel.For(1, 1000, i => set.TryAdd(i%400));
            return set.Count;
        }
    }
}
