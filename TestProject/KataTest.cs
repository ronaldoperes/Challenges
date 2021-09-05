using FluentAssertions;
using Xunit;
using HelloWorld;

namespace TestProject
{
    public class KataTest
    {
        [Fact]
        public void When_Greet_IsCalled_ReturnString()
        {
            var test = Kata.greet();

            test.Should().Be("hello world!");
        }

        [Fact]
        public void When_Greet2_IsCalled_ReturnString()
        {
            var test = Kata.greet2();

            test.Should().Be("hello world!");
        }
    }
}
