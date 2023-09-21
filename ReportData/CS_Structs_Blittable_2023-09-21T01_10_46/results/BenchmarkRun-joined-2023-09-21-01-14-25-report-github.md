```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VFFXGM : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-EZKNGS : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-TLIJAB : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

InvocationCount=1  IterationCount=1  IterationTime=250.0000 ms  
LaunchCount=100  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean       | Error       | StdDev      | Median     | Min        | Max         |
|---------------- |-------------------- |------------------- |--------------------- |-----------:|------------:|------------:|-----------:|-----------:|------------:|
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 1,729.2 μs | 1,397.01 μs | 4,119.12 μs | 1,311.6 μs | 1,264.4 μs | 42,507.4 μs |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 1,724.2 μs | 1,344.63 μs | 3,964.68 μs | 1,327.5 μs | 1,283.0 μs | 40,974.0 μs |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 2,096.5 μs | 1,378.01 μs | 4,063.10 μs | 1,683.2 μs | 1,653.6 μs | 42,320.5 μs |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 1,901.8 μs | 1,175.31 μs | 3,465.43 μs | 1,554.3 μs | 1,520.2 μs | 36,208.7 μs |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 1,861.7 μs | 1,027.69 μs | 3,030.16 μs | 1,558.2 μs | 1,517.3 μs | 31,859.0 μs |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 1,611.9 μs | 1,174.81 μs | 3,463.96 μs | 1,264.2 μs | 1,225.6 μs | 35,904.4 μs |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |   378.1 μs |     1.58 μs |     4.67 μs |   378.2 μs |   365.7 μs |    393.0 μs |
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |   359.6 μs |     2.24 μs |     6.61 μs |   359.5 μs |   343.8 μs |    401.4 μs |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |   499.7 μs |     1.54 μs |     4.54 μs |   498.9 μs |   490.7 μs |    514.4 μs |
