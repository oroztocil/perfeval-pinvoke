```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-POHQQA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NHTGTD : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-HBBHJI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    409.9 μs |    NA |    409.9 μs |    409.9 μs |    409.9 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    496.6 μs |    NA |    496.6 μs |    496.6 μs |    496.6 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    577.9 μs |    NA |    577.9 μs |    577.9 μs |    577.9 μs |         - |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 31,803.4 μs |    NA | 31,803.4 μs | 31,803.4 μs | 31,803.4 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 32,002.1 μs |    NA | 32,002.1 μs | 32,002.1 μs | 32,002.1 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 32,676.1 μs |    NA | 32,676.1 μs | 32,676.1 μs | 32,676.1 μs |     640 B |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 41,879.4 μs |    NA | 41,879.4 μs | 41,879.4 μs | 41,879.4 μs |     640 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 42,476.5 μs |    NA | 42,476.5 μs | 42,476.5 μs | 42,476.5 μs |         - |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 43,355.8 μs |    NA | 43,355.8 μs | 43,355.8 μs | 43,355.8 μs |     400 B |
