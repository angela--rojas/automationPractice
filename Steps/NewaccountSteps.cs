using automationpractice.Framework.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace automationpractice
{
    [Binding]
    public class NewaccountSteps
    {
        public static IWebDriver driver = new ChromeDriver();
        public HomePage homePage = new HomePage(driver);
        LogInPage logInPage = new LogInPage(driver);
        NewAccountPage newAccountPage = new NewAccountPage(driver);
        SessionStartedPage sessionStartedPage = new SessionStartedPage(driver);


        [Given]
        public void GivenIAmInHomePageForNewAccount()
        {
            homePage.GoToPage();
        }
        
        [When]
        public void WhenISelectSignin()
        {
            homePage.ClickOnSignIn();
        }
        
        [When]
        public void WhenIEnterAnEmailAddress()
        {
            logInPage.InsertEmail("xcccc8888@gmail.com");
            logInPage.ClickOnSubmitCreate();
        }
        
        [When]
        public void WhenIFillTheNewAccountForm()
        {
            newAccountPage.CallElement();
            newAccountPage.FillNewAccountForm("Patricia", "Londoño", "clave1", "19", "6", "1984", "163 Rockland Street Port Orange, FL 32127", "Philadelphia", "38", "77777", "202-555-0153");
            newAccountPage.ClickOnSubmitAccount();
        }
        
        [Then]
        public void ThenIVerifyTheSuccessMessageForANewAccount()
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
