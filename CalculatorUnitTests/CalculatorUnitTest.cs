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
            Assert.Equal(4.5m, _calculator.Add(1.0m, 3.5m));
        }
    }
}