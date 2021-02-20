``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19042
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=6.0.100-preview.1.21103.13
  [Host]     : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT
  DefaultJob : .NET Core 3.1.12 (CoreCLR 4.700.21.6504, CoreFX 4.700.21.6905), X64 RyuJIT


```
|                Method |       Mean |     Error |    StdDev |     Median | Ratio | RatioSD |
|---------------------- |-----------:|----------:|----------:|-----------:|------:|--------:|
|                 Array | 10.0516 ns | 0.7807 ns | 2.3019 ns |  9.6060 ns |     ? |       ? |
| Enumerable_EmptyArray | 25.3290 ns | 1.2378 ns | 3.6302 ns | 25.2338 ns |     ? |       ? |
|            EmptyArray |  0.3467 ns | 0.1581 ns | 0.4661 ns |  0.0000 ns |     ? |       ? |
|                  List | 10.1788 ns | 0.5008 ns | 1.4288 ns |  9.8679 ns |     ? |       ? |
|             EmptyList | 41.3174 ns | 3.3577 ns | 9.9002 ns | 46.1868 ns |     ? |       ? |
