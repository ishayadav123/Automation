using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;
using TechTalk.SpecFlow;

namespace GulaqAutomationTesting.Context
{
    public class WebdriverContext
    {

        public ChromeDriver driver;

        public WebdriverContext()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(100);
        }

        

    }
}
