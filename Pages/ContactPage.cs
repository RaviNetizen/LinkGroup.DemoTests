using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using LinkGroup.DemoTest.Helpers;
using System.Threading;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace LinkGroup.DemoTest.Pages
{
    class ContactPage
    {
        private readonly WebDriverWait _wait;
        private readonly IWebDriver _driver;
        public ContactPage(IWebDriver driver)
        {
            //PageFactory.InitElements(driver, this);
            this._driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(25));
        }


        private IWebElement logo => _driver.FindElement(By.CssSelector("[alt='Link Group logo']"));

        public void iAssertLogo()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("[alt='Link Group logo']")));
            Assert.IsTrue(logo.Displayed);
            Assert.AreEqual(_driver.Url, "https://www.linkgroup.com/contact.html");
            Assert.AreEqual(_driver.Title, "Link Group");
        }
    }
}
