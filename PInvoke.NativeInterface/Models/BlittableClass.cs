using System.Runtime.InteropServices;

namespace PInvoke.NativeInterface.Models
{
    [StructLayout(LayoutKind.Sequential)]
    public class BlittableClass
    {
        public int a;
        public int b;
        public int result;
    }
}
