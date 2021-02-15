using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootsSeleniumPOM
{
    public class SeleniumDriverConfig
    {
        public IWebDriver Driver { get; set; }

        
        public SeleniumDriverConfig(string driver, int pageLoadsInSecs, int implicitWaitInSecs)
        {
            DriverSetUp(driver, pageLoadsInSecs, implicitWaitInSecs);
        }

        private void DriverSetUp(string driverName, int pageLoadsInSecs, int implicitWaitInSecs)
        {
            if (driverName.ToLower() == "chrome")
            {
                SetChromeDriver();
                
                SetDriverConfiguration(pageLoadsInSecs, implicitWaitInSecs);
            }
            else if (driverName.ToLower() == "firefox")
            {
                SetChromeDriver();
                
                SetDriverConfiguration(pageLoadsInSecs, implicitWaitInSecs);
            }
        }

        public void SetFirefoxDriver()
        {
            Driver = new FirefoxDriver();
        }


        private void SetChromeDriver()
        {
            Driver = new ChromeDriver();
            //ChromeOptions options = new ChromeOptions();
            //options.AddArgument("headless");
            ////If running slow you can add these in
        }

        private void SetDriverConfiguration(int pageLoadsInSecs, int implicitWaitInSecs)
        {
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadsInSecs);
            
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
