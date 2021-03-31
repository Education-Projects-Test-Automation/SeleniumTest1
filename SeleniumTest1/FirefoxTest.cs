using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Firefox;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumTest1
{
    class FirefoxTest
    {
        IWebDriver driver;
        string Url = "https://www.wikipedia.org/";

        [SetUp]
        public void startBrowser()
        {
            driver = new FirefoxDriver();

            driver.Manage().Window.Maximize();

            driver.Url = Url;
        }

        [Test]
        public void TestSearchWiki()
        {
            IWebElement searchField = driver.FindElement(By.XPath("//input[@id=\"searchInput\"]"));
            searchField.SendKeys("automation testing");
            IWebElement searchButton = driver.FindElement(By.XPath("//*[@id=\"search-form\"]/fieldset/button"));
            searchButton.Click();
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}
