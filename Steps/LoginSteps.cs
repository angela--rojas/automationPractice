using automationpractice.Framework.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace automationpractice.Steps
{
    [Binding]
    public class LoginSteps
    {
        public static IWebDriver driver = new ChromeDriver();
        public HomePage homePage = new HomePage(driver);
        LogInPage logInPage = new LogInPage(driver);
        
        SessionStartedPage sessionStartedPage = new SessionStartedPage(driver);


        [Given]
        public void GivenIAmInHomePageForLogin()
        {
            homePage.GoToPage();
        }
        
        [When]
        public void WhenISelectSigninButton()
        {
            homePage.ClickOnSignIn();
        }
        
        [When]
        public void WhenIFillTheLoginForm()
        {
            logInPage.FillLogInForm("ggggg8881@gmail.com", "clave1");
            logInPage.ClickOnSubmitLogin();
        }
        
        [Then]
        public void ThenIVerifyTheSuccessMessageForLogin()
        {
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", sessionStartedPage.GetSuccessMessage());
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }
    }
}
