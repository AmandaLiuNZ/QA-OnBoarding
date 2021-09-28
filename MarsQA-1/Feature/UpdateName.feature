Feature: UpdateName


@updatename
Scenario: Update first name and last name
	Given I am on profile page
	When update first name and last name
	Then name be updated

@Updatename
Scenario: 01 Test Update Firstname and LastName successfully
	Given I am on profile page
	When seller enter firstname as "Max" and last name as"Thomas"
	Then User name should be "Max Thomas"

@Updatename
Scenario: Update name error
	Given I am on profile page
	When update null name
	Then name input error message