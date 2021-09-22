using FluentAssertions;
using LC;
using Xunit;

namespace TestProject
{
    public class DiagonalTraverseTests
    {

        [Fact]
        public void When_Solution_IsCalled_ReturnEquivalenteArray()
        {
            var expected = new int[] { 1, 2, 4, 7, 5, 3, 6, 8, 9 };

            int[][] matrix = new int[3][];
            matrix[0] =  new int[3] { 1, 2, 3 };
            matrix[1] =  new int[3] { 4, 5, 6 };
            matrix[2] =  new int[3] { 7, 8, 9 };


            var result = DiagonalTravese.Solution(matrix);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void When_Solution_IsCalled_ReturnEquivalenteArray2()
        {
            var expected = new int[] { 1,2,3 };

            int[][] matrix = new int[1][];
            matrix[0] = new int[3] { 1, 2, 3 };


            var result = DiagonalTravese.Solution(matrix);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void When_Solution_IsCalled_ReturnEquivalenteArray3()
        {
            var expected = new int[] { 1,2,4,5,3,6 };

            int[][] matrix = new int[2][];
            matrix[0] = new int[3] { 1, 2, 3 };
            matrix[1] = new int[3] { 4, 5, 6 };


            var result = DiagonalTravese.Solution(matrix);

            result.Should().BeEquivalentTo(expected);
        }

        [Fact]
        public void When_Solution_IsCalled_ReturnEquivalenteArray4()
        {
            var expected = new int[] { 1,2,5,6,3,4,7,8 };

            int[][] matrix = new int[2][];
            matrix[0] = new int[4] { 1, 2, 3, 4 };
            matrix[1] = new int[4] { 5, 6, 7, 8 };


            var result = DiagonalTravese.Solution(matrix);

            result.Should().BeEquivalentTo(expected);
        }

    }
}
