using System;

namespace PInvoke.NativeInterface
{
    public static class MarshalExtensions
    {
        public const byte FalseByte = 0;
        public const byte TrueByte = 1;

        public static byte BoolToByte(bool value) =>
            value ? TrueByte : FalseByte;

        public static bool ByteToBool(byte value) =>
            value != FalseByte;

        public static IntPtr StringToHGlobalUTF8(string str, out int length)
        {
            length = 0;
            return IntPtr.Zero;
        }
    }
}
