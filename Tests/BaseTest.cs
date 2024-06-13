using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestProject2.Factories;
using TestProject2.Pages;

namespace TestProject2.Tests
{
    internal class BaseTest
    {
        [SetUp]
        public void SetUp() 
        {
            BasePage.OpenPage();
        }
        [TearDown]
        public void TearDown()
        {
            Driver.QuitDriver();
        }
    }
}
