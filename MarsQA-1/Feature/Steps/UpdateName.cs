using MarsQA_1.SpecflowPages.Pages;
using System;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.Driver;

namespace MarsQA_1.Feature
{
    [Binding]
    public class UpdateNameSteps
    {
        ProfilePage profilePage = new ProfilePage(driver);

        [When(@"update first name and last name")]
        public void WhenUpdateFirstNameAndLastName()
        {
            profilePage.UpdateName();
        }
        
        [Then(@"name be updated")]
        public void ThenNameBeUpdated()
        {
            profilePage.AssertName();
        }
        [When(@"seller enter firstname as ""(.*)"" and last name as""(.*)""")]
        public void WhenSellerEnterFirstnameAsAndLastNameAs(string firstName, string lastName)
        {
            profilePage.UpdateName(firstName, lastName);
        }

        [Then(@"User name should be ""(.*)""")]
        public void ThenUserNameShouldBe(string fullName)
        {
            profilePage.AssertName(fullName);
        }

        [When(@"update null name")]
        public void WhenUpdateNullName()
        {
            profilePage.DeleteName();
        }

        [Then(@"name input error message")]
        public void ThenNameInputErrorMessage()
        {
            profilePage.AssertErrorMsg();
        }

    }
}
