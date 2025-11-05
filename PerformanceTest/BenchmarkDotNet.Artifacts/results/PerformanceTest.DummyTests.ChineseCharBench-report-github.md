```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
Intel Core Ultra 7 155H 1.40GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]   : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| OldWay | 349.4 ns | 428.4 ns | 23.48 ns |  2.28 |    0.17 | 0.0863 |    1088 B |        3.40 |
| NewWay | 153.3 ns | 153.8 ns |  8.43 ns |  1.00 |    0.07 | 0.0253 |     320 B |        1.00 |
