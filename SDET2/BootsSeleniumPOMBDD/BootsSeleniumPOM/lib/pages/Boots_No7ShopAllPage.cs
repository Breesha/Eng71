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
    public class Boots_No7ShopAllPage
    {
        private IWebDriver _seleniumDriver;

        private string No7ShopAllUrl = AppConfigReader.No7ShopAllUrl;
        private IWebElement _productTypeTab => _seleniumDriver.FindElement(By.Id("section_button_ads_f24505_ntk_cs_4_3074457345618264155_3074457345619374529"));
        private IWebElement _priceTypeTab => _seleniumDriver.FindElement(By.Id("section_button_19_4_3074457345618264155_3074457345619374529"));
        private IWebElement _viewAllProductType => _seleniumDriver.FindElement(By.Id("showMoreLabel_ads_f24505_ntk_cs"));
        private IWebElement _eyeCreamTab => _seleniumDriver.FindElement(By.Id("facetLabel_-7000000000000135605101121101329911410197109"));
        private IWebElement _price10_15Tab => _seleniumDriver.FindElement(By.Id("facetLabel_11211410599101957166805840123494832495312532494832495341"));
        private IWebElement _productTotal => _seleniumDriver.FindElement(By.CssSelector("#estores_product_listing_widget > div.header_bar > div.showing_products > span.showing_products_total"));
        private IWebElement _showingViewRange => _seleniumDriver.FindElement(By.CssSelector("#estores_product_listing_widget > div.header_bar > div.showing_products > span.showing_products_current_range"));
        private IWebElement _sortByDropdown => _seleniumDriver.FindElement(By.CssSelector("#orderBy_6_3074457345618283155_3074457345619374528 .dijitRight"));
        private IWebElement _viewDropdown => _seleniumDriver.FindElement(By.CssSelector("#pageSize_6_3074457345618283155_3074457345619374528 .dijitStretch > .dijitInputField"));
        private IWebElement _sortPriceLowToHigh => _seleniumDriver.FindElement(By.Id("dijit_MenuItem_1"));
        private IWebElement _view180Select => _seleniumDriver.FindElement(By.Id("dijit_MenuItem_2_text"));


        public Boots_No7ShopAllPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitNo7ShopAllPage()
        {
            _seleniumDriver.Navigate().GoToUrl(No7ShopAllUrl);
        }

        public void ClickProductType()
        {
            _productTypeTab.Click();
        }

        public void ClickPriceType()
        {
            _priceTypeTab.Click();
        }

        public void ClickViewAllProductType()
        {
            _productTypeTab.Click();
            Thread.Sleep(5000);
            _viewAllProductType.Click();
        }

        public void ClickEyeCream()
        {
            _eyeCreamTab.Click();
        }

        public void ClickPrice10To15()
        {
            _price10_15Tab.Click();
        }

        public void ClickViewDropdown()
        {
            _viewDropdown.Click();
        }

        public string TotalProductNumber()
        {
            return _productTotal.Text;
        }

        public string ProductViewRange()
        {
            return _showingViewRange.Text;
        }

        public void SelectSortDropDown()
        {
            _sortByDropdown.Click();
        }

        public void SelectSortLowToHigh()
        {
            _sortPriceLowToHigh.Click();
        }

        public void SelectView180()
        {
            _view180Select.Click();
        }


    }
}
