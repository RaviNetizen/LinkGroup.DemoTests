using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using LinkGroup.DemoTest.Helpers;
using System.Threading;
using NUnit.Framework;
using SeleniumExtras.PageObjects;

namespace LinkGroup.DemoTest.Pages
{
    class HomePage
    {
        private readonly WebDriverWait _wait;
        private readonly IWebDriver _driver;
        public HomePage(IWebDriver driver)
        {
            //PageFactory.InitElements(driver, this);
            this._driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(25));
        }


        private IWebElement logo => _driver.FindElement(By.CssSelector("[alt='Link Group logo']"));

        private IWebElement cookies => _driver.FindElement(By.CssSelector("[class='cc-btn cc-dismiss']"));

        private IWebElement contact => _driver.FindElement(By.CssSelector("[href='../contact.html']"));

        private IWebElement funds => _driver.FindElement(By.CssSelector("[class='fund']"));


        public void iAssertLogo()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.CssSelector("[alt='Link Group logo']")));
            Assert.IsTrue(logo.Displayed);
            Assert.AreEqual(_driver.Title, "Link Group");
        }

        public void iAcceptCookies() 
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(cookies));
            cookies.Click();
        }
        public void iClickContact()
        {
            contact.Click();
        }

        public void iClickFundSolutions()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(funds));
            funds.Click();
        }
    }
}
