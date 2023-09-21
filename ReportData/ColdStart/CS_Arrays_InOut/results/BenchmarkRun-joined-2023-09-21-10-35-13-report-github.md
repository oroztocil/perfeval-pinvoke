```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QTKMQJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MTUYHX : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-NMYUSG : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    400.8 μs |    NA |    400.8 μs |    400.8 μs |    400.8 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    505.8 μs |    NA |    505.8 μs |    505.8 μs |    505.8 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    600.5 μs |    NA |    600.5 μs |    600.5 μs |    600.5 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 30,798.2 μs |    NA | 30,798.2 μs | 30,798.2 μs | 30,798.2 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 30,895.9 μs |    NA | 30,895.9 μs | 30,895.9 μs | 30,895.9 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 31,670.3 μs |    NA | 31,670.3 μs | 31,670.3 μs | 31,670.3 μs |     400 B |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 41,245.3 μs |    NA | 41,245.3 μs | 41,245.3 μs | 41,245.3 μs |     640 B |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 41,507.2 μs |    NA | 41,507.2 μs | 41,507.2 μs | 41,507.2 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 41,750.0 μs |    NA | 41,750.0 μs | 41,750.0 μs | 41,750.0 μs |         - |
