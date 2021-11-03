using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace TerapicFisicHelper.SpecFlow.StepDefinition
{
    [Binding]
    public sealed class US0003StepDefs
    {
        public static IWebDriver webDriver;
        public WebDriverWait wait;

        public US0003StepDefs(ScenarioContext scenarioContext)
        {
            webDriver = new ChromeDriver();
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        // SCENARIO 1
        [Given(@"the rehabilitation specialist is in the New Customer view")]
        public void GivenTheRehabilitationSpecialistIsInTheNewCustomerView()
        {
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app/");
            webDriver.Manage().Window.Maximize();
            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webCustomer = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[2]")));
            webCustomer.Click();

            IWebElement newCustomer = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/main/div/div/div/header/div/button")));
            newCustomer.Click();
        }

        [When(@"enters the requested data: (.*) and (.*)")]
        public void WhenEntersTheRequestedDataAnd(string description, string userId)
        {
            IWebElement customerDescription = wait.Until(e => e.FindElement(By.Id("customer-description")));
            customerDescription.SendKeys(description);

            IWebElement customerUserId = wait.Until(e => e.FindElement(By.Id("customer-userId")));
            customerUserId.SendKeys(userId);
        }

        [When(@"clicks the button save")]
        public void WhenClicksTheButtonSave()
        {
            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("customer-save")));
            btnSave_U.Click();
        }

        [Then(@"the system registers the customer information")]
        public void ThenTheSystemRegistersTheCustomerInformation()
        {
            WebDriverWait espera = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        // SCENARIO 2
        [Given(@"the rehabilitation specialist is in the Customer view")]
        public void GivenTheRehabilitationSpecialistIsInTheCustomerView()
        {
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app/");
            webDriver.Manage().Window.Maximize();
            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webCustomer = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[2]")));
            webCustomer.Click();

            IWebElement editCustomer = wait.Until(e => e.FindElement(By.Id("customer-edit")));
            editCustomer.Click();
        }

        [When(@"edits the customer information: (.*) and (.*)")]
        public void WhenEditsTheCustomerInformationAnd(string description, string userId)
        {
            IWebElement customerDescription = wait.Until(e => e.FindElement(By.Id("customer-description")));

            IWebElement customerUserId = wait.Until(e => e.FindElement(By.Id("customer-userId")));

            customerDescription.Clear();
            customerUserId.Clear();
            customerDescription.SendKeys(description);
            customerUserId.SendKeys(userId);
        }

        [When(@"clicks button Save")]
        public void WhenClicksButtonSave()
        {
            IWebElement btnSave_C = wait.Until(e => e.FindElement(By.Id("customer-save")));
            btnSave_C.Click();
        }

        [Then(@"the system save changes made")]
        public void ThenTheSystemSaveChangesMade()
        {
            WebDriverWait espera = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
    }
}
