```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WKQXDG : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-FLCOFD : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-LPEQHV : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    371.8 μs |    NA |    371.8 μs |    371.8 μs |    371.8 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    378.8 μs |    NA |    378.8 μs |    378.8 μs |    378.8 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    489.0 μs |    NA |    489.0 μs |    489.0 μs |    489.0 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 31,074.7 μs |    NA | 31,074.7 μs | 31,074.7 μs | 31,074.7 μs |     640 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,087.1 μs |    NA | 31,087.1 μs | 31,087.1 μs | 31,087.1 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 41,413.3 μs |    NA | 41,413.3 μs | 41,413.3 μs | 41,413.3 μs |     640 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 41,469.9 μs |    NA | 41,469.9 μs | 41,469.9 μs | 41,469.9 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 41,839.3 μs |    NA | 41,839.3 μs | 41,839.3 μs | 41,839.3 μs |         - |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 45,165.0 μs |    NA | 45,165.0 μs | 45,165.0 μs | 45,165.0 μs |     400 B |
