using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.Driver;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddLanguage
    {
        By _languageTextLink = By.LinkText("Languages");
        By _username = By.CssSelector(".title");

        LanguagePage addLanguagePage = new LanguagePage(driver);

        [Given(@"I am on profile page")]
        public void GivenIAmOnProfilePage()
        {
            addLanguagePage.IsDisplayed(_languageTextLink, 10);
            addLanguagePage.IsTextDisplayed(_username, 10);
        }

        [When(@"click Languages Link")]
        public void WhenClickLanguagesLink()
        {
            addLanguagePage.Click(_languageTextLink);
        }

        [When(@"add new language")]
        public void WhenAddNewLanguage()
        {
            addLanguagePage.ProfileLanguageUpdate();
        }
                
        [Then(@"the new language is added")]
        public void ThenTheNewLanguageIsAdded()
        {
            addLanguagePage.AssertLaguageAdded();

        }

        [When(@"add new language as ""(.*)"" and level as ""(.*)""")]
        public void WhenAddNewLanguageAsAndLevelAs(string newLanguage, string level)
        {
            addLanguagePage.ProfileLanguageUpdate(newLanguage, level);
        }

        [Then(@"""(.*)"" should be added to your languages\.""(.*)"" will be displayed on top right of the application")]
        public void ThenShouldBeAddedToYourLanguages_WillBeDisplayedOnTopRightOfTheApplication(string newLanguage, string message)
        {
            addLanguagePage.AssertLaguageAdded(newLanguage, message);
        }

    }
}
