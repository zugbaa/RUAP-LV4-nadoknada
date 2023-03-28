using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTests
{
    [TestFixture]
    public class TestCase
    {
        private IWebDriver driver;
    private StringBuilder verificationErrors;
    private string baseURL;
    private bool acceptNextAlert = true;

    [SetUp]
    public void SetupTest()
    {
        driver = new ChromeDriver();
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
    public void aRegister_user()
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
        driver.FindElement(By.Id("email_address")).SendKeys("zugbaatoniiiii19@gmail.com");
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

        
        [Test]
        public void bSign_in()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("zugbaatoniiiii7@gmail.com");
            driver.FindElement(By.Id("pass")).Click();
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("123washere??");
            driver.FindElement(By.XPath("//main[@id='maincontent']/div[3]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
            driver.FindElement(By.XPath("//button[@type='button']")).Click();
            driver.FindElement(By.LinkText("Sign Out")).Click();
        }


        [Test]
        public void cAdd_item_to_shopping_cart()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.XPath("//img[@alt='Push It Messenger Bag']")).Click();
            driver.FindElement(By.Id("product-addtocart-button")).Click();
        }

        [Test]
        public void dSearch_item_sort()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.Id("search")).Click();
            driver.FindElement(By.Id("search")).Clear();
            driver.FindElement(By.Id("search")).SendKeys("jacket");
            driver.FindElement(By.Id("search_mini_form")).Submit();
            driver.FindElement(By.Id("sorter")).Click();
            new SelectElement(driver.FindElement(By.Id("sorter"))).SelectByText("Price");
            driver.FindElement(By.XPath("//img[@alt='Lando Gym Jacket']")).Click();
        }


        [Test]
        public void eChange_password()
        {
            driver.Navigate().GoToUrl("https://magento.softwaretestingboard.com/");
            driver.FindElement(By.LinkText("Sign In")).Click();
            driver.FindElement(By.Id("email")).Click();
            driver.FindElement(By.Id("email")).Clear();
            driver.FindElement(By.Id("email")).SendKeys("zugbaatoniiiii19@gmail.com");
            driver.FindElement(By.Id("pass")).Click();
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("123washere??");
            driver.FindElement(By.XPath("//main[@id='maincontent']/div[3]/div/div[2]")).Click();
            driver.FindElement(By.XPath("//button[@id='send2']/span")).Click();
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
            driver.FindElement(By.Id("email")).SendKeys("zugbaatoniiiii19@gmail.com");
            driver.FindElement(By.Id("pass")).Click();
            driver.FindElement(By.Id("pass")).Clear();
            driver.FindElement(By.Id("pass")).SendKeys("12345washere??");
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

    private string CloseAlertAndGetItsText()
    {
        try
        {
            IAlert alert = driver.SwitchTo().Alert();
            string alertText = alert.Text;
            if (acceptNextAlert)
            {
                alert.Accept();
            }
            else
            {
                alert.Dismiss();
            }
            return alertText;
        }
        finally
        {
            acceptNextAlert = true;
        }
    }
}
}

