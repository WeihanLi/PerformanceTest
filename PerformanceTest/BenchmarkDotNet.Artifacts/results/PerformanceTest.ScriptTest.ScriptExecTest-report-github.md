```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.3447)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
|                Method |       Mean |    Error |   StdDev | Ratio | RatioSD |
|---------------------- |-----------:|---------:|---------:|------:|--------:|
|    DotnetScriptSimple |   212.6 ms |  4.21 ms |  9.43 ms |  1.00 |    0.00 |
|      DotnetExecSimple | 1,028.8 ms | 19.23 ms | 17.05 ms |  5.07 |    0.30 |
| DotnetScriptReference |   229.0 ms |  1.74 ms |  1.63 ms |  1.12 |    0.07 |
|   DotnetExecReference | 1,153.3 ms |  9.88 ms |  9.24 ms |  5.66 |    0.34 |
