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
