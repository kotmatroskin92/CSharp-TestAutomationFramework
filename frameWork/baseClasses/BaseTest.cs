using Microsoft.VisualStudio.TestTools.UnitTesting;
using Test.baseClasses;
using Test.browser;
using Test.utils;

namespace TestAutomation
{
    [TestClass]
    public class BaseTest : BaseEntity
    {
        public TestContext TestContext { get; set; }

        
        [TestInitialize]
        public void Setup()
        {
            var driver = Browser.GetDriver();
            FileUtils.CleanDirectory(FileUtils.GetOutputDirectory());
            Browser.OpenBaseUrl();
        }

        [TestCleanup]
        public void TearDown()
        {
            ScreenShotUtils.TakeScreenshot(TestContext);
            Browser.Quit();
        }
    }
}