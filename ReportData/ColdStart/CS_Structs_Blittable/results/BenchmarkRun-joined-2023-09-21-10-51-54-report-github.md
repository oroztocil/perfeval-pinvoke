```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-VZADFJ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MFSTOQ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-GAYQOF : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    376.6 μs |    NA |    376.6 μs |    376.6 μs |    376.6 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    378.2 μs |    NA |    378.2 μs |    378.2 μs |    378.2 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    551.3 μs |    NA |    551.3 μs |    551.3 μs |    551.3 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 30,892.7 μs |    NA | 30,892.7 μs | 30,892.7 μs | 30,892.7 μs |     640 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 30,990.2 μs |    NA | 30,990.2 μs | 30,990.2 μs | 30,990.2 μs |     400 B |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,390.8 μs |    NA | 31,390.8 μs | 31,390.8 μs | 31,390.8 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 40,988.8 μs |    NA | 40,988.8 μs | 40,988.8 μs | 40,988.8 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 41,964.6 μs |    NA | 41,964.6 μs | 41,964.6 μs | 41,964.6 μs |     640 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 42,200.0 μs |    NA | 42,200.0 μs | 42,200.0 μs | 42,200.0 μs |         - |
