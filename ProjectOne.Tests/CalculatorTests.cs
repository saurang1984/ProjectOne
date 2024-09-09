using Xunit;
using ProjectOne;

namespace ProjectOne.Tests
{
    public class CalculatorTests
    {
        [Fact]
        public void Add_ShouldReturnCorrectSum()
        {
            var calculator = new Calculator();
            int result = calculator.Add(2, 3);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Subtract_ShouldReturnCorrectDifference()
        {
            var calculator = new Calculator();
            int result = calculator.Subtract(5, 3);
            Assert.Equal(2, result);
        }

        [Fact]
        public void Multiply_ShouldReturnCorrectProduct()
        {
            var calculator = new Calculator();
            int result = calculator.Multiply(4, 5);
            Assert.Equal(20, result);
        }

        [Fact]
        public void Divide_ShouldReturnCorrectQuotient()
        {
            var calculator = new Calculator();
            int result = calculator.Divide(10, 2);
            Assert.Equal(5, result);
        }

        [Fact]
        public void Divide_ByZero_ShouldThrowDivideByZeroException()
        {
            var calculator = new Calculator();
            Assert.Throws<DivideByZeroException>(() => calculator.Divide(10, 0));
        }
    }
}
