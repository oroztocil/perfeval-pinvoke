using System.Text;

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

        [Theory]
        [InlineData("evaluace")]
        [InlineData("koníček")]
        public void StringLength8(string input)
        {
            var result = NativeFunctions.StringLength8(input);
            var utf8Bytes = Encoding.UTF8.GetBytes(input);

            Assert.Equal(utf8Bytes.Length, result);
        }

        [Theory]
        [InlineData("evaluace")]
        [InlineData("koníček")]
        public void StringLength16(string input)
        {
            var result = NativeFunctions.StringLength16(input);

            Assert.Equal(input.Length, result);
        }

        [Theory]
        [InlineData("evaluace")]
        public void StringToUppercase(string input)
        {
            var result = NativeFunctions.StringToUppercase(input);

            Assert.Equal(input.ToUpper(), result);
        }
    }
}