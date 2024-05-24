using Xunit;
using Test.Extensions;

namespace Test.Tests
{
    public  class StringExtensionsTests
    {

        [Theory()]
        [InlineData("[()]{}{[()()] ()}", true)]
        [InlineData("[(])", false)]
        public void HasBalancedBrakets_Success(string testValue, bool isBalanced)
        {
            // Arrange

            // Act
            var result = testValue.HasBalancedBrakets();

            // Assert
            Assert.Equal(isBalanced, result);
        }
    }
}
