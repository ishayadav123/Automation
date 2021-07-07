using GulaqAutomationTesting.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace GulaqAutomationTesting.StepDefinitions
{
    [Binding]
    public sealed class LoginSteps
    {

        private readonly loginPage _login;
        public LoginSteps(loginPage login)
        {
            this._login = login;
        }
       
        //Step Definitions Of Add Fund

        [Given(@"Gulaq Dashboard, click Add Fund")]
        public void GivenGulaqDashboardClickAddFund()
        {

            _login.ClickAdd();
        }

        [Then(@"Redirected to the Login Cashier Page")]
        public void ThenRedirectedToTheLoginCashierPage()
        {
            Console.WriteLine("Login Cashier Page");
        }


        //Step Definitions Of Goal Planning
        [Given(@"Gulaq Dashboard, Click Goal Planning under Gulaq Advisory")]
        public void GivenGulaqDashboardClickGoalPlanningUnderGulaqAdvisory()
        {

            _login.ClickGoal();
        }

       
    }
}

