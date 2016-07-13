Feature: Testing with page objects
	In order to check that FluentAutomation integration works correctly
	As a developer
	I want to have few automated scenarios

Scenario: Navigating to a page
	Given I'm on the homepage
	When I click on the 2nd page link
	Then I'm on the 2nd page
