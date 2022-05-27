// Copyright (c) Weihan Li. All rights reserved.
// Licensed under the MIT license.

namespace PerformanceTest.CollectionTest;

[MemoryDiagnoser]
public class EnumerableChuckTest
{
    [Benchmark]
    public int[][] DotNetImplement()
    {
        return Enumerable.Range(1, 1000)
            .Chunk(5)
            .ToArray();
    }

    [Benchmark]
    public int[][] CustomImplement()
    {
        return Enumerable.Range(1, 1000)
            .MyChuck(5)
            .ToArray();
    }
}

public static class MyExtensions
{
    public static IEnumerable<T[]> MyChuck<T>(this IEnumerable<T> source, int batchSize)
    {
        using var enumerator = source.GetEnumerator();
        while (enumerator.MoveNext())
        {
            yield return Split(enumerator, batchSize).ToArray();
        }
    }

    private static IEnumerable<T> Split<T>(IEnumerator<T> enumerator, int batchSize)
    {
        do
        {
            yield return enumerator.Current;
        } while (--batchSize > 0 && enumerator.MoveNext());
    }
}
