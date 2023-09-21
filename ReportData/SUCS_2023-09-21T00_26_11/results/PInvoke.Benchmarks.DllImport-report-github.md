```

BenchmarkDotNet v0.13.8, Windows 10 (10.0.19045.3448/22H2/2022Update)
Intel Core i5-10400F CPU 2.90GHz, 1 CPU, 12 logical and 6 physical cores
.NET SDK 8.0.100-preview.7.23376.3
  [Host]     : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-PQSQNL : .NET 6.0.22 (6.0.2223.42425), X64 RyuJIT AVX2
  Job-OYRDQZ : .NET 8.0.0 (8.0.23.37506), X64 RyuJIT AVX2
  Job-DRIFLL : .NET Framework 4.8.1 (4.8.9181.0), X64 RyuJIT VectorSize=256

IterationTime=250.0000 ms  WarmupCount=5  

```
| Method                 | Runtime            | input       | Mean      | Error     | StdDev    | Median    | Min       | Max       |
|----------------------- |------------------- |------------ |----------:|----------:|----------:|----------:|----------:|----------:|
| Empty_IntArray_ByValue | .NET 6.0           | Int32[1000] | 10.709 ns | 0.0016 ns | 0.0012 ns | 10.709 ns | 10.708 ns | 10.712 ns |
| Empty_IntArray_ByValue | .NET 8.0           | Int32[1000] | 10.362 ns | 0.0032 ns | 0.0025 ns | 10.362 ns | 10.360 ns | 10.370 ns |
| Empty_IntArray_ByValue | .NET Framework 4.8 | Int32[1000] | 15.487 ns | 0.1747 ns | 0.1549 ns | 15.447 ns | 15.228 ns | 15.799 ns |
| Empty_IntArray_ByValue | .NET 6.0           | Int32[10]   |  8.773 ns | 0.0346 ns | 0.0307 ns |  8.757 ns |  8.753 ns |  8.843 ns |
| Empty_IntArray_ByValue | .NET 8.0           | Int32[10]   |  8.277 ns | 0.0067 ns | 0.0056 ns |  8.275 ns |  8.270 ns |  8.290 ns |
| Empty_IntArray_ByValue | .NET Framework 4.8 | Int32[10]   | 13.302 ns | 0.0045 ns | 0.0040 ns | 13.301 ns | 13.297 ns | 13.309 ns |
| Empty_StringSUCS       | .NET 6.0           | ?           | 41.645 ns | 0.0313 ns | 0.0261 ns | 41.646 ns | 41.588 ns | 41.684 ns |
| Empty_VoidSUCS         | .NET 6.0           | ?           |  7.008 ns | 0.0024 ns | 0.0019 ns |  7.008 ns |  7.006 ns |  7.013 ns |
| Empty_StringSUCS       | .NET 8.0           | ?           | 34.854 ns | 0.0925 ns | 0.0772 ns | 34.872 ns | 34.605 ns | 34.904 ns |
| Empty_VoidSUCS         | .NET 8.0           | ?           |  6.850 ns | 0.0014 ns | 0.0012 ns |  6.850 ns |  6.849 ns |  6.853 ns |
| Empty_StringSUCS       | .NET Framework 4.8 | ?           | 70.962 ns | 0.0900 ns | 0.0798 ns | 70.971 ns | 70.717 ns | 71.049 ns |
| Empty_VoidSUCS         | .NET Framework 4.8 | ?           |  8.490 ns | 0.0019 ns | 0.0015 ns |  8.490 ns |  8.488 ns |  8.493 ns |
| Empty_IntArraySUCS     | .NET 6.0           | Int32[1000] |  8.762 ns | 0.0206 ns | 0.0193 ns |  8.750 ns |  8.747 ns |  8.803 ns |
| Empty_IntArraySUCS     | .NET 8.0           | Int32[1000] |  8.277 ns | 0.0067 ns | 0.0056 ns |  8.276 ns |  8.270 ns |  8.290 ns |
| Empty_IntArraySUCS     | .NET Framework 4.8 | Int32[1000] | 10.131 ns | 0.0031 ns | 0.0026 ns | 10.130 ns | 10.127 ns | 10.136 ns |
| Empty_IntArraySUCS     | .NET 6.0           | Int32[10]   |  8.753 ns | 0.0142 ns | 0.0125 ns |  8.745 ns |  8.742 ns |  8.776 ns |
| Empty_IntArraySUCS     | .NET 8.0           | Int32[10]   |  8.281 ns | 0.0058 ns | 0.0045 ns |  8.279 ns |  8.276 ns |  8.290 ns |
| Empty_IntArraySUCS     | .NET Framework 4.8 | Int32[10]   | 10.157 ns | 0.0240 ns | 0.0187 ns | 10.163 ns | 10.117 ns | 10.179 ns |
| Empty_String           | .NET 6.0           | ?           | 42.346 ns | 0.6584 ns | 0.5837 ns | 42.109 ns | 41.860 ns | 43.562 ns |
| Empty_String           | .NET 8.0           | ?           | 34.785 ns | 0.2190 ns | 0.2049 ns | 34.700 ns | 34.542 ns | 35.160 ns |
| Empty_String           | .NET Framework 4.8 | ?           | 75.075 ns | 1.0750 ns | 0.8393 ns | 74.685 ns | 74.412 ns | 76.937 ns |
| Empty_Void             | .NET 6.0           | ?           |  7.503 ns | 0.1895 ns | 0.5345 ns |  7.466 ns |  6.733 ns |  9.054 ns |
| Empty_Void             | .NET 8.0           | ?           |  6.874 ns | 0.0371 ns | 0.0310 ns |  6.857 ns |  6.843 ns |  6.924 ns |
| Empty_Void             | .NET Framework 4.8 | ?           | 13.417 ns | 0.0407 ns | 0.0340 ns | 13.409 ns | 13.385 ns | 13.501 ns |
