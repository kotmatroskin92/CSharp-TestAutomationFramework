using OpenQA.Selenium;
using Test.browser;
using Test.logging;

namespace Test.baseClasses
{
    public class BaseEntity
    {
        protected static readonly IWebDriver Driver = Browser.GetDriver();
        protected static readonly Logg Log = Logg.GetInstance();
        
    }
}