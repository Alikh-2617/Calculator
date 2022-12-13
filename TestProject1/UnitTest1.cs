using Calculator;

namespace TestProject1
{
    public class UnitTest1
    {
        CalculatorXunit calculator = new CalculatorXunit(); 

        [Fact]
        public void SumTest()
        {
            Assert.Equal(4, calculator.sum(2, 2));
        }

        [Fact]
        public void MulTest()
        {
            Assert.Equal(6, calculator.mul(3, 2));
        }

        [Fact]
        public void DivTest()
        {
            Assert.Equal(2, calculator.div(4, 2));
        }

        [Fact]
        public void SubTest()
        {
            Assert.Equal(2, calculator.sub(4, 2));
        }

    }
}