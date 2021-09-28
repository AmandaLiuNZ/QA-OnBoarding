Feature: UpdateAvailabilityType


@availability
Scenario: Update AvailabilityType
	Given I am on profile page
	When Update AvailabilityType
	Then AvailabilityType is updated

Scenario: 05 Test change availability type successfully
	Given I am on profile page
	When seller select Availability as "Part Time"
	Then Availability should be "Part Time". Alert message "Availability updated" will be displayed on top right of the application