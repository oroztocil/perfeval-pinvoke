```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-YUCSQJ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YCWZNR : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BLPJLO : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    356.7 μs |    NA |    356.7 μs |    356.7 μs |    356.7 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    384.8 μs |    NA |    384.8 μs |    384.8 μs |    384.8 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    499.3 μs |    NA |    499.3 μs |    499.3 μs |    499.3 μs |         - |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,407.1 μs |    NA | 31,407.1 μs | 31,407.1 μs | 31,407.1 μs |     688 B |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,587.2 μs |    NA | 31,587.2 μs | 31,587.2 μs | 31,587.2 μs |     448 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,457.7 μs |    NA | 32,457.7 μs | 32,457.7 μs | 32,457.7 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,212.9 μs |    NA | 42,212.9 μs | 42,212.9 μs | 42,212.9 μs |         - |
| DllImportCS     | Empty_String | .NET 8.0           | 43,162.5 μs |    NA | 43,162.5 μs | 43,162.5 μs | 43,162.5 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 43,742.6 μs |    NA | 43,742.6 μs | 43,742.6 μs | 43,742.6 μs |     640 B |
