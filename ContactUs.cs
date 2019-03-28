using automationpractice.Framework.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace automationpractice
{
    [TestClass]
    public class ContactUs
    {
        IWebDriver driver;
        [TestInitialize]
        public void TestInitialize() //Configuración inicial del test
        {
            driver = new ChromeDriver(); //inicializa el driver
        }

        /*[TestMethod]
        public void ContactUsTest() //Donde hacemos el paso a paso que está indicado en el TestCase
        {
            driver.Url = "http://automationpractice.com/index.php?";
            IWebElement contactLink = driver.FindElement(By.Id("contact-link"));
            contactLink.Click();
            SelectElement subjectHeading = new SelectElement(driver.FindElement(By.Id("id_contact")));
            subjectHeading.SelectByValue("2");
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("hola@mailinator.com");
            IWebElement orderRef = driver.FindElement(By.Id("id_order"));
            orderRef.SendKeys("1012252");
            IWebElement message = driver.FindElement(By.Id("message"));
            message.SendKeys("this is a test for automation");
            IWebElement submit = driver.FindElement(By.Id("submitMessage"));
            submit.Click();
            string success = driver.FindElement(By.XPath("//*[@id=\"center_column\"]/p")).Text;
            Assert.AreEqual("Your message has been successfully sent to our team.", success);
        }*/

        [TestMethod]
        public void ContactUsTest() //Donde hacemos el paso a paso que está indicado en el TestCase
        {
            HomePage homePage = new HomePage(driver);
            ContactUsPage contactUsPage = new ContactUsPage(driver);

            homePage.GoToPage();
            homePage.ClickOnContackLink();
            contactUsPage.SetSubjectHeading("2");
            contactUsPage.FillContactUsForm("email@gol.com", " 102030", "message 123");
            contactUsPage.ClickOnSubmitButton();
            Assert.AreEqual("Your message has been successfully sent to our team.",contactUsPage.GetSuccessMessage());
        }


        /*[TestMethod]
        public void NewAccount() //Donde hacemos el paso a paso que está indicado en el TestCase
        {
            driver.Url = "http://automationpractice.com/index.php?";
            IWebElement signIn = driver.FindElement(By.ClassName("header_user_info"));
            signIn.Click();
            IWebElement emailAddress = driver.FindElement(By.Id("email_create"));
            emailAddress.SendKeys("ggggg8883@gmail.com");
            IWebElement btnCreateAccount = driver.FindElement(By.Id("SubmitCreate"));
            btnCreateAccount.Click();
            WebDriverWait wait = new WebDriverWait(driver, new TimeSpan(0, 0, 5));
            IWebElement gender = wait.Until(driver => driver.FindElement(By.Id("id_gender2")));
            gender.Click();
            IWebElement customerFirstName = driver.FindElement(By.Id("customer_firstname"));
            customerFirstName.SendKeys("Patricia");
            IWebElement customerLastName = driver.FindElement(By.Id("customer_lastname"));
            customerLastName.SendKeys("Londoño");
            IWebElement password = driver.FindElement(By.Id("passwd"));
            password.SendKeys("clave1");
            SelectElement dayBirth = new SelectElement(driver.FindElement(By.Id("days")));
            dayBirth.SelectByValue("19");
            SelectElement monthBirth = new SelectElement(driver.FindElement(By.Id("months")));
            monthBirth.SelectByValue("6");
            SelectElement yearBirth = new SelectElement(driver.FindElement(By.Id("years")));
            yearBirth.SelectByValue("1984");
            IWebElement address = driver.FindElement(By.Id("address1"));
            address.SendKeys("163 Rockland Street Port Orange, FL 32127");
            IWebElement city = driver.FindElement(By.Id("city"));
            city.SendKeys("Philadelphia");
            SelectElement state = new SelectElement(driver.FindElement(By.Id("id_state")));
            state.SelectByValue("38");
            IWebElement postalCode = driver.FindElement(By.Id("postcode"));
            postalCode.SendKeys("77777");
            IWebElement mobilePhone = driver.FindElement(By.Id("phone_mobile"));
            mobilePhone.SendKeys("202-555-0153");
            IWebElement register = driver.FindElement(By.Id("submitAccount"));
            register.Click();
            string success = driver.FindElement(By.ClassName("info-account")).Text;
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", success);
        }*/



        [TestMethod]
        public void NewAccount1() //Donde hacemos el paso a paso que está indicado en el TestCase
        {
            HomePage homePage = new HomePage(driver);
            LogInPage logInPage = new LogInPage(driver);
            NewAccountPage newAccountPage = new NewAccountPage(driver);
            SessionStartedPage sessionStartedPage = new SessionStartedPage(driver);

            homePage.GoToPage();
            homePage.ClickOnSignIn();
            logInPage.InsertEmail("zzzzz8888@gmail.com");
            logInPage.ClickOnSubmitCreate();

            newAccountPage.CallElement();
            newAccountPage.FillNewAccountForm("Patricia", "Londoño", "clave1", "19", "6", "1984", "163 Rockland Street Port Orange, FL 32127", "Philadelphia", "38", "77777", "202-555-0153");
            newAccountPage.ClickOnSubmitAccount();
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", sessionStartedPage.GetSuccessMessage());
        }


        /*[TestMethod]
        public void LogIn()
        {
            driver.Url = "http://automationpractice.com/index.php?";
            IWebElement signIn = driver.FindElement(By.ClassName("header_user_info"));
            signIn.Click();
            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys("ggggg8881@gmail.com");
            IWebElement password = driver.FindElement(By.Id("passwd"));
            password.SendKeys("clave1");
            IWebElement btnSignIn = driver.FindElement(By.Id("SubmitLogin"));
            btnSignIn.Click();
            string success = driver.FindElement(By.ClassName("info-account")).Text;
            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", success);
        }*/


        [TestMethod]
        public void LogIn1()
        {
            HomePage homePage = new HomePage(driver);
            LogInPage logInPage = new LogInPage(driver);
            SessionStartedPage sessionStartedPage = new SessionStartedPage(driver);

            homePage.GoToPage();
            homePage.ClickOnSignIn();
            logInPage.FillLogInForm("ggggg8881@gmail.com", "clave1");
            logInPage.ClickOnSubmitLogin();

            Assert.AreEqual("Welcome to your account. Here you can manage all of your personal information and orders.", sessionStartedPage.GetSuccessMessage());
        }



        [TestCleanup]
        public void TestCleanup() //Cerramos el driver
        {
            driver.Quit(); //cierra el driver
        }

    }
}