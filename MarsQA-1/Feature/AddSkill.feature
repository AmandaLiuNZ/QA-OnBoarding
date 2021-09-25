Feature: AddSkill


@skills
Scenario: Add new skills
	Given I am on profile page
    And click Skills Link
	When add new skill
	Then the new skill is added