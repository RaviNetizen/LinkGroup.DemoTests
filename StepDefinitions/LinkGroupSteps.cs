using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using LinkGroup.DemoTest.Pages;
using LinkGroup.DemoTest.Helpers;

namespace LinkGroup.DemoTest.StepDefinitions
{
    [Binding]
    public class LinkGroupSteps
    {
        IWebDriver driver = null;
        string baseUrl = "https://www.linkgroup.com/";


        [Given(@"I open the home page")]
        public void GivenIOpenTheHomePage()
        {
            driver = Browser.Startbrowser("chrome", baseUrl);
        }
        
        [Then(@"the page is displayed")]
        public void ThenThePageIsDisplayed()
        {
            HomePage home = new HomePage(driver);
            home.iAssertLogo();
        }

        [Given(@"I have opened the home page")]
        public void GivenIHaveOpenedTheHomePage()
        {
            driver = Browser.Startbrowser("chrome", baseUrl);
        }

        [Given(@"I have agreed to the cookie policy")]
        public void GivenIHaveAgreedToTheCookiePolicy()
        {
            HomePage home = new HomePage(driver);
            home.iAcceptCookies();
        }

        [When(@"I select Contact")]
        public void WhenISelectContact()
        {
            HomePage home = new HomePage(driver);
            home.iClickContact();
        }

        [Then(@"the Contact page is displayed")]
        public void ThenTheContactPageIsDisplayed()
        {
            ContactPage contact = new ContactPage(driver);
            contact.iAssertLogo();
        }

    }
}
