using System;
using System.Linq.Expressions;
using BenchmarkDotNet.Attributes;

namespace PerformanceTest.ReflectionTests
{
    public class TestEntity
    {
        public string Value { get; set; }
    }

    public class NewInstanceTest
    {
        [Benchmark]
        public TestEntity NewDirectly()
        {
            return new TestEntity();
        }

        [Benchmark]
        public TestEntity NewByReflection()
        {
            return Activator.CreateInstance<TestEntity>();
        }

        [Benchmark]
        public TestEntity NewByExpressionTree()
        {
            return New<TestEntity>.Instance();
        }

        private static class New<T> where T : new()
        {
            public static readonly Func<T> Instance = Expression.Lambda<Func<T>>
            (
                Expression.New(typeof(T))
            ).Compile();
        }
    }
}
