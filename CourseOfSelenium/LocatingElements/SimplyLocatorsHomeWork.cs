using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace CourseOfSelenium.LocatingElements
{
    class SimplyLocatorsHomeWork
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
            IWebElement header = driver.FindElement(By.ClassName("entry-title"));
            IWebElement userName = driver.FindElement(By.Name("username"));
            IWebElement password = driver.FindElement(By.Id("password"));
            IWebElement remembereMe = driver.FindElement(By.Id("rememberme"));
            IWebElement LogIn = driver.FindElement(By.Id("login"));
            IWebElement losPassword = driver.FindElement(By.LinkText("Nie pamiętasz hasła?"));

        }
        [TearDown]
        public void QuiteDriver()
        {
            driver.Quit();
        }
    }
}
