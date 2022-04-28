using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atest
{
    public class DemoqaTextbox
    {
        [Test]
        public static void TestInputPage()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            IWebElement FullNameInput = driver.FindElement(By.Id("userName"));
            FullNameInput.SendKeys("Ignas D.");
            IWebElement submitbutton = driver.FindElement(By.Id("submit"));
            submitbutton.Click();


            //driver.Quit();
        }
    }
}
