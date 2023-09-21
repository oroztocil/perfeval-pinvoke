```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-NGTSDB : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-UPXSXY : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QKMJWD : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    365.7 μs |    NA |    365.7 μs |    365.7 μs |    365.7 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    373.0 μs |    NA |    373.0 μs |    373.0 μs |    373.0 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    492.7 μs |    NA |    492.7 μs |    492.7 μs |    492.7 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 31,357.2 μs |    NA | 31,357.2 μs | 31,357.2 μs | 31,357.2 μs |     640 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,393.2 μs |    NA | 31,393.2 μs | 31,393.2 μs | 31,393.2 μs |     400 B |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 32,315.6 μs |    NA | 32,315.6 μs | 32,315.6 μs | 32,315.6 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 41,644.2 μs |    NA | 41,644.2 μs | 41,644.2 μs | 41,644.2 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 41,907.7 μs |    NA | 41,907.7 μs | 41,907.7 μs | 41,907.7 μs |     640 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 43,174.5 μs |    NA | 43,174.5 μs | 43,174.5 μs | 43,174.5 μs |         - |
