```

BenchmarkDotNet v0.15.8, Windows 11 (10.0.26200.8655/25H2/2025Update/HudsonValley2)
Intel Core Ultra 7 155H 1.40GHz, 1 CPU, 22 logical and 16 physical cores
.NET SDK 11.0.100-preview.5.26302.115
  [Host]     : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3
  DefaultJob : .NET 10.0.9 (10.0.9, 10.0.926.27113), X64 RyuJIT x86-64-v3


```
| Method                | Mean       | Error    | StdDev   | Ratio | RatioSD |
|---------------------- |-----------:|---------:|---------:|------:|--------:|
| DotnetScriptSimple    |   308.0 ms |  5.45 ms |  5.10 ms |  1.00 |    0.02 |
| DotnetExecSimple      | 1,837.5 ms | 13.40 ms | 12.54 ms |  5.97 |    0.10 |
| DotnetScriptReference |   360.1 ms |  7.08 ms |  8.95 ms |  1.17 |    0.03 |
| DotnetExecReference   | 1,976.6 ms | 15.52 ms | 14.52 ms |  6.42 |    0.11 |
