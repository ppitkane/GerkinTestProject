using Xunit;
using Calculator;

namespace CalculatorUnitTests
{
    public class CalculatorUnitTests
    {
        readonly SimpleCalculator _calculator = new SimpleCalculator();
        
        [Fact]
        public void AddTwoNumbers()
        {
            Assert.Equal(4, _calculator.Add(1, 3));
        }
    }
}