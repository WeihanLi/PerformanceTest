```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.3527)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
|             Method |     Mean |    Error |   StdDev | Ratio | Allocated | Alloc Ratio |
|------------------- |---------:|---------:|---------:|------:|----------:|------------:|
|        GetLocalNow | 26.98 ns | 0.242 ns | 0.227 ns |  1.00 |         - |          NA |
| GetLocalNow_Update | 27.23 ns | 0.183 ns | 0.162 ns |  1.01 |         - |          NA |
