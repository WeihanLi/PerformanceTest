```

BenchmarkDotNet v0.14.0, Windows 10 (10.0.19045.5131/22H2/2022Update)
Intel Xeon W-2133 CPU 3.60GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 9.0.100
  [Host]     : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL
  DefaultJob : .NET 8.0.11 (8.0.1124.51707), X64 RyuJIT AVX-512F+CD+BW+DQ+VL


```
| Method     | Mean     | Error    | StdDev   | Ratio | RatioSD | Gen0   | Allocated | Alloc Ratio |
|----------- |---------:|---------:|---------:|------:|--------:|-------:|----------:|------------:|
| SubString  | 19.05 ns | 0.419 ns | 0.327 ns |  1.00 |    0.02 | 0.0074 |      32 B |        1.00 |
| SpanString | 20.71 ns | 0.414 ns | 0.367 ns |  1.09 |    0.03 | 0.0074 |      32 B |        1.00 |
