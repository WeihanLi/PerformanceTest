```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.3447)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
|                Method |     Mean |   Error |  StdDev | Ratio | RatioSD |
|---------------------- |---------:|--------:|--------:|------:|--------:|
|    DotnetScriptSimple | 211.1 ms | 4.08 ms | 4.53 ms |  1.00 |    0.00 |
|      DotnetExecSimple | 201.9 ms | 2.33 ms | 2.18 ms |  0.95 |    0.02 |
| DotnetScriptReference | 227.5 ms | 2.94 ms | 2.75 ms |  1.08 |    0.03 |
|   DotnetExecReference | 228.2 ms | 2.20 ms | 2.06 ms |  1.08 |    0.03 |
