``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.19041.173 (2004/?/20H1)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET Core SDK=3.1.201
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                 Method |       Mean |      Error |    StdDev |  Ratio | RatioSD |
|----------------------- |-----------:|-----------:|----------:|-------:|--------:|
|                 Invoke |   2.236 ns |  0.0335 ns | 0.0280 ns |   1.00 |    0.00 |
|           InvokeBoxing |   7.557 ns |  0.0659 ns | 0.0585 ns |   3.38 |    0.05 |
|          DynamicInvoke | 601.180 ns |  2.6923 ns | 2.3866 ns | 268.83 |    3.50 |
|    DynamicInvokeBoxing | 394.025 ns |  3.5004 ns | 3.1030 ns | 176.29 |    2.11 |
|       MethodInfoInvoke | 176.440 ns |  0.7207 ns | 0.5627 ns |  79.02 |    0.99 |
| MethodInfoInvokeBoxing | 220.982 ns |  0.4654 ns | 0.3886 ns |  98.86 |    1.29 |
|          ReflectInvoke | 917.546 ns |  4.7908 ns | 4.2469 ns | 410.21 |    5.60 |
|    ReflectInvokeBoxing | 995.824 ns | 10.9270 ns | 9.6865 ns | 445.48 |    7.16 |
