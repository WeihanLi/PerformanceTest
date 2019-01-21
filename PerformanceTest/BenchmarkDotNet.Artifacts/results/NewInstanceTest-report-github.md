``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.2.102
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT


```
|              Method |      Mean |     Error |    StdDev |
|-------------------- |----------:|----------:|----------:|
|         NewDirectly |  3.523 ns | 0.1485 ns | 0.1389 ns |
|     NewByReflection | 69.251 ns | 0.5404 ns | 0.4790 ns |
| NewByExpressionTree |  7.761 ns | 0.1704 ns | 0.1594 ns |
