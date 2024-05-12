```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.3527)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
|      Method |     Mean |    Error |   StdDev | Ratio |   Gen0 |   Gen1 | Allocated | Alloc Ratio |
|------------ |---------:|---------:|---------:|------:|-------:|-------:|----------:|------------:|
| BooleanTest | 49.32 μs | 0.395 μs | 0.330 μs |  1.00 | 6.1035 | 0.9766 |  73.29 KB |        1.00 |
|    ByteTest | 49.74 μs | 0.462 μs | 0.433 μs |  1.01 | 6.1035 | 1.0986 |  73.21 KB |        1.00 |
| IntegerTest | 49.85 μs | 0.324 μs | 0.288 μs |  1.01 | 6.1035 | 1.0986 |  73.29 KB |        1.00 |
|  ObjectTest | 53.05 μs | 0.442 μs | 0.414 μs |  1.08 | 6.1035 | 1.0986 |  73.29 KB |        1.00 |
