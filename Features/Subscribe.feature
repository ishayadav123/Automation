Feature: Subscribe
	Simple calculator for adding two numbers

Background: 
   Given First launch the application
   And Click LOGIN WITH ZERODHA
   And Enter the User ID and Password
      | userid | paasword |
      | IT4817 | Alok1857@ |
   And Click Login
   And Enter PIN
   Then Click Continue
   
@Subscribe
Scenario: Subscribe
   Given Gulaq Dashboard, Click Subscribe
   Then Redirected to the RIA Agreement
   