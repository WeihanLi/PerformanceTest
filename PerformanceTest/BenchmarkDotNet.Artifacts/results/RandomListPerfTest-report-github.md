``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.18362
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.0.100-preview5-011568
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT


```
|                         Method |       Mean |      Error |     StdDev |
|------------------------------- |-----------:|-----------:|-----------:|
|           RandomOrderByRandom0 |   186.9 us |  1.9582 us |  1.8317 us |
|            RandomOrderByRandom |   184.2 us |  1.3392 us |  1.2527 us |
|              RandomOrderByGuid |   300.3 us |  1.7463 us |  1.5481 us |
|          RandomOrderByGuidHash |   270.4 us |  0.6675 us |  0.5917 us |
| RandomOrderByStupidRandomIndex | 3,417.4 us | 30.6603 us | 27.1796 us |
