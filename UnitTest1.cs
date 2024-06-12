using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using TestProject2.Factories;
using TestProject2.Pages;
using OpenQA.Selenium.Chrome;

namespace TestProject2
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
           
            
        }

        [Test]
        public void Test1()
        {

            //Thread.Sleep(5000);
            // public static WebDriverWait GetWait() => _wait ??=  new (_driver, TimeSpan.FromSeconds(20));
            // _wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("//input[@placeholder='First Name']"))).SendKeys("FirstName");
            CheckBoxesPage.OpenPage();
            //  Thread.Sleep(5000);
            //CheckBoxesPage.GetWait();
            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_5);
            //Thread.Sleep(5000);
            IWebElement inputArea = Driver.GetDriver().FindElement(By.XPath("//*[@class =\"dcg-mq-aria-alert\"]"));
            //Assert.AreEqual(inputArea.Text, CheckBoxesPage.button_5);
            //Assert.That(inputArea.Text)
        }
        [TearDown]
        public void TearDown()
        {

            CheckBoxesPage.ClosePage();
        }
    }
}