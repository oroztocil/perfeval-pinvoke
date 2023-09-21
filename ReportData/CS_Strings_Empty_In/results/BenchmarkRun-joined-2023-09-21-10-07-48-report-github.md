```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-KOUOZS : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-ZOOGFB : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QNKKKW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    362.7 μs |    NA |    362.7 μs |    362.7 μs |    362.7 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    389.6 μs |    NA |    389.6 μs |    389.6 μs |    389.6 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    483.9 μs |    NA |    483.9 μs |    483.9 μs |    483.9 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,145.6 μs |    NA | 31,145.6 μs | 31,145.6 μs | 31,145.6 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,148.7 μs |    NA | 31,148.7 μs | 31,148.7 μs | 31,148.7 μs |     688 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 31,768.0 μs |    NA | 31,768.0 μs | 31,768.0 μs | 31,768.0 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 42,076.4 μs |    NA | 42,076.4 μs | 42,076.4 μs | 42,076.4 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 42,167.5 μs |    NA | 42,167.5 μs | 42,167.5 μs | 42,167.5 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,655.3 μs |    NA | 42,655.3 μs | 42,655.3 μs | 42,655.3 μs |         - |
