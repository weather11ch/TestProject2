using Microsoft.VisualStudio.TestPlatform.ObjectModel.DataCollection;
using OpenQA.Selenium;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProject2.Pages
{
    internal class MainPage : BasePage
    {
      public static  List<IWebElement> itemNames = driver.FindElements(By.XPath("//*[@class='inventory_item_name ']")).ToList();

       private static List<string> itemNamesText  = new List<string>();

        private static IWebElement filtr = driver.FindElement(By.XPath("//*[@class='product_sort_container']"));
        private static IWebElement sortTypeZA = driver.FindElement(By.XPath("//*[@value='za']"));

        public static void ChangeSortType()
        {
            filtr.Click();
            sortTypeZA.Click();

        }

        private static List<string> GetItemText() 
        { 
            foreach (var item in itemNames)
            {
                itemNamesText.Add(item.Text);
            }
            return itemNamesText;
        }      

        public static bool IsNameEqual()
        {
            var sortedName = GetItemText();
            sortedName.OrderByDescending(x=>x).ToList();

            return sortedName.SequenceEqual(itemNamesText);

        }
       
    }
}
