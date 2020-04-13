``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18363
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.100-preview.1.20155.7
  [Host]     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT


```
|                 Method |         Mean |     Error |    StdDev |  Ratio | RatioSD |
|----------------------- |-------------:|----------:|----------:|-------:|--------:|
|                 Invoke |     3.006 ns | 0.0339 ns | 0.0301 ns |   1.00 |    0.00 |
|           InvokeBoxing |     7.459 ns | 0.0938 ns | 0.0877 ns |   2.48 |    0.03 |
|          DynamicInvoke |   717.518 ns | 3.1583 ns | 2.9543 ns | 238.58 |    2.54 |
|    DynamicInvokeBoxing |   740.683 ns | 3.1763 ns | 2.6524 ns | 246.16 |    1.81 |
|          ReflectInvoke | 1,085.203 ns | 3.1458 ns | 2.9426 ns | 361.03 |    3.94 |
|       MethodInfoInvoke |   173.461 ns | 0.7950 ns | 0.7047 ns |  57.71 |    0.66 |
| MethodInfoInvokeBoxing |   201.357 ns | 1.1984 ns | 1.1209 ns |  66.96 |    0.82 |
|    ReflectInvokeBoxing | 1,297.182 ns | 3.6302 ns | 3.2181 ns | 431.56 |    4.18 |
