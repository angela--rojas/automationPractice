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
    /// Summary description for ContactUsPage
    /// </summary>
    [TestClass]
    public class ContactUsPage
    {
        private IWebDriver driver;

        public ContactUsPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "id_contact")]
        private IWebElement subjectHeading;

        [FindsBy(How = How.Id, Using = "email")]
        private IWebElement emailContact;

        [FindsBy(How = How.Id, Using = "id_order")]
        private IWebElement orderRef;


        [FindsBy(How = How.Id, Using = "message")]
        private IWebElement message;


        [FindsBy(How = How.Id, Using = "submitMessage")]
        private IWebElement submit;


        [FindsBy(How = How.XPath, Using = "//*[@id=\"center_column\"]/p")]
        private IWebElement successMessage;




        public void SetSubjectHeading(string value)
        {
            Actions.SelectValue(subjectHeading, value);
        }




        public void FillContactUsForm(string email, string refer, string msg)
        {
            Actions.Type(driver, emailContact, email);
            Actions.Type(driver, orderRef, refer);
            Actions.Type(driver, message, msg);
        }


        public void ClickOnSubmitButton()
        {
            Actions.ClickOn(driver, submit);
        }


        public string GetSuccessMessage()
        {
            return successMessage.Text;
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
