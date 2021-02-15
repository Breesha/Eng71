using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootsSeleniumPOM
{
    public class Boots_Website
    {
        public IWebDriver SeleniumDriver { get; internal set; }
        public Boots_HomePage Boots_HomePage { get; internal set; }
        public Boots_SigninPage Boots_SigninPage { get; internal set; }
        public Boots_No7ShopAllPage Boots_No7ShopAllPage { get; internal set; }
        public Boots_Website(string driverName, int pageLoadWaitInSecs = 20, int implicitWaitInSecs = 20)
        {
            SeleniumDriver = new SeleniumDriverConfig(driverName, pageLoadWaitInSecs, implicitWaitInSecs).Driver;

            //Instantiate page objects with the selenium driver
            Boots_HomePage = new Boots_HomePage(SeleniumDriver);
            Boots_SigninPage = new Boots_SigninPage(SeleniumDriver);
            Boots_No7ShopAllPage = new Boots_No7ShopAllPage(SeleniumDriver);
        }

        public void DeleteCookies()
        {
            SeleniumDriver.Manage().Cookies.DeleteAllCookies();
        }
    }
}
