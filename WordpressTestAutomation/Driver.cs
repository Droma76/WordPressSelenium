using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.IO;
using System.Reflection;

namespace WordpressTestAutomation
{
    public class Driver
    {
        public static IWebDriver Instance { get; set; }

        public static void Initialise()
        {
            ChromeOptions options = new ChromeOptions();
            options.AddArguments("test-type");
            options.AddArguments("disable-plugins");
            options.AddArguments("disable-extensions");

            Instance = new ChromeDriver(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location), options);

            Instance.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);
        }

        public static void Close()
        {
           Instance.Close();
        }
    }
}

