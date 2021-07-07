using AventStack.ExtentReports;
using AventStack.ExtentReports.Gherkin.Model;
using AventStack.ExtentReports.Reporter;
using GulaqAutomationTesting.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;
using TechTalk.SpecFlow.Assist;

namespace GulaqAutomationTesting.StepDefinitions
{
    [Binding]
    public sealed class Login
    {
        private readonly loginPage _login;
        public Login(loginPage login)
        {
            this._login = login;
        }

        //Step Definitions of Login

        [Given(@"First launch the application")]
        public void GivenFirstLaunchTheApplication()
        {
            //var htmlReporter = new ExtentHtmlReporter(@"H:\Gulaq\Gulaq_Automation_Testing_Proj\GulaqAutomationTesting\ExtentReport.html");
            //htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            //var extent = new ExtentReports();
            //extent.AttachReporter(htmlReporter);

            ////Feature
            //var feature = extent.CreateTest<Feature>("Gulaq Automation Testing");

            ////Scenario 
            //var scenario = feature.CreateNode<Scenario>("Add Fund");

            ////Steps
            //scenario.CreateNode<Given>("Gulaq Dashboard, click Add Fund");
            ////extent.Flush();
            _login.Go();
        }

        [Given(@"Click LOGIN WITH ZERODHA")]
        public void GivenClickLOGINWITHZERODHA()
        {

            _login.ClickLogin();
        }

        [Given(@"Enter the User ID and Password")]
        public void GivenEnterTheUserIDAndPassword(Table table)
        {

            dynamic data = table.CreateDynamicInstance();
            _login.Login((string)data.userid, (string)data.paasword);
        }

        [Given(@"Click Login")]
        public void GivenClickLogin()
        {
            _login.ClickLoginButton();

        }

        [Given(@"Enter PIN")]
        public void GivenEnterPIN()
        {
            _login.Pin();
        }

        [Then(@"Click Continue")]
        public void ThenClickContinue()
        {
            _login.ClickPinButton();

        }
    }
}
