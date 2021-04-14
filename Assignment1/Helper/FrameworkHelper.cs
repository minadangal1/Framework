using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.Helper
{
    public enum IdentifierType
    {
        Id,
        Name,
        ClassName,
        CssSelector,
        Xpath,
        TagName,
        LinkText,
        PartialLinkText
    }
   public static  class FrameworkHelper
    {
        private static IWebDriver driver;
        public static WebDriverWait wait;
        public static IWebDriver WebDriver
        {
            get
            {
                return driver;
            }
            set
            {
                driver = value;
            }
        }
        public static IWebElement GetElement(string locator,IdentifierType identifierType)
        {
            IWebElement element = null;
            switch (identifierType)
            {
                case IdentifierType.Id:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                    element = WebDriver.FindElement(By.Id(locator));
                    break;
                case IdentifierType.Name:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));
                    element = WebDriver.FindElement(By.Name(locator));
                    break;
                case IdentifierType.ClassName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));
                    element = WebDriver.FindElement(By.ClassName(locator));
                    break;
                case IdentifierType.CssSelector:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
                    element = WebDriver.FindElement(By.CssSelector(locator));
                    break;
                case IdentifierType.Xpath:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
                    element = WebDriver.FindElement(By.XPath(locator));
                    break;
                case IdentifierType.TagName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));
                    element = WebDriver.FindElement(By.TagName(locator));
                    break;
                case IdentifierType.LinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
                    element = WebDriver.FindElement(By.LinkText(locator));
                    break;
                case IdentifierType.PartialLinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
                    element = WebDriver.FindElement(By.PartialLinkText(locator));
                    break;
               
            }
            return element;

        }
        public static IReadOnlyCollection<IWebElement> Getelements(string locator, IdentifierType identifierType)
        {

            IReadOnlyCollection<IWebElement> elements = null;
            switch (identifierType)
            {
                case IdentifierType.Id:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Id(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));
                    break;
                case IdentifierType.Name:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.Name(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));


                    break;
                case IdentifierType.ClassName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.ClassName(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));


                    break;
                case IdentifierType.CssSelector:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.CssSelector(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));

                    break;
                case IdentifierType.Xpath:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.XPath(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));


                    break;
                case IdentifierType.TagName:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.TagName(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));


                    break;
                case IdentifierType.LinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.LinkText(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));


                    break;
                case IdentifierType.PartialLinkText:
                    wait.Until(ExpectedConditions.ElementIsVisible(By.PartialLinkText(locator)));
                    elements = WebDriver.FindElements(By.Id(locator));


                    break;
              
            }
            return elements;
        }
        public static void SetTest(string text, string locator,IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            element.SendKeys(text);
        }
        public static string GetText(string text ,string locator,IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            return text;
        }
        public static void ClickElement(string locator,IdentifierType identifierType)
        {
            IWebElement element = GetElement(locator, identifierType);
            element.Click();
        }
        
    }
}
