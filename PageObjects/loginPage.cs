using OpenQA.Selenium;

namespace GulaqAutomationTesting.PageObjects
{
    public class loginPage
    {
        
        private readonly Hooks _webdriverContext;
        public loginPage(Hooks webdriverContext)
        {
            this._webdriverContext = webdriverContext;
        }
        public void Go() => _webdriverContext.driver.Navigate().GoToUrl("https://pro.gulaq.com/logintesting");

        public IWebElement lnklogin => _webdriverContext.driver.FindElement(By.CssSelector("button[class='MuiButtonBase-root MuiButton-root MuiButton-contained MuiButton-containedSecondary']"));

        public IWebElement userid => _webdriverContext.driver.FindElement(By.XPath(".//*[@id = 'userid']"));

        public IWebElement paasword => _webdriverContext.driver.FindElement(By.XPath(".//*[@id = 'password']"));

        public IWebElement btnlogin => _webdriverContext.driver.FindElement(By.ClassName("actions"));

        public IWebElement pim => _webdriverContext.driver.FindElement(By.XPath(".//*[@id = 'pin']"));

        public IWebElement btnpin => _webdriverContext.driver.FindElement(By.ClassName("actions"));

        public IWebElement lnkDetails => _webdriverContext.driver.FindElement(By.CssSelector("button[class='MuiButtonBase-root MuiButton-root MuiButton-outlined jss62 MuiButton-outlinedSecondary']"));

        public void ClickLogin() => lnklogin.Click();

        public void Login(string username, string password)
        {
            userid.SendKeys(username);

            paasword.SendKeys(password);

        }

        public void ClickLoginButton() => btnlogin.Click();


        public void Pin()
        {
            pim.SendKeys("030191");
        }

        public void ClickPinButton() => btnpin.Click();

        public bool IsDetailsExixt() => lnkDetails.Displayed;


        public IWebElement ClickAddFund => _webdriverContext.driver.FindElement(By.CssSelector("div[class='jss70']"));

        public void ClickAdd() => ClickAddFund.Click();

        public void Check()
        {
            //string actualUrl = "https://kite.zerodha.com/connect/login?api_key=cashier&sess_id=WywPZiFitA6ZOK2seHTc0yekEtA1F9Cd";
            //string expected = _webdriverContext.driver.Url;
            //Assert.AreEqual(expected, actualUrl);
        }


        public IWebElement ClickGoalPlanning => _webdriverContext.driver.FindElement(By.CssSelector("span[class='MuiTypography-root MuiListItemText-primary MuiTypography-body1 MuiTypography-displayBlock']"));

        public void ClickGoal() => ClickGoalPlanning.Click();

        public void CheckGoal()
        {
            //string actualUrl = "https://pro.gulaq.com/goalplanning";
            //string expected = _webdriverContext.driver.Url;
            //Assert.AreEqual(expected, actualUrl);
        }

        public IWebElement ClickSubsCribe => _webdriverContext.driver.FindElement(By.CssSelector("button[class='MuiButtonBase-root MuiButton-root MuiButton-contained jss96']"));

        public void Subscribe() => ClickSubsCribe.Click();

        public IWebElement ClickReprofile => _webdriverContext.driver.FindElement(By.CssSelector("span[class='MuiButton-label']"));
        public void Reprofile() => ClickReprofile.Click();

        public IWebElement FirstAns => _webdriverContext.driver.FindElement(By.CssSelector("input[value='11 years or more']"));
        public void ClickFirst() => FirstAns.Click();

        public IWebElement NextButton => _webdriverContext.driver.FindElement(By.XPath("//*[text()='Next']"));
        public void ClickOnNext() => NextButton.Click();

        public IWebElement secondAns => _webdriverContext.driver.FindElement(By.CssSelector("input[value='11 years or more']"));
        public void ClickSecond() => secondAns.Click();


        public IWebElement ThirdAns => _webdriverContext.driver.FindElement(By.CssSelector("input[value ='Stable']"));
        public void ClickThird() => ThirdAns.Click();


        public IWebElement forthAns => _webdriverContext.driver.FindElement(By.CssSelector("input[value ='Equally concerned about my investment losing or gaining value']"));
        public void ClickForth() => forthAns.Click();


        public IWebElement FifthAns => _webdriverContext.driver.FindElement(By.CssSelector("input[value ='Do nothing']"));
        public void ClickFifth() => FifthAns.Click();


        public IWebElement SixthAns => _webdriverContext.driver.FindElement(By.CssSelector("input[value ='Plan C	- Average(11.1%), Best(43.2%), Worst(-14.3%)']"));
        public void ClickSixth() => SixthAns.Click();


        public IWebElement seventh => _webdriverContext.driver.FindElement(By.XPath("//p[contains(text(),'Individual')]//..//input[@value='None']"));
        public void clickOnseventhQues() => seventh.Click();

        public IWebElement seventhone => _webdriverContext.driver.FindElement(By.XPath("//p[contains(text(),'Mutual')]//..//input[@value='Some']"));
        public void clickOnseventhone() => seventhone.Click();

        public IWebElement seventhtwo => _webdriverContext.driver.FindElement(By.XPath("//p[contains(text(),'My experience with Futures and Options :')]//..//input[@value='Extensive']"));
        public void clickOnseventhtwo() => seventhtwo.Click();


        public IWebElement Submit => _webdriverContext.driver.FindElement(By.CssSelector("span[class='MuiButton-label']"));
        public void ClicOnSubmit() => Submit.Click();

        public IWebElement Submit2 => _webdriverContext.driver.FindElement(By.CssSelector("span[class='MuiButton-label']"));
        public void ClicOnSubmit2() => Submit2.Click();


        public IWebElement Proceed => _webdriverContext.driver.FindElement(By.CssSelector("button[class='MuiButtonBase-root MuiButton-root MuiButton-contained jss50 MuiButton-containedSecondary']"));
        public void ClicOnProceedToDashboard() => Proceed.Click();
        

        public IWebElement Profile => _webdriverContext.driver.FindElement(By.CssSelector("div[class='MuiAvatar-root MuiAvatar-circle jss43 MuiAvatar-colorDefault']"));
        public void ClickProfile() => Profile.Click();

        public IWebElement Logout => _webdriverContext.driver.FindElement(By.CssSelector("svg[class='MuiSvgIcon-root']"));
        public void ClickLogout() => Logout.Click();

        public IWebElement Reprofiling => _webdriverContext.driver.FindElement(By.CssSelector("span[class='MuiButton-label']"));
        public void ClickOnReprofile() => Reprofiling.Click();

        public IWebElement First => _webdriverContext.driver.FindElement(By.CssSelector("input[value='11 years or more']"));
        public void FirstClick() => First.Click();

        public IWebElement next => _webdriverContext.driver.FindElement(By.XPath("//*[text()='Next']"));
        public void ClicOnnext6() =>next.Click();

        public IWebElement Back => _webdriverContext.driver.FindElement(By.XPath("//*[text()='Back']"));
        public void ClickBack() => Back.Click();

        public IWebElement Assert => _webdriverContext.driver.FindElement(By.XPath("//*text() ='Login to'"));


        public IWebElement funds => _webdriverContext.driver.FindElement(By.CssSelector("#menu-list-grow > li:nth-child(1) > div > div:nth-child(2) > p > span"));
    }
}
