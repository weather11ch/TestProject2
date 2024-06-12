using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Factories;

namespace TestProject2.Pages
{
    internal static class CheckBoxesPage
    {
        private static IWebDriver driver;
        private static WebDriverWait wait;
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://www.desmos.com/scientific?lang=ru");
            Driver.WaitDriver(Driver.GetDriver(), 30);    
        }

       public static IWebElement button_5 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"5\"]"));
        public static IWebElement button_1 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"1\"]"));
        public static IWebElement button_2 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"2\"]"));
        public static IWebElement button_3 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"3\"]"));
        public static IWebElement button_4 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"4\"]"));
        public static IWebElement button_8 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"8\"]"));
        public static IWebElement button_6 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"6\"]"));
        public static IWebElement button_7 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"7\"]"));
        public static IWebElement button_9 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"9\"]"));
        public static IWebElement button_0 = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"0\"]"));
        public static IWebElement button_plus = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"Плюс\"]"));
        public static IWebElement button_enter = Driver.GetDriver().FindElement(By.XPath("//*[@aria-label=\"ВВод\"]"));


        //WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));
        //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label=\"5\"]")));

        public static void ClickCheckBox(IWebElement button)
        {
            button.Click();
            Driver.WaitDriver(Driver.GetDriver(), 30);
        }
        public static void ClickCheckBox()
        {
            button_5.Click();
            Driver.WaitDriver(Driver.GetDriver(), 30);
        }

        public static void GetWait()
        {
            wait = Driver.WaitDriver(driver, 30);
            //wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//*[@aria-label=\"5\"]")));
        }
        public static IWebElement GetElement(By locator)
        {
            return Driver.WaitDriver(driver,20).Until(ExpectedConditions.ElementToBeClickable(locator));
        }
        

        public static void ClosePage()
        {
            Driver.GetDriver().Dispose();
        }
    }
}
