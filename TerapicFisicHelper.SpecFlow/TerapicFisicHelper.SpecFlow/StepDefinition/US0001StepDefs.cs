using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using TechTalk.SpecFlow;

namespace TerapicFisicHelper.SpecFlow.StepDefinition
{
    [Binding]
    public sealed class US0001StepDefs
    {
        public static IWebDriver webDriver;
        public WebDriverWait wait;

        public US0001StepDefs()
        {
            webDriver = new ChromeDriver();
            wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        //  SCENARIO 1

        [Given(@"the user enters the (.*) of the web application")]
        public void GivenTheUserEntersTheOfTheWebApplication(string url)
        {
            webDriver.Navigate().GoToUrl(url);
        }

        [Given(@"is in the home view")]
        public void GivenIsInTheHomeView()
        {
            webDriver.Manage().Window.Maximize();
        }

        [When(@"the user selects the user view option")]
        public void WhenTheUserSelectsTheUserViewOption()
        {
            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webUser = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[1]")));
            webUser.Click();
        }

        [Then(@"the system displays the user registration view")]
        public void ThenTheSystemDisplaysTheUserRegistrationView()
        {
            WebDriverWait espera = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }

        // SCENARIO 2

        [Given(@"the user is in the New User view")]
        public void GivenTheUserIsInTheNewUserView()
        {
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app");
            webDriver.Manage().Window.Maximize();
            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webUser = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[1]")));
            webUser.Click();

            IWebElement newUser = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/main/div/div/div/header/div/button")));
            newUser.Click();
        }

        [When(@"the user enters the requested data: (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*), (.*) and (.*)")]
        public void WhenTheUserEntersTheRequestedDataAnd(string name, string lastname, string description, string birth, string address, string phone, string age, string email, string country, string gender, string password)
        {
            IWebElement userName = wait.Until(e => e.FindElement(By.Id("user-name")));
            userName.SendKeys(name);

            IWebElement userLastName = wait.Until(e => e.FindElement(By.Id("user-lastname")));
            userLastName.SendKeys(lastname);

            IWebElement userDescription = wait.Until(e => e.FindElement(By.Id("user-description")));
            userDescription.SendKeys(description);

            IWebElement userBirth = wait.Until(e => e.FindElement(By.Id("user-birth")));
            userBirth.SendKeys(birth);

            IWebElement userAddress = wait.Until(e => e.FindElement(By.Id("user-address")));
            userAddress.SendKeys(address);

            IWebElement userPhone = wait.Until(e => e.FindElement(By.Id("user-phone")));
            userPhone.SendKeys(phone);

            IWebElement userAge = wait.Until(e => e.FindElement(By.Id("user-age")));
            userAge.SendKeys(age);

            IWebElement userEmail = wait.Until(e => e.FindElement(By.Id("user-email")));
            userEmail.SendKeys(email);

            IWebElement userCountry = wait.Until(e => e.FindElement(By.Id("user-country")));
            userCountry.SendKeys(country);

            IWebElement userGender = wait.Until(e => e.FindElement(By.Id("user-gender")));
            userGender.SendKeys(gender);

            IWebElement userPassword = wait.Until(e => e.FindElement(By.Id("user-password")));
            userPassword.SendKeys(password);
        }

        [When(@"clicks save")]
        public void WhenClicksSave()
        {
            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("user-save")));
            btnSave_U.Click();
        }

        [Then(@"the system registers the user's account")]
        public void ThenTheSystemRegistersTheUserSAccount()
        {
            WebDriverWait espera = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));
        }
    }
}
