using OpenQA.Selenium;
using System.Collections.Generic;

namespace WordpressTestAutomation
{
    public class PostPage
    {
        public static string Title { get
            {
                var title = Driver.Instance.FindElement(By.ClassName("entry-title"));
                return title != null ? title.Text : string.Empty;
            }
        }
        //public static string Body { get; set; }
    }
}