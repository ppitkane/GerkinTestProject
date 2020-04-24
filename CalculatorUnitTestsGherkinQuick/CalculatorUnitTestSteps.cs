using System;
using System.Diagnostics.CodeAnalysis;
using Calculator;
using Xunit;
using Xunit.Gherkin.Quick;

namespace CalculatorUnitTestsGherkinQuick
{
    [ExcludeFromCodeCoverage]
    public class CalculatorUnitTestSteps
    {
        private readonly SimpleCalculator _calculator = new SimpleCalculator();

        private Decimal _num1;
        private Decimal _num2;
        private Decimal _result;

        [Given(@"two numbers are defined: (.*) and (.*)")]
        public void GivenTwoNumbersAreDefinedAnd(Decimal p0, Decimal p1)
        {
            _num1 = p0;
            _num2 = p1;
        }

        [When(@"numbers are added")]
        public void NumbersAreAdded()
        {
            _result = _calculator.Add(_num1, _num2);
        }
        
        [Then(@"result should be (.*)")]
        public void ResultShouldBe(Decimal result)
        {
            Assert.Equal(_result, result);
        }
    }
}