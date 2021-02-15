using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace BootsSeleniumPOM
{
    [Binding]
    public class Boots_No7Steps
    {
        public Boots_Website Boots_Website { get; } = new Boots_Website("Chrome");

        [Given(@"I am on the No7 page")]
        public void GivenIAmOnTheNo7Page()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(2000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
        }
        
        [When(@"no filters are applied")]
        public void WhenNoFiltersAreApplied() { }


        [When(@"the product type tab is clicked")]
        public void WhenTheProductTypeTabIsClicked()
        {
            Boots_Website.Boots_No7ShopAllPage.ClickProductType();
        }

        [When(@"the eyecream filter is clicked")]
        public void WhenTheEyecreamFilterIsClicked()
        {
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.ClickEyeCream();
        }

        [When(@"the price category between £10 and £15 is clicked")]
        public void WhenThePriceCategoryBetweenAndIsClicked()
        {
            Boots_Website.Boots_No7ShopAllPage.ClickPrice10To15();
        }

        [When(@"the sort by dropdown is clicked")]
        public void WhenTheSortByDropdownIsClicked()
        {
            Boots_Website.Boots_No7ShopAllPage.SelectSortDropDown();
        }

        [When(@"the sort by price low to high is selected")]
        public void WhenTheSortByPriceLowToHighIsSelected()
        {
            Boots_Website.Boots_No7ShopAllPage.SelectSortLowToHigh();
        }

        [When(@"the view amount dropdown is clicked")]
        public void WhenTheViewAmountDropdownIsClicked()
        {
            Boots_Website.Boots_No7ShopAllPage.ClickViewDropdown();
        }

        [When(@"the view 180 is selected")]
        public void WhenTheView180IsSelected()
        {
            Boots_Website.Boots_No7ShopAllPage.SelectView180();
        }

        [Then(@"the total product number showing is ""(.*)""")]
        public void ThenTheTotalProductNumberShowingIs(string expected)
        {
            Thread.Sleep(5000);
            Assert.That(Boots_Website.Boots_No7ShopAllPage.ProductViewRange, Does.Contain(expected));
        }



        [Then(@"the total product number is (.*)")]
        public void ThenTheTotalProductNumberIs(int expected)
        {
            Thread.Sleep(2000);
            Assert.That(Boots_Website.Boots_No7ShopAllPage.TotalProductNumber, Does.Contain(expected.ToString())); ;
        }

        [AfterScenario]
        public void DisposeWebDriver()
        {
            //Quit this driver, closing every assocciated window
            Boots_Website.SeleniumDriver.Quit();
            Boots_Website.SeleniumDriver.Dispose();
        }
    }
}
