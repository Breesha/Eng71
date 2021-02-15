using NUnit.Framework;
using System.Threading;

namespace BootsSeleniumPOM
{
    public class Boots_HomePage_Tests
    {

        public Boots_Website Boots_Website { get; } = new Boots_Website("Chrome");


        [Test]
        public void GivenIAmOnTheHomepage_WhenIClickTheCookiesButton_ThenTheMessageShouldDisappear()
        {
            Boots_Website.Boots_HomePage.VisitHomePage();
            Thread.Sleep(7000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();

            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle(), Does.Contain("Beauty | Health | Pharmacy and Prescriptions - Boots"));
        }
        [Test]
        public void GivenIAmOnTheHomepage_WhenIClickTheCloseShippingButton_ThenIShouldLandOnTheHomePageWithoutPopups()
        {
            Boots_Website.Boots_HomePage.VisitHomePage();
            Thread.Sleep(2000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_HomePage.ClickShippingClose();
            
            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle(), Does.Contain("Beauty | Health | Pharmacy and Prescriptions - Boots"));
        }

        [Test]
        public void GivenIAmOnTheHomepage_WhenIClickTheSigninButton_ThenIShouldLandOnTheSigninPage()
        {
            Boots_Website.Boots_HomePage.VisitHomePageWithoutPopups();
            Boots_Website.Boots_HomePage.VisitSigninPage();
            Thread.Sleep(5000);
            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle(), Does.Contain("Sign In"));
        }

        [Test]
        public void GivenIAmOnTheHomepage_WhenIClickNo7_ThenIGetTheNo7DropDown()
        {
            Boots_Website.Boots_HomePage.VisitHomePageWithoutPopups();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickNo7();
            Thread.Sleep(5000);
            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle(), Does.Contain("Beauty | Health | Pharmacy and Prescriptions - Boots"));
        }

        [Test]
        public void GivenIAmOnTheHomepage_WhenIClickShopAllOnTheNo7DropDown_ThenIGoToNo7ShopAllPage()
        {
            Boots_Website.Boots_HomePage.VisitHomePageWithoutPopups();
            Thread.Sleep(2000);
            Boots_Website.Boots_HomePage.ClickNo7ShopAll();
            Thread.Sleep(2000);
            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle(), Does.Contain("No7 | Shop all - Boots"));
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
