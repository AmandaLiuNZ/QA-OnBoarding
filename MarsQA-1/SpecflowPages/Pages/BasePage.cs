using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Text;

namespace MarsQA_1.SpecflowPages.Pages
{
    public class BasePage
    {
        IWebDriver Driver;

        public BasePage(IWebDriver driver)
        {
            Driver = driver;
        }

        public void Visit(string url)
        {
            Driver.Navigate().GoToUrl(url);
        }

        public IWebElement Find(By locator)
        {
            //wait for element........
            return Driver.FindElement(locator);
        }

        public void Click(By locator)
        {
            Find(locator).Click();
        }

        public void Type(By locator, string inputText)
        {
            Find(locator).SendKeys(inputText);
        }

        public bool IsDisplayed(By locator, int maxWaitTime=10)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(maxWaitTime));
                wait.Until(drv => drv.FindElement(locator).Displayed);
                return true;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException)
            {
                return false;
            }
        }

        public bool IsTextDisplayed(By locator, int maxWaitTime)
        {
            try
            {
                WebDriverWait wait = new WebDriverWait(Driver, System.TimeSpan.FromSeconds(maxWaitTime));
                wait.Until(drv => drv.FindElement(locator).Text!="");
                return true;
            }
            catch (OpenQA.Selenium.WebDriverTimeoutException)
            {
                return false;
            }
        }
    }
}
