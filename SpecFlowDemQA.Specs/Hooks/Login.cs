using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class Login
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public Login(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement BookStoreApplication => webDriver.FindElement(By.XPath("//div[text()='Book Store Application']"));
        public IWebElement login => webDriver.FindElement(By.XPath("//span[text()='Login']"));
        public IWebElement bookStoreUserNameField => webDriver.FindElement(By.Id("userName"));
        public IWebElement bookStorePasswordField => webDriver.FindElement(By.Id("password"));
        public IWebElement bookStoreLoginButton => webDriver.FindElement(By.Id("login"));

        public void clickBookStoreApplication() => BookStoreApplication.Click();
        public void ClickLogin() => login.Click();
        public WebElement getBookStoreUserName()
        {
            return (WebElement)webDriver.FindElement((By)bookStoreUserNameField);
        }

        public WebElement getBookStorePassword()
        {
            return (WebElement)webDriver.FindElement((By)bookStorePasswordField);
        }

        public WebElement getBookStoreLoginButton()
        {
            return (WebElement)webDriver.FindElement((By)bookStoreLoginButton);
        }

        public void bookStoreUserNameFill(String a)
        {
            getBookStoreUserName().SendKeys(a);
        }

        public void bookStorePasswordFill(String b)
        {
            getBookStorePassword().SendKeys(b);
        }

        public void bookStoreSubmitButtonClick()
        {
            getBookStoreLoginButton().Click();
        }

    }
}
