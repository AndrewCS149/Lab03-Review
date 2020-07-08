using System;
using Xunit;
using static Review.Program;

namespace xUnitTest_Review
{
    public class UnitTest1
    {
        // Test Challenge 1: GetProduct()

        [Theory]
        [InlineData("5 5 5", 125)]
        [InlineData("3 10 10 33", 300)]
        [InlineData("10 4", 0)]
        [InlineData("-10 10 1", -100)]
        public void CanReturnProperProduct(string input, int product)
        {
            // arrange & act
            int result = GetProduct(input);

            // assert
            Assert.Equal(product, result);
        } 
    }
}
