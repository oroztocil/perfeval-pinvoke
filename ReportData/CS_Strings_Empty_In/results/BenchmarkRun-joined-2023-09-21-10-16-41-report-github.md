```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-SVORXI : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-RXHVZM : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QWSDEL : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    354.7 μs |    NA |    354.7 μs |    354.7 μs |    354.7 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    397.9 μs |    NA |    397.9 μs |    397.9 μs |    397.9 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    488.5 μs |    NA |    488.5 μs |    488.5 μs |    488.5 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,312.0 μs |    NA | 31,312.0 μs | 31,312.0 μs | 31,312.0 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,454.4 μs |    NA | 31,454.4 μs | 31,454.4 μs | 31,454.4 μs |     688 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 32,374.4 μs |    NA | 32,374.4 μs | 32,374.4 μs | 32,374.4 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,577.6 μs |    NA | 42,577.6 μs | 42,577.6 μs | 42,577.6 μs |         - |
| DllImportCS     | Empty_String | .NET 6.0           | 43,289.4 μs |    NA | 43,289.4 μs | 43,289.4 μs | 43,289.4 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 43,782.4 μs |    NA | 43,782.4 μs | 43,782.4 μs | 43,782.4 μs |     400 B |
