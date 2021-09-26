``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22463
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-rc.1.21463.6
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|                            Method |     Mean |     Error |    StdDev | Ratio | RatioSD |
|---------------------------------- |---------:|----------:|----------:|------:|--------:|
|    SystemJson_JsonDocument_Writer | 1.760 μs | 0.0348 μs | 0.0499 μs |  0.57 |    0.03 |
| SystemJson_JsonDocument_Serialize | 7.588 μs | 0.1456 μs | 0.1733 μs |  2.48 |    0.13 |
|              JsonNet_ReaderWriter | 2.000 μs | 0.0396 μs | 0.1044 μs |  0.65 |    0.05 |
|            JsonNet_JTokenToString | 3.088 μs | 0.0610 μs | 0.1300 μs |  1.00 |    0.00 |
