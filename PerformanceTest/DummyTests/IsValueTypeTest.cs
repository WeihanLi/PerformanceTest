using System;
using System.Runtime.CompilerServices;
using BenchmarkDotNet.Attributes;
using WeihanLi.Common.Event;
using WeihanLi.Common.Models;

namespace PerformanceTest.DummyTests
{
    public class IsValueTypeTest
    {
        [Benchmark(Baseline = true)]
        public bool[] IsValueType1ValueTest()
        {
            return new[]
            {
                IsValueTypeUti.IsValueType1<int>(),
                IsValueTypeUti.IsValueType1<double>(),
                IsValueTypeUti.IsValueType1<long>(),
                IsValueTypeUti.IsValueType1<float>(),
                IsValueTypeUti.IsValueType1<decimal>(),
            };
        }

        [Benchmark]
        public bool[] IsValueType2ValueTest()
        {
            return new[]
            {
                IsValueTypeUti.IsValueType2<int>(),
                IsValueTypeUti.IsValueType2<double>(),
                IsValueTypeUti.IsValueType2<long>(),
                IsValueTypeUti.IsValueType2<float>(),
                IsValueTypeUti.IsValueType2<decimal>(),
            };
        }

        [Benchmark]
        public bool[] IsValueType3ValueTest()
        {
            return new[]
            {
                IsValueTypeUti.IsValueType3<int>(),
                IsValueTypeUti.IsValueType3<double>(),
                IsValueTypeUti.IsValueType3<long>(),
                IsValueTypeUti.IsValueType3<float>(),
                IsValueTypeUti.IsValueType3<decimal>(),
            };
        }

        [Benchmark]
        public bool[] IsValueType1ClassTest()
        {
            return new[]
            {
                IsValueTypeUti.IsValueType1<string>(),
                IsValueTypeUti.IsValueType1<ResultModel>(),
                IsValueTypeUti.IsValueType1<object>(),
                IsValueTypeUti.IsValueType1<Action>(),
                IsValueTypeUti.IsValueType1<EventBus>(),
            };
        }

        [Benchmark]
        public bool[] IsValueType2ClassTest()
        {
            return new[]
            {
                IsValueTypeUti.IsValueType2<string>(),
                IsValueTypeUti.IsValueType2<ResultModel>(),
                IsValueTypeUti.IsValueType2<object>(),
                IsValueTypeUti.IsValueType2<Action>(),
                IsValueTypeUti.IsValueType2<EventBus>(),
            };
        }

        [Benchmark]
        public bool[] IsValueType3ClassTest()
        {
            return new[]
            {
                IsValueTypeUti.IsValueType3<string>(),
                IsValueTypeUti.IsValueType3<ResultModel>(),
                IsValueTypeUti.IsValueType3<object>(),
                IsValueTypeUti.IsValueType3<Action>(),
                IsValueTypeUti.IsValueType3<EventBus>(),
            };
        }

        private static class IsValueTypeUti
        {
            [MethodImpl(MethodImplOptions.NoInlining)]
            public static bool IsValueType1<T>()
            {
                return typeof(T).IsValueType;
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static bool IsValueType2<T>()
            {
                return default(T) != null;
            }

            [MethodImpl(MethodImplOptions.NoInlining)]
            public static bool IsValueType3<T>()
            {
                return IsValueTypeHelper<T>.IsValueType;
            }
        }

        private static class IsValueTypeHelper<T>
        {
            public static readonly bool IsValueType = typeof(T).IsValueType;
        }
    }
}
