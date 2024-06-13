using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace TestProject2.Factories
{
    internal class Driver
    {
        public static IWebDriver? _driver;

        public static WebDriverWait? _wait;

        public static IWebDriver GetDriver() => _driver ??= SetupDriver();   
        public static WebDriverWait WaitDriver(IWebDriver driver, double waitTime) => _wait ??= new WebDriverWait(driver, TimeSpan.FromSeconds(waitTime));

        //обнуление драйвера
        public static void QuitDriver()
        {
            _driver.Quit();
            _driver = null;
        }
        
        private static IWebDriver SetupDriver() => _driver ??= new ChromeDriver();

        public static IWebElement GetElement(By locator)
        {
            return Driver.WaitDriver(_driver,1000).Until(ExpectedConditions.ElementToBeClickable(locator));
        }

    }
}
