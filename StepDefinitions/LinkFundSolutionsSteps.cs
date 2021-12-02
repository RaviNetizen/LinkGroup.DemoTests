using System;
using TechTalk.SpecFlow;
using OpenQA.Selenium;
using LinkGroup.DemoTest.Pages;
using LinkGroup.DemoTest.Helpers;

namespace LinkGroup.DemoTest.StepDefinitions
{
    [Binding]
    public class LinkFundSolutionsSteps
    {
        IWebDriver driver = null;
        string baseUrl = "https://www.linkfundsolutions.co.uk/";

        [Given(@"I have opened the Found Solutions page")]
        public void GivenIHaveOpenedTheFoundSolutionsPage()
        {
            driver = Browser.Startbrowser("chrome", baseUrl);            
        }
        
        [When(@"I view Funds")]
        public void WhenIViewFunds()
        {
            FundsPage fund = new FundsPage(driver);
            fund.iHooverOverFunds();
        }
        
        [Then(@"I can select the investment managers for (.*) investors")]
        public void ThenICanSelectTheInvestmentManagersForUKInvestors(string p1)
        {
            FundsPage fund = new FundsPage(driver);
            fund.iClickFunds(p1);
        }

        [Then(@"the url is equals to (.*)")]
        public void ThenTheUrlIsEqualsTo(string p0)
        {
            ScenarioContext.Current.Pending();
        }

    }
}
