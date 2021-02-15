using NUnit.Framework;
using OpenQA.Selenium;
using System.Threading;

namespace SeleniumPOMWalkthrough
{
    public class AP_Homepage_Tests
    {
        public AP_Website AP_Website { get; } = new AP_Website("Chrome");

        [Test]
        public void GivenIAmOnTheHomenpage_AndTheSearchBarIsEmpty_WhenIClickTheSearchButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            AP_Website.AP_HomePage.ClickSearchSubmit();
            Thread.Sleep(2000);
            AP_Website.AP_HomePage.GetAlert();
            Assert.That(AP_Website.AP_HomePage.GetAlert(), Does.Contain("Please enter a search keyword"));
        }

        [Test]
        public void GivenIAmOnTheHomenpage_AndIEnterAnInvalidSearchInTheSearchBar_WhenIClickTheSearchButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            AP_Website.AP_HomePage.InputSearch("tomatoes");
            AP_Website.AP_HomePage.ClickSearchSubmit();
            Thread.Sleep(2000);
            AP_Website.AP_HomePage.GetAlert();
            Assert.That(AP_Website.AP_HomePage.GetAlert(), Does.Contain("No results were found for your search \"tomatoes\""));
        }




        [OneTimeTearDown]
        public void Cleanup()
        {
            //Quit this driver, closing every assocciated window
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();

        }
    }
}
