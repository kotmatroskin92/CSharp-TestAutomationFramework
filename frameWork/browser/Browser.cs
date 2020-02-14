using OpenQA.Selenium;
using Test.logging;
using Test.utils;

namespace Test.browser
{
    //расширение классов
    public static class Browser
    {
        private static IWebDriver _driver;
        private static readonly Logg Log = Logg.GetInstance();

        public static IWebDriver GetDriver()
        {
            return _driver ??= BrowserFactory.InitDriver(JsonReader.GetBrowser());
        }

        public static void Quit()
        {
            if (_driver == null) return;
            _driver.Quit();
            _driver = null;
        }

        public static string GetCurrentUrl(this IWebDriver driver)
        {
            return driver.Url;
        }
        
        public static void OpenBaseUrl()
        {
            Log.Debug("browser");
            _driver.Url = JsonReader.GetBaseUrl();
        }

        public static void WaitForPageLoaded()
        {
            SmartWait.WaitFor(_driver,
                b => ((IJavaScriptExecutor)b).ExecuteScript("return document.readyState").Equals("complete"),
                JsonReader.GetPageLoadTimeOutInSeconds());
        }

        public static void RefreshPage()
        {
            _driver.Navigate().Refresh();
        }

        public static int GetWindowSize()
        {
            return _driver.Manage().Window.Size.Height;
        }

        public static void ScrollToElement(IWebElement webElement)
        {
            var jse = (IJavaScriptExecutor) _driver;
            jse.ExecuteScript("arguments[0].scrollIntoView(true)", webElement);
        }

        public static void ScrollToMiddle()
        {
            var jse = (IJavaScriptExecutor) _driver;
            jse.ExecuteScript($"window.scrollBy(0, {GetWindowSize() / 2})");
        }
    }
}