using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using automationpractice.Framework.BrowserCommands;

namespace automationpractice.Framework.PageObjects
{
    /// <summary>
    /// Summary description for HomePage
    /// </summary>
    [TestClass]
    public class HomePage
    {
        private IWebDriver driver;

        public HomePage(IWebDriver driver)
        {
            this.driver = driver;
            //GoToPage();
            //PageFactory.InitElements(driver, this);
        }


        [FindsBy(How = How.Id, Using = "contact-link")]
        private IWebElement contactLink;

        [FindsBy(How = How.ClassName, Using = "header_user_info")]
        private IWebElement signIn;

        

        public void GoToPage()
        {
            driver.Navigate().GoToUrl("http://automationpractice.com/index.php");
            PageFactory.InitElements(driver, this);
        }


        public void ClickOnContackLink()
        {
            Actions.ClickOn(driver, contactLink);
        }


        public void ClickOnSignIn()
        {
            Actions.ClickOn(driver, signIn);
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
