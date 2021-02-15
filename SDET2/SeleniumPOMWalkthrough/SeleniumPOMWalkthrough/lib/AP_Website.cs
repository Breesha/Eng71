using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    //Super class = the service object for all pages (ie. decompose business objects into more manageable classes and methods
    public class AP_Website
    {
        //accessible page object
        public IWebDriver SeleniumDriver { get; internal set; }
        public AP_HomePage AP_HomePage { get; internal set; }
        public AP_SigninPage AP_SigninPage { get; internal set; }
        public AP_Website(string driverName, int pageLoadWaitInSecs = 10, int implicitWaitInSecs=10)
        {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;

            //Instantiate page objects with the selenium driver
            AP_HomePage = new AP_HomePage(SeleniumDriver);
            AP_SigninPage = new AP_SigninPage(SeleniumDriver);
        }

        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
