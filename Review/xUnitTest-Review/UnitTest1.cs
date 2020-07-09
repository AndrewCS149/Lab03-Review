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

        // Test Challenge 4: MaxDupe()
        [Theory]
        [InlineData(new int[] { 1, 1, 2, 2, 3, 3, 3, 1, 1, 5, 5, 6, 7, 8, 2, 1, 1 }, 1)]
        [InlineData(new int[] { 44, 3, 0, 0, 0, 44, 44, 44 }, 44)]
        [InlineData(new int[] { 5, 5, 5, 5, 5, 5, 5 }, 5)]
        [InlineData(new int[] { 1, 2, 3, 5, 6, 7, 8, 9 }, 1)]
        [InlineData(new int[] { 1, 1, 3, 3, 3, 2, 2, 2 }, 3)]
        public void CanReturnProperMaxDupe(int[] numbers, int maxDupe)
        {
            // arrange & act
            int result = MaxDupe(numbers);

            // assert
            Assert.Equal(maxDupe, result);
        }

        // Test Challenge 5: MaxNum()
        [Theory]
        [InlineData(new int[] { 5, 25, 99, 123, 78, 96, 555, 108, 4 }, 555)]
        [InlineData(new int[] { 50, 100, -20}, 100)]
        [InlineData(new int[] { 40, 40, 40, 40 }, 40)]
        public void CanReturnProperMaxNumber(int[] numbers, int maxNumber)
        {
            // arrange & act
            int result = MaxNum(numbers);

            // assert
            Assert.Equal(maxNumber, result);
        }
    }
}
