using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpecFlowDemQA.Specs.Hooks
{
    public class DatePicker
    {
        public IWebDriver webDriver { get; }
        public IWebDriver WebDriver { get; }
        public DatePicker(IWebDriver webDriver)
        {
            WebDriver = webDriver;
        }

        public IWebElement datepicker => WebDriver.FindElement(By.XPath("//span[text()='Date Picker"));
        public IWebElement date => WebDriver.FindElement(By.Id("datePickerMonthYearInput"));
        public IWebElement dateAndTime => WebDriver.FindElement(By.Id("dateAndTimePickerInput"));

        public void clickDatePicker() => datepicker.Click();
        public void selectDate(String enterDate)
        {
            date.SendKeys(enterDate);
        }

        public void enterDateAndTime(String enterDateTime)
        {
            dateAndTime.SendKeys(enterDateTime);
        }
    }
}
