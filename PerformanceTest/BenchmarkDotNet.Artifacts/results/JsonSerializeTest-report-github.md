``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-5200U CPU 2.20GHz (Broadwell), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=2.1.300-rc1-008673
  [Host]     : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.7 (CoreCLR 4.6.26328.01, CoreFX 4.6.26403.03), 64bit RyuJIT


```
|            Method |     Mean |     Error |    StdDev |   Median |
|------------------ |---------:|----------:|----------:|---------:|
| SerializeToString | 2.269 us | 0.0278 us | 0.0232 us | 2.270 us |
| SerializeToStream | 2.938 us | 0.0584 us | 0.1007 us | 2.884 us |
