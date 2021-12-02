using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using LinkGroup.DemoTest.Helpers;
using System.Threading;
using NUnit.Framework;
using SeleniumExtras.PageObjects;
using OpenQA.Selenium.Interactions;

namespace LinkGroup.DemoTest.Pages
{
    class FundsPage
    {
        private readonly WebDriverWait _wait;
        private readonly IWebDriver _driver;
        public FundsPage(IWebDriver driver)
        {
            this._driver = driver;
            _wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(25));
        }


        private IWebElement fundsButton => _driver.FindElement(By.Id("navbarDropdown"));

        private IWebElement ukLink => _driver.FindElement(By.CssSelector("[href='/investment-managers-for-uk-investors/']"));
        


        public void iHooverOverFunds()
        {
            _wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(fundsButton));
            Actions action = new Actions(_driver);
            action.MoveToElement(fundsButton).Perform();
        }

        public void iClickFunds(string p1)
        {
            //_wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementToBeClickable(By.CssSelector(p1)));
           _driver.FindElement(By.CssSelector(p1)).Click();
        }

    }
}
