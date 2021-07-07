using GulaqAutomationTesting.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GulaqAutomationTesting.StepDefinitions
{
    [Binding]
    public sealed class ReProfileSteps
    {
        private readonly loginPage _login;
        public ReProfileSteps(loginPage login)
        {
            this._login = login;
        }

        [Given(@"Gulaq Dashboard")]
        public void GivenGulaqDashboard()
        {
            Console.WriteLine("Gulaq Dashboard");
        }

        [Given(@"Click Re Profile button on Dashbaord")]
        public void GivenClickReProfileButtonOnDashbaord()
        {

            _login.Reprofile();
        }

        [Given(@"Redirected to the Questionnaire")]
        public void GivenRedirectedToTheQuestionnaire()
        {
            Console.WriteLine("Questionnaire");
        }

        [Given(@"Select Answer for First Question")]
        public void GivenSelectAnswerForFirstQuestion()
        {

            _login.ClickFirst();
        }

        [Given(@"Click Next after First selection")]
        public void GivenClickNextAfterFirstSelection()
        {

            _login.ClickOnNext();
        }

        [Given(@"Select Answer for Second Question")]
        public void GivenSelectAnswerForSecondQuestion()
        {

            _login.ClickSecond();
        }

        [Given(@"Click Next after Second selection")]
        public void GivenClickNextAfterSecondSelection()
        {

            _login.ClickOnNext();
        }

        [Given(@"Select Answer for Third Question")]
        public void GivenSelectAnswerForThirdQuestion()
        {

            _login.ClickThird();
        }

        [Given(@"Click Next after Third selection")]
        public void GivenClickNextAfterThirdSelection()
        {

            _login.ClickOnNext();
        }

        [Given(@"Select Answer for Forth Question")]
        public void GivenSelectAnswerForForthQuestion()
        {

            _login.ClickForth();
        }

        [Given(@"Click Next after Forth selection")]
        public void GivenClickNextAfterForthSelection()
        {

            _login.ClickOnNext();
        }

        [Given(@"Select Answer for Fifth Question")]
        public void GivenSelectAnswerForFifthQuestion()
        {

            _login.ClickFifth();
        }

        [Given(@"Click Next after Fifth selection")]
        public void GivenClickNextAfterFifthSelection()
        {

            _login.ClickOnNext();
        }

        [Given(@"Select Answer for Sixth Question")]
        public void GivenSelectAnswerForSixthQuestion()
        {

            _login.ClickSixth();
        }

        [Given(@"Click Next after Sixth selection")]
        public void GivenClickNextAfterSixthSelection()
        {

            _login.ClickOnNext();
        }

        [Given(@"Select Answer for Seventh Question")]
        public void GivenSelectAnswerForSeventhQuestion()
        {

            _login.clickOnseventhQues();
            _login.clickOnseventhone();
            _login.clickOnseventhtwo();
        }

        [Given(@"Click Submit")]
        public void GivenClickSubmit()
        {

            _login.ClicOnSubmit();
        }

        [Given(@"You have your Prefernces")]
        public void GivenYouHaveYourPrefernces()
        {
            Console.WriteLine("Preferences");
        }

        [Given(@"Click Submit with Preferences")]
        public void GivenClickSubmitWithPreferences()
        {

            _login.ClicOnSubmit2();
        }

        [Given(@"Popup Window showing the profile")]
        public void GivenPopupWindowShowingTheProfile()
        {
            Console.WriteLine("Popup");
        }

        [Given(@"click on Proceed To Dashboard")]
        public void GivenClickOnProceedToDashboard()
        {

            _login.ClicOnProceedToDashboard();
        }

        [Then(@"Redirected to the Dashboard with Updated Profile")]
        public void ThenRedirectedToTheDashboardWithUpdatedProfile()
        {
            Console.WriteLine("Dashboard");
        }

        //Step Definitions Of Re Profile & Back

        [Given(@"Dashboard")]
        public void GivenDashboard()
        {
            Console.WriteLine("Dashboard");
        }

        [Given(@"Click Re Profile")]
        public void GivenClickReProfile()
        {

            _login.ClickOnReprofile();
        }

        [Given(@"Select Answer for First")]
        public void GivenSelectAnswerForFirst()
        {

            _login.FirstClick();
        }

        [Given(@"Click Next after Selection")]
        public void GivenClickNextAfterSelection()
        {

            _login.ClickOnNext();
        }

        [Given(@"Click Back")]
        public void GivenClickBack()
        {

            _login.ClickBack();
        }

        [Then(@"Redirected to the Previous Question Answered")]
        public void ThenRedirectedToThePreviousQuestionAnswered()
        {
            Console.WriteLine("Redirected to Previous Question");
        }

    }
}
