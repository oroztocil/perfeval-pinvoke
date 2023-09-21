```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CDHPDE : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-APAHZS : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-AGRLDX : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    407.1 μs |    NA |    407.1 μs |    407.1 μs |    407.1 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    497.2 μs |    NA |    497.2 μs |    497.2 μs |    497.2 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    582.0 μs |    NA |    582.0 μs |    582.0 μs |    582.0 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 31,446.8 μs |    NA | 31,446.8 μs | 31,446.8 μs | 31,446.8 μs |     640 B |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 31,935.4 μs |    NA | 31,935.4 μs | 31,935.4 μs | 31,935.4 μs |     400 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 32,682.9 μs |    NA | 32,682.9 μs | 32,682.9 μs | 32,682.9 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 42,886.3 μs |    NA | 42,886.3 μs | 42,886.3 μs | 42,886.3 μs |         - |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 43,420.3 μs |    NA | 43,420.3 μs | 43,420.3 μs | 43,420.3 μs |     400 B |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 43,796.6 μs |    NA | 43,796.6 μs | 43,796.6 μs | 43,796.6 μs |     640 B |
