Feature: AddLanguage

@languages
Scenario: Add new languages
	Given I am on profile page
	And click Languages Link
	When add new language
	Then the new language is added
