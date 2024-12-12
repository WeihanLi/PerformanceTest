// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using BenchmarkDotNet.Configs;
using System.Collections.Frozen;
using System.Collections.Immutable;

namespace PerformanceTest.CollectionTest;

[MemoryDiagnoser]
[SimpleJob]
[GroupBenchmarksBy(BenchmarkLogicalGroupRule.ByCategory), CategoriesColumn]
public class FrozenSetTest
{
    private HashSet<string> _hashSet;
    private ImmutableHashSet<string> _immutableHashSet;
    private FrozenSet<string> _frozenSet;

    [GlobalSetup]
    public void Setup()
    {
        var array = Enumerable.Range(0, 10).Select(x => x.ToString()).ToArray();
        _hashSet = array.ToHashSet();
        _immutableHashSet = array.ToImmutableHashSet();
        _frozenSet = array.ToFrozenSet();
    }
    
    [Benchmark(Baseline = true)]
    [BenchmarkCategory("Contains")]
    public bool FrozenSetContains()
    {
        return _frozenSet.Contains("6");
    }
    
    [Benchmark]
    [BenchmarkCategory("Contains")]
    public bool HashSetContains()
    {
        return _hashSet.Contains("6");
    }
    
    [Benchmark]
    [BenchmarkCategory("Contains")]
    public bool ImmutableHashSetContains()
    {
        return _immutableHashSet.Contains("6");
    }
    
    [Benchmark(Baseline = true)]
    [BenchmarkCategory("NotContains")]
    public bool FrozenSetNotContains()
    {
        return _frozenSet.Contains("-1");
    }
    
    [Benchmark]
    [BenchmarkCategory("NotContains")]
    public bool HashSetNotContains()
    {
        return _hashSet.Contains("-1");
    }
    
    [Benchmark]
    [BenchmarkCategory("NotContains")]
    public bool ImmutableHashSetNotContains()
    {
        return _immutableHashSet.Contains("-1");
    }
}
