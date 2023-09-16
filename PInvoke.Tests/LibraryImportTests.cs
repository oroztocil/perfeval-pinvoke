using System.Linq;
using System.Text;

using PInvoke.NativeInterface.LibraryImport;
using PInvoke.NativeInterface.Models;

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

        [Theory]
        [InlineData("evaluace")]
        [InlineData("koníček")]
        public void StringLength_Utf8(string input)
        {
            var result = NativeFunctions.StringLength_Utf8(input);
            var expected = Encoding.UTF8.GetBytes(input).Length;

            Assert.Equal(expected, result);
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
        [InlineData("abraka dabra")]
        public void StringToUppercase_ByteArray(string input)
        {
            var result = NativeFunctions.StringToUppercase_ByteArray(input);

            Assert.Equal(input.ToUpper(), result);
        }

        [Theory]
        [InlineData("evaluace")]
        [InlineData("abraka dabra")]
        public void StringToUppercase_PooledByteArray(string input)
        {
            var result = NativeFunctions.StringToUppercase_PooledByteArray(input);

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

        [Fact]
        public void UpdateStruct_Pointer()
        {
            var input = new NonBlittableStruct
            {
                number = 41,
                flag = true,
                text = "ahoj",
                numberArray = new int[] { 1, 2, 3 },
            };

            NativeFunctions.UpdateStruct_Pointer(ref input);

            Assert.Equal(42, input.number);
            Assert.False(input.flag);
            Assert.Equal("Xhoj", input.text);
            Assert.Equal(new int[] { 2, 3, 4 }, input.numberArray);
        }
    }
}