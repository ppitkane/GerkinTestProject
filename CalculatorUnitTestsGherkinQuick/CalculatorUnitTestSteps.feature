Feature: CalculatorUnitTestSteps
  
  Scenario: Add numbers together
    Given two numbers are defined: 1 and 3
    When numbers are added together
    Then result should be 4

  Scenario: Subtract two numbers
    Given two numbers are defined: 1 and 3
    When numbers are subtracted
    Then result should be -2

  Scenario: Multiply two numbers
    Given two numbers are defined: 1 and 3
    When numbers are multiplied
    Then result should be 3