// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

namespace PerformanceTest.DummyTests;

[MemoryDiagnoser]
[SimpleJob]
public class LinqSelectTest
{
    [Benchmark(Baseline = true)]
    public string[] LinqSelect()
    {
        return LinqSelectImpl().ToArray();
    }
    
    [Benchmark]
    public string[] YieldReturn()
    {
        return YieldReturnImpl().ToArray();
    }
    
    private IEnumerable<string> YieldReturnImpl()
    {
        foreach (var i in Enumerable.Range(0, 10))
        {
            yield return i.ToString();
        }
    }
    
    private IEnumerable<string> LinqSelectImpl()
    {
        return Enumerable.Range(0, 10)
            .Select(i => i.ToString());
    }
}
