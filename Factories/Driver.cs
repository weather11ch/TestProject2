using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using Microsoft.VisualStudio.TestPlatform.ObjectModel;
using SeleniumExtras.WaitHelpers;

namespace TestProject2.Factories
{
    internal class Driver
    {
        public static IWebDriver? _driver;

        public static WebDriverWait? _wait;

        public static IWebDriver GetDriver() => _driver ??= SetupDriver();   
        public static WebDriverWait WaitDriver(IWebDriver driver, double waitTime) => _wait ??= new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));
        
        private static IWebDriver SetupDriver() => _driver ??= new ChromeDriver();

        public static IWebElement GetElement(By locator)
        {
            return Driver.WaitDriver(_driver,30).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

        //driver = new RemoteWebDriver(new Uri($"https://{LT_USERNAME}:{LT_ACCESS_KEY}{gridURL}"), desiredCapabilities, TimeSpan.FromSeconds(600));



        //internal class WebDriverWait
        //{
        //    public static IWebDriver _driver;

        //    public static IWebDriver _wait;
        //    public WebDriverWait(IWebDriver driver) { }

        //    public static GetWebDriverWait()
        //    {
        //        if (_driver == null)
        //        {
        //            WebDriverWait();
        //        }
        //        return _driver;
        //    }
        //    public static WebDriverWait GetWebDriverWait() => _driver ??= new(_driver, TimeSpan.FromSeconds(20));
        //    public WebDriverWait(IWebDriver driver)
        //    {
        //        _driver = driver;
        //        _wait = Driver.GetWebDriverWait(_driver, 30);
        //    }
        //    public static WebDriverWait GetWait() => _wait ??= new(_driver, TimeSpan.FromSeconds(20));
        //}




    }
}
