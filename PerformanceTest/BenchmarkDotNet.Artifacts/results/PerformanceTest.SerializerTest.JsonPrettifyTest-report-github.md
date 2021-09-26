``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22463
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=6.0.100-rc.1.21463.6
  [Host]     : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT
  DefaultJob : .NET 5.0.9 (5.0.921.35908), X64 RyuJIT


```
|                  Method |     Mean |     Error |    StdDev | Ratio | RatioSD |
|------------------------ |---------:|----------:|----------:|------:|--------:|
| SystemJson_JsonDocument | 1.887 μs | 0.0365 μs | 0.0546 μs |  0.42 |    0.02 |
|    JsonNet_ReaderWriter | 2.125 μs | 0.0814 μs | 0.2200 μs |  0.46 |    0.06 |
|  JsonNet_JTokenToString | 4.661 μs | 0.1835 μs | 0.4928 μs |  1.00 |    0.00 |
