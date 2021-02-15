using NUnit.Framework;
using System.Threading;

namespace BootsSeleniumPOM
{
    public class Boots_No7ShopAll_Tests
    {

        public Boots_Website Boots_Website { get; } = new Boots_Website("Chrome");


        [Test]
        public void GivenIAmOnTheNo7AllPage_WhenNoFiltersAreApplied_ThenTheTotalProductsIs272()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.TotalProductNumber();
            Thread.Sleep(5000);

            Assert.That(Boots_Website.Boots_No7ShopAllPage.TotalProductNumber, Does.Contain("272"));
        }

        [Test]
        public void GivenIAmOnTheNo7AllPage_WhenIClickViewAllProductType_ThenTheListExpands()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.ClickProductType();
            Thread.Sleep(5000);
            Boots_Website.Boots_No7ShopAllPage.ClickViewAllProductType();
            Thread.Sleep(2000);

            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle, Does.Contain("No7 | Shop all - Boots"));
        }

        [Test]
        public void GivenIAmOnTheNo7AllPage_AndIHaveClickedProductTypeTab_WhenIClickEyeCream_ThenTheProductsChange()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.ClickViewAllProductType();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.ClickEyeCream();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.TotalProductNumber();
            Thread.Sleep(5000);

            Assert.That(Boots_Website.Boots_No7ShopAllPage.TotalProductNumber, Does.Contain("8"));
        }

        [Test]
        public void GivenIAmOnTheNo7AllPage_AndIHaveClickedPriceTab_WhenIClickBetween10And15_ThenTheProductsChange()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.ClickPrice10To15();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.TotalProductNumber();
            Thread.Sleep(5000);

            Assert.That(Boots_Website.Boots_No7ShopAllPage.TotalProductNumber, Does.Contain("134"));
        }

        [Test]
        public void GivenIAmOnTheNo7AllPage_WhenIClickTheSortByDropDown_ThenTheDropdownOptionsAppear()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.SelectSortDropDown();
            Thread.Sleep(5000);

            Assert.That(Boots_Website.Boots_No7ShopAllPage.TotalProductNumber, Does.Contain("272"));
        }

        [Test]
        public void GivenIAmOnTheNo7AllPage_WhenIClickTheSortByDropDown_AndISelectLowToHigh_ThenTheDropdownOptionChangesToLowToHigh()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.SelectSortDropDown();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.SelectSortLowToHigh();
            Thread.Sleep(2000);

            Assert.That(Boots_Website.Boots_No7ShopAllPage.TotalProductNumber, Does.Contain("272"));
        }

        [Test]
        public void GivenIAmOnTheNo7AllPage_WhenIClickTheViewDropDown_AndISelectView180_ThenTheDropdownOptionIs180()
        {
            Boots_Website.Boots_No7ShopAllPage.VisitNo7ShopAllPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.ClickViewDropdown();
            Thread.Sleep(2000);
            Boots_Website.Boots_No7ShopAllPage.SelectView180();
            Thread.Sleep(2000);

            Assert.That(Boots_Website.Boots_No7ShopAllPage.ProductViewRange, Does.Contain("1 - 180"));
        }



        [OneTimeTearDown]
        public void Cleanup()
        {
            //Quit this driver, closing every assocciated window
            Boots_Website.SeleniumDriver.Quit();
            Boots_Website.SeleniumDriver.Dispose();

        }
    }
}
