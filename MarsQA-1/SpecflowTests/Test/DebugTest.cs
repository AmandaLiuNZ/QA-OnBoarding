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
    public class LanguageTest
    {
        private IWebDriver driver;

        By _lanname_1 = By.CssSelector("tbody:nth-child(2) > tr > td:nth-child(1)");
        By _lanlevel_1 = By.CssSelector("tbody:nth-child(2) > tr > td:nth-child(2)");
        //By _languageTextLink = By.LinkText("Languages");
        By _languageTextLink = By.CssSelector("div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)");
        By _languageList = By.CssSelector("div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody");

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        protected void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void AddLanguageTest()
        {
            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.Visit("http://localhost:5000/");
            profilePage.Login();

            if (profilePage.IsDisplayed(_languageTextLink, 10))
            {
                profilePage.Click(_languageTextLink);
            }

            IList<IWebElement> listOfElements = driver.FindElements(_languageList);

            int i = 0;
            foreach (IWebElement element in listOfElements)
            {
                if (element.Text != "")
                {
                    TestContext.WriteLine(element.Text);
                    i++;
                }    
            }
        }

        [Test]
        public void UpdateNameTest() {

            By _nsbox = By.CssSelector("body > div.ns-box");
            By _nsboxerror = By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-error.ns-show");
            By _name = By.CssSelector(".title");
            By _nameicon = By.CssSelector(".title > i");
            By _firstname = By.CssSelector("div.field > input[type=text]:nth-child(2)");
            By _lastname = By.CssSelector("div.field > input[type=text]:nth-child(4)");
            By _save = By.CssSelector("div > .teal");


            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.Visit("http://localhost:5000/");
            profilePage.Login();

            if (profilePage.IsTextDisplayed(_name, 10))
            {
                TestContext.WriteLine(profilePage.Find(_name).Text);
            }
                
            profilePage.Click(_nameicon);

            if (profilePage.IsDisplayed(_firstname,10))
            {
                TestContext.WriteLine(profilePage.Find(_firstname).Text);
            }

            profilePage.Find(_firstname).Clear();
            profilePage.Type(_firstname, "a");
            profilePage.Type(_firstname, Keys.Backspace);
            //            profilePage.Find(_lastname).Clear();
            //            profilePage.Type(_lastname,Keys.Backspace);
            profilePage.Click(_save);

            if (profilePage.IsDisplayed(_nsbox,10))
            {
                TestContext.WriteLine(profilePage.Find(_nsbox).Text);
            }

            if (profilePage.IsDisplayed(_nsboxerror, 10))
            {
                TestContext.WriteLine(profilePage.Find(_nsboxerror).Text);
            }

            ////////////////Test Availibility////////////////////////////////////
            By _availabletimeButton = By.CssSelector(".item:nth-child(2) > .right .right");
            profilePage.Click(_availabletimeButton);

            By _availabilityType = By.Name("availabiltyType");

            if (profilePage.IsDisplayed(_availabilityType))
            {
                //var dropdown = profilePage.Find(_availabilityType);
                //var selectElement = new SelectElement(dropdown);
                //selectElement.SelectByIndex(1);
                profilePage.Type(_availabilityType, "Part Time");

            }

            if (profilePage.IsDisplayed(_nsbox, 10))
            {
                TestContext.WriteLine(profilePage.Find(_nsbox).Text);
            }



        }


    }

}
