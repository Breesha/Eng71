using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    public class SeleniumDriverConfig
    {
        //Property for the driver for later use
        public IWebDriver Driver { get; set; }

        //Constructor that calls a method to set up the driver depending on the type of browser we want
        public SeleniumDriverConfig(string driver, int pageLoadsInSecs, int implicitWaitInSecs)
        {
            //Method that set ups the driver, we can pass in the driver type
            DriverSetUp(driver, pageLoadsInSecs, implicitWaitInSecs);
        }

        //This method will trigger another method that set the driver configuration depending on the browser type
        private void DriverSetUp(string driverName, int pageLoadsInSecs, int implicitWaitInSecs)
        {
            if (driverName.ToLower()=="chrome")
            {
                //This method create the new driver instance that we can use in our testing
                SetChromeDriver();
                //Method will set the config of the driver (pageload time and implicit wait)
                SetDriverConfiguration(pageLoadsInSecs, implicitWaitInSecs);
            }
            else if (driverName.ToLower()=="firefox")
            {
                //This method create the new driver instance that we can use in our testing
                SetChromeDriver();
                //Method will set the config of the driver (pageload time and implicit wait)
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
            //Time driver will wait for page to load
            Driver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(pageLoadsInSecs);
            //Time driver waits for element before the test fails
            Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(implicitWaitInSecs);
        }
    }
}
