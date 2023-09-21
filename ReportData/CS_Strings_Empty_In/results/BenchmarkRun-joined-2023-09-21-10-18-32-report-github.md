```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZFPUEQ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-EADSFT : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CIGEAJ : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    358.5 μs |    NA |    358.5 μs |    358.5 μs |    358.5 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    371.1 μs |    NA |    371.1 μs |    371.1 μs |    371.1 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    493.8 μs |    NA |    493.8 μs |    493.8 μs |    493.8 μs |         - |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,278.5 μs |    NA | 31,278.5 μs | 31,278.5 μs | 31,278.5 μs |     688 B |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,637.5 μs |    NA | 31,637.5 μs | 31,637.5 μs | 31,637.5 μs |     448 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,367.6 μs |    NA | 32,367.6 μs | 32,367.6 μs | 32,367.6 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 42,469.5 μs |    NA | 42,469.5 μs | 42,469.5 μs | 42,469.5 μs |     640 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,495.6 μs |    NA | 42,495.6 μs | 42,495.6 μs | 42,495.6 μs |         - |
| DllImportCS     | Empty_String | .NET 8.0           | 42,760.4 μs |    NA | 42,760.4 μs | 42,760.4 μs | 42,760.4 μs |     400 B |
