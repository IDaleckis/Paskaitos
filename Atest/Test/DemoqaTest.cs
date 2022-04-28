using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Atest.Page;

namespace Atest.Test
{
    public class DemoqaTest
    {
        private static IWebDriver _driver;

        [OneTimeSetUp]
        public static void OneTimeSetUp()
        {
            _driver = new ChromeDriver();
            _driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            _driver.Manage().Window.Maximize();

        }

        [OneTimeTearDown]

            public static void OneTimeTearDown()
        {
            _driver.Quit();
        }
        [Test]

        public static void TestFullNameInputField(string expectedResult)
        {
            string fullName = "Ignas";

            DemoqaPage demoqaPage = new DemoqaPage(_driver);

            demoqaPage.NavigateToDefaultPage();
            demoqaPage.InsertTextToFullNameField(fullName);
            demoqaPage.ClickSubmitButton();
            demoqaPage.VerifyFullNameResult(fullName);
        }
    }
}
