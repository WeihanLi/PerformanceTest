``` ini

BenchmarkDotNet=v0.13.1, OS=Windows 10.0.22621
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK=7.0.100-preview.4.22252.9
  [Host]     : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT
  DefaultJob : .NET 6.0.5 (6.0.522.21309), X64 RyuJIT


```
|          Method |     Mean |    Error |   StdDev |   Gen 0 | Allocated |
|---------------- |---------:|---------:|---------:|--------:|----------:|
| DotNetImplement | 11.94 μs | 0.207 μs | 0.480 μs |  8.6823 |     13 KB |
| CustomImplement | 41.18 μs | 0.805 μs | 0.862 μs | 28.0151 |     43 KB |
