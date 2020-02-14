using System.Reflection;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using Test.baseClasses;
using Test.browser;
using Test.logging;
using Test.utils;
using TestAutomation.pages;

namespace TestAutomation
{
    [TestClass]
    public class BaseTest : BaseEntity
    {
        public TestContext TestContext { get; set; }

        protected MainPage MainPage;
        
        [TestInitialize]
        public void Setup()
        {
            var driver = Browser.GetDriver();
            FileUtils.CleanDirectory(FileUtils.GetOutputDirectory());
            Browser.OpenBaseUrl();
            MainPage = new MainPage();
        }

        [TestCleanup]
        public void TearDown()
        {
            ScreenShotUtils.TakeScreenshot(TestContext);
            Browser.Quit();
        }
    }
}