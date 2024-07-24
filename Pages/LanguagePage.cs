using MarsSpecFlow_HannahN.Utils;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsSpecFlow_HannahN.Pages
{
    internal class LanguagePage 
    {
        public void addLanguage(IWebDriver driver)
        {
            IWebElement addNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[1]"));
            addNew.Click();

            IWebElement addLanguageClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addLanguageClick.Click();

            IWebElement addLanguage = driver.FindElement(By.Name("name"));
            addLanguage.SendKeys("English");

            IWebElement chooseLanguageLevelClick = driver.FindElement(By.Name("level"));
            chooseLanguageLevelClick.Click();

            IWebElement addLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[2]/select/option[4]"));
            addLanguageLevel.Click();

            IWebElement add = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/div/div[3]/input[1]"));
            add.Click();
            Thread.Sleep(2000);
        }

        public void verifyAddLanguage(IWebDriver driver)
        {
            String language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            String level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
            Assert.That(language == "English", "Language does not match");
            Assert.That(level == "Fluent", "Level does not match");

        }


        public void cancelUpdateLanguage(IWebDriver driver)
        {
            IWebElement editClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editClick.Click();

            IWebElement cancelClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
            cancelClick.Click();
        }

        public void verifyCancelUpdateLanguage(IWebDriver driver)
        {
            String language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            String level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
            Assert.That(language == "English", "Language update is not cancelled");
            Assert.That(level == "Fluent", "Level update is not cancelled");
            Thread.Sleep(2000);
        }


        public void updateLanguage(IWebDriver driver)
        {
            IWebElement editClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editClick.Click();

            IWebElement deleteOldLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            deleteOldLanguage.Clear();

            IWebElement addNewLanguage = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            addNewLanguage.SendKeys("French");

            IWebElement languageLevelClick = driver.FindElement(By.Name("level"));
            languageLevelClick.Click();

            IWebElement addNewLanguageLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
            addNewLanguageLevel.Click();

            IWebElement updateClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateClick.Click();
        }

        public void verifyUpdateLanguage(IWebDriver driver)
        {
            Thread.Sleep(2000);
            String language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            String level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
            Assert.That(language == "French", "Language is not updated");
            Assert.That(level == "Basic", "Level is not updated");
        }


        public void deleteLanguage(IWebDriver driver)
        {
            IWebElement deleteClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteClick.Click();
        }

        public void verifyDeleteLanguage(IWebDriver driver)
        {
            String language = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[2]/div/div[2]/div/table/thead/tr/th[1]")).Text;
            Assert.That(language != "French", "Language is deleted");
        }

    }
}

    

