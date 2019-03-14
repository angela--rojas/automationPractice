using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace automationpractice.Framework.BrowserCommands
{
    /// <summary>
    /// Summary description for Actions
    /// </summary>
    [TestClass]
    public class Actions
    {
        public Actions()
        {
            //
            // TODO: Add constructor logic here
            //
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


        public static void ClickOn(IWebDriver driver, IWebElement element)
        {
            try
            {
                element.Click();
            }
            catch
            {
                IJavaScriptExecutor executor = (IJavaScriptExecutor)driver;
                executor.ExecuteScript("arguments[0].click();",element);

            }
        }

        public static IWebElement WaitForElement(IWebDriver driver, By by, int seconds = 25)
        {
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(seconds));
            return wait.Until((d) =>
            {
                return d.FindElement(by);
            });
        }


        public static void Type(IWebDriver driver, IWebElement element, string value)
        {
            element.SendKeys(value);
        }


        public static void SelectValue(IWebElement element, string value)
        {
            SelectElement subjectHeading = new SelectElement(element);
            subjectHeading.SelectByValue(value);
        }


    }
}
