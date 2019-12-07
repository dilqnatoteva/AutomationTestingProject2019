using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AutomationTestingProject2019
{
    [TestClass]
    public class TestLogin : BaseTest
    {
        [TestMethod]
        public void SuccessfulLogin()
        {
            // Arrane
            mainPage.GoToIndex();
            header.GoToLogin();

            // Act
            loginPage.Login("automation_testing_account", "123456Dd");
            
            // Assert
            Assert.AreEqual(header.UserEmailInfo.Text, "automation_testing_account@abv.bg");
        }

        [TestMethod]
        public void EmptyUsername()
        {
            mainPage.GoToIndex();
            header.GoToLogin();

            loginPage.Login("", "123456Dd");

            Assert.AreEqual(loginPage.GetMissingUsernameOrPasswordErrorText(), "Моля попълнете полето Потребителско име.");
        }

        [TestMethod]
        public void InvalidUsername()
        {
            mainPage.GoToIndex();
            header.GoToLogin();

            loginPage.Login("non_existing_username_sjjsgfsdgsd", "123456Dd");

            Assert.AreEqual(loginPage.GetInvalidUsernameOrPasswordErrorText(), "Грешен потребител / парола.");
        }

        [TestMethod]
        public void EmptyPassword()
        {
            mainPage.GoToIndex();
            header.GoToLogin();

            loginPage.Login("automation_testing_account", "");

            Assert.AreEqual(loginPage.GetMissingUsernameOrPasswordErrorText(), "Моля попълнете полето Парола.");
        }
    }
}
