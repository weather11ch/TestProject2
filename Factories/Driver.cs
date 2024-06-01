using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Chrome;

namespace TestProject2.Factories
{
    internal class Driver
    {
        private static IWebDriver _driver;
              

        public static IWebDriver GetDriver()
        {
            if (_driver == null)
            {
                SetupDriver();
            }
            return _driver;
        }

        private static IWebDriver SetupDriver() => _driver ??= new ChromeDriver();


    }
}
