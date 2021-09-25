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

        [Given(@"click Languages Link")]
        public void GivenClickLanguagesLink()
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
    }
}
