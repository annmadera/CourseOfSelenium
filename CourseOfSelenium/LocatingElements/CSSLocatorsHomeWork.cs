using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseOfSelenium.LocatingElements
{
    class SimplyLocatorsHomeWorkCSS
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
            driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(10);
        }
        [Test]
        public void LocatingManyElementsTest()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/moje-konto/");
            IWebElement userName = driver.FindElement(By.CssSelector("input#username"));
            IWebElement password = driver.FindElement(By.CssSelector("input#password"));
            IWebElement remembereMe = driver.FindElement(By.CssSelector("input#rememberme"));
            IWebElement LogIn = driver.FindElement(By.CssSelector("button[name='login']"));
            IWebElement losPassword = driver.FindElement(By.CssSelector("p.lost_password"));
            IWebElement email = driver.FindElement(By.CssSelector("input#reg_email"));
            IWebElement regPassword = driver.FindElement(By.CssSelector("input#reg_password"));
            IWebElement register = driver.FindElement(By.CssSelector("button[name='register']"));
            IWebElement windsurfing = driver.FindElement(By.CssSelector("li.cat-item-18"));


        }
        [TearDown]
        public void QuiteDriver()
        {
            driver.Quit();
        }
    }
}
