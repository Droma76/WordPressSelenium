using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace WordpressTestAutomation.Tests
{
    public class CreatePostTests : IDisposable
    {
        public CreatePostTests()
        {
            Driver.Initialise();
        }

        [Fact]
        public void CanCreateABasicPost()
        {
            LoginPage.Goto();
            LoginPage
                .LoginAs("selenium_user")
                .WithPassword("q*y12rVMn7NJ8Jjxw@")
                .Login();

            NewPostPage.GoTo();
            NewPostPage
                .CreatePost("This is a test post title")
                .WithBody("Hi, this is the body")
                .Publish();

            NewPostPage.GoToNewPost();

            Assert.Equal("This is a test post title", PostPage.Title);
            // Assert.Equal(PostPage.Body, "Hi, this is the body");
        }

        public void Dispose()
        {
            Driver.Close();
        }
    }
}
