using CalculatorLogic;
using Xunit;

namespace CalculatorTest
{
    public class UnitTest1
    {
        [Fact]
        public void ShouldAddTwoNumbers()
        {
            var x = new Calculator().Sum(1, 2);
            Assert.Equal(x, 3);
        }

        [Fact]
        public void ShouldSubstractTwoNumbers()
        {
            var x = new Calculator().Subtract(4, 5);
            Assert.Equal(x, -1);
        }
        
        [Fact]
        public void ShouldMultiplyTwoNumbers()
        {
            var x = new Calculator().Multiply(3, 2);
            Assert.Equal(6, x);
        }
        
        [Fact]
        public void ShouldDivideTwoNumbers()
        {
            var x = new Calculator().Divide(4, 4);
            Assert.Equal(1, x);
        }
  
        [Fact]
        public void ShouldDivideTwoNumbersWithDecimalResult()
        {
            double resultDecimal = 5.0/3;
            var x = new Calculator().Divide(5, 3);
            Assert.Equal(resultDecimal, x);
        }
        
        [Fact]
        public void ShouldNotDivideOneNumberByZero()
        {
            var x = new Calculator().Divide(4, 0);
            Assert.Equal(null, x);
        }    
    }
}
