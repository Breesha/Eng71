Feature: Boots_No7
	In order to be able to browse items
	As a customer
	I want to be able to select different settings
	so that I can filter through the products

@no7settingschange
Scenario: Total Products
	Given I am on the No7 page
	When no filters are applied
	Then the total product number is 272

@no7settingschange
Scenario: Eye Cream Products
	Given I am on the No7 page
	When the product type tab is clicked
	And the eyecream filter is clicked
	Then the total product number is 8

@no7settingschange
Scenario: Price £10 to £15
	Given I am on the No7 page
	When the price category between £10 and £15 is clicked
	Then the total product number is 134

@no7settingschange
Scenario: Price Low to High
	Given I am on the No7 page
	When the sort by dropdown is clicked
	And the sort by price low to high is selected
	Then the total product number is 272

@no7settingschange
Scenario: View 180
	Given I am on the No7 page
	When the view amount dropdown is clicked
	And the view 180 is selected
	Then the total product number showing is "1 - 180"