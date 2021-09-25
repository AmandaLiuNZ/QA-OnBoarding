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

        [Given(@"click Skills Link")]
        public void GivenClickSkillsLink()
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
    }
}
