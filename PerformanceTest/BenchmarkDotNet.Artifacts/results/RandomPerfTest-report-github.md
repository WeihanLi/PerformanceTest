``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.2.102
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT


```
|                         Method |       Mean |      Error |     StdDev |
|------------------------------- |-----------:|-----------:|-----------:|
|            RandomOrderByRandom |   187.3 us |  0.7057 us |  0.6601 us |
|              RandomOrderByGuid |   309.1 us |  1.6273 us |  1.5222 us |
|          RandomOrderByGuidHash |   265.6 us |  1.7944 us |  1.6785 us |
| RandomOrderByStupidRandomIndex | 3,474.3 us | 29.6379 us | 27.7233 us |
