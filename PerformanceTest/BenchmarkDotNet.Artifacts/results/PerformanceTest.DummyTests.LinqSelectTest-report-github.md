```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5131/22H2/2022Update)
Intel Xeon W-2133 CPU 3.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method      | Mean     | Error   | StdDev  | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------------ |---------:|--------:|--------:|------:|--------:|-------:|----------:|------------:|
| LinqSelect  | 112.1 ns | 2.29 ns | 2.45 ns |  1.00 |    0.03 | 0.0445 |     192 B |        1.00 |
| YieldReturn | 257.2 ns | 2.34 ns | 2.19 ns |  2.30 |    0.05 | 0.0963 |     416 B |        2.17 |
