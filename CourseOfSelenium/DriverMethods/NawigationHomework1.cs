using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseOfSelenium.DriverMethods
{
    class NawigationHomework1
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

        }

        [Test]
        public void BackTest()
        {
            driver.Navigate().GoToUrl("https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna");
            driver.Navigate().GoToUrl("http://www.nasa.gov");
            driver.Navigate().Back();
            string expectedUrl = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";

            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct.");
        }

        [Test]
        public void ForwardTest()
        {
            driver.Navigate().GoToUrl("https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna");
            driver.Navigate().GoToUrl("https://www.nasa.gov");
            driver.Navigate().Back();
            driver.Navigate().Forward();
            string expectedUrl = "https://www.nasa.gov/";

            Assert.AreEqual(expectedUrl, driver.Url, "URL is not correct.");
        }




        [TearDown]
        public void QuiteDriver()
        {
            driver.Quit();
        }
    }
}
