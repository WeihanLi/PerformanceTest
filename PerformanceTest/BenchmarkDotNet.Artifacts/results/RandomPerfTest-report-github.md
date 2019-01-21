``` ini

BenchmarkDotNet=v0.10.14, OS=Windows 10.0.17134
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=2.2.102
  [Host]     : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT
  DefaultJob : .NET Core 2.0.9 (CoreCLR 4.6.26614.01, CoreFX 4.6.26614.01), 64bit RyuJIT


```
|                         Method |     Mean |     Error |    StdDev |
|------------------------------- |---------:|----------:|----------:|
|            RandomOrderByRandom | 2.897 us | 0.0470 us | 0.0440 us |
|              RandomOrderByGuid | 1.962 us | 0.0221 us | 0.0207 us |
|          RandomOrderByGuidHash | 1.908 us | 0.0166 us | 0.0155 us |
| RandomOrderByStupidRandomIndex | 3.078 us | 0.0370 us | 0.0328 us |
