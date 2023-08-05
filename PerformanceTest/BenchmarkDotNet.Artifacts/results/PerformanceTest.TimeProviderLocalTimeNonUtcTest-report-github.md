```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.25915.1000)
Intel Core i5-6300U CPU 2.40GHz (Skylake), 1 CPU, 4 logical and 2 physical cores
.NET SDK 8.0.100-preview.6.23330.14
  [Host]     : .NET 8.0.0 (8.0.23.32907), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.0 (8.0.23.32907), X64 RyuJIT AVX2


```
|             Method |     Mean |    Error |   StdDev | Ratio | RatioSD | Allocated | Alloc Ratio |
|------------------- |---------:|---------:|---------:|------:|--------:|----------:|------------:|
|        GetLocalNow | 66.95 ns | 0.590 ns | 0.523 ns |  1.00 |    0.00 |         - |          NA |
| GetLocalNow_Update | 67.22 ns | 1.373 ns | 1.526 ns |  1.00 |    0.02 |         - |          NA |
