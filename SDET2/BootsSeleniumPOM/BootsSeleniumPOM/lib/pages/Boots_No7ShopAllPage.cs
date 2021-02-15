using OpenQA.Selenium;
using System.Threading;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootsSeleniumPOM
{
    public class Boots_No7ShopAllPage
    {
        private IWebDriver _seleniumDriver;

        private string No7ShopAllUrl = AppConfigReader.No7ShopAllUrl;

        public Boots_No7ShopAllPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitNo7ShopAllPage()
        {
            _seleniumDriver.Navigate().GoToUrl(No7ShopAllUrl);
        }



    }
}
