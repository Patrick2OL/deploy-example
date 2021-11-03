using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;

namespace TerapicFisicHelper.Selenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void TestCreateUser()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app/");
            webDriver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            // Test en User
            IWebElement webUser = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[1]")));
            webUser.Click();


            IWebElement newUser = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/main/div/div/div/header/div/button")));
            newUser.Click();

            IWebElement userName = wait.Until(e => e.FindElement(By.Id("user-name")));
            userName.SendKeys("Luis");

            IWebElement userLastName = wait.Until(e => e.FindElement(By.Id("user-lastname")));
            userLastName.SendKeys("Mendez");

            IWebElement userDescription = wait.Until(e => e.FindElement(By.Id("user-description")));
            userDescription.SendKeys("Me gusta hacer deporte");

            IWebElement userBirth = wait.Until(e => e.FindElement(By.Id("user-birth")));
            userBirth.SendKeys("11/11/1990");

            IWebElement userAddress = wait.Until(e => e.FindElement(By.Id("user-address")));
            userAddress.SendKeys("Avenida La Alameda");

            IWebElement userPhone = wait.Until(e => e.FindElement(By.Id("user-phone")));
            userPhone.SendKeys("966314855");

            IWebElement userAge = wait.Until(e => e.FindElement(By.Id("user-age")));
            userAge.SendKeys("31");

            IWebElement userEmail = wait.Until(e => e.FindElement(By.Id("user-email")));
            userEmail.SendKeys("luis.mendez@gmail.com");

            IWebElement userCountry = wait.Until(e => e.FindElement(By.Id("user-country")));
            userCountry.SendKeys("Perú");

            IWebElement userGender = wait.Until(e => e.FindElement(By.Id("user-gender")));
            userGender.SendKeys("maculino");

            IWebElement userPassword = wait.Until(e => e.FindElement(By.Id("user-password")));
            userPassword.SendKeys("rfLNWwn8");

            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("user-save")));
            btnSave_U.Click();
        }

        [Test]
        public void TestEditUser()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app/");
            webDriver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webUser = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[1]")));
            webUser.Click();

            IWebElement editedUser = wait.Until(e => e.FindElement(By.Id("user-edit")));
            editedUser.Click();

            IWebElement userBirth = wait.Until(e => e.FindElement(By.Id("user-birth")));
            userBirth.SendKeys("11/11/1990");

            IWebElement userAddress = wait.Until(e => e.FindElement(By.Id("user-address")));
            IWebElement userAge = wait.Until(e => e.FindElement(By.Id("user-age")));
            IWebElement userPhone = wait.Until(e => e.FindElement(By.Id("user-phone")));

            userAddress.Clear();
            userPhone.Clear();
            userAge.Clear();

            userAddress.SendKeys("Jr Huánuco");
            userPhone.SendKeys("123456789");
            userAge.SendKeys("60");

            IWebElement userPassword = wait.Until(e => e.FindElement(By.Id("user-password")));
            userPassword.SendKeys("rf");

            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("user-save")));
            btnSave_U.Click();

        }


        [Test]
        public void TestCreateCustomer()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app/");
            webDriver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webCustomer = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[2]")));
            webCustomer.Click();


            IWebElement newCustomer = wait.Until(e => e.FindElement(By.XPath("/html/body/div/div/main/div/div/div/header/div/button")));
            newCustomer.Click();

            IWebElement customerDescription = wait.Until(e => e.FindElement(By.Id("customer-description")));
            customerDescription.SendKeys("Usuario número 1");

            IWebElement customerUserId = wait.Until(e => e.FindElement(By.Id("customer-userId")));
            customerUserId.SendKeys("1");
            

            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("customer-save")));
            btnSave_U.Click();

        }

        [Test]
        public void TestEditCustomer()
        {
            IWebDriver webDriver = new ChromeDriver();
            webDriver.Navigate().GoToUrl("https://terapic-96405.web.app/");
            webDriver.Manage().Window.Maximize();
            WebDriverWait wait = new WebDriverWait(webDriver, TimeSpan.FromSeconds(10));

            IWebElement webMenu = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/header/div/div[1]/button/span")));
            webMenu.Click();

            IWebElement webCustomer = wait.Until(e => e.FindElement(By.XPath("//*[@id=\"inspire\"]/div/nav/div[1]/div/div[1]/div[2]/a[2]")));
            webCustomer.Click();


            IWebElement editCustomer = wait.Until(e => e.FindElement(By.Id("customer-edit")));
            editCustomer.Click();

            IWebElement customerDescription = wait.Until(e => e.FindElement(By.Id("customer-description")));
            
            IWebElement customerUserId = wait.Until(e => e.FindElement(By.Id("customer-userId")));
            
            customerDescription.Clear();
            customerUserId.Clear();
            customerDescription.SendKeys("Usuario número dos");
            customerUserId.SendKeys("2");

            IWebElement btnSave_U = wait.Until(e => e.FindElement(By.Id("customer-save")));
            btnSave_U.Click();

        }

    }
}