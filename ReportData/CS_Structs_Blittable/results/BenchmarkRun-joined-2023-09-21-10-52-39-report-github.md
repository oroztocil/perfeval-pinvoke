```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QVFKFD : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-XNJJOP : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-AIMMAT : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    373.4 μs |    NA |    373.4 μs |    373.4 μs |    373.4 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    381.3 μs |    NA |    381.3 μs |    381.3 μs |    381.3 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    530.8 μs |    NA |    530.8 μs |    530.8 μs |    530.8 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,368.9 μs |    NA | 31,368.9 μs | 31,368.9 μs | 31,368.9 μs |     400 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 31,422.6 μs |    NA | 31,422.6 μs | 31,422.6 μs | 31,422.6 μs |     640 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 42,161.2 μs |    NA | 42,161.2 μs | 42,161.2 μs | 42,161.2 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 42,243.2 μs |    NA | 42,243.2 μs | 42,243.2 μs | 42,243.2 μs |         - |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 44,436.2 μs |    NA | 44,436.2 μs | 44,436.2 μs | 44,436.2 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 45,742.8 μs |    NA | 45,742.8 μs | 45,742.8 μs | 45,742.8 μs |     640 B |