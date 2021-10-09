Feature: AddProfileDetail
	As a Seller
I want the feature to add my Profile Details
So that
The people seeking for some skills can look into my details.


@ignore@name
Scenario: 01 Test Change Firstname and LastName successfully
	Given I am on profile page
	When seller enter firstname as "Max" and last name as"Thomas"
	Then User name should be "Max Thomas"

@ignore@name
Scenario: 02 Test error message when first name is not entered 
	Given I am on profile page
	When seller enter firstname as "" and last name as"Thomas"
	Then Alert message "First name and last name are required" is displayed on top right of the application. Name should not be changed

@ignore@name
Scenario: 03 Test error message when last name is not entered 
	Given I am on profile page
	When seller enter firstname as "Max" and last name as""
	Then Alert message "First name and last name are required" is displayed on top right of the application. Name should not be changed

@ignore@name
Scenario: 04 Test error message when first name and last name are not entered 
	Given I am on profile page
	When seller enter firstname as "" and last name as""
	Then Alert message "First name and last name are required" is displayed on top right of the application. Name should not be changed


@ignore@availability
Scenario: 05 Test change availability type successfully
	Given I am on profile page
	When seller select Availability as "Part Time"
	Then Availability should be "Part Time". Alert message "Availability updated" will be displayed on top right of the application

@ignore@availability
Scenario: 06 Test change availability type successfully
	Given I am on profile page
	When seller select Availability as "Full Time"
	Then Availability should be "Full Time". Alert message "Availability updated" will be displayed on top right of the application

@ignore@availability
Scenario: 07 Test change availability hours successfully
	Given I am on profile page
	When seller select Hours as "Less than 30hours a week"
	Then Hours should be "Less than 30hours a week". Alert message "Availability updated" will be displayed on top right of the application

@ignore@availability
Scenario: 08 Test change availability hours successfully
	Given I am on profile page
	When seller select Hours as "More than 30hours a week"
	Then Hours should be "More than 30hours a week". Alert message "Availability updated" will be displayed on top right of the application

@ignore@availability
Scenario: 09 Test change availability hours successfully
	Given I am on profile page
	When seller select Hours as "As needed"
	Then Hours should be "As needed". Alert message "Availability updated" will be displayed on top right of the application


@ignore@availability
Scenario: 10 Test change Earn Target successfully
	Given I am on profile page
	When seller select Earn Target as "Less than $500 per month"
	Then Earn Target should be "Less than $500 per month". Alert message "Availability updated" will be displayed on top right of the application

@ignore@availability
Scenario: 11 Test change Earn Target successfully
	Given I am on profile page
	When seller select Earn Target as "Between $500 and $1000 per month"
	Then Earn Target should be "Between $500 and $1000 per month". Alert message "Availability updated" will be displayed on top right of the application

@ignore@availability
Scenario: 12 Test change Earn Target successfully
	Given I am on profile page
	When seller select Earn Target as "More than $1000 per month"
	Then Earn Target should be "More than $1000 per month". Alert message "Availability updated" will be displayed on top right of the application


@ignore@Description
Scenario: 13 Test update Description successfully
	Given I am on profile page
	When seller enter Description as "10 years tester experience"
	And clicks on Save action button
	Then Description should be "10 years tester experience". The alert message,"Description has been saved successfully" will be displayed on top right of the application

@ignore@Description
Scenario: 14 Test error message when description is not entered
	Given I am on profile page
	When seller clear Description
	And clicks on Save action button
    Then Alert message, "Please, a description is required" will be displayed on top right of the application

@ignore@Languages
Scenario: 16 Test Add Language successfully
	Given I am on profile page
	When click Languages Link
	And add new language as "Japanese" and level as "Conversational"
	Then "Japanese Conversational" should be added to your profile."Japanese has been added to your languages" will be displayed on top right of the application

@ignore@Languages
Scenario: 17 Test Add Language successfully
	Given I am on profile page
	When click Languages Link
	And add new language as "English" and level as "Fluent"
	Then "English Fluent" should be added to your profile."English has been added to your languages" will be displayed on top right of the application

@ignore@Languages
Scenario: 18 Test Add Language successfully
	Given I am on profile page
	When click Languages Link
	And add new language as "Korean" and level as "Native/Bilingual"
    Then "Korean Native/Bilingual" should be added to your profile."Korean has been added to your languages" will be displayed on top right of the application

@ignore@Languages
Scenario: 19 Test maximum 4 languages
	Given I am on profile page
	When click Languages Link
	And seller already have 4 languages
	Then no add language button show up

@ignore@Languages
Scenario: 20 Test listing languages
	Given I am on profile page
	When click Languages Link
	And seller clicks on Laguages tab
	Then languages page should display the list of languages that were added

@ignore@Languages
Scenario: 21 Test update Language level successfully
	Given I am on profile page
	When click Languages Link
	And seller update language of "Korean"
	And select level as "Basic"
	And clicks on Update action button
	Then "Korean Basic" should be updated to profile. The alert message,"Korean has been updated to your languages" will be displayed on top right of the application

@ignore@Languages
Scenario: 22 Test update Language successfully
	Given I am on profile page
	When click Languages Link
	And seller update language of "Korean" to "Maori"
	And clicks on Update action button
    Then language should be updated to profile. The alert message,"Maori has been updated to your languages" will be displayed on top right of the application

@ignore@Languages
Scenario: 23 Test error message when update to an exist language same level
	Given I am on profile page
	When click Languages Link
	And seller update language of "Korean" to an exist language
	And select level as the same level
	And clicks on Update action button
	Then language should not be updated to profile. The alert message,"The language is already added to your language list" will be displayed on top right of the application

@ignore@Languages!!bug!!
Scenario: 23 Test error message when update to an exist language different level
	Given I am on profile page
	When click Languages Link
	And seller update language of "Korean" to an exist language
	And select level as the different level
	And clicks on Update action button
	Then language should not be updated to profile. The alert message,"The language is already added to your language list" will be displayed on top right of the application

@ignore@Languages
Scenario: 24 Test Delete Language successfully
	Given I am on profile page
	When click Languages Link
	And seller delete language "English"
	Then "English" should be deleted. The alert message,"English has been deleted from your languages" will be displayed on top right of the application

@ignore@Languages
Scenario: 25 Test error message when language is not entered
	Given I am on profile page
	When click Languages Link
	And seller do not enter value in language text box
	And select level as "Basic"
	And clicks on Add action button
    Then Alert message,"please enter language and level" will be displayed on top right of the application.No language is added

@ignore@Languages
Scenario: 26 Test error message when level is not selected
	Given I am on profile page
	When click Languages Link
	And seller enter language as "English"
	And do not select level
	And clicks on Add action button
	Then Alert message,"please enter language and level" will be displayed on top right of the application. No language is added

@ignore@Languages
Scenario: 27 Test error message when same language different level is added
	Given I am on profile page
	When click Languages Link
	And seller enter existing language (i.e. Japanese)
	And and select a different level(i.e Fluent)
	And clicks on Add action button
	Then Alert message,"Duplicated data" will be displayed on top right of the application. No language is added

@ignore@Languages
Scenario: 28 Test error message when same language same level is added
	Given I am on profile page
	When click Languages Link
	And seller enter existing language (i.e. Japanese)
	And and select a same level(i.e Conversational)
	And clicks on Add action button
	Then Alert message,"This language is already exist in your language list" will be displayed on top right of the application. No language is added

@ignore@Skills
Scenario: 30 Test Add Skills successfully
	Given I am on profile page
    When click Skills Link
	And seller add new skill as "Postman" and level as "Intermediate"
	Then "Postman Intermediate" should be added to your skills."Postman has been added to your skills" will be displayed on top right of the application

@ignore@Skills
Scenario: 31 Test Add Skills successfully
	Given I am on profile page
    When click Skills Link
	And seller add new skill as "Selenium" and level as "Expert"
	Then "Selenium Expert" should be added to your skills."Selenium has been added to your skills" will be displayed on top right of the application

@ignore@Skills
Scenario: 32 Test listing skills
	Given I am on profile page
    When click Skills Link
	Then skills page should display the list of skills that were added

@ignore@Skills
Scenario: 33 Test update Skill level successfully
	Given I am on profile page
    When click Skills Link
	And click update button
	And seller update skill level as "Beginner"
	And clicks on update action button
	Then "Selenium Beginner" should be updated to your profile.The alert message,"Selenium has been updated to your skills" will be displayed on top right of the application

@ignore@Skills
Scenario: 34 Test update to new skills successfully
	Given I am on profile page
    When click Skills Link
	And click update button
	And enter skill name as "python"
	And clicks on update action button
	Then "python Beginner" should be updated to your profile.The alert message,"python has been updated to your skills" will be displayed on top right of the application

@ignore@Skills
Scenario: 35 Test error message when update to exist skill same level
	Given I am on profile page
    When click Skills Link
	And seller update "Selenium"
	And enter skill name "Java"
	And select level as "Beginner"
	And clicks on update action button
	Then Alert message,"This skill has already added to your skill list" will be displayed on top right of the application

@ignore@Skills!!!bug!!!!!!
Scenario: 36 Test error message when update to exist skill different level
	Given I am on profile page
    When click Skills Link
	And seller update "Selenium"
	And enter skill name "Java"
	And select level as "Expert"
	And clicks on update action button
	Then Alert message,"This skill has already added to your skill list" will be displayed on top right of the application

@ignore@Skills
Scenario: 37 Test Delete Skill successfully
	Given I am on profile page
    When click Skills Link
	And seller delete skill "Selenium"
	Then "Selenium" should be deleted.The alert message,"Selenium has been deleted" will be displayed on top right of the application

@ignore@Skills
Scenario: 38 Test error message when skill is not entered
	Given I am on profile page
    When click Skills Link
	And seller do not enter value in skill text box
	And select level as "Beginner"
	And clicks on Add action button
	Then Alert message,"please enter skill and experience level" will be displayed on top right of the application. No skill is added

@ignore@Skills
Scenario: 39 Test error message when level is not selected
	Given I am on profile page
    When click Skills Link
	And seller enter skill as "Selenium"
	And do not select level
	And clicks on Add action button
	Then Alert message,"please enter skill and experience level" will be displayed on top right of the application. No skill is added

@ignore@Skills
Scenario: 40 Test error message when same skill different level is added
	Given I am on profile page
    When click Skills Link
	And seller enter skill as "Postman"
	And select level as "Expert"
	And clicks on Add action button
	Then Alert message,"Duplicated data" will be displayed on top right of the application. No skill is added

@ignore@Skills
Scenario: 41 Test error message when same skill same level is added
	Given I am on profile page
    When click Skills Link
	And seller enter skill as "Postman"
	And select level as "Intermediate"
	And clicks on Add action button
	Then Alert message,"This skill is already exist in your skill list" will be displayed on top right of the application.No skill is added


@ignore@Education
Scenario: 42 Test Add Education successfully
	Given seller is on Education page
	When seller enter college name as "Cambridge University"
	And select country as "United Kingdom"
	And select title as "PHD"
	And enter Degree as "Bachelor"
	And select Year of graduation as "2004"
	And clicks on Add action button
	Then education should be added to your profile.The alert message,"Education has been added" will be displayed on top right of the application

@ignore@Education
Scenario: 43 Test Add Education successfully
	Given seller is on Education page
	When seller enter college name as "Oxford University"
	And select country as "United States"
	And select title as "BA"
	And enter Degree as "Master"
	And select Year of graduation as "2008"
	And clicks on Add action button
	Then education should be added to your profile.The alert message,"Education has been added" will be displayed on top right of the application

@ignore@Education
Scenario: 44 Test listing Education
	Given seller is on Education page
	When seller clicks on Education tab
	Then education page should display the list of education that were added

@ignore@Education
Scenario: 45 Test Delete Education successfully
	Given seller is on Education page
	When seller delete Education "Cambridge"
	Then "Cambridge" should be deleted.The alert message,"Education entry successfully removed" will be displayed on top right of the application

@ignore@Education
Scenario: 46 Test error message when college is not entered
	Given seller is on Education page
	When seller do not enter college name
	And select country as "United States"
	And select title as "BA"
	And enter Degree as "Master"
	And select Year of graduation as "2008"
	And clicks on Add action button
	Then Alert message,"Please enter all the fields" will be displayed on top right of the application

@ignore@Education
Scenario: 47 Test error message when Country is not selected
	Given seller is on Education page
	When seller enter college name as "Oxford University"
	And do not select country
	And select title as "BA"
	And enter Degree as "Master"
	And select Year of graduation as "2008"
	And clicks on Add action button
	Then Alert message,"Please enter all the fields" will be displayed on top right of the application

@ignore@Education!!!bug!!!!!
Scenario: 48 Test error message when title is not selected
	Given seller is on Education page
	When seller enter college name as "Oxford University"
	And select country as "United States"
	And do not select title
	And enter Degree as "Master"
	And select Year of graduation as "2008"
	And clicks on Add action button
	Then Alert message,"Please enter all the fields" will be displayed on top right of the application

@ignore@Education
Scenario: 49 Test error message when Degree is not entered
	Given seller is on Education page
	When seller enter college name as "Oxford University"
	And select country as "United States"
	And select title as "BA"
	And do not enter degree
	And select Year of graduation as "2008"
	And clicks on Add action button
	Then Alert message,"Please enter all the fields" will be displayed on top right of the application

@ignore@Education
Scenario: 50 Test error message when year of graduation is not selected
	Given seller is on Education page
	When seller enter college name as "Oxford University"
	And select country as "United States"
	And select title as "BA"
	And enter Degree as "Master"
	And do not select year of graduation
	And clicks on Add action button
	Then Alert message,"Please enter all the fields" will be displayed on top right of the application

@ignore@Education
Scenario: 51 Test listing Education
	Given seller is on Education page
	When seller clicks on Education tab
	Then Education page should display the list of education that were added

@ignore@Education
Scenario: 52 Test update college name successfully
	Given seller is on Education page
	When seller update to new college name
	And clicks on Update action button
	Then education be updated.Alert message,"Education has been updated" will be displayed on top right of the application

@ignore@Education
Scenario: 53 Test error message when update to same education
	Given seller is on Education page
	When seller update to same education
	And clicks on Update action button
	Then Alert message "This information is already exist" will be displayed on top right of the application

@ignore@Education
Scenario: 54 Test delete education successfully
	Given seller is on Education page
	When seller delete education
    Then Alert message "Education entry successfully removed" will be displayed on top right of the application

@ignore@Certifications
Scenario: 55 Test Add Certifications successfully
	Given seller is on Certification page
	When seller enter certification name as "Test Foundation"
	And enter certified from "ISTQB"
	And select Year of as "2021"
	And clicks on Add action button
	Then certification should be added to your profile.The alert message,"Test Foundation has been added to your certification" will be displayed on top right of the application

@ignore@Certifications
Scenario: 56 Test Error message when do not enter certification name
	Given seller is on Certification page
	When seller do not enter certification name
	And enter certified from "ISTQB"
	And select Year of as "2021"
	And clicks on Add action button
	Then The alert message,"Please enter Certification name,Certification from and Certification year" will be displayed on top right of the application

@ignore@Certifications
Scenario: 57 Test Error message when do not enter certification from
	Given seller is on Certification page
	When seller enter certification name as "Test Foundation"
	And do not enter certification from
	And select Year of as "2021"
	And clicks on Add action button
	Then The alert message,"Please enter Certification name,Certification from and Certification year" will be displayed on top right of the application

@ignore@Certifications
Scenario: 58 Test Error message when do not select certification year
	Given seller is on Certification page
	When seller enter certification name as "Test Foundation"
	And do not enter certification from
	And select Year of as "2021"
	And clicks on Add action button
	Then The alert message,"Please enter Certification name,Certification from and Certification year" will be displayed on top right of the application

@ignore@Certifications
Scenario: 59 Test Error message when add same certification name and from different year
	Given seller is on Certification page
	When seller enter same certification name
	And enter same certification from
	And select different year
	And clicks on Add action button
	Then The alert message,"Duplicated data" will be displayed on top right of the application

@ignore@Certifications
Scenario: 60 Test Error message when add the same certification
	Given seller is on Certification page
	When seller enter same certification name
	And enter same certification from
	And select same year
	And clicks on Add action button
	Then The alert message,"The information is already exist" will be displayed on top right of the application

@ignore@Certifications
Scenario: 61 Test update certification name
	Given seller is on Certification page
	When seller update certification name as "software engineer"
	And clicks on Update action button
	Then The alert message,"software engineer has been updated to your certification" will be displayed on top right of the application

@ignore@Certifications
Scenario: 62 Test delete certification successfully
	Given seller is on Certification page
	When seller delete "software engineer" certification
    Then The alert message,"software engineer has been deleted from your certification" will be displayed on top right of the application