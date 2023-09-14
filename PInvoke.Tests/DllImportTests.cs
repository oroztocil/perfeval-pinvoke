using System.Linq;

using PInvoke.NativeInterface.DllImport;

using Xunit;

namespace PInvoke.Tests
{
    public class DllImportTests
    {
        [Fact]
        public void MultiplyInt()
        {
            var a = 1234;
            var b = 4321;
            var result = NativeFunctions.MultiplyInt(a, b);

            Assert.Equal(a * b, result);
        }

        [Theory]
        [InlineData(true)]
        [InlineData(false)]
        public void NegateBool(bool input)
        {
            var result = NativeFunctions.NegateBool(input);

            Assert.Equal(!input, result);
        }

        [Fact]
        public void SumIntArray()
        {
            var arr = new int[] { 1, 2, 3, 4 };
            var sum = NativeFunctions.SumIntArray(arr, arr.Length);

            Assert.Equal(arr.Sum(), sum);
        }

        [Fact]
        public void FillIntArray()
        {
            var buffer = new int[10];
            NativeFunctions.FillIntArray(buffer, buffer.Length);

            var expected = Enumerable.Range(0, 10).ToArray();

            Assert.Equal(expected, buffer);
        }

        [Fact]
        public void FillIntArray_Out()
        {
            var buffer = new int[10];
            NativeFunctions.FillIntArray_OutAttr(buffer, buffer.Length);

            var expected = Enumerable.Range(0, 10).ToArray();

            Assert.Equal(expected, buffer);
        }

        [Fact]
        public void FillIntArray_PinnedHandle()
        {
            var buffer = new int[10];
            NativeFunctions.FillIntArray_Pinned(buffer, buffer.Length);

            var expected = Enumerable.Range(0, 10).ToArray();

            Assert.Equal(expected, buffer);
        }

        [Fact]
        public void FillIntArray_FixedPtr()
        {
            var buffer = new int[10];
            NativeFunctions.FillIntArray_Fixed(buffer, buffer.Length);

            var expected = Enumerable.Range(0, 10).ToArray();

            Assert.Equal(expected, buffer);
        }

        [Theory]
        [InlineData("evaluace")]
        [InlineData("koníček")]
        public void StringLength_MultiByte(string input)
        {
            var result = NativeFunctions.StringLength_MultiByte(input);

#if OS_WINDOWS // CharSet = CharSet.Ansi uses code pages on Windows
            Assert.Equal(input.Length, result);
#else // CharSet = CharSet.Ansi uses UTF-8 on Linux
            var utf8Bytes = Encoding.UTF8.GetBytes(input);
            Assert.Equal(utf8Bytes.Length, result);
#endif
        }

        [Theory]
        [InlineData("evaluace")]
        [InlineData("koníček")]
        public void StringLength_Utf16(string input)
        {
            var result = NativeFunctions.StringLength_Utf16(input);

            Assert.Equal(input.Length, result);
        }

        [Theory]
        [InlineData("evaluace")]
        public void StringToUppercase_ByteArray(string input)
        {
            var result = NativeFunctions.StringToUppercase_ByteArray(input);

            Assert.Equal(input.ToUpper(), result);
        }

        [Theory]
        [InlineData("evaluace")]
        public void StringToUppercase_StringBuilder(string input)
        {
            var result = NativeFunctions.StringToUppercase_StringBuilder(input);

            Assert.Equal(input.ToUpper(), result);
        }

        [Theory]
        [InlineData("evaluace")]
        public void StringToUppercase_Pointer(string input)
        {
            var result = NativeFunctions.StringToUppercase_Pointer(input);

            Assert.Equal(input.ToUpper(), result);
        }
    }
}