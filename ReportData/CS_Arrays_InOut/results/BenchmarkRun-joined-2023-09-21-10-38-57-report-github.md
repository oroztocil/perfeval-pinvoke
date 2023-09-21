```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PKCDSQ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LVFKFE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-NCIHJP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | input     | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |---------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | FillIntArray | .NET 8.0           | Int32[10] |    404.0 μs |    NA |    404.0 μs |    404.0 μs |    404.0 μs |     400 B |
| ManagedCS       | FillIntArray | .NET 6.0           | Int32[10] |    503.5 μs |    NA |    503.5 μs |    503.5 μs |    503.5 μs |     640 B |
| ManagedCS       | FillIntArray | .NET Framework 4.8 | Int32[10] |    586.3 μs |    NA |    586.3 μs |    586.3 μs |    586.3 μs |         - |
| FuncPointersCS  | FillIntArray | .NET 8.0           | Int32[10] | 30,861.1 μs |    NA | 30,861.1 μs | 30,861.1 μs | 30,861.1 μs |     400 B |
| FuncPointersCS  | FillIntArray | .NET 6.0           | Int32[10] | 32,338.8 μs |    NA | 32,338.8 μs | 32,338.8 μs | 32,338.8 μs |     640 B |
| LibraryImportCS | FillIntArray | .NET 8.0           | Int32[10] | 32,795.9 μs |    NA | 32,795.9 μs | 32,795.9 μs | 32,795.9 μs |     400 B |
| DllImportCS     | FillIntArray | .NET Framework 4.8 | Int32[10] | 42,061.9 μs |    NA | 42,061.9 μs | 42,061.9 μs | 42,061.9 μs |         - |
| DllImportCS     | FillIntArray | .NET 6.0           | Int32[10] | 42,115.0 μs |    NA | 42,115.0 μs | 42,115.0 μs | 42,115.0 μs |     640 B |
| DllImportCS     | FillIntArray | .NET 8.0           | Int32[10] | 42,125.3 μs |    NA | 42,125.3 μs | 42,125.3 μs | 42,125.3 μs |     400 B |
