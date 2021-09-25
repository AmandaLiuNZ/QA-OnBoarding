Feature: UpdateAvailabilityType


@availability
Scenario: Update AvailabilityType
	Given I am on profile page
	When Update AvailabilityType
	Then AvailabilityType is updated