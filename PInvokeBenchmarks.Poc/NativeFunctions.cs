using System.Runtime.InteropServices;

namespace PInvokeBenchmarks.Poc;

internal static partial class NativeFunctions
{
    public const string LibraryName = "bench_lib";

    [LibraryImport(LibraryName)]
    public static partial void Hello();

    [LibraryImport(LibraryName)]
    public static partial int Answer();

    [LibraryImport(LibraryName)]
    public static partial int Mul2(int x);

    [LibraryImport(LibraryName, StringMarshalling = StringMarshalling.Utf8)]
    public static partial void ShoutAtMe(string input);
}