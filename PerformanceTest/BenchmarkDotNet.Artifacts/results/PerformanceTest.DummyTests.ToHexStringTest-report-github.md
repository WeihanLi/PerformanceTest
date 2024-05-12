```

BenchmarkDotNet v0.13.7, Windows 11 (10.0.22631.3527)
Intel Core Ultra 7 155H, 1 CPU, 22 logical and 16 physical cores
.NET SDK 9.0.100-preview.3.24204.13
  [Host]     : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2
  DefaultJob : .NET 8.0.4 (8.0.424.16909), X64 RyuJIT AVX2


```
|              Method |       Mean |     Error |    StdDev |
|-------------------- |-----------:|----------:|----------:|
|  ConvertToHexString |   7.914 ns | 0.0812 ns | 0.0634 ns |
| BitConverterConvert |  86.960 ns | 1.7135 ns | 1.6829 ns |
|          StringJoin | 128.956 ns | 2.5967 ns | 3.0912 ns |
|     StringAggregate | 168.589 ns | 3.3993 ns | 3.9147 ns |
