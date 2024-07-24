using MarsSpecFlow_HannahN.Pages;
using MarsSpecFlow_HannahN.Utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MarsSpecFlow_HannahN.StepDefinitions
{
    [Binding]
    internal class SkillTestsStepDefinitions : CommonDriver 
    {
        LoginPage loginPageObj = new LoginPage();
        SkillPage skillPageObj = new SkillPage();
        [Given(@"user login Mars (.*)")]
        public void GivenUserLoginMars(int p0)
        {
            driver = new ChromeDriver();
            loginPageObj.loginPage(driver);
        }

        [When(@"user add a new skill")]
        public void WhenUserAddANewSkill()
        {
            skillPageObj.addSkill(driver);
        }

        [Then(@"new skill is added successfully")]
        public void ThenNewSkillIsAddedSuccessfully()
        {
            skillPageObj.verifyAddKill(driver);
        }

        [When(@"user cancel update skill")]
        public void WhenUserCancelUpdateSkill()
        {
            skillPageObj.cancelUpdateSkill(driver);
        }

        [Then(@"update skill is cancelled successfully")]
        public void ThenUpdateSkillIsCancelledSuccessfully()
        {
            skillPageObj.verifyCancelUpdateSkill(driver);
        }

        [When(@"user update skill")]
        public void WhenUserUpdateSkill()
        {
            skillPageObj.updateSkill(driver);
        }

        [Then(@"skill is updated successfully")]
        public void ThenSkillIsUpdatedSuccessfully()
        {
            skillPageObj.verifyUpdateSkill(driver);
        }

        [When(@"user delete skill")]
        public void WhenUserDeleteSkill()
        {
            skillPageObj.deleteSkill(driver);
        }

        [Then(@"skill is deleted successfully")]
        public void ThenSkillIsDeletedSuccessfully()
        {
            skillPageObj.verifyDeleteSkill(driver);
        }
    }
}
