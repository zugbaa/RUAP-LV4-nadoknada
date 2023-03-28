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
    public class 5TestCase
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
        public void The5TestCaseTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Change Password")).Click();
            driver.FindElement(By.Id("current-password")).Click();
            driver.FindElement(By.Id("current-password")).Clear();
            driver.FindElement(By.Id("current-password")).SendKeys("123washere??");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("12345washere??");
            driver.FindElement(By.Id("password-confirmation")).Click();
            driver.FindElement(By.Id("password-confirmation")).Clear();
            driver.FindElement(By.Id("password-confirmation")).SendKeys("12345washere??");
            driver.FindElement(By.XPath("//form[@id='form-validate']/div/div/button")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("zugbatoni@gmail.com");
            driver.FindElement(By.Id("pass")).Click();
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("12345washere??");
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/customer/account/login/referer/aHR0cHM6Ly9tYWdlbnRvLnNvZnR3YXJldGVzdGluZ2JvYXJkLmNvbS8%2C/");
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("zugbaatoniiiii16@gmail.com");
            driver.FindElement(By.Id("pass")).Click();
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("12345washere??");
            driver.FindElement(By.Id("send2")).Click();
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            driver.FindElement(By.LinkText("My Account")).Click();
            driver.FindElement(By.LinkText("Change Password")).Click();
            driver.FindElement(By.Id("current-password")).Click();
            driver.FindElement(By.Id("current-password")).Clear();
            driver.FindElement(By.Id("current-password")).SendKeys("12345washere??");
            driver.FindElement(By.Id("password")).Click();
            driver.FindElement(By.Id("password")).Clear();
            driver.FindElement(By.Id("password")).SendKeys("123washere??");
            driver.FindElement(By.Id("password-confirmation")).Click();
            driver.FindElement(By.Id("password-confirmation")).Clear();
            driver.FindElement(By.Id("password-confirmation")).SendKeys("123washere??");
            driver.FindElement(By.XPath("//form[@id='form-validate']/div/div/button/span")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("zugbaatoniiiii16@gmail.com");
            driver.FindElement(By.Id("pass")).Click();
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("123washere??");
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
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
