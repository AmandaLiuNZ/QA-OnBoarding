Feature: UpdateName


@updatename
Scenario: Update first name and last name
	Given I am on profile page
	When update first name and last name
	Then name be updated

	Scenario: Update name error
	Given I am on profile page
	When update null name
	Then name input error message