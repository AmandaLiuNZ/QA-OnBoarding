Feature: AddSkill


@skills
Scenario: Add new skills
	Given I am on profile page
    When click Skills Link
	And add new skill
	Then the new skill is added

@AddSkills
Scenario: 29 Test Add Skills successfully
	Given I am on profile page
    When click Skills Link
	And seller add new skill as "Java" and level as "Beginner"
    Then "Java Beginner" should be added to your skills."Java has been added to your skills" will be displayed on top right of the application