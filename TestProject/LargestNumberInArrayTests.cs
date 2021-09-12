using FluentAssertions;
using LC;
using Xunit;

namespace TestProject
{
    public class LargestNumberInArrayTests
    {
        [Theory]
        [InlineData(new int[] { 1 }, 0)]
        [InlineData(new int[] { 1, 2, 3, 4 }, -1)]
        [InlineData(new int[] { 3, 6, 1, 0 }, 1)]
        public void DominantIndex_WhenCalled_ReturnMinusOne(int[] array, int expected)
        {
            var result = LargestNumberInArray.DominantIndex(array);

            result.Should().Be(expected);
        }



    }
}
