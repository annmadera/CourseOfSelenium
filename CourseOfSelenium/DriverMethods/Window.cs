using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Text;

namespace CourseOfSelenium.DriverMethods
{
    class Window
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            /*          driver.Manage().Window.Position = new Point(8, 30);
                        driver.Manage().Window.Size = new Size(1290, 730);*/
            

        }

        [Test]
        public void MinimizeWindowTest()
        {
            driver.Navigate().GoToUrl("https://google.pl");
            driver.Manage().Window.Minimize();
        }

        [Test]
        public void WindowStartingPoint()
        {
            Point startiingPoint = driver.Manage().Window.Position;
            Assert.AreEqual(new Point(10, 10),startiingPoint, "StartinPoint is not (10,10)");
        }

        [Test]
        public void WindowStartingSize()
        {
            Size startingSize = driver.Manage().Window.Size;
            Assert.AreEqual(new Size(945, 999), startingSize, "StartingSize is not (945,999)");
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