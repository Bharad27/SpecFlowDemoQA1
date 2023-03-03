
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class WebTable
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public WebTable(IWebDriver webDriver)
        {
            webDriver = webDriver;
        }

        public IWebElement webtable => webDriver.FindElement(By.XPath("//span[text()='Web Tables']"));
        public IWebElement webTablesAddButton => webDriver.FindElement(By.Id("addNewRecordButton"));
        public IWebElement webTablesSearchBox => webDriver.FindElement(By.ClassName("form-control"));
        public IWebElement webTablesTableBody => webDriver.FindElement(By.ClassName("rt-tbody"));
        public IWebElement webTablesField => webDriver.FindElement(By.ClassName("rt-td"));
        public IWebElement webTablesFirstName => webDriver.FindElement(By.Id("firstName"));
        public IWebElement webTablesLastName => webDriver.FindElement(By.Id("lastName"));
        public IWebElement webTablesEmail => webDriver.FindElement(By.Id("userEmail"));
        public IWebElement webTablesAge => webDriver.FindElement(By.Id("age"));
        public IWebElement webTablesSalary => webDriver.FindElement(By.Id("salary"));
        public IWebElement webTablesDepartment => webDriver.FindElement(By.Id("department"));
        public IWebElement webTablesSubmitButton => webDriver.FindElement(By.Id("submit"));
        public IWebElement webTablesEditRecord1 => webDriver.FindElement(By.Id("edit-record-1"));
        public IWebElement webTablesEditRecord2 => webDriver.FindElement(By.Id("edit-record-2"));
        public IWebElement webTablesEditRecord3 => webDriver.FindElement(By.Id("edit-record-3"));
        public IWebElement webTablesDeleteRecord1 => webDriver.FindElement(By.Id("delete-record-1"));
        public IWebElement webTablesDeleteRecord2 => webDriver.FindElement(By.Id("delete-record-2"));
        public IWebElement webTablesDeleteRecord3 => webDriver.FindElement(By.Id("delete-record-3"));
        public IWebElement webTablesJumpPage => webDriver.FindElement(By.ClassName("-pageJump"));
        public IWebElement webTablesRows => webDriver.FindElement(By.XPath("/html/body/div[2]/div/div/div[2]/div[2]/div[2]/div[3]/div[2]/div/div[2]/span[2]/select"));

        public void CLickWebtable() => webtable.Click();

        public ArrayList fields()
        {
            ArrayList allFields = new ArrayList(webDriver.FindElements((By)webTablesField));
            return allFields;
        }
        public WebElement getWebTablesAddButton()
        {
            return (WebElement)webDriver.FindElement((By)webTablesAddButton);
        }

        public void webTablesAddRecordFill()
        {
            getWebTablesAddButton().Click();
        }

        public WebElement getWebTablesSearchBox()
        {
            return (WebElement)webDriver.FindElement((By)webTablesSearchBox);
        }

        public String getWebtablesTableBodyText()
        {
            return webDriver.FindElement((By)webTablesTableBody).Text;
        }
        public WebElement getWebTablesUsername()
        {
            return (WebElement)webDriver.FindElement((By)webTablesFirstName);
        }
        public void webTablesSearch(String s)
        {
            webDriver.FindElement((By)webTablesSearchBox).SendKeys(s);
        }

        public void webTablesFillUserName(String a)
        {
            webDriver.FindElement((By)webTablesFirstName).SendKeys(a);
        }

        public void webTablesFillLastName(String b)
        {
            webDriver.FindElement((By)webTablesLastName).SendKeys(b);
        }

        public void webTablesFillEmail(String c)
        {
            webDriver.FindElement((By)webTablesEmail).SendKeys(c);
        }

        public void webTablesFillAge(String d)
        {
            webDriver.FindElement((By)webTablesAge).SendKeys(d);
        }

        public void webTablesFillSalary(String e)
        {
            webDriver.FindElement((By)webTablesSalary).SendKeys(e);
        }

        public void webTablesFillDepartment(String f)
        {
            webDriver.FindElement((By)webTablesDepartment).SendKeys(f);
        }

        public void webTablesSubmitForm()
        {
            webDriver.FindElement((By)webTablesSubmitButton).Click();
        }

        public WebElement getWebTablesDeleteRecord1()
        {
            return (WebElement)webDriver.FindElement((By)webTablesDeleteRecord1);
        }

        public void webTablesDeleteRecordOne()
        {
            getWebTablesDeleteRecord1().Click();
        }

        public WebElement getWebTablesEditRecord1()
        {
            return (WebElement)webDriver.FindElement((By)webTablesEditRecord1);
        }

        public void webTablesEditRecordOne()
        {
            getWebTablesEditRecord1().Click();
        }

        public void WebTablesJumpPage(String i)
        {
            webDriver.FindElement((By)webTablesJumpPage).Clear();
            webDriver.FindElement((By)webTablesJumpPage).SendKeys("i");
        }

        public void webTablesDropdownMenu(int i)
        {
            SelectElement select = new SelectElement(webDriver.FindElement((By)webTablesRows));
            select.SelectByIndex(i);
        }
    }
}
