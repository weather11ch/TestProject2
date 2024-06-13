using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Factories;

namespace TestProject2.Pages
{
    internal class BasePage
    {
        protected static IWebDriver driver = Driver.GetDriver();
        protected static WebDriverWait wait = Driver.WaitDriver(driver, 30);
        public static void OpenPage()
        {
            driver.Navigate().GoToUrl("https://www.saucedemo.com/");
            
        }
    }
}
