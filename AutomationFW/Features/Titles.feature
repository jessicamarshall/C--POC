Feature: Titles
	In order to organize employees
	As an admin of the system
	I want to be able to create and manage employee titles


Scenario: Create new title
	Given That I am logged in as admin
	And I have nagivated to Titles page
	When When I add a new title
	Then I should see a success message

Scenario: Edit title
	Given That I am logged in as admin
	And I have nagivated to Titles page
	And I have an existing title
	When I edit the title name
	Then I should see a success message
