﻿using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class LanguagePage : BasePage
    {
        By _languageTextLink = By.CssSelector("div.eight.wide.column > form > div.ui.top.attached.tabular.menu > a:nth-child(1)");
        By _addnewbutton = By.CssSelector(".ui:nth-child(2) > .row .ui .ui");
        By _languagename = By.Name("name");
        By _languagelevel = By.Name("level");
        By _languageList = By.CssSelector("div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody");
        By _addnewlanguagebutton = By.CssSelector(".ui:nth-child(2) > .row .ui .ui");
        By _languageAddbutton = By.CssSelector(".six > .teal");
//        By _addSuccess = By.CssSelector("body > div.ns-box.ns-growl.ns-effect-jelly.ns-type-success");
        By _nsbox = By.CssSelector("body > div.ns-box");

        IWebDriver driver;
        int languageCount;
        string newLanguageName;
        string newLanguageLevel;

        public LanguagePage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void AddLanguage(string lName, int level)
        {
            if (IsDisplayed(_languageTextLink, 10))
            {
                Click(_languageTextLink);
                Click(_addnewbutton);
                Type(_languagename, lName);

                Click(_languagelevel);
                var dropdown = Find(_languagelevel);
                var selectElement = new SelectElement(dropdown);
                selectElement.SelectByIndex(level);

                Click(_languageAddbutton);
            }
        }

        public void AddLanguageFromExcel(int language_row, int level)
        {
            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Language");

            newLanguageName = ExcelLibHelper.ReadData(language_row + 1, "Language");
            newLanguageLevel = ExcelLibHelper.ReadData(language_row + 1, "Level");

            Type(_languagename, newLanguageName);
            Type(_languagelevel, newLanguageLevel);

            //var dropdown = Find(_languagelevel);
            //var selectElement = new SelectElement(dropdown);
            //selectElement.SelectByIndex(level);

            Click(_languageAddbutton);

        }

        public void ProfileLanguageUpdate()
        {
            IList<IWebElement> listOfElements = driver.FindElements(_languageList);
            languageCount = listOfElements.Count;

            newLanguageName = "";
            if (languageCount < 4)
            {
                Click(_addnewlanguagebutton);
                AddLanguageFromExcel(languageCount + 1, languageCount + 1);
                languageCount++;
            }
        }

        public void AssertLaguageAdded()
        {

            IsDisplayed(_nsbox);
            string actualMsg;
            string expectedMsg;

            IList<IWebElement> listOfElements = driver.FindElements(_languageList);
            if (newLanguageName != "")
            {
                string newLanguage = newLanguageName + " " + newLanguageLevel + "   ";
                Assert.AreEqual(newLanguage, listOfElements[languageCount - 1].Text);
                TestContext.WriteLine(newLanguage);

                expectedMsg = newLanguageName + " has been added to your languages";
                actualMsg = Find(_nsbox).Text;
                Assert.AreEqual(actualMsg, expectedMsg);
            }

        }
    }
}