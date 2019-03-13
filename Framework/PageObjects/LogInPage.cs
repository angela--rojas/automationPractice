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
    /// Summary description for LogInPage
    /// </summary>
    [TestClass]
    public class LogInPage
    {

        private IWebDriver driver;

        public LogInPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }

        //Elements to create a new account
        [FindsBy(How = How.Id, Using = "email_create")]
        private IWebElement emailAddress;

        [FindsBy(How = How.Id, Using = "SubmitCreate")]
        private IWebElement btnCreateAccount;



        //Elements to login with an existing account
        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailLogIn;

        [FindsBy(How = How.Id, Using = "passwd")]
        private IWebElement password;

        [FindsBy(How = How.Id, Using = "SubmitLogin")]
        private IWebElement btnSignIn;




        //Methods to create a new account
        public void InsertEmail(string email)
        {
            Actions.Type(driver, emailAddress, email);
        }

        public void ClickOnSubmitCreate()
        {
            Actions.ClickOn(driver, btnCreateAccount);
        }



        //Methods to login with an existing account
        public void FillLogInForm(string email, string pass)
        {
            Actions.Type(driver, emailLogIn, email);
            Actions.Type(driver, password, pass);
        }

        public void ClickOnSubmitLogin()
        {
            Actions.ClickOn(driver, btnSignIn);
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
