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
        [InlineData("20 2 Dogs", 40)]
        public void CanReturnProperProduct(string input, int product)
        {
            // arrange & act
            int result = GetProduct(input);

            // assert
            Assert.Equal(product, result);
        } 

        // Test Challenge 2: GetAvg()
        [Theory]
        [InlineData(new double[] { 5, 20, 33, 50, 20 }, 25.6)]
        [InlineData(new double[] { 100, 55, 769, 5 }, 232.25)]
        [InlineData(new double[] { 10, 22, 44, 33, 20 }, 25.8)]
        [InlineData(new double[] { 0, 0, 0, 0 }, 0)]
        public void CanReturnProperAverage(double[] numbers, double average)
        {
            // arrange & act
            double result = GetAvg(numbers);

            // assert
            Assert.Equal(average, result);
        }
    }
}
