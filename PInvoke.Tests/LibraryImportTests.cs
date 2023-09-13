using System.Linq;

using PInvoke.NativeInterface.LibraryImport;

using Xunit;

namespace PInvoke.Tests
{
    public class LibraryImportTests
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

        [Theory]
        [InlineData("evaluace")]
        [InlineData("koníček")]
        public void StringLength_MultiByte(string input)
        {
            var result = NativeFunctions.StringLength_MultiByte(input);

            Assert.Equal(input.Length, result);
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

        [Fact]
        public void FillIntArray()
        {
            var buffer = new int[10];
            NativeFunctions.FillIntArray(buffer, buffer.Length);

            var expected = Enumerable.Range(0, 10).ToArray();

            Assert.Equal(expected, buffer);
        }
    }
}