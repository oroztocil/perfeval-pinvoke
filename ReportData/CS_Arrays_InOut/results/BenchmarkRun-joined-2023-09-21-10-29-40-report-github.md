```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-GVAIMZ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-AMBRNT : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YELZTH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    403.3 μs |    NA |    403.3 μs |    403.3 μs |    403.3 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    509.3 μs |    NA |    509.3 μs |    509.3 μs |    509.3 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    591.8 μs |    NA |    591.8 μs |    591.8 μs |    591.8 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 31,001.1 μs |    NA | 31,001.1 μs | 31,001.1 μs | 31,001.1 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 31,100.6 μs |    NA | 31,100.6 μs | 31,100.6 μs | 31,100.6 μs |     640 B |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 40,976.8 μs |    NA | 40,976.8 μs | 40,976.8 μs | 40,976.8 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 41,300.7 μs |    NA | 41,300.7 μs | 41,300.7 μs | 41,300.7 μs |         - |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 41,755.6 μs |    NA | 41,755.6 μs | 41,755.6 μs | 41,755.6 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 44,354.9 μs |    NA | 44,354.9 μs | 44,354.9 μs | 44,354.9 μs |     400 B |
