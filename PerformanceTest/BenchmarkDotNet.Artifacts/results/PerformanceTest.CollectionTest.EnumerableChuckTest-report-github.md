```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.3527)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
|          Method |      Mean |     Error |    StdDev |   Gen0 |   Gen1 | Allocated |
|---------------- |----------:|----------:|----------:|-------:|-------:|----------:|
| DotNetImplement |  3.780 μs | 0.0748 μs | 0.0972 μs | 1.0834 | 0.0229 |  13.36 KB |
| CustomImplement | 11.649 μs | 0.2228 μs | 0.2477 μs | 3.5095 | 0.1068 |     43 KB |
