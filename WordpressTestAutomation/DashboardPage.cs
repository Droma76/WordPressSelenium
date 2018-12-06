using OpenQA.Selenium;
using System.Linq;

namespace WordpressTestAutomation
{
    public class DashboardPage
    {
        public static bool IsAt
        {
            get
            {
                return Driver.Instance
                        .FindElements(By.TagName("h2")).ToList()
                        .Where(h2 => h2.Text == "Dashboard")
                        .Any();
            }
        }
    }
}