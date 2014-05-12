Feature: SearchForTDD
	In order to check that FluentAutomation integration works correctly
	As a developer
	I want to have few automated scenarios

Scenario: Search for TDD keyword
	Given I have entered bing.com
	When I enter TDD to the search field
	And I press enter
	Then the first link should be wiki
