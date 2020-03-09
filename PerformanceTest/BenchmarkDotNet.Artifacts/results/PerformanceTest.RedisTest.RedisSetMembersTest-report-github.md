``` ini

BenchmarkDotNet=v0.12.0, OS=Windows 10.0.18362
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=3.1.101
  [Host]     : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT
  DefaultJob : .NET Core 3.1.1 (CoreCLR 4.700.19.60701, CoreFX 4.700.19.60801), X64 RyuJIT


```
|           Method |           Mean |         Error |        StdDev |         Median |
|----------------- |---------------:|--------------:|--------------:|---------------:|
| SetRandomMembers |       503.5 us |      12.83 us |      23.14 us |       492.6 us |
|          SetScan | 5,383,682.4 us | 153,518.52 us | 435,506.50 us | 5,351,407.8 us |
