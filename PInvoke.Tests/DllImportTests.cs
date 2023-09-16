using System.Linq;
using System.Text;

using PInvoke.NativeInterface.DllImport;
using PInvoke.NativeInterface.Models;

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
        public void StringLength_Utf8(string input)
        {
            var result = NativeFunctions.StringLength_Utf8(input);
            var utf8Bytes = Encoding.UTF8.GetBytes(input);
            Assert.Equal(utf8Bytes.Length, result);
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
        public void StringToUppercase_Fixed(string input)
        {
            var result = NativeFunctions.StringToUppercase_Fixed(input);

            Assert.Equal(input.ToUpper(), result);
        }

        [Fact]
        public void SumIntsInStruct_Return()
        {
            var input = new BlittableStruct { a = 3, b = 4 };
            var result = NativeFunctions.SumIntsInStruct_Return(input);

            Assert.Equal(7, result.result);
        }

        [Fact]
        public void SumIntsInStruct_Pointer()
        {
            var input = new BlittableStruct { a = 3, b = 4 };
            NativeFunctions.SumIntsInStruct_Ref(ref input);

            Assert.Equal(7, input.result);
        }
    }
}