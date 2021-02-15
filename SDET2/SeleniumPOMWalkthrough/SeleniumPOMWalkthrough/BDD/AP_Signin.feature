Feature: AP_Signin
	In order to be able to buy items
	As a registered user of the automation practice website
	I want to be able to sign in to my account

@Login
Scenario: Invalid password - too short
	Given I am on the singin page
	And I have entered the email "testing@snailmail.ccm"
	And I have entered the password <passwords>
	When I click the sign in button
	Then I should see an alert containing the error message "Invalid password."
	Examples: 
	| passwords |
	| four      |
	| 1234      |
	| nish      |



	@Login
Scenario: Invalid username
	Given I am on the singin page
	And I have entered the email "testing@snailmail.ccm"
	And I have entered the password "fours"
	When I click the sign in button
	Then I should see an alert containing the error message "Authentication failed."


		@Login
Scenario: Forgot password
	Given I am on the singin page
	When I click the forgot your password? link
	Then I will go to a form to reset my password