using MarsSpecFlow_HannahN.Pages;
using MarsSpecFlow_HannahN.Utils;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;

namespace MarsSpecFlow_HannahN.StepDefinitions
{
    [Binding]
    internal class LanguageTestsStepDefinitions : CommonDriver 
    {
        LoginPage loginPageObj = new LoginPage();
        LanguagePage languagePageObj = new LanguagePage();
        [Given(@"user login Mars")]
        public void GivenUserLoginMars()
        {
            driver = new ChromeDriver();
            loginPageObj.loginPage(driver);
        }

        [When(@"user add a new language")]
        public void WhenUserAddANewLanguage()
        {
            languagePageObj.addLanguage(driver);
        }

        [Then(@"new language is added successfully")]
        public void ThenNewLanguageIsAddedSuccessfully()
        {
            languagePageObj.verifyAddLanguage(driver);
        }

        [When(@"user cancel update language")]
        public void WhenUserCancelUpdateLanguage()
        {
            languagePageObj.cancelUpdateLanguage(driver);
        }

        [Then(@"update language is cancelled successfully")]
        public void ThenUpdateLanguageIsCancelledSuccessfully()
        {
            languagePageObj.verifyCancelUpdateLanguage(driver);
        }

        [When(@"user update language")]
        public void WhenUserUpdateLanguage()
        {
            languagePageObj.updateLanguage(driver);
        }

        [Then(@"language is updated successfully")]
        public void ThenLanguageIsUpdatedSuccessfully()
        {
            languagePageObj.verifyUpdateLanguage(driver);
        }

        [When(@"user delete language")]
        public void WhenUserDeleteLanguage()
        {
            languagePageObj.deleteLanguage(driver);
        }

        [Then(@"language is deleted successfully")]
        public void ThenLanguageIsDeletedSuccessfully()
        {
            languagePageObj.verifyDeleteLanguage(driver);
        }
    }
}
