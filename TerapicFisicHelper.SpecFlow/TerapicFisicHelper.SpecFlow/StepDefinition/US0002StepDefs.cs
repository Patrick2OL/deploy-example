using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace TerapicFisicHelper.SpecFlow.StepDefinition
{
    [Binding]
    public sealed class US0002StepDefs
    {
        public static IWebDriver webDriver;
        public WebDriverWait wait;

        private readonly ScenarioContext _scenarioContext;

        public US0002StepDefs(ScenarioContext scenarioContext)
        {
            webDriver = new ChromeDriver();
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        [Given(@"the user is in the Edit User view")]
        public void GivenTheUserIsInTheEditUserView()
        {
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app");
            webDriver.Manage().Window.Maximize();
            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webUser = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[1]")));
            webUser.Click();

            IWebElement editedUser = wait.Until(e => e.FindElement(By.Id("user-edit")));
            editedUser.Click();
        }

        [When(@"enters the information to change (.*)")]
        public void WhenEntersTheInformationToChange(string description)
        {
            IWebElement userBirth = wait.Until(e => e.FindElement(By.Id("user-birth")));
            userBirth.SendKeys("11/11/1990");

            IWebElement userDescription = wait.Until(e => e.FindElement(By.Id("user-description")));
            userDescription.SendKeys(" " + description);
        }

        [When(@"the user clicks save")]
        public void WhenTheUserClicksSave()
        {
            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("user-save")));
            btnSave_U.Click();
        }

        [Then(@"the system update user information")]
        public void ThenTheSystemUpdateUserInformation()
        {
            WebDriverWait espera = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
    }
}
