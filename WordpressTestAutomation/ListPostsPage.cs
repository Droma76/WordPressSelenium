﻿using OpenQA.Selenium;
using System;

namespace WordpressTestAutomation
{
    public class ListPostsPage
    {
        public static void GoTo(PostType postType)
        {
            switch (postType)
            {
                case PostType.Page:
                    Driver.Instance.FindElement(By.Id("menu-pages")).Click();
                    //Driver.Instance.FindElement(By.LinkText("All ")).Click();
                    break;
            }
        }

        public static void SelectPost(string title)
        {
            var postLink = Driver.Instance.FindElement(By.LinkText("Sample Page"));
            postLink.Click();
        }
    }
}