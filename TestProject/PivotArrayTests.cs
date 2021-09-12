using FluentAssertions;
using LC;
using Xunit;
using Xunit.Abstractions;

namespace TestProject
{
    public class PivotArrayTests
    {
        private readonly ITestOutputHelper _output;

        public PivotArrayTests(ITestOutputHelper output)
        {
            _output = output;
        }

        [Fact]
        public void Array_FindPivot_Return_Int()
        {
            int[] intArray = new int[3] { 2, 1, -1 };
            PivotArray pa = new();

            var result = pa.PivotIndex(intArray);

            result.Should().Be(0);
            _output.WriteLine($"Result {result}");

        }

        [Fact]
        public void EmptyArray_FindPivot_Return_Minus1()
        {
            int[] intArray = new int[1];
            PivotArray pa = new();

            var result = pa.PivotIndex(intArray);

            _output.WriteLine($"Result {result}");

            result.Should().Be(-1);
        }
    }
}
