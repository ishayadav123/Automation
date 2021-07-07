Feature: Logout
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
   
@Logout
Scenario: Logout From Gulaq
   Given Gulaq Dashboard, Click the Profile on Top Right of Dashboard
   And Click Logout
   Then Redirected to the Login Page
   