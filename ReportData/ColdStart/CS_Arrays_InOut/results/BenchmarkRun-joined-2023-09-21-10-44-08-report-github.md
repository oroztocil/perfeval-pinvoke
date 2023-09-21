```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZKXFHT : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TYELGF : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-UIBBSH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    404.0 μs |    NA |    404.0 μs |    404.0 μs |    404.0 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    510.0 μs |    NA |    510.0 μs |    510.0 μs |    510.0 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    597.3 μs |    NA |    597.3 μs |    597.3 μs |    597.3 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 30,686.8 μs |    NA | 30,686.8 μs | 30,686.8 μs | 30,686.8 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 30,899.9 μs |    NA | 30,899.9 μs | 30,899.9 μs | 30,899.9 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 39,331.6 μs |    NA | 39,331.6 μs | 39,331.6 μs | 39,331.6 μs |     400 B |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 40,784.5 μs |    NA | 40,784.5 μs | 40,784.5 μs | 40,784.5 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 41,073.8 μs |    NA | 41,073.8 μs | 41,073.8 μs | 41,073.8 μs |         - |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 41,238.6 μs |    NA | 41,238.6 μs | 41,238.6 μs | 41,238.6 μs |     640 B |
