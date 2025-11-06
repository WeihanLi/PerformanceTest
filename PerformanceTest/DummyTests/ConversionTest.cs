// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

using System.Text;

namespace PerformanceTest.DummyTests;

using System;
using BenchmarkDotNet.Attributes;

[ShortRunJob]
[MemoryDiagnoser]
public class ChineseCharBench
{
    private const string Input = "漢字简繁转换性能测试ABC123";
    private readonly string ZhTw = Input.ToZhTw();
    private readonly string ZhCn = Input.ToZhCn();

    [Benchmark]
    public int OldWay()
    {
        int t = 0, s = 0;

        foreach (var c in Input)
        {
            if (ZhTw.Contains(c.ToString())) t++;
            if (ZhCn.Contains(c.ToString())) s++;
        }

        return t - s;
    }

    [Benchmark(Baseline = true)]
    public int NewWay()
    {
        var traditional = ZhTw.AsSpan();
        var simple = ZhCn.AsSpan();
        int t = 0, s = 0;

        foreach (var c in Input)
        {
            if (traditional.Contains(c)) t++;
            if (simple.Contains(c)) s++;
        }

        return t - s;
    }
}

file static class ChineseConvertExtensions
{
    private static readonly Dictionary<char, char> SimplifiedToTraditional = new()
    {
        ['汉'] = '漢',
        ['马'] = '馬',
        ['门'] = '門',
        ['风'] = '風'
    };

    private static readonly Dictionary<char, char> TraditionalToSimplified = new()
    {
        ['漢'] = '汉',
        ['馬'] = '马',
        ['門'] = '门',
        ['風'] = '风'
    };

    public static string ToZhTw(this string input)
    {
        var sb = new StringBuilder(input.Length);

        foreach (var c in input)
            sb.Append(SimplifiedToTraditional.GetValueOrDefault(c, c));

        return sb.ToString();
    }

    public static string ToZhCn(this string input)
    {
        var sb = new StringBuilder(input.Length);

        foreach (var c in input)
            sb.Append(TraditionalToSimplified.GetValueOrDefault(c, c));

        return sb.ToString();
    }
}
