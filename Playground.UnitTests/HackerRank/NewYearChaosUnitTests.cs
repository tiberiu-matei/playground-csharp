using Moq;
using Playground.HackerRank;
using Playground.Infrastructure;
using Xunit;

namespace Playground.UnitTests.HackerRank
{
    public class NewYearChaosUnitTests
    {
        private readonly Mock<IConsole> _mockConsole = new Mock<IConsole>();

        private readonly NewYearChaos _target;

        public NewYearChaosUnitTests()
        {
            _target = new NewYearChaos(_mockConsole.Object);
        }

        [Theory]
        [InlineData(new[] { 1, 2, 3, 4, 5 }, 0)]
        [InlineData(new[] { 2, 1, 3, 4, 5 }, 1)]
        [InlineData(new[] { 2, 1, 5, 3, 4 }, 3)]
        [InlineData(new[] { 3, 2, 1 }, 3)]
        [InlineData(new[] { 1, 2, 5, 3, 7, 8, 6, 4 }, 7)]
        public void NormalChaosLevels(int[] input, int expected)
        {
            _target.MinimumBribes(input);

            _mockConsole.Verify(e => e.WriteLine(It.Is<string>(m => m == expected.ToString())), Times.Once);
        }

        [Theory]
        [InlineData(new[] { 1, 5, 2, 3, 4 })]
        [InlineData(new[] { 2, 5, 1, 3, 4 })]
        [InlineData(new[] { 3, 1, 2, 7, 6, 5, 4 })]

        public void TooMuchChaos(int[] input)
        {
            _target.MinimumBribes(input);

            _mockConsole.Verify(e => e.WriteLine(It.Is<string>(m => m == "Too chaotic")), Times.Once);
        }
    }
}
