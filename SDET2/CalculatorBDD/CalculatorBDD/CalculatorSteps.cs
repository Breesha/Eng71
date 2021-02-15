using System;
using TechTalk.SpecFlow;
using CalculatorProject;
using NUnit.Framework;

namespace CalculatorBDD
{
    [Binding]
    public class CalculatorSteps
    {
        private Calculator _calculator;
        private int _result;

        [Given(@"I have a calculator")]
        public void GivenIHaveACalculator()
        {
            _calculator = new Calculator();
        }
        
        [Given(@"then I enter (.*) and (.*) into the calculator")]
        public void GivenThenIEnterAndIntoTheCalculator(int a, int b)
        {
            _calculator.Num1=a;
            _calculator.Num2 = b;
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            _result = _calculator.Add();
        }

        [When(@"I press subtract")]
        public void WhenIPressSubtract()
        {
            _result=_calculator.Subtract();
        }

        [When(@"I press multiply")]
        public void WhenIPressMultiply()
        {
            _result=_calculator.Multiply();
        }


        [Given(@"then I enter the numbers below to a list")]
        public void GivenThenIEnterTheNumbersBelowToAList(Table table)
        {
            foreach (var row in table.Rows)
            {
                foreach (var num in row.Values)
                {
                    _calculator.NumList.Add(int.Parse(num));
                }

            }
        }

        [When(@"I go to iterate through the list selecting even numbers")]
        public void WhenIGoToIterateThroughTheListSelectingEvenNumbers()
        {
            _result=_calculator.IterateThrough();
        }



        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int expected)
        {
            Assert.That(_result, Is.EqualTo(expected));
        }
    }
}
