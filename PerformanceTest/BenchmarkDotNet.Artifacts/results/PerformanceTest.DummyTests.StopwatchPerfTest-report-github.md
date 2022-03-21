``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22579
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.2.22153.17
  [Host]     : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT
  DefaultJob : .NET 6.0.3 (6.0.322.12309), X64 RyuJIT


```
|             Method |    Mean |    Error |   StdDev | Ratio | Allocated |
|------------------- |--------:|---------:|---------:|------:|----------:|
|      StopwatchTest | 1.008 s | 0.0049 s | 0.0046 s |  1.00 |   2,136 B |
| ValueStopwatchTest | 1.008 s | 0.0052 s | 0.0049 s |  1.00 |     848 B |
| GetElapsedTimeTest | 1.008 s | 0.0053 s | 0.0050 s |  1.00 |     848 B |
