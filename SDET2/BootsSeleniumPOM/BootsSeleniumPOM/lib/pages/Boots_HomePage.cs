using OpenQA.Selenium;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace BootsSeleniumPOM
{
    public class Boots_HomePage
    {
        private IWebDriver _seleniumDriver;

        private string HomePageUrl = AppConfigReader.BaseUrl;
        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Log in/register"));
        private IWebElement _shippingClose => _seleniumDriver.FindElement(By.CssSelector("#shipToOverlay > div > a"));
        private IWebElement _acceptCookies => _seleniumDriver.FindElement(By.CssSelector("body > div.optanon-alert-box-wrapper > div.optanon-alert-box-bg > div.optanon-alert-box-button-container > div.optanon-alert-box-button.optanon-button-allow > div > button"));
        private IWebElement _no7dropdown => _seleniumDriver.FindElement(By.LinkText("No7"));
        private IWebElement _shopAll => _seleniumDriver.FindElement(By.LinkText("shop all"));

        public Boots_HomePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitHomePage()
        {
            _seleniumDriver.Navigate().GoToUrl(HomePageUrl);
        }

        public void ClickAcceptCookies()
        {
            _acceptCookies.Click();
        }

        public void ClickShippingClose()
        {
            _shippingClose.Click();
        }

        public void VisitHomePageWithoutPopups()
        {
            _seleniumDriver.Navigate().GoToUrl(HomePageUrl);
            Thread.Sleep(2000);
            _acceptCookies.Click();
            Thread.Sleep(2000);
            _shippingClose.Click();

        }

        //Call and click the sign in element
        public void VisitSigninPage()
        {
            _signInLink.Click();
        }

        public string GetPageTitle()
        {
            return _seleniumDriver.Title;
        }

        public void ClickNo7()
        {
            _no7dropdown.Click();
        }

        public void ClickNo7ShopAll()
        {
            _no7dropdown.Click();
            Thread.Sleep(2000);
            _shopAll.Click();
        }
    }
}
