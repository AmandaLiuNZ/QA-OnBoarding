Feature: AddLanguage

@languages
Scenario: Add new languages
	Given I am on profile page
	When click Languages Link
	And add new language
	Then the new language is added

@AddLanguages
Scenario: 15 Test Add Language successfully
	Given I am on profile page
	When click Languages Link
	And add new language as "Maori" and level as "Basic"
	Then "Maori Basic" should be added to your languages."Maori has been added to your languages" will be displayed on top right of the application