```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-LTAGKR : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-AZTWCT : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-PQVRHV : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    374.4 μs |    NA |    374.4 μs |    374.4 μs |    374.4 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    375.4 μs |    NA |    375.4 μs |    375.4 μs |    375.4 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    486.8 μs |    NA |    486.8 μs |    486.8 μs |    486.8 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,328.3 μs |    NA | 31,328.3 μs | 31,328.3 μs | 31,328.3 μs |     400 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 31,390.4 μs |    NA | 31,390.4 μs | 31,390.4 μs | 31,390.4 μs |     640 B |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 32,190.7 μs |    NA | 32,190.7 μs | 32,190.7 μs | 32,190.7 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 41,917.5 μs |    NA | 41,917.5 μs | 41,917.5 μs | 41,917.5 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 42,534.6 μs |    NA | 42,534.6 μs | 42,534.6 μs | 42,534.6 μs |     640 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 42,921.3 μs |    NA | 42,921.3 μs | 42,921.3 μs | 42,921.3 μs |         - |
