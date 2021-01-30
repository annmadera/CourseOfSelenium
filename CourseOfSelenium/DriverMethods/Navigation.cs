using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseOfSelenium.DriverMethods
{
    class Navigation
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Position = new System.Drawing.Point(8, 30);
            driver.Manage().Window.Size = new System.Drawing.Size(1290, 730);
            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(5);
            driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(5);
        }

        [Test]
        public void GoToUrlTest()
        {
            driver.Navigate().GoToUrl("https://google.pl");
            string expectedUrl = "https://www.google.pl/";

            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct.");
        }

        [Test]
        public void BackTest()
        {
            driver.Navigate().GoToUrl("https://google.pl");
            driver.Navigate().GoToUrl("https://amazon.com");
            driver.Navigate().Back();
            string expectedUrl = "https://www.google.pl/";

            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct.");
        }

        [Test]
        public void ForwardTest()
        {
            
            driver.Navigate().GoToUrl("https://amazon.com");
            driver.Navigate().GoToUrl("https://google.pl");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            string expectedUrl = "https://www.google.pl/";

            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct.");
        }

        [Test]
        public void RefreshTest()
        {

            driver.Navigate().GoToUrl("https://amazon.com");
            driver.Navigate().Refresh();
            string expectedUrl = "https://www.amazon.com/";
 
            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct.");
        }



        [TearDown]
        public void QuiteDriver()
        {
            driver.Quit();
        }
    }
}