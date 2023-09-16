using System.Runtime.InteropServices;

namespace PInvoke.NativeInterface.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public struct BlittableStruct
    {
        public int a;
        public int b;
        public int result;
    }
}
