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

           driver.Manage().Timeouts().ImplicitWait = System.TimeSpan.FromSeconds(10);
           driver.Manage().Timeouts().PageLoad = System.TimeSpan.FromSeconds(10);
        }
        [Test]
        public  void LocatingElementsTestById()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl");
            IWebElement search=driver.FindElement(By.Id("woocommerce-product-search-field-0"));
            search.SendKeys("Grecja - Limnos");
            search.Submit();
            Assert.AreEqual("Grecja – Limnos – FakeStore", driver.Title, "Page title is not correct.");
            Assert.AreEqual("https://fakestore.testelka.pl/product/grecja-limnos/", driver.Url, "URL is not correct.");
        }


        [Test]
        public void LocatingElementsTestByClass()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl");
            IWebElement header = driver.FindElement(By.TagName("header"));
            IWebElement search =header.FindElement(By.ClassName("search-field"));
            search.SendKeys("Grecja - Limnos");
            search.Submit();
            Assert.AreEqual("Grecja – Limnos – FakeStore", driver.Title, "Page title is not correct.");
            Assert.AreEqual("https://fakestore.testelka.pl/product/grecja-limnos/", driver.Url, "URL is not correct.");
        }

        [Test]
        public void IsPaymentButtonCartPageTest()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/product/gran-koscielcow/");
            driver.FindElement(By.Name("add-to-cart")).Click();
            driver.FindElement(By.LinkText("Zobacz koszyk")).Click();
            Assert.DoesNotThrow(()=>driver.FindElement(By.LinkText("Przejdź do kasy")), "Go to payment link was not found."); /*asercja z wykorzystaniem wyrażenia lambda*/

        /*Asercja z wykorzysraniem delegaqty*/
/*            TestDelegate findGoToPaymentLink = new TestDelegate(FindGoToPaymentLink);
            Assert.DoesNotThrow(findGoToPaymentLink, "Go to payment link was not found.") ;*/



        }

        /*        private void FindGoToPaymentLink()
                {
                    driver.FindElement(By.LinkText("Przejdź do kasy"));

                }*/

        [Test]
        public void IsNotPaymentButtonCartPageTest()
        {
            driver.Navigate().GoToUrl("https://fakestore.testelka.pl/koszyk");
            Assert.Throws<NoSuchElementException>(() => 
           driver.FindElement(By.LinkText("Przejdź do kasy")), "Go to payment link was not found."); /*asercja z wykorzystaniem wyrażenia lambda*/


        }

            [TearDown]
        public void QuiteDriver()
        {
            driver.Quit();
        }

    }
}
