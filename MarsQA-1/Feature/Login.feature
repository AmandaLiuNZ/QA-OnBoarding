
Feature: Login


@login
Scenario: Login to website
	Given I am on Mars website
	When I click Sign In button
	And enter email address
	And  enter password
	And click Login button
	Then I will be on profile page
