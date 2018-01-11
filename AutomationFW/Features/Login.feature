Feature: Login
	In order to use the application
	As a user
	I should be able to login

Scenario Outline: Sucessful Login
	Given I am on the home page
	When I login using <username> and <password>
	Then I should be logged in successfully
	Examples:
	| username | password |
	| company.admin | test123 |


Scenario Outline: Negative Login
	Given I am on the home page
	When I login using <username> and <password>
	Then I should see an error message
	Examples:
	| username | password |
	| falksdjfklas | wrongpassword |