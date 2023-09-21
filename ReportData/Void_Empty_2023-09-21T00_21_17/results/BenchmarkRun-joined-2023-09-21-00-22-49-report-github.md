```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DAQGWA : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-NDGSCD : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LVCDDB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Type          | Method     | Runtime            | Mean       | Error     | StdDev    | Median     | Min        | Max        |
|-------------- |----------- |------------------- |-----------:|----------:|----------:|-----------:|-----------:|-----------:|
| DllImport     | Empty_Void | .NET 6.0           |  9.0867 ns | 0.0093 ns | 0.0087 ns |  9.0843 ns |  9.0766 ns |  9.1049 ns |
| DllImport     | Empty_Void | .NET 8.0           |  9.0785 ns | 0.0067 ns | 0.0056 ns |  9.0791 ns |  9.0691 ns |  9.0863 ns |
| DllImport     | Empty_Void | .NET Framework 4.8 | 14.3759 ns | 0.0263 ns | 0.0246 ns | 14.3774 ns | 14.3244 ns | 14.4125 ns |
| FuncPointers  | Empty_Void | .NET 6.0           |  8.7246 ns | 0.0044 ns | 0.0037 ns |  8.7255 ns |  8.7199 ns |  8.7319 ns |
| FuncPointers  | Empty_Void | .NET 8.0           |  8.7289 ns | 0.0053 ns | 0.0042 ns |  8.7280 ns |  8.7247 ns |  8.7407 ns |
| LibraryImport | Empty_Void | .NET 8.0           |  9.0751 ns | 0.0015 ns | 0.0012 ns |  9.0749 ns |  9.0733 ns |  9.0773 ns |
| Managed       | Empty_Void | .NET 6.0           |  0.6928 ns | 0.0007 ns | 0.0006 ns |  0.6927 ns |  0.6915 ns |  0.6942 ns |
| Managed       | Empty_Void | .NET 8.0           |  0.6984 ns | 0.0003 ns | 0.0003 ns |  0.6984 ns |  0.6980 ns |  0.6988 ns |
| Managed       | Empty_Void | .NET Framework 4.8 |  1.0710 ns | 0.0013 ns | 0.0011 ns |  1.0706 ns |  1.0698 ns |  1.0737 ns |
