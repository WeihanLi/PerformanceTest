``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


```
|     Method |       Mean |     Error |     StdDev |     Median |
|----------- |-----------:|----------:|-----------:|-----------:|
|      Empty |   3.802 ns | 0.2107 ns |  0.5128 ns |   3.536 ns |
|      Array |   5.893 ns | 0.2404 ns |  0.6205 ns |   5.738 ns |
| EmptyArray |   4.663 ns | 0.2157 ns |  0.3421 ns |   4.542 ns |
|       List |   9.233 ns | 0.3035 ns |  0.8358 ns |   9.260 ns |
|  EmptyList | 140.977 ns | 7.4103 ns | 21.6162 ns | 133.436 ns |
