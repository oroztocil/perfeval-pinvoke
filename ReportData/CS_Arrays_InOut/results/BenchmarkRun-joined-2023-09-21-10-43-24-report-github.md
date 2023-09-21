```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZENSTG : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-HYDEZR : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-RSTKGQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    403.9 μs |    NA |    403.9 μs |    403.9 μs |    403.9 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    499.3 μs |    NA |    499.3 μs |    499.3 μs |    499.3 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    588.1 μs |    NA |    588.1 μs |    588.1 μs |    588.1 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 32,054.2 μs |    NA | 32,054.2 μs | 32,054.2 μs | 32,054.2 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 32,534.6 μs |    NA | 32,534.6 μs | 32,534.6 μs | 32,534.6 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 32,766.2 μs |    NA | 32,766.2 μs | 32,766.2 μs | 32,766.2 μs |     400 B |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 42,634.1 μs |    NA | 42,634.1 μs | 42,634.1 μs | 42,634.1 μs |     640 B |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 42,973.0 μs |    NA | 42,973.0 μs | 42,973.0 μs | 42,973.0 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 43,471.4 μs |    NA | 43,471.4 μs | 43,471.4 μs | 43,471.4 μs |         - |
