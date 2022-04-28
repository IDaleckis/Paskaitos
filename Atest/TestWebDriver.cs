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
    public class TestWebDriver
    {
        [Test]

        public static void TestChromeDriver()
         
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://login.yahoo.com";

            driver.Quit();
        }
    }
}
