using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using NUnit.Framework;
using OpenQA.Selenium.Support.UI;
using static MarsQA_1.Helpers.Driver;
using MarsQA_1.SpecflowPages.Pages;

namespace MarsQA_1.Feature
{
    [Binding]
    public class Login
    {
        ProfilePage profilePage = new ProfilePage(driver);

        [Given(@"I login to the website")]
        public void GivenILoginToTheWebsite()
        {
            string userName;
            userName = profilePage.GetUsername();

//            Assert.AreEqual(userName, "Amanda Liu");
        }
    }
}
