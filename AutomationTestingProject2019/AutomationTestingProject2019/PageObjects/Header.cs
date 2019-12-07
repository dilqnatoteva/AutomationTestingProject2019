using OpenQA.Selenium;

namespace AutomationTestingProject2019.PageObjects
{
    public class Header
    {
        private IWebDriver driver;
        private IWebElement loginButton;
        private IWebElement userEmailInfo;

        public Header(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement LoginButton
        {
            get
            {
                loginButton = driver.FindElement(By.CssSelector(".right:nth-child(2) > strong"));
                return loginButton;
            }
        }

        public IWebElement UserEmailInfo
        {
            get
            {
                userEmailInfo = driver.FindElement(By.CssSelector("span.abv-green.fl"));
                return userEmailInfo;
            }
        }

        public void GoToLogin()
        {
            LoginButton.Click();
        }
    }
}
