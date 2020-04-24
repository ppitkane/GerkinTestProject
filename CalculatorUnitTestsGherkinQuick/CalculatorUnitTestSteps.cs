using System;
using System.Diagnostics.CodeAnalysis;
using Calculator;
using Xunit;
using Xunit.Gherkin.Quick;

namespace CalculatorUnitTestsGherkinQuick
{
    [ExcludeFromCodeCoverage]
    public class CalculatorUnitTestSteps : Feature
    {
        private readonly SimpleCalculator _calculator = new SimpleCalculator();

        private int _num1;
        private int _num2;
        private int _result;

        [Given(@"two numbers are defined: (-?\d+) and (-?\d+)")]
        public void GivenTwoNumbersAreDefinedAnd(int num1, int num2)
        {
            _num1 = num1;
            _num2 = num2;
        }

        [When("numbers are added together")]
        public void NumbersAreAddedTogether()
        {
            _result = _calculator.Add(_num1, _num2);
        }
        
        [When("numbers are subtracted")]
        public void NumbersAreSubtracted()
        {
            _result = _calculator.Subtract(_num1, _num2);
        }

        [When("numbers are multiplied")]
        public void NumbersAreMultiplied()
        {
            _result = _calculator.Multiply(_num1, _num2);
        }

        [Then(@"result should be (-?\d+)")]
        public void ResultShouldBe(Decimal result)
        {
            Assert.Equal(_result, result);
        }
    }
}