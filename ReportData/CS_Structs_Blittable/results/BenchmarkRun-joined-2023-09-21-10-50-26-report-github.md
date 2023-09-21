```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JBKJKW : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-QKXQRT : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-WMGFMK : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    373.6 μs |    NA |    373.6 μs |    373.6 μs |    373.6 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    377.2 μs |    NA |    377.2 μs |    377.2 μs |    377.2 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    487.7 μs |    NA |    487.7 μs |    487.7 μs |    487.7 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 30,999.3 μs |    NA | 30,999.3 μs | 30,999.3 μs | 30,999.3 μs |     400 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 31,214.9 μs |    NA | 31,214.9 μs | 31,214.9 μs | 31,214.9 μs |     640 B |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,752.2 μs |    NA | 31,752.2 μs | 31,752.2 μs | 31,752.2 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 41,399.1 μs |    NA | 41,399.1 μs | 41,399.1 μs | 41,399.1 μs |         - |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 41,517.7 μs |    NA | 41,517.7 μs | 41,517.7 μs | 41,517.7 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 42,214.3 μs |    NA | 42,214.3 μs | 42,214.3 μs | 42,214.3 μs |     640 B |
