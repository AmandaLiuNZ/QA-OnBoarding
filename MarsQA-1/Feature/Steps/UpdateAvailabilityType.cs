using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.Driver;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateAvailabilitySteps
    {
        ProfilePage profilePage = new ProfilePage(driver);

        [When(@"Update AvailabilityType")]
        public void WhenUpdateAvailabilityType()
        {
            profilePage.UpdateAvailabilityType();
        }

        [Then(@"AvailabilityType is updated")]
        public void ThenAvailabilityTypeIsUpdated()
        {
            profilePage.AssertAvailabilityType();
        }

        [When(@"seller select Availability as ""(.*)""")]
        public void WhenSellerSelectAvailabilityAs(string availabilityType)
        {
            profilePage.UpdateAvailabilityType(availabilityType);
        }

        [Then(@"Availability should be ""(.*)""\. Alert message ""(.*)"" will be displayed on top right of the application")]
        public void ThenAvailabilityShouldBe_AlertMessageWillBeDisplayedOnTopRightOfTheApplication(string availabilityType, string message)
        {
            profilePage.AssertAvailabilityType(availabilityType, message);
        }

    }
}
