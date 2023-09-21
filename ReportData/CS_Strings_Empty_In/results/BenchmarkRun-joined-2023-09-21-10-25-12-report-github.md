```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ILUWCE : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-MQIJUF : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CTAYGW : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |------------- |------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | Empty_String | .NET 6.0           |    371.3 μs |    NA |    371.3 μs |    371.3 μs |    371.3 μs |     640 B |
| ManagedCS       | Empty_String | .NET 8.0           |    387.0 μs |    NA |    387.0 μs |    387.0 μs |    387.0 μs |     400 B |
| ManagedCS       | Empty_String | .NET Framework 4.8 |    497.8 μs |    NA |    497.8 μs |    497.8 μs |    497.8 μs |         - |
| FuncPointersCS  | Empty_String | .NET 8.0           | 30,988.8 μs |    NA | 30,988.8 μs | 30,988.8 μs | 30,988.8 μs |     448 B |
| FuncPointersCS  | Empty_String | .NET 6.0           | 31,262.1 μs |    NA | 31,262.1 μs | 31,262.1 μs | 31,262.1 μs |     688 B |
| DllImportCS     | Empty_String | .NET 6.0           | 41,997.9 μs |    NA | 41,997.9 μs | 41,997.9 μs | 41,997.9 μs |     640 B |
| DllImportCS     | Empty_String | .NET 8.0           | 42,222.3 μs |    NA | 42,222.3 μs | 42,222.3 μs | 42,222.3 μs |     400 B |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 42,882.8 μs |    NA | 42,882.8 μs | 42,882.8 μs | 42,882.8 μs |         - |
| LibraryImportCS | Empty_String | .NET 8.0           | 44,096.4 μs |    NA | 44,096.4 μs | 44,096.4 μs | 44,096.4 μs |     400 B |
