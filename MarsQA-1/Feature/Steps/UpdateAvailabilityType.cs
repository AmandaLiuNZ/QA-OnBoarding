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

    }
}
