using OpenQA.Selenium;
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
        public static void OpenPage()
        {
            Driver.GetDriver().Navigate().GoToUrl("https://the-internet.herokuapp.com/checkboxes");
        }

       public static IWebElement checkBox1 = Driver.GetDriver().FindElement(By.XPath("//*[@id=\"checkboxes\"]//input[1]"));

       public static void ClickCheckBox()
        {
            checkBox1.Click();
        }
        public static void ClosePage()
        {
            Driver.GetDriver().Dispose();
        }
    }
}
