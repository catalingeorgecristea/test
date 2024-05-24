using System.Linq;
using Test.Extensions;
using Xunit;

namespace Test.Tests
{
    public class ArrayExtensionsTests
    {

        [Theory()]
        [InlineData(new[] { 2, 2, 1 }, 1)]
        [InlineData(new[] { 4, 1, 2, 1, 2 }, 2)]
        [InlineData(new[] { 1 }, 1)]
        [InlineData(new[] { 1, 2, 3, 4, 5, 6, 7, 1, 2, 3, 4, 5, 1, 2, 6, 6, 6, 6 }, 7)]
        public void GetUniqueValues_Success(int[] testValue, int uniqueValue)
        {
            // Arrange

            // Act
            var result = testValue.GetUniqueValues();

            // Assert
            Assert.Equal(uniqueValue, result.First());
        }
    }
}
