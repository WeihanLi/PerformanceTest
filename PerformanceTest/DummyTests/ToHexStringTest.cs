// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using WeihanLi.Extensions;

namespace PerformanceTest.DummyTests;

public class ToHexStringTest
{
    private readonly byte[] _testBytes = "Test1234".GetBytes();
    
    
    [Benchmark]
    public string ConvertToHexString()
    {
        return Convert.ToHexString(_testBytes);
    }
    
    [Benchmark]
    public string BitConverterConvert()
    {
        return BitConverter.ToString(_testBytes).Replace("-", "");
    }
    
    [Benchmark]
    public string StringJoin()
    {
        return string.Join("", _testBytes.Select(b=> b.ToString("X2")));
    }
    
    [Benchmark]
    public string StringAggregate()
    {
        return _testBytes.Select(b=> b.ToString("X2")).Aggregate(string.Empty, string.Concat);
    }
}
