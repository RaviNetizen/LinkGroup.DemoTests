Feature: LinkFundSolutions

[priority3]
Scenario Outline: Investment managers
   Given I have opened the Found Solutions page
   When I view Funds
   Then I can select the investment managers for <Jurisdiction> investors
   And the url is equals to <url>>
Examples:
| Jurisdiction |url|
| By.CssSelector("[href='/investment-managers-for-uk-investors/']") | https://www.linkfundsolutions.co.uk/investment-managers-for-uk-investors/|
#| "[href='/investment-managers-for-irish-investors/']" |https://www.linkfundsolutions.co.uk/investment-managers-for-irish-investors/ |
#| "[href='/investment-managers-for-swiss-investors/']" | https://www.linkfundsolutions.co.uk/investment-managers-for-swiss-investors/ |
