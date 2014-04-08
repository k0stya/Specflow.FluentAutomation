Feature: SearchForWiki
	In order to check that FluentAutomation integration works correctly
	As a developer
	I want to have few automated scenarios

Scenario: Search for wiki logo
	Given I navigated google
	And entered "wiki" to the search box
	When I click Images link
	Then the resulting view should contain wiki logo

Scenario: Search for wiki page
	Given I navigated google
	And entered "wiki" to the search box
	When I click wiki link
	Then the resulting page should be wikipedia