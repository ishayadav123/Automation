using GulaqAutomationTesting.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GulaqAutomationTesting.StepDefinitions
{
    [Binding]
    public sealed class LogoutSteps
    {
        private readonly loginPage _login;
        public LogoutSteps(loginPage login)
        {
            this._login = login;
        }
        //Step Definitions Of Logout

        [Given(@"Gulaq Dashboard, Click the Profile on Top Right of Dashboard")]
        public void GivenGulaqDashboardClickTheProfileOnTopRightOfDashboard()
        {

            _login.ClickProfile();
        }

        [Given(@"Click Logout")]
        public void GivenClickLogout()
        {

            _login.ClickLogout();
        }

        [Then(@"Redirected to the Login Page")]
        public void ThenRedirectedToTheLoginPage()
        {
            Console.WriteLine("Redirected to the Login Page");
        }
    }
}
