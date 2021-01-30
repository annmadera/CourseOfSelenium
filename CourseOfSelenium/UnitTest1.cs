using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
namespace TestowyProjekt
{
    public class UnitTest1
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
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://google.pl");
            IWebElement searchField = driver.FindElement(By.CssSelector("[title='Szukaj']"));
            string searchEntry = "wszechświaty równoległe";
            searchField.SendKeys(searchEntry);
            searchField.Submit();
            string title = "Wieloświat – Wikipedia, wolna encyklopedia";
            driver.FindElement(By.XPath(".//*[text()='" + title + "']")).Click();
            string entryURL = "https://pl.wikipedia.org/wiki/Wielo%C5%9Bwiat";
            Assert.AreEqual(entryURL, driver.Url, "URL is not correct.");
        }

        [TearDown]
        public void QuitDriver()
        {
            driver.Quit();
        }
    }
}