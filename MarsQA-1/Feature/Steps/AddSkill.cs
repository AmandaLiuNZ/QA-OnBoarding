using MarsQA_1.SpecflowPages.Pages;
using OpenQA.Selenium;
using TechTalk.SpecFlow;
using static MarsQA_1.Helpers.Driver;

namespace MarsQA_1.Feature
{
    [Binding]
    public class AddSkill
    {
        By _skills = By.LinkText("Skills");

        SkillPage addSkillPage = new SkillPage(driver);

        [When(@"click Skills Link")]
        public void WhenClickSkillsLink()
        {
            addSkillPage.Click(_skills);
        }

        [When(@"add new skill")]
        public void WhenAddNewSkill()
        {
            addSkillPage.AddSkill();
        }

        [Then(@"the new skill is added")]
        public void ThenTheNewSkillIsAdded()
        {
            addSkillPage.AssertSkillAdded();

        }

        [When(@"seller add new skill as ""(.*)"" and level as ""(.*)""")]
        public void WhenSellerAddNewSkillAsAndLevelAs(string skillname, string level)
        {
            addSkillPage.AddSkill(skillname,level);
        }

        [Then(@"""(.*)"" should be added to your skills\.""(.*)"" will be displayed on top right of the application")]
        public void ThenShouldBeAddedToYourSkills_WillBeDisplayedOnTopRightOfTheApplication(string skill, string message)
        {
            addSkillPage.AssertSkillAdded(skill,message);
        }

    }
}
