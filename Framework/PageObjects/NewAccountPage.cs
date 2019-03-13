using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using automationpractice.Framework.BrowserCommands;

namespace automationpractice.Framework.PageObjects
{
    /// <summary>
    /// Summary description for NewAccountPage
    /// </summary>
    [TestClass]
    public class NewAccountPage
    {

        private IWebDriver driver;

        public NewAccountPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "id_gender2")]
        private IWebElement gender;

        [FindsBy(How = How.Id, Using = "customer_firstname")]
        private IWebElement customerFirstName;

        [FindsBy(How = How.Id, Using = "customer_lastname")]
        private IWebElement customerLastName;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "days")]
        private IWebElement dayBirth;

        [FindsBy(How = How.Id, Using = "months")]
        private IWebElement monthBirth;

        [FindsBy(How = How.Id, Using = "years")]
        private IWebElement yearBirth;

        [FindsBy(How = How.Id, Using = "address1")]
        private IWebElement address;

        [FindsBy(How = How.Id, Using = "city")]
        private IWebElement city;

        [FindsBy(How = How.Id, Using = "id_state")]
        private IWebElement state;

        [FindsBy(How = How.Id, Using = "postcode")]
        private IWebElement postalCode;            

        [FindsBy(How = How.Id, Using = "phone_mobile")]
        private IWebElement mobilePhone;
        
        [FindsBy(How = How.Id, Using = "submitAccount")]
        private IWebElement register;

        

        public void CallElement()
        {
            Actions.WaitForElement(driver, By.Id("id_gender2"));
        }


        public void FillNewAccountForm(string firstName, string lastName, string passw, string dayValue, string monthValue, string yearValue, string addr, string cityName, string stateValue, string postal, string mobile)
        {
            Actions.ClickOn(driver, gender);
            Actions.Type(driver, customerFirstName, firstName);
            Actions.Type(driver, customerLastName, lastName);
            Actions.Type(driver, password, passw);
            Actions.SelectValue(dayBirth, dayValue);
            Actions.SelectValue(monthBirth, monthValue);
            Actions.SelectValue(yearBirth, yearValue);
            Actions.Type(driver, address, addr);
            Actions.Type(driver, city, cityName);
            Actions.SelectValue(state, stateValue);
            Actions.Type(driver, postalCode, postal);
            Actions.Type(driver, mobilePhone, mobile);
        }


        public void ClickOnSubmitAccount()
        {
            Actions.ClickOn(driver, register);
        }


        private TestContext testContextInstance;

        /// <summary>
        ///Gets or sets the test context which provides
        ///information about and functionality for the current test run.
        ///</summary>
        public TestContext TestContext
        {
            get
            {
                return testContextInstance;
            }
            set
            {
                testContextInstance = value;
            }
        }

        #region Additional test attributes
        //
        // You can use the following additional attributes as you write your tests:
        //
        // Use ClassInitialize to run code before running the first test in the class
        // [ClassInitialize()]
        // public static void MyClassInitialize(TestContext testContext) { }
        //
        // Use ClassCleanup to run code after all tests in a class have run
        // [ClassCleanup()]
        // public static void MyClassCleanup() { }
        //
        // Use TestInitialize to run code before running each test 
        // [TestInitialize()]
        // public void MyTestInitialize() { }
        //
        // Use TestCleanup to run code after each test has run
        // [TestCleanup()]
        // public void MyTestCleanup() { }
        //
        #endregion

        [TestMethod]
        public void TestMethod1()
        {
            //
            // TODO: Add test logic here
            //
        }
    }
}
