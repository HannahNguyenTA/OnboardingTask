using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsSpecFlow_HannahN.Pages
{
    internal class LoginPage
    {
        public void loginPage(IWebDriver driver)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            try
            {
                IWebElement signinButton = driver.FindElement(By.XPath("//*[@id=\"home\"]/div/div/div[1]/div/a")); signinButton.Click();
                IWebElement email = driver.FindElement(By.Name("email")); email.SendKeys("nbaoha81@gmail.com");
                IWebElement password = driver.FindElement(By.Name("password")); password.SendKeys("Nbaoha81!");
                IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button")); loginButton.Click();
            }
            catch
            {
                Assert.Fail("Mars did not load successfully");
            }
        }
    }
}
