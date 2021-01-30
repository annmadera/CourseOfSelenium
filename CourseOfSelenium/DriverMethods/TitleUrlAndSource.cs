using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseOfSelenium.DriverMethods
{
    class TitleUrlAndSource
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
;
        }

        [Test]
        public void RetriveTitlePageTest()
        {
            driver.Navigate().GoToUrl("https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna");
            string expectedTitle = "Wikipedia, wolna encyklopedia";

            Assert.AreEqual(expectedTitle, driver.Title, "Title is not correct.");
        }

        [Test]
        public void RetriveUrlPageTest()
        {
            driver.Navigate().GoToUrl("https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna");
            string expectedUrl = "https://pl.wikipedia.org/wiki/Wikipedia:Strona_g%C5%82%C3%B3wna";

            Assert.AreEqual(expectedUrl, driver.Url, "Url is not correct.");
        }

        [Test]
        public void RetrivePageSourceTest()
        {
            driver.Navigate().GoToUrl("https://google.pl");
            string metaContent = " /images/branding/googlelogo/2x/googlelogo_color_272x92dp.png";

            Assert.IsTrue(driver.PageSource.Contains(metaContent), "Meta content was not found on the source page.");
        }


        [TearDown]
        public void QuiteDriver()
        {
            driver.Quit();
        }
    }
}