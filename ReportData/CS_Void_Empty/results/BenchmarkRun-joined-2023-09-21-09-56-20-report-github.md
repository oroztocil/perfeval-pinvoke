```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FOXVTL : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-TETHMR : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BMETFH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method     | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |----------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_Void | .NET 6.0           |    267.2 μs |    NA |    267.2 μs |    267.2 μs |    267.2 μs |     640 B |
| ManagedCS       | Empty_Void | .NET 8.0           |    325.4 μs |    NA |    325.4 μs |    325.4 μs |    325.4 μs |     400 B |
| ManagedCS       | Empty_Void | .NET Framework 4.8 |    362.3 μs |    NA |    362.3 μs |    362.3 μs |    362.3 μs |         - |
| FuncPointersCS  | Empty_Void | .NET 6.0           | 31,634.8 μs |    NA | 31,634.8 μs | 31,634.8 μs | 31,634.8 μs |     640 B |
| FuncPointersCS  | Empty_Void | .NET 8.0           | 31,657.1 μs |    NA | 31,657.1 μs | 31,657.1 μs | 31,657.1 μs |     400 B |
| LibraryImportCS | Empty_Void | .NET 8.0           | 32,295.9 μs |    NA | 32,295.9 μs | 32,295.9 μs | 32,295.9 μs |     400 B |
| DllImportCS     | Empty_Void | .NET Framework 4.8 | 41,668.1 μs |    NA | 41,668.1 μs | 41,668.1 μs | 41,668.1 μs |         - |
| DllImportCS     | Empty_Void | .NET 6.0           | 42,315.3 μs |    NA | 42,315.3 μs | 42,315.3 μs | 42,315.3 μs |     640 B |
| DllImportCS     | Empty_Void | .NET 8.0           | 43,652.0 μs |    NA | 43,652.0 μs | 43,652.0 μs | 43,652.0 μs |     400 B |
