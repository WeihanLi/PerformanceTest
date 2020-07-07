``` ini

BenchmarkDotNet=v0.12.1, OS=Windows 10.0.18363.900 (1909/November2018Update/19H2)
Intel Core i5-3470 CPU 3.20GHz (Ivy Bridge), 1 CPU, 4 logical and 4 physical cores
.NET Core SDK=5.0.100-preview.4.20258.7
  [Host]     : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT
  DefaultJob : .NET Core 3.1.5 (CoreCLR 4.700.20.26901, CoreFX 4.700.20.27001), X64 RyuJIT


```
|                Method |      Mean |    Error |   StdDev |
|---------------------- |----------:|---------:|---------:|
| IsValueType1ValueTest | 131.55 ns | 0.365 ns | 0.342 ns |
| IsValueType2ValueTest |  13.96 ns | 0.128 ns | 0.120 ns |
| IsValueType3ValueTest |  13.96 ns | 0.203 ns | 0.169 ns |
| IsValueType1ClassTest | 231.47 ns | 0.652 ns | 0.578 ns |
| IsValueType2ClassTest |  15.02 ns | 0.373 ns | 0.349 ns |
| IsValueType3ClassTest |  34.13 ns | 0.368 ns | 0.326 ns |
