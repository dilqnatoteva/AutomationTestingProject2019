using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AutomationTestingProject2019.PageObjects;

namespace AutomationTestingProject2019
{
    [TestClass]
    public class BaseTest
    {
        protected Header header;
        protected MainPage mainPage;
        protected LoginPage loginPage;
        protected IWebDriver driver;

        public BaseTest()
        {
            driver = new ChromeDriver();
            header = new Header(driver);
            mainPage = new MainPage(driver);
            loginPage = new LoginPage(driver);
        }

        [TestInitialize]
        public void TestSetup()
        {
            driver.Manage().Window.Maximize();
        }

        [TestCleanup]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
