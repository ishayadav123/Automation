Feature: Gulaq Automation Testing


Background: 
   Given First launch the application
   And Click LOGIN WITH ZERODHA
   And Enter the User ID and Password
      | userid | paasword |
      | IT4817 | Alok1857@ |
   And Click Login
   And Enter PIN
   Then Click Continue

   @Fund
Scenario: Add Fund
   Given Gulaq Dashboard, click Add Fund
   Then Redirected to the Login Cashier Page

   @GoalPlanning
Scenario: Goal Planning 
   Given Gulaq Dashboard, Click Goal Planning under Gulaq Advisory

  






