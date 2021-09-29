using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA_1.SpecflowTests.Test
{
    public class ProfileTest
    {
        public IWebDriver driver;
        public ProfilePage profilePage;

        By _username = By.CssSelector(".title");
        By _languageTextLink = By.LinkText("Languages");

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
            profilePage = new ProfilePage(driver);
            profilePage.Visit("http://localhost:5000/");
            profilePage.Login();
            profilePage.IsTextDisplayed(_username,10);
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void UpdateNameTest() 
        {
            profilePage.UpdateName();
            profilePage.AssertName();

            profilePage.DeleteName();
            profilePage.AssertErrorMsg();

        }

        [Test]
        public void UpdateAvailabilityTest()
        {
            profilePage.UpdateAvailabilityType();
            profilePage.AssertAvailabilityType();
        }

        [Test]
        public void AddLanguageTest()
        {       
            LanguagePage languagePage = new LanguagePage(driver);

            if (languagePage.IsDisplayed(_languageTextLink, 10))
            {
                languagePage.Click(_languageTextLink);
            }

            languagePage.ProfileLanguageUpdate();
            languagePage.AssertLaguageAdded();

        }

    }

}
