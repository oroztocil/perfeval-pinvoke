```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BMJCUL : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-IFPAZD : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DUHSJX : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method     | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |----------- |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | NegateBool | .NET 6.0           | 10.1199 ns | 0.0051 ns | 0.0043 ns | 10.1208 ns | 10.1142 ns | 10.1288 ns |
| DllImport     | NegateBool | .NET 8.0           | 10.1241 ns | 0.0068 ns | 0.0057 ns | 10.1234 ns | 10.1151 ns | 10.1347 ns |
| DllImport     | NegateBool | .NET Framework 4.8 | 15.1833 ns | 0.0070 ns | 0.0062 ns | 15.1819 ns | 15.1761 ns | 15.1989 ns |
| FuncPointers  | NegateBool | .NET 6.0           |  9.0740 ns | 0.0014 ns | 0.0012 ns |  9.0739 ns |  9.0724 ns |  9.0762 ns |
| FuncPointers  | NegateBool | .NET 8.0           |  9.0738 ns | 0.0014 ns | 0.0013 ns |  9.0741 ns |  9.0711 ns |  9.0758 ns |
| LibraryImport | NegateBool | .NET 8.0           |  9.4240 ns | 0.0011 ns | 0.0009 ns |  9.4239 ns |  9.4223 ns |  9.4253 ns |
| Managed       | NegateBool | .NET 6.0           |  0.7022 ns | 0.0004 ns | 0.0003 ns |  0.7022 ns |  0.7016 ns |  0.7028 ns |
| Managed       | NegateBool | .NET 8.0           |  0.6984 ns | 0.0008 ns | 0.0006 ns |  0.6985 ns |  0.6965 ns |  0.6992 ns |
| Managed       | NegateBool | .NET Framework 4.8 |  1.0779 ns | 0.0008 ns | 0.0007 ns |  1.0779 ns |  1.0771 ns |  1.0797 ns |
