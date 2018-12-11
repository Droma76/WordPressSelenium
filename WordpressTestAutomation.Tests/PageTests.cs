using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WordpressTestAutomation.Tests
{
    public class PageTests
    {
        public PageTests()
        {
            Driver.Initialise();
        }

        [Fact]
        public void CanEditAPage()
        {
            LoginPage.Goto();
            LoginPage
                .LoginAs("selenium_user")
                .WithPassword("q*y12rVMn7NJ8Jjxw@")
                .Login();

            ListPostsPage.GoTo(PostType.Page);
            ListPostsPage.SelectPost("Sample Page");

            Assert.True(NewPostPage.IsInEditMode(), "Isn't in Edit mode");
            Assert.Equal("Sample Page", NewPostPage.Title);
        }

        public void Dispose()
        {
            Driver.Close();
        }
    }
}
