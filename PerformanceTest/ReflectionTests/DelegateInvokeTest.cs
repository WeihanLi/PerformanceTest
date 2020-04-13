using System;
using System.Reflection;
using BenchmarkDotNet.Attributes;
using WeihanLi.Extensions;

namespace PerformanceTest.ReflectionTests
{
    public class DelegateInvokeTest
    {
        private readonly object _func, _func1;
        private readonly string parameter;
        private readonly MethodInfo _methodInfo, _methodInfo1;
        private readonly object _methodTarget, _methodTarget1;

        public DelegateInvokeTest()
        {
            parameter = "Test";
            var func = (Func<string, string>)(str => str);
            var func1 = (Func<string, int>)(str => 0);
            _func = func;
            _func1 = func1;

            _methodInfo = func.Method;
            _methodTarget = func.Target;
            _methodInfo1 = func1.Method;
            _methodTarget1 = func1.Target;
        }

        [Benchmark(Baseline = true)]
        public object Invoke()
        {
            return ((Func<string, string>)_func).Invoke(parameter);
        }

        [Benchmark]
        public object InvokeBoxing()
        {
            return ((Func<string, int>)_func1).Invoke(parameter);
        }

        [Benchmark]
        public object DynamicInvoke()
        {
            return ((Delegate)_func).DynamicInvoke(parameter);
        }

        [Benchmark]
        public object DynamicInvokeBoxing()
        {
            return ((Delegate)_func1).DynamicInvoke(parameter);
        }

        [Benchmark]
        public object MethodInfoInvoke()
        {
            return _methodInfo?.Invoke(_methodTarget, new object[] { parameter });
        }

        [Benchmark]
        public object MethodInfoInvokeBoxing()
        {
            return _methodInfo1?.Invoke(_methodTarget1, new object[] { parameter });
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
            return method?.Invoke(target, new object[] { parameter });
        }
    }
}
