```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-CHLGTW : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-BQYPZK : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-QBZOAI : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    371.7 μs |    NA |    371.7 μs |    371.7 μs |    371.7 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    376.1 μs |    NA |    376.1 μs |    376.1 μs |    376.1 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    497.7 μs |    NA |    497.7 μs |    497.7 μs |    497.7 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 30,947.5 μs |    NA | 30,947.5 μs | 30,947.5 μs | 30,947.5 μs |     640 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 30,967.0 μs |    NA | 30,967.0 μs | 30,967.0 μs | 30,967.0 μs |     400 B |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,524.1 μs |    NA | 31,524.1 μs | 31,524.1 μs | 31,524.1 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 41,558.1 μs |    NA | 41,558.1 μs | 41,558.1 μs | 41,558.1 μs |         - |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 41,599.1 μs |    NA | 41,599.1 μs | 41,599.1 μs | 41,599.1 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 42,482.8 μs |    NA | 42,482.8 μs | 42,482.8 μs | 42,482.8 μs |     640 B |
