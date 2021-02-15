using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    public class AP_HomePage
    {
        //Setting the driver
        private IWebDriver _seleniumDriver;
        //sets the homepage URL
        private string HomePageUrl = AppConfigReader.BaseUrl;
        private IWebElement _signInLink => _seleniumDriver.FindElement(By.LinkText("Sign in"));
        private IWebElement _searchBar => _seleniumDriver.FindElement(By.Id("search_query_top"));
        private IWebElement _searchSubmitButton => _seleniumDriver.FindElement(By.Name("submit_search"));
        private IWebElement _alert => _seleniumDriver.FindElement(By.ClassName("alert"));

        public AP_HomePage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        //Navigates to the homepage - method
        public void VisitHomePage()
        {
            _seleniumDriver.Navigate().GoToUrl(HomePageUrl);
        }

        //Call and click the sign in element
        public void VisitSigninPage()
        {
            _signInLink.Click();
        }

        //Return the title of the page it is currently on
        public string GetPageTitle()
        {
            return _seleniumDriver.Title;
        }

        public void InputSearch(string search)
        {
            _searchBar.SendKeys(search);
        }

        public void ClickSearchSubmit()
        {
            _searchSubmitButton.Click();
        }

        public string GetAlert()
        {
            return _alert.Text;
        }
    }
}
