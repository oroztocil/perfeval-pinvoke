```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-SBFYIJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-RJSCVP : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-AUSCRQ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    398.1 μs |    NA |    398.1 μs |    398.1 μs |    398.1 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    501.1 μs |    NA |    501.1 μs |    501.1 μs |    501.1 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    592.8 μs |    NA |    592.8 μs |    592.8 μs |    592.8 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 30,583.8 μs |    NA | 30,583.8 μs | 30,583.8 μs | 30,583.8 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 30,822.3 μs |    NA | 30,822.3 μs | 30,822.3 μs | 30,822.3 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 31,635.8 μs |    NA | 31,635.8 μs | 31,635.8 μs | 31,635.8 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 41,620.3 μs |    NA | 41,620.3 μs | 41,620.3 μs | 41,620.3 μs |         - |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 41,653.4 μs |    NA | 41,653.4 μs | 41,653.4 μs | 41,653.4 μs |     400 B |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 42,136.5 μs |    NA | 42,136.5 μs | 42,136.5 μs | 42,136.5 μs |     640 B |
