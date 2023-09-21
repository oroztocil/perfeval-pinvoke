```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-GBHEAL : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PSTRIR : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-KOPCZC : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method     | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        | Allocated |
|-------------- |----------- |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|----------:|
| Managed       | NegateBool | .NET 8.0           |  0.7025 ns | 0.0088 ns | 0.0082 ns |  0.6979 ns |  0.6971 ns |  0.7166 ns |         - |
| Managed       | NegateBool | .NET 6.0           |  0.7031 ns | 0.0009 ns | 0.0008 ns |  0.7031 ns |  0.7015 ns |  0.7041 ns |         - |
| Managed       | NegateBool | .NET Framework 4.8 |  1.0166 ns | 0.0007 ns | 0.0006 ns |  1.0164 ns |  1.0157 ns |  1.0179 ns |         - |
| FuncPointers  | NegateBool | .NET 8.0           |  6.8684 ns | 0.0039 ns | 0.0033 ns |  6.8669 ns |  6.8651 ns |  6.8744 ns |         - |
| FuncPointers  | NegateBool | .NET 6.0           |  7.0233 ns | 0.0015 ns | 0.0012 ns |  7.0232 ns |  7.0216 ns |  7.0263 ns |         - |
| LibraryImport | NegateBool | .NET 8.0           |  9.4170 ns | 0.0019 ns | 0.0018 ns |  9.4168 ns |  9.4151 ns |  9.4203 ns |         - |
| DllImport     | NegateBool | .NET 8.0           | 10.1142 ns | 0.0023 ns | 0.0018 ns | 10.1135 ns | 10.1122 ns | 10.1177 ns |         - |
| DllImport     | NegateBool | .NET 6.0           | 10.1213 ns | 0.0079 ns | 0.0074 ns | 10.1192 ns | 10.1145 ns | 10.1352 ns |         - |
| DllImport     | NegateBool | .NET Framework 4.8 | 14.7499 ns | 0.0096 ns | 0.0085 ns | 14.7488 ns | 14.7366 ns | 14.7680 ns |         - |
