using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Pages;

namespace TestProject2.Tests
{
    internal class SortTest : BaseTest
    {
        [Test]
        public void Sort()
        {
            LoginPage.Login();   
            MainPage.ChangeSortType();
            //var items = MainPage.itemNames;

            bool result = MainPage.IsNameEqual();
            Assert.That(result);
        }
    }
}
