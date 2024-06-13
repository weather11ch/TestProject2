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
        public void CheckOneClickButton()
        {            
            CheckBoxesPage.OpenPage();
            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_5);
            IWebElement inputArea = Driver.GetDriver().FindElement(By.XPath("//*[@class =\"dcg-mq-digit\"]"));
            
            string inputText = inputArea.Text;
            Assert.AreEqual(inputText, "5");
           // Thread.Sleep(5000);
         }
        
        [Test]
        public void CheckSumInput()
        {
            CheckBoxesPage.OpenPage();

            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_5);
            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_plus);
            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_2);
            
            IWebElement inputArea = Driver.GetDriver().FindElement(By.XPath("//*[@class=\"dcg-mq-container\"]"));
            
            string inputText = inputArea.Text;
            Assert.AreEqual(inputText, "5+2");
            // Thread.Sleep(5000);

        }
        [Test]
        public void CheckSumResult()
        {
            CheckBoxesPage.OpenPage();

            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_5);
            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_plus);
            CheckBoxesPage.ClickCheckBox(CheckBoxesPage.button_2);
            
            IWebElement resultArea = Driver.GetDriver().FindElement(By.XPath("//*[@class=\"dcg-exp-output-container\"]"));

            string resultText = resultArea.Text;
            Assert.AreEqual(resultText, "=7");
            // Thread.Sleep(5000);

        }
        [TearDown]
        public void TearDown()
        {

            CheckBoxesPage.ClosePage();
        }
    }
}