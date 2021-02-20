``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=6.0.100-preview.1.21103.13
  [Host]     : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT
  DefaultJob : .NET Core 5.0.3 (CoreCLR 5.0.321.7212, CoreFX 5.0.321.7212), X64 RyuJIT


```
|      Method |     Mean |   Error |  StdDev |   Median | Ratio | RatioSD |   Gen 0 | Gen 1 | Gen 2 | Allocated |
|------------ |---------:|--------:|--------:|---------:|------:|--------:|--------:|------:|------:|----------:|
| BooleanTest | 106.1 μs | 2.11 μs | 3.74 μs | 105.6 μs |  1.00 |    0.00 | 32.1045 |     - |     - |   47.3 KB |
|    ByteTest | 116.9 μs | 2.56 μs | 7.47 μs | 116.3 μs |  1.10 |    0.09 | 31.9824 |     - |     - |   47.3 KB |
| IntegerTest | 103.6 μs | 2.68 μs | 7.90 μs | 101.2 μs |  0.96 |    0.05 | 32.1045 |     - |     - |  47.29 KB |
|  ObjectTest | 113.3 μs | 2.24 μs | 4.87 μs | 111.4 μs |  1.08 |    0.06 | 31.7383 |     - |     - |  47.21 KB |
