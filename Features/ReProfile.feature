Feature: ReProfile
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

 @Reprofile_Next  
Scenario: Reprofiling and Next Button functionality
   Given Gulaq Dashboard
   And Click Re Profile button on Dashbaord
   And Redirected to the Questionnaire
   And Select Answer for First Question
   And Click Next after First selection
   And Select Answer for Second Question
   And Click Next after Second selection
   And Select Answer for Third Question
   And Click Next after Third selection
   And Select Answer for Forth Question
   And Click Next after Forth selection
   And Select Answer for Fifth Question
   And Click Next after Fifth selection
   And Select Answer for Sixth Question
   And Click Next after Sixth selection
   And Select Answer for Seventh Question
   And Click Submit
   And You have your Prefernces
   And Click Submit with Preferences
   And Popup Window showing the profile
   And click on Proceed To Dashboard
   Then Redirected to the Dashboard with Updated Profile
   
  @Reprofile_Back
Scenario: Reprofiling and Back button Functionality
   Given Dashboard
   And Click Re Profile
   And Select Answer for First 
   And Click Next after Selection
   And Click Back
   Then Redirected to the Previous Question Answered
   