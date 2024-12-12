```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4602/23H2/2023Update/SunValley3)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.101
  [Host]     : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.0 (9.0.24.52809), X64 RyuJIT AVX2


```
| Method                      | Categories  | Mean      | Error     | StdDev    | Ratio | RatioSD | Allocated | Alloc Ratio |
|---------------------------- |------------ |----------:|----------:|----------:|------:|--------:|----------:|------------:|
| FrozenSetContains           | Contains    | 1.7361 ns | 0.0115 ns | 0.0108 ns |  1.00 |    0.01 |         - |          NA |
| HashSetContains             | Contains    | 6.4355 ns | 0.1522 ns | 0.3177 ns |  3.71 |    0.18 |         - |          NA |
| ImmutableHashSetContains    | Contains    | 9.8509 ns | 0.2001 ns | 0.1774 ns |  5.67 |    0.10 |         - |          NA |
|                             |             |           |           |           |       |         |           |             |
| FrozenSetNotContains        | NotContains | 0.2963 ns | 0.0316 ns | 0.0422 ns |  1.02 |    0.21 |         - |          NA |
| HashSetNotContains          | NotContains | 3.9321 ns | 0.0359 ns | 0.0300 ns | 13.55 |    2.04 |         - |          NA |
| ImmutableHashSetNotContains | NotContains | 5.3004 ns | 0.0350 ns | 0.0327 ns | 18.26 |    2.75 |         - |          NA |
