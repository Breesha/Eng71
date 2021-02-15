Feature: AP_CreateAccount
	In order to be able to buy items
	As a non-user of the automation practice website
	I want to be able to create an account
	so that I can start buying fake goods

@createaccount
Scenario: Creating account with vaid email
	Given I am on the login page
	And I entered the email "example@spartaglobal.ccm"
	When I click the create an account button
	Then I should go to a page with Url "http://automationpractice.com/index.php?controller=authentication"

	@createaccount
Scenario: Creating account with invaid email
	Given I am on the login page
	And I entered the email "example.spartaglobal"
	When I click the create an account button
	Then I see an alert containing the error message "Invalid email address."