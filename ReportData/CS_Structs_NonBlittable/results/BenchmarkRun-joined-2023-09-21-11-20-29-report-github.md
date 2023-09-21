```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-MWMBSE : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-JSLPIQ : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-HTVPJP : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

MaxRelativeError=0.01  InvocationCount=1  IterationCount=1  
LaunchCount=1  RunStrategy=ColdStart  UnrollFactor=1  
WarmupCount=5  

```
| Type            | Method                          | Runtime            | input                | Mean        | Error | Median      | Min         | Max         | Allocated |
|---------------- |-------------------------------- |------------------- |--------------------- |------------:|------:|------------:|------------:|------------:|----------:|
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] |    512.0 μs |    NA |    512.0 μs |    512.0 μs |    512.0 μs |     480 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] |    649.5 μs |    NA |    649.5 μs |    649.5 μs |    649.5 μs |     720 B |
| ManagedCS       | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] |    767.5 μs |    NA |    767.5 μs |    767.5 μs |    767.5 μs |         - |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 32,805.1 μs |    NA | 32,805.1 μs | 32,805.1 μs | 32,805.1 μs |     472 B |
| FuncPointersCS  | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 32,835.5 μs |    NA | 32,835.5 μs | 32,835.5 μs | 32,835.5 μs |     712 B |
| LibraryImportCS | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 33,440.7 μs |    NA | 33,440.7 μs | 33,440.7 μs | 33,440.7 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 8.0           | PInvo(...)truct [49] | 42,673.7 μs |    NA | 42,673.7 μs | 42,673.7 μs | 42,673.7 μs |     472 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET 6.0           | PInvo(...)truct [49] | 43,023.2 μs |    NA | 43,023.2 μs | 43,023.2 μs | 43,023.2 μs |     712 B |
| DllImportCS     | UpdateNonBlittableStruct_Manual | .NET Framework 4.8 | PInvo(...)truct [49] | 43,140.7 μs |    NA | 43,140.7 μs | 43,140.7 μs | 43,140.7 μs |         - |
