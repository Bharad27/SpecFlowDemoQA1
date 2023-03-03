using System;
using System.Collections.Generic;
using System.Text;
using OpenQA.Selenium;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class TextBox
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public TextBox(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }
        public IWebElement Elements => WebDriver.FindElement(By.XPath("//h5[text()='Elements']"));
        public IWebElement Textbox => WebDriver.FindElement(By.XPath("//span[text()='Text Box']"));
        public IWebElement FullName => WebDriver.FindElement(By.Id("userName"));
        public IWebElement Email => WebDriver.FindElement(By.Id("userEmail"));
        public IWebElement CurrentAddr => WebDriver.FindElement(By.Id("currentAddress"));
        public IWebElement PermanentAddr => WebDriver.FindElement(By.Id("permanentAddress"));
        public IWebElement Submit => WebDriver.FindElement(By.Id("submit"));
        public IWebElement name => WebDriver.FindElement(By.Id("name"));
        public IWebElement mail => WebDriver.FindElement(By.Id("email"));
        public IWebElement CurrentAddress => WebDriver.FindElement(By.Id("currentAddress"));
        public IWebElement PermanentAddress => WebDriver.FindElement(By.Id("permanentAddress"));
        public IWebElement Output => WebDriver.FindElement(By.XPath("//div[@id='output']"));

        public void ClickElements() => Elements.Click();
        public void ClickTextBox() => Textbox.Click();
        public void ClickSubmit() => Submit.Click();
        public bool isOutputExist() => Output.Displayed;
        public bool isFullNameExist() => name.Displayed;
        public bool isEmailExist() => mail.Displayed;
        public bool isCurrentAddrExist() => CurrentAddress.Displayed;
        public bool isPermanentAddrExist() => PermanentAddress.Displayed;

    }
}
