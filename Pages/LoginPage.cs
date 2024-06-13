using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    internal class LoginPage : BasePage
    {
        const string userName = "standard_user";
        const string password = "secret_sauce";

        private static IWebElement userNameField => wait.Until(ExpectedConditions.ElementIsVisible(By.Id("user-name")));
        private static IWebElement passwordField => wait.Until(ExpectedConditions.ElementIsVisible(By.Name("password")));
        private static IWebElement loginButton => wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//input[@id='login-button']")));

        public static void Login()
        {
            userNameField.SendKeys(userName);
            passwordField.SendKeys(password);
            loginButton.Click();
        }
        //private static IWebElement userName =>wait.Until(ExpectedConditions.ElementIsVisible(By.Id("user-name")));
        //private static IWebElement PasswordInput() => Page.GetElement(By.Name("password"));
        //private static IWebElement LoginButton() => Page.GetElement(By.XPath("//input[@id='login-button']"));
        //private static IWebElement PasswordForAll() => Page.GetElement(By.XPath("//*[text()='Password for all users:']"));
        //private static IWebElement LoginLogo() => Page.GetElement(By.CssSelector(".login_logo"));
        //private static IWebElement ErrorMessage() => Page.GetElement(By.CssSelector("h3[data-test='error']"));
        //private static IWebElement We() => Page.GetElement(By.Id("login_credentials"));
    }
}
