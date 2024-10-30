```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.22631.4317/23H2/2023Update/SunValley3)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.100-rc.2.24474.11
  [Host]     : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.10 (8.0.1024.46610), X64 RyuJIT AVX2


```
| Method                    | Mean     | Error    | StdDev   | Ratio | RatioSD | Allocated | Alloc Ratio |
|-------------------------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
| StopwatchTest             | 15.33 ns | 0.234 ns | 0.207 ns |  1.00 |    0.02 |         - |          NA |
| WatchGetElapsedTimeTest   | 15.76 ns | 0.337 ns | 0.374 ns |  1.03 |    0.03 |         - |          NA |
| WatchGetElapsedTime2Test  | 15.95 ns | 0.247 ns | 0.231 ns |  1.04 |    0.02 |         - |          NA |
| CustomGetElapsedTimeTest  | 16.99 ns | 0.347 ns | 0.356 ns |  1.11 |    0.03 |         - |          NA |
| CustomGetElapsedTime2Test | 15.48 ns | 0.213 ns | 0.189 ns |  1.01 |    0.02 |         - |          NA |
