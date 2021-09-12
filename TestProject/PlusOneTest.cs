using FluentAssertions;
using LC;
using Xunit;

namespace TestProject
{
    public class PlusOneTest
    {
        [Fact]
        public void When_PlusOne_IsCalled_ReturnEquivalenteArray()
        {
            var expected = new int[] { 1, 0, 0, 0 };

            var result = PlusOneArray.PlusOne(new int[] { 9, 9, 9 });

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void When_PlusOne_IsCalled_ReturnEquivalenteArray2()
        {
            var expected = new int[] { 1, 2, 4 };

            var result = PlusOneArray.PlusOne(new int[] { 1, 2, 3 });

            result.Should().BeEquivalentTo(expected);
        }
    }
}
