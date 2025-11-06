```

BenchmarkDotNet v0.15.6, Windows 11 (10.0.26200.6899)
Intel Core Ultra 7 155H 1.40GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.100-rc.2.25502.107
  [Host]   : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3
  ShortRun : .NET 10.0.0 (10.0.0-rc.2.25502.107, 10.0.25.50307), X64 RyuJIT x86-64-v3

Job=ShortRun  IterationCount=3  LaunchCount=1  
WarmupCount=3  

```
| Method | Mean      | Error     | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|------- |----------:|----------:|---------:|------:|--------:|-------:|----------:|------------:|
| OldWay | 202.37 ns | 45.210 ns | 2.478 ns |  5.70 |    0.06 | 0.0610 |     768 B |          NA |
| NewWay |  35.50 ns |  2.044 ns | 0.112 ns |  1.00 |    0.00 |      - |         - |          NA |
