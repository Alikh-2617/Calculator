using Calculator;
using System;

namespace TestProject1
{
    public class UnitTest1
    {
        CalculatorXunit calculator = new CalculatorXunit(); 

        [Fact]
        public void SumTest()
        {
            int[] x = { 2 };
            int[] y = { 2 };
            Assert.Equal(8, calculator.sum(x, y));
            Assert.Equal(4, calculator.sum(2, 2));
        }
        [Fact]
        public void SubTest()
        {
            int[] x = { 4 };
            int[] y = { 2 };
            Assert.Equal(2, calculator.sub(x, y));
            Assert.Equal(2, calculator.sub(4, 2));
        }

        [Fact]
        public void MulTest()
        {
            Assert.Equal(6, calculator.mul(3, 2));
        }

        [Fact]
        public void divTest()
        {
            // funkar inte tror jag 
            // ArgumentException e = Assert.Throws<DivideByZeroException>(() => calculator.div(5, 0));
            // Assert.Equal("Attempted to divide by zero.", e.Message);

        }


    }
}