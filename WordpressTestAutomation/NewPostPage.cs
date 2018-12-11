using OpenQA.Selenium;
using System;
using System.Collections.Generic;

namespace WordpressTestAutomation
{
    public class NewPostPage
    {
        public static string Title
        {
            get
            {
                var title = Driver.Instance.FindElement(By.Id("title"));
                return title != null ? title.GetAttribute("value") : string.Empty;
            }
        }
        public static void GoTo()
        {
            var menuPosts = Driver.Instance.FindElement(By.Id("menu-posts"));
            menuPosts.Click();

            var addNew = Driver.Instance.FindElement(By.LinkText("Add New"));
            addNew.Click();
        }

        public static CreatePostCommand CreatePost(string title)
        {
            return new CreatePostCommand(title);
        }

        public static void GoToNewPost()
        {
            var message = Driver.Instance.FindElement(By.Id("message"));
            var newPostLink = message.FindElements(By.TagName("a"))[0];
            newPostLink.Click();
        }

        public static bool IsInEditMode()
        {
            return Driver.Instance.FindElements(By.TagName("h1"))[0].Text == "Edit Page";
        }
    }
}