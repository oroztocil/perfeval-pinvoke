```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TOKHMN : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WIADSG : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-KQAKJP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    396.6 μs |    NA |    396.6 μs |    396.6 μs |    396.6 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    504.4 μs |    NA |    504.4 μs |    504.4 μs |    504.4 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    593.7 μs |    NA |    593.7 μs |    593.7 μs |    593.7 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 30,848.3 μs |    NA | 30,848.3 μs | 30,848.3 μs | 30,848.3 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 30,934.4 μs |    NA | 30,934.4 μs | 30,934.4 μs | 30,934.4 μs |     640 B |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 41,524.5 μs |    NA | 41,524.5 μs | 41,524.5 μs | 41,524.5 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 42,044.0 μs |    NA | 42,044.0 μs | 42,044.0 μs | 42,044.0 μs |         - |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 42,455.8 μs |    NA | 42,455.8 μs | 42,455.8 μs | 42,455.8 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 44,167.3 μs |    NA | 44,167.3 μs | 44,167.3 μs | 44,167.3 μs |     400 B |