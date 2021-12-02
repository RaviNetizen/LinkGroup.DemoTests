Feature: Link Group

[priority1]
Scenario: Smoke test
   Given I open the home page
   Then the page is displayed

[priority2]
Scenario: Contact page 
   Given I have opened the home page 
   And I have agreed to the cookie policy 
   When I select Contact 
   Then the Contact page is displayed 