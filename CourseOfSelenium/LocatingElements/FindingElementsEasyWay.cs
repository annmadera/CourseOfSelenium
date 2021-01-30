using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseOfSelenium.LocatingElements
{
    class FindingElementsEasyWay
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
        public  void LocatingElementsTest()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl");
            IWebElement search=driver.FindElement(By.Id("woocommerce - product - search - field - 0"));
            search.SendKeys("Grecja - Limnos");
            search.Submit();
            Assert.AreEqual("Grecja – Limnos – FakeStore", driver.Title, "Page title is not correct.");
            Assert.AreEqual("https://fakestore.testelka.pl/product/grecja-limnos/", driver.Url, "URL is not correct.");
        }

    }
}
