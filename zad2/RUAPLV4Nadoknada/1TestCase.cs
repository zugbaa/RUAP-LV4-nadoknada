using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class 1TestCase
    {
        private IWebDriver driver;
        private StringBuilder verificationErrors;
        private string baseURL;
        private bool acceptNextAlert = true;
        
        [SetUp]
        public void SetupTest()
        {
            driver = new FirefoxDriver();
            baseURL = "https://www.google.com/";
            verificationErrors = new StringBuilder();
        }
        
        [TearDown]
        public void TeardownTest()
        {
            try
            {
                driver.Quit();
            }
            catch (Exception)
            {
                // Ignore errors if unable to close the browser
            }
            Assert.AreEqual("", verificationErrors.ToString());
        }
        
        [Test]
        public void The1TestCaseTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Create an Account")).Click();
            driver.FindElement(By.Id("firstname")).Click();
            driver.FindElement(By.Id("firstname")).Clear();
            driver.FindElement(By.Id("firstname")).SendKeys("toni");
            driver.FindElement(By.Id("lastname")).Click();
            driver.FindElement(By.Id("lastname")).Clear();
            driver.FindElement(By.Id("lastname")).SendKeys("zugba");
            driver.FindElement(By.Id("email_address")).Click();
            driver.FindElement(By.Id("email_address")).Clear();
            driver.FindElement(By.Id("email_address")).SendKeys("zugbatooooni@gmail.com");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123washere??");
            driver.FindElement(By.Id("password-confirmation")).Click();
            driver.FindElement(By.Id("password-confirmation")).Clear();
            driver.FindElement(By.Id("password-confirmation")).SendKeys("123washere??");
            driver.FindElement(By.Id("form-validate")).Click();
            driver.FindElement(By.XPath("//form[@id='form-validate']/div/div/button")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            driver.FindElement(By.LinkText("Sign Out")).Click();
        }
        private bool IsElementPresent(By by)
        {
            try
            {
                driver.FindElement(by);
                return true;
            }
            catch (NoSuchElementException)
            {
                return false;
            }
        }
        
        private bool IsAlertPresent()
        {
            try
            {
                driver.SwitchTo().Alert();
                return true;
            }
            catch (NoAlertPresentException)
            {
                return false;
            }
        }
        
        private string CloseAlertAndGetItsText() {
            try {
                IAlert alert = driver.SwitchTo().Alert();
                string alertText = alert.Text;
                if (acceptNextAlert) {
                    alert.Accept();
                } else {
                    alert.Dismiss();
                }
                return alertText;
            } finally {
                acceptNextAlert = true;
            }
        }
    }
}
