using GulaqAutomationTesting.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace GulaqAutomationTesting.StepDefinitions
{
    [Binding]
    public sealed class Subscribe
    {
        private readonly loginPage _login;
        public Subscribe(loginPage login)
        {
            this._login = login;
        }
        //Step Definitions Of Subscribe
        [Given(@"Gulaq Dashboard, Click Subscribe")]
        public void GivenGulaqDashboardClickSubscribe()
        {

            _login.Subscribe();
        }

        [Then(@"Redirected to the RIA Agreement")]
        public void ThenRedirectedToTheRIAAgreement()
        {
            Console.WriteLine("RIA Agreement");
        }
    }
}
