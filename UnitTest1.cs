using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using TestProject2.Factories;
using TestProject2.Pages;
using OpenQA.Selenium.Chrome;
using SeleniumExtras;

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
            
              //Thread.Sleep(50000);

            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_5);
            //Thread.Sleep(5000);
            IWebElement inputArea = Driver.GetDriver().FindElement(By.XPath("//*[@class =\"dcg-mq-digit\"]"));
            
            string inputText = inputArea.Text;
            Assert.AreEqual(inputText, "5");
           // Thread.Sleep(5000);
           
        }
        [TearDown]
        public void TearDown()
        {

            CheckBoxesPage.ClosePage();
        }
    }
}