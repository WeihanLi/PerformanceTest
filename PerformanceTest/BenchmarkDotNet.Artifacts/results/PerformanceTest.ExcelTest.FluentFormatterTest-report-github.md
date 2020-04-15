``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.778 (1909/November2018Update/19H2)
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.100-preview.1.20155.7
  [Host]    : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  1.8.2     : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT
  1.9.0-pre : .NET Core 3.1.3 (CoreCLR 4.700.20.11803, CoreFX 4.700.20.12001), X64 RyuJIT

IterationCount=15  LaunchCount=2  WarmupCount=10  

```
|          Method |       Job |                             NuGetReferences |     Mean |    Error |   StdDev |
|---------------- |---------- |-------------------------------------------- |---------:|---------:|---------:|
| FluentFormatter |     1.8.2 |                         WeihanLi.Npoi 1.8.2 | 552.2 μs | 121.0 μs | 181.1 μs |
| FluentFormatter | 1.9.0-pre | WeihanLi.Npoi 1.9.0-preview-20200413-122712 | 465.0 μs | 100.0 μs | 146.6 μs |
