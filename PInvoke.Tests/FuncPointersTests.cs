using Xunit;

using PInvoke.NativeInterface.FuncPointers;
using System.Linq;

namespace PInvoke.Tests
{
    public class FuncPointersTests
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
            var sum = NativeFunctions.SumIntArray_Fixed(arr, arr.Length);

            Assert.Equal(arr.Sum(), sum);
        }

        [Fact]
        public void FillIntArray()
        {
            var buffer = new int[10];
            NativeFunctions.FillIntArray_Fixed(buffer, buffer.Length);

            var expected = Enumerable.Range(0, 10).ToArray();

            Assert.Equal(expected, buffer);
        }
    }
}
