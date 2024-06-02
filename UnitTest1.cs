using TestProject2.Factories;
using TestProject2.Pages;

namespace TestProject2
{
    public class Tests
    {

        [SetUp]
        public void Setup()
        {
            CheckBoxesPage.OpenPage();
        }

        [Test]
        public void Test1()
        {
            CheckBoxesPage.ClickCheckBox();
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {

            CheckBoxesPage.ClosePage();
        }
    }
}