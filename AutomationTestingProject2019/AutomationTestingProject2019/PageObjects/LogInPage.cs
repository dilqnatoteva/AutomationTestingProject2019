using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;

namespace AutomationTestingProject2019.PageObjects
{
    public class LoginPage
    {
        private IWebElement username;
        private IWebElement password;
        private IWebElement acceptAllButton;
        private IWebElement errorMessage;
        private IWebDriver driver;

        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        private IWebElement Username
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                username = wait.Until(d => d.FindElement(By.Id("username")));

                return username;
            }
        }

        private IWebElement Password
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                password = wait.Until(d => d.FindElement(By.Id("password")));

                return password;
            }
        }

        private IWebElement LoginButton
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                acceptAllButton = wait.Until(d => d.FindElement(By.CssSelector("p > input")));

                return acceptAllButton;
            }
        }

        private IWebElement MissingUsernameOrPasswordError
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                errorMessage = wait.Until(d => d.FindElement(By.ClassName("abv-error")));

                return errorMessage;
            }
        }

        private IWebElement InvalidUsernameOrPasswordError
        {
            get
            {
                WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(3));
                errorMessage = wait.Until(d => d.FindElement(By.Id("form.errors")));

                return errorMessage;
            }
        }

        public string GetMissingUsernameOrPasswordErrorText()
        {
            return MissingUsernameOrPasswordError.Text;
        }

        public string GetInvalidUsernameOrPasswordErrorText()
        {
            return InvalidUsernameOrPasswordError.Text;
        }

        public void Login(string emailAddress, string password)
        {
            Username.Click();
            Username.Clear();
            Username.SendKeys(emailAddress);

            Password.Click();
            Password.Clear();
            Password.SendKeys(password);

            LoginButton.Click();
        }
    }
}
