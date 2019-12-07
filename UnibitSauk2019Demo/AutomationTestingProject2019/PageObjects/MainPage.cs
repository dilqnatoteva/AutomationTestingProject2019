using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;

namespace AutomationTestingProject2019.PageObjects
{
    [TestClass]
    public class MainPage
    {

        private const string Url = "https://www.abv.bg/";
        private IWebDriver driver;

        public MainPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void GoToIndex()
        {
            driver.Navigate().GoToUrl(Url);
        }
    }
}
