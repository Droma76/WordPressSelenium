using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Reflection;

namespace WordpressTestAutomation
{
    public class LoginPage
    {
        public static void Goto()
        {
            Driver.Instance.Navigate().GoToUrl(@"http://localhost/wordpress/wp-login.php");
            var wait = new WebDriverWait(Driver.Instance, TimeSpan.FromSeconds(10));
            wait.Until(d => d.SwitchTo().ActiveElement().GetAttribute("id") == "user_login");
        }

        public static LoginCommand LoginAs(string username)
        {
            return new LoginCommand(username);
        }
    }
}