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
    public class 4TestCase
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
        public void The4TestCaseTest()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.XPath("//main[@id='maincontent']/div[3]/div/div[2]/div[3]/div/div/ol/li[6]/div/a/span/span/img")).Click();
            driver.FindElement(By.XPath("//button[@id='product-addtocart-button']/span")).Click();
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("search")).Clear();
            driver.FindElement(By.Id("search")).SendKeys("jacket");
            driver.FindElement(By.Id("search_mini_form")).Submit();
            driver.FindElement(By.Id("sorter")).Click();
            new SelectElement(driver.FindElement(By.Id("sorter"))).SelectByText("Price");
            driver.FindElement(By.XPath("//img[@alt='Lando Gym Jacket']")).Click();
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
