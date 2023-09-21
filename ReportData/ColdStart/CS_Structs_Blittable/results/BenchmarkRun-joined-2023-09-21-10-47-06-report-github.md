```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-WERAMA : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-OSJUFQ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-NOPEAP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method              | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] |    374.4 μs |    NA |    374.4 μs |    374.4 μs |    374.4 μs |     400 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] |    383.7 μs |    NA |    383.7 μs |    383.7 μs |    383.7 μs |     640 B |
| ManagedCS       | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] |    488.8 μs |    NA |    488.8 μs |    488.8 μs |    488.8 μs |         - |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,405.8 μs |    NA | 31,405.8 μs | 31,405.8 μs | 31,405.8 μs |     400 B |
| FuncPointersCS  | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 31,413.0 μs |    NA | 31,413.0 μs | 31,413.0 μs | 31,413.0 μs |     640 B |
| LibraryImportCS | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 31,901.7 μs |    NA | 31,901.7 μs | 31,901.7 μs | 31,901.7 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 6.0           | PInvo(...)truct [46] | 41,464.6 μs |    NA | 41,464.6 μs | 41,464.6 μs | 41,464.6 μs |     640 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET 8.0           | PInvo(...)truct [46] | 41,570.3 μs |    NA | 41,570.3 μs | 41,570.3 μs | 41,570.3 μs |     400 B |
| DllImportCS     | SumIntsInStruct_Ref | .NET Framework 4.8 | PInvo(...)truct [46] | 41,711.6 μs |    NA | 41,711.6 μs | 41,711.6 μs | 41,711.6 μs |         - |
