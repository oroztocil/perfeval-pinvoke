```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-UROJPB : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-JPSVFM : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CWYEUU : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

InvocationCount=1  IterationCount=1  IterationTime=250.0000 ms  
LaunchCount=100  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method       | Runtime            | Mean       | Error       | StdDev      | Median     | Min        | Max         |
|---------------- |------------- |------------------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|
| DllImportCS     | Empty_String | .NET 6.0           | 1,991.1 μs | 1,387.63 μs | 4,091.45 μs | 1,572.9 μs | 1,539.9 μs | 42,494.4 μs |
| DllImportCS     | Empty_String | .NET 8.0           | 2,487.9 μs | 1,373.58 μs | 4,050.04 μs | 2,083.3 μs | 1,963.8 μs | 42,580.6 μs |
| DllImportCS     | Empty_String | .NET Framework 4.8 | 2,324.9 μs | 1,405.92 μs | 4,145.38 μs | 1,908.2 μs | 1,865.8 μs | 43,363.5 μs |
| FuncPointersCS  | Empty_String | .NET 6.0           | 1,795.0 μs | 1,006.97 μs | 2,969.07 μs | 1,492.5 μs | 1,470.1 μs | 31,188.1 μs |
| FuncPointersCS  | Empty_String | .NET 8.0           | 1,868.8 μs | 1,108.22 μs | 3,267.62 μs | 1,542.8 μs | 1,497.4 μs | 34,217.8 μs |
| LibraryImportCS | Empty_String | .NET 8.0           | 1,734.8 μs | 1,072.26 μs | 3,161.58 μs | 1,419.8 μs | 1,375.5 μs | 33,033.9 μs |
| ManagedCS       | Empty_String | .NET 6.0           |   360.8 μs |     1.67 μs |     4.94 μs |   361.4 μs |   348.8 μs |    377.5 μs |
| ManagedCS       | Empty_String | .NET 8.0           |   376.5 μs |     1.44 μs |     4.24 μs |   377.0 μs |   363.0 μs |    386.2 μs |
| ManagedCS       | Empty_String | .NET Framework 4.8 |   492.2 μs |     1.87 μs |     5.50 μs |   490.9 μs |   484.1 μs |    512.2 μs |
