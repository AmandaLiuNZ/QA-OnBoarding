using MarsQA_1.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsQA_1.SpecflowPages.Pages
{
    class SkillPage: BasePage
    {
        By _skillList = By.CssSelector("div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table > tbody");
        By _addnewskillbutton = By.CssSelector(".ui:nth-child(3) .ui .ui");
        By _skillname = By.Name("name");
        By _skilllevel = By.Name("level");
        By _skillAddbutton = By.CssSelector(".buttons-wrapper > .teal");

        By _nsbox = By.CssSelector("body > div.ns-box");

        IWebDriver driver;

        int skillCount;
        string newSkillName;
        string newSkillLevel;

        public SkillPage(IWebDriver driver) : base(driver)
        {
            this.driver = driver;
        }

        public void AddSkill()
        {
            IList<IWebElement> listOfElements = driver.FindElements(_skillList);
            skillCount = listOfElements.Count;

            Click(_addnewskillbutton);

            ExcelLibHelper.PopulateInCollection(@"MarsQA-1\SpecflowTests\Data\Data.xlsx", "Skill");
            newSkillName = ExcelLibHelper.ReadData(skillCount + 2, "Skill");
            newSkillLevel = ExcelLibHelper.ReadData(skillCount + 2, "Level");

            Type(_skillname, newSkillName);
            Type(_skilllevel, newSkillLevel);

            //var dropdown = Find(_languagelevel);
            //var selectElement = new SelectElement(dropdown);
            //selectElement.SelectByIndex(level);

            Click(_skillAddbutton);
        }
        public void AssertSkillAdded()
        {
            string actualMsg;
            string expectedMsg;

            if (IsDisplayed(_nsbox))
            {
                IList<IWebElement> listOfElements = driver.FindElements(_skillList);
                skillCount = listOfElements.Count;

                string newSkill = newSkillName + " " + newSkillLevel + "   ";
                Assert.AreEqual(newSkill, listOfElements[skillCount - 1].Text);
                TestContext.WriteLine(newSkill);

                expectedMsg = newSkillName + " has been added to your skills";
                actualMsg = Find(_nsbox).Text;
                Assert.AreEqual(actualMsg, expectedMsg);
            }
        }

    }
}
