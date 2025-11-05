```

BenchmarkDotNet v0.14.0, Windows 11 (10.0.26100.4351)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 10.0.100-preview.5.25277.114
  [Host]     : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX2
  DefaultJob : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX2
  ShortRun   : .NET 9.0.6 (9.0.625.26613), X64 RyuJIT AVX2


```
| Method                | Job        | IterationCount | LaunchCount | WarmupCount | Mean       | Error       | StdDev    | Ratio | RatioSD |
|---------------------- |----------- |--------------- |------------ |------------ |-----------:|------------:|----------:|------:|--------:|
| DotnetScriptSimple    | DefaultJob | Default        | Default     | Default     |   215.1 ms |     1.68 ms |   1.49 ms |  1.00 |    0.01 |
| DotnetExecSimple      | DefaultJob | Default        | Default     | Default     | 1,650.1 ms |    32.72 ms |  49.97 ms |  7.67 |    0.23 |
| DotnetScriptReference | DefaultJob | Default        | Default     | Default     |   277.1 ms |     5.51 ms |  15.72 ms |  1.29 |    0.07 |
| DotnetExecReference   | DefaultJob | Default        | Default     | Default     | 2,051.2 ms |    40.56 ms |  37.94 ms |  9.53 |    0.18 |
|                       |            |                |             |             |            |             |           |       |         |
| DotnetScriptSimple    | ShortRun   | 3              | 1           | 3           |   250.0 ms |    22.86 ms |   1.25 ms |  1.00 |    0.01 |
| DotnetExecSimple      | ShortRun   | 3              | 1           | 3           | 1,931.3 ms | 1,406.51 ms |  77.10 ms |  7.73 |    0.27 |
| DotnetScriptReference | ShortRun   | 3              | 1           | 3           |   275.2 ms |   194.62 ms |  10.67 ms |  1.10 |    0.04 |
| DotnetExecReference   | ShortRun   | 3              | 1           | 3           | 2,263.5 ms | 2,225.83 ms | 122.01 ms |  9.06 |    0.42 |
