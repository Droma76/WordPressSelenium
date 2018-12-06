using System;
using Xunit;
using WordpressTestAutomation;
using System.Threading;

namespace WordpressTestAutomation.Tests
{
    public class LoginTests : IDisposable
    {
        public LoginTests()
        {
            Driver.Initialise();
        }

        [Fact]
        public void Selenium_user_can_log_in()
        {
            LoginPage.Goto();

            Thread.SpinWait(4000);

            LoginPage
                .LoginAs("selenium_user")
                .WithPassword("q*y12rVMn7NJ8Jjxw@")
                .Login();

            //Assert.True(DashboardPage.IsAt, "Failed to login");
        }

        public void Dispose()
        {
            Driver.Close();
        }
    }
}
