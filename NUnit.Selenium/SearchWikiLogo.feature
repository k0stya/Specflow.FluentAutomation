Feature: SearchWikiLogo
	In order to check that FluentAutomation integration works correctly
	As a developer
	I want to have few automated scenarios

Scenario: Add two numbers
	Given I navigated google
	And entered "wiki" to the search box
	When I click Images link
	Then the resulting view should contain wiki logo
