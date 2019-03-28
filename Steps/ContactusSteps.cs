using automationpractice.Framework.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TechTalk.SpecFlow;

namespace automationpractice
{
    [Binding]
    public class ContactusSteps
    {
        public static IWebDriver driver = new ChromeDriver();
        public HomePage homePage = new HomePage(driver);
        ContactUsPage contactUsPage = new ContactUsPage(driver);

        [Given]
        public void GivenIAmInHomePage()
        {
            homePage.GoToPage();
        }
        
        [When]
        public void WhenISelectContactus()
        {
            homePage.ClickOnContackLink();
        }
        
        [When]
        public void WhenIFillTheForm()
        {
            contactUsPage.SetSubjectHeading("2");
            contactUsPage.FillContactUsForm("email@gol.com", " 102030", "message 123");
            contactUsPage.ClickOnSubmitButton();
        }
        
        [Then]
        public void ThenIVerifyTheSuccessMessage()
        {
            Assert.AreEqual("Your message has been successfully sent to our team.", contactUsPage.GetSuccessMessage());
        }

        [AfterScenario]
        public void AfterScenario()
        {
            driver.Quit();
        }

    }
}
