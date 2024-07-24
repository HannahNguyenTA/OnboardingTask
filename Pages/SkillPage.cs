using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsSpecFlow_HannahN.Pages
{
    internal class SkillPage
    {
        public void addSkill(IWebDriver driver)
        {
            IWebElement skillClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillClick.Click();

            IWebElement addNew = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[3]/div"));
            addNew.Click();

            IWebElement addSkill = driver.FindElement(By.Name("name"));
            addSkill.SendKeys("Manual Testing");

            IWebElement chooseSkillLevelClick = driver.FindElement(By.Name("level"));
            chooseSkillLevelClick.Click();

            IWebElement addSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/div[2]/select/option[3]"));
            addSkillLevel.Click();

            IWebElement add = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/div/span/input[1]"));
            add.Click();
            Thread.Sleep(2000);
        }

        public void verifyAddKill(IWebDriver driver)
        {
            String skill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            String level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
            Assert.That(skill == "Manual Testing", "Skill does not match");
            Assert.That(level == "Intermediate", "Level does not match");
            Thread.Sleep(2000);
        }


        public void cancelUpdateSkill(IWebDriver driver)
        {
            IWebElement skillClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillClick.Click();

            IWebElement editClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editClick.Click();

            IWebElement cancelClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[2]"));
            cancelClick.Click();
        }

        public void verifyCancelUpdateSkill(IWebDriver driver)
        {
            String skill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            String level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
            Assert.That(skill == "Manual Testing", "Skill update is not cancelled");
            Assert.That(level == "Intermediate", "Level update is not cancelled");
        }

        public void updateSkill(IWebDriver driver)
        {
            IWebElement skillClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillClick.Click();

            IWebElement editClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[1]/i"));
            editClick.Click();

            IWebElement deleteOldSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            deleteOldSkill.Clear();

            IWebElement addNewSkill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[1]/input"));
            addNewSkill.SendKeys("Automation Testing");

            IWebElement skillLevelClick = driver.FindElement(By.Name("level"));
            skillLevelClick.Click();

            IWebElement addNewSkillLevel = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/div[2]/select/option[2]"));
            addNewSkillLevel.Click();

            IWebElement updateClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td/div/span/input[1]"));
            updateClick.Click();
        }

        public void verifyUpdateSkill(IWebDriver driver)
        {
            Thread.Sleep(2000);
            String skill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[1]")).Text;
            String level = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[2]")).Text;
            Assert.That(skill == "Automation Testing", "Skill is not updated");
            Assert.That(level == "Beginner", "Level is not updated");
        }


        public void deleteSkill(IWebDriver driver)
        {
            IWebElement skillClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[1]/a[2]"));
            skillClick.Click();

            IWebElement deleteClick = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/tbody/tr/td[3]/span[2]/i"));
            deleteClick.Click();
        }

        public void verifyDeleteSkill(IWebDriver driver)
        {
            String skill = driver.FindElement(By.XPath("//*[@id=\"account-profile-section\"]/div/section[2]/div/div/div/div[3]/form/div[3]/div/div[2]/div/table/thead/tr/th[1]")).Text;
            Assert.That(skill != "Automation Testing", "Skill is not deleted");
        }
    }
}

    

