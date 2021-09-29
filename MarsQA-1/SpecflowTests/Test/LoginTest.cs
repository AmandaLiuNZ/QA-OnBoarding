using MarsQA_1.SpecflowPages.Pages;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace MarsQA_1.SpecflowTests.Test
{
    class LoginTest
    {
        IWebDriver driver;

        [SetUp]
        public void SetUp()
        {
            driver = new ChromeDriver();
        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }

        [Test]
        public void MyLogin()
        {
            ProfilePage profilePage = new ProfilePage(driver);
            profilePage.Visit("http://localhost:5000/");
            profilePage.Login();
        }
    }
}
