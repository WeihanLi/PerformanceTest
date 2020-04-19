using System;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using WeihanLi.Extensions;

namespace PerformanceTest.ReflectionTests
{
    public class DelegateInvokeTest
    {
        private readonly Delegate _func, _func1;
        private readonly string parameter;
        private readonly int paramInt;

        public DelegateInvokeTest()
        {
            parameter = "Test";
            paramInt = 1;

            _func = (Func<string, string>)(str => str);
            _func1 = (Func<int, int>)(val => 0);
        }

        [Benchmark(Baseline = true)]
        public object Invoke()
        {
            return ((Func<string, string>)_func).Invoke(parameter);
        }

        [Benchmark]
        public object InvokeBoxing()
        {
            return ((Func<int, int>)_func1).Invoke(paramInt);
        }

        [Benchmark]
        public object DynamicInvoke()
        {
            return _func.DynamicInvoke(parameter);
        }

        [Benchmark]
        public object DynamicInvokeBoxing()
        {
            return _func1.DynamicInvoke(paramInt);
        }

        [Benchmark]
        public object MethodInfoInvoke()
        {
            return _func.Method?.Invoke(_func.Target, new object[] { parameter });
        }

        [Benchmark]
        public object MethodInfoInvokeBoxing()
        {
            return _func1.Method?.Invoke(_func1.Target, new object[] { paramInt });
        }

        [Benchmark]
        public object ReflectInvoke()
        {
            var funcType = typeof(Func<,>).MakeGenericType(typeof(string), typeof(string));
            var method = funcType.GetProperty("Method")?.GetValueGetter()?.Invoke(_func) as MethodInfo;
            var target = funcType.GetProperty("Target")?.GetValueGetter()?.Invoke(_func);
            return method?.Invoke(target, new object[] { parameter });
        }

        [Benchmark]
        public object ReflectInvokeBoxing()
        {
            var funcType = typeof(Func<,>).MakeGenericType(typeof(string), typeof(int));
            var method = funcType.GetProperty("Method")?.GetValueGetter()?.Invoke(_func1) as MethodInfo;
            var target = funcType.GetProperty("Target")?.GetValueGetter()?.Invoke(_func1);
            return method?.Invoke(target, new object[] { paramInt });
        }
    }
}
