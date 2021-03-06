using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atest.Page
{
    public class DemoqaPage
    {
        private static IWebDriver _driver;
        private static IWebElement _fullNameInput => _driver.FindElement(By.Id("userName"));
        private static IWebElement _submitButton => _driver.FindElement(By.Id("userName"));
        private static IWebElement _nameResult = _driver.FindElement(By.Id("name"));
        private static IWebElement _popUp => _driver.FindElement(By.Id("close-fixedban"));

        public DemoqaPage(IWebDriver webDriver)
            {
                _driver = webDriver;
            }
        public void NavigateToDefaultPage()
        {
            _driver.Url = "https://demoqa.com/text-box";
        }
        public void ClosePopUp()
        {
            WebDriverWait wait = new WebDriverWait(_driver, TimeSpan.FromSeconds(10));
            wait.Until(d => _popUp.Displayed);
            _popUp.Click();
        }
        public void InsertTextToFullNameField(string fullName)
        {
            _fullNameInput.Clear();
            _fullNameInput.SendKeys(fullName);
        }
        public void ClickSubmitButton()
        {
            _submitButton.Click();
        }
        public void VerifyFullNameResult(string expectedResult)
        {
            Assert.AreEqual($"Name:{expectedResult}", _nameResult.Text, "Name is wrong!");
        }

    }
}
