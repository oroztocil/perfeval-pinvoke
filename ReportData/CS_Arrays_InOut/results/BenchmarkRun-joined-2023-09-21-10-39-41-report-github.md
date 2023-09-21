```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UYULJS : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-KWVSDQ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-YUYNBW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    409.5 μs |    NA |    409.5 μs |    409.5 μs |    409.5 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    501.3 μs |    NA |    501.3 μs |    501.3 μs |    501.3 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    584.5 μs |    NA |    584.5 μs |    584.5 μs |    584.5 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 31,146.5 μs |    NA | 31,146.5 μs | 31,146.5 μs | 31,146.5 μs |     400 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 31,896.5 μs |    NA | 31,896.5 μs | 31,896.5 μs | 31,896.5 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 31,984.3 μs |    NA | 31,984.3 μs | 31,984.3 μs | 31,984.3 μs |     640 B |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 41,545.7 μs |    NA | 41,545.7 μs | 41,545.7 μs | 41,545.7 μs |     400 B |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 42,048.5 μs |    NA | 42,048.5 μs | 42,048.5 μs | 42,048.5 μs |     640 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 42,674.0 μs |    NA | 42,674.0 μs | 42,674.0 μs | 42,674.0 μs |         - |
