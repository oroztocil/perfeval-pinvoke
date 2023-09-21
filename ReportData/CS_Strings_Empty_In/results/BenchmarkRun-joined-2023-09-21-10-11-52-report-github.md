```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MNTFHT : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-RNCEPU : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VCUVJH : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    346.8 μs |    NA |    346.8 μs |    346.8 μs |    346.8 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    381.6 μs |    NA |    381.6 μs |    381.6 μs |    381.6 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    488.8 μs |    NA |    488.8 μs |    488.8 μs |    488.8 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 31,040.1 μs |    NA | 31,040.1 μs | 31,040.1 μs | 31,040.1 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,422.1 μs |    NA | 31,422.1 μs | 31,422.1 μs | 31,422.1 μs |     688 B |
| LibraryImportCS | Empty_String | .NET 8.0           | 31,858.5 μs |    NA | 31,858.5 μs | 31,858.5 μs | 31,858.5 μs |     400 B |
| DllImportCS     | Empty_String | .NET 6.0           | 41,798.7 μs |    NA | 41,798.7 μs | 41,798.7 μs | 41,798.7 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 42,185.7 μs |    NA | 42,185.7 μs | 42,185.7 μs | 42,185.7 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,554.0 μs |    NA | 42,554.0 μs | 42,554.0 μs | 42,554.0 μs |         - |