```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-ZRCDSH : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-RPTBPJ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-EQVYIE : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    369.9 μs |    NA |    369.9 μs |    369.9 μs |    369.9 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    378.9 μs |    NA |    378.9 μs |    378.9 μs |    378.9 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    489.8 μs |    NA |    489.8 μs |    489.8 μs |    489.8 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,120.8 μs |    NA | 31,120.8 μs | 31,120.8 μs | 31,120.8 μs |     400 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 31,267.3 μs |    NA | 31,267.3 μs | 31,267.3 μs | 31,267.3 μs |     640 B |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,831.9 μs |    NA | 31,831.9 μs | 31,831.9 μs | 31,831.9 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 41,430.4 μs |    NA | 41,430.4 μs | 41,430.4 μs | 41,430.4 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 41,598.1 μs |    NA | 41,598.1 μs | 41,598.1 μs | 41,598.1 μs |         - |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 41,809.9 μs |    NA | 41,809.9 μs | 41,809.9 μs | 41,809.9 μs |     640 B |
