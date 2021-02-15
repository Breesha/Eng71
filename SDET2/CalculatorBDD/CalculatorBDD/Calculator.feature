Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Addition
	Given I have a calculator
	And then I enter 5 and 2 into the calculator
	When I press add
	Then the result should be 7


	@mytag
Scenario: Subtraction
	Given I have a calculator
	And then I enter <input1> and <input2> into the calculator
	When I press subtract
	Then the result should be <result>
	Examples: 
	| input1 | input2 | result |
	| 1     | 1      | 0      |
	| 0     | 1      | -1     |
	| 1000  | 1      | 999    |


		@mytag
Scenario: Multiply
	Given I have a calculator
	And then I enter <input1> and <input2> into the calculator
	When I press multiply
	Then the result should be <result>
	Examples: 
	| input1 | input2 | result |
	| 1     | 1      | 1      |
	| 2     | 3      | 6      |
	| 9     | 9      | 81     |
	| 5     | -17    | -85    |

			@mytag
Scenario: SumOfNumbersDivisibleBy2
	Given I have a calculator
	And then I enter the numbers below to a list
	| nums |
	| 1    |
	| 2    |
	| 3    |
	| 4    |
	| 5    |
	When I go to iterate through the list selecting even numbers
	Then the result should be 6