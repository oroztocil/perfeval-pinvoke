```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-KBDCZB : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QKBCJM : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-XDQDJS : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  WarmupCount=5  

```
| Type          | Method        | Runtime            | Mean      | Error     | StdDev    | Median    | Min       | Max       | Allocated |
|-------------- |-------------- |------------------- |----------:|----------:|----------:|----------:|----------:|----------:|----------:|
| LibraryImport | EmptyVoid     | .NET 8.0           |  6.843 ns | 0.0017 ns | 0.0013 ns |  6.843 ns |  6.842 ns |  6.847 ns |         - |
| DllImport     | EmptyVoid     | .NET 8.0           |  6.849 ns | 0.0099 ns | 0.0092 ns |  6.843 ns |  6.842 ns |  6.864 ns |         - |
| DllImport     | EmptyVoid     | .NET 6.0           |  7.727 ns | 0.0105 ns | 0.0098 ns |  7.730 ns |  7.708 ns |  7.740 ns |         - |
| DllImport     | EmptyVoid     | .NET Framework 4.8 | 12.384 ns | 0.0042 ns | 0.0038 ns | 12.383 ns | 12.380 ns | 12.392 ns |         - |
| DllImport     | EmptyVoid_SLE | .NET 6.0           | 16.356 ns | 0.0104 ns | 0.0092 ns | 16.356 ns | 16.341 ns | 16.377 ns |         - |
| DllImport     | EmptyVoid_SLE | .NET 8.0           | 17.090 ns | 0.0028 ns | 0.0025 ns | 17.089 ns | 17.087 ns | 17.096 ns |         - |
| LibraryImport | EmptyVoid_SLE | .NET 8.0           | 17.518 ns | 0.0032 ns | 0.0025 ns | 17.518 ns | 17.515 ns | 17.523 ns |         - |
| DllImport     | EmptyVoid_SLE | .NET Framework 4.8 | 18.164 ns | 0.0254 ns | 0.0237 ns | 18.158 ns | 18.140 ns | 18.217 ns |         - |
