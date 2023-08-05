```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.25915.1000)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100-preview.6.23330.14
  [Host]     : .NET 8.0.0 (8.0.23.32907), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.32907), X64 RyuJIT AVX2


```
|             Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|------------------- |---------:|---------:|---------:|------:|----------:|------------:|
|        GetLocalNow | 61.69 ns | 0.243 ns | 0.190 ns |  1.00 |         - |          NA |
| GetLocalNow_Update | 51.31 ns | 0.219 ns | 0.183 ns |  0.83 |         - |          NA |
