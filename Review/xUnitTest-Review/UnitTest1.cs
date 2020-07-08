using System;
using Xunit;
using static Review.Program;

namespace xUnitTest_Review
{
    public class UnitTest1
    {
        // TEST GetProduct()

        [Fact]
        public void CanReturn0()
        {
            // arrange 
            string input = "0";

            // act 
            int output = GetProduct(input);

            // assert
            Assert.Equal(0, output);
        }
    }
}
