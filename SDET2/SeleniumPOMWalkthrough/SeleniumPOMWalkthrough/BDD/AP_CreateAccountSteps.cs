using System;
using TechTalk.SpecFlow;
using NUnit.Framework;
using System.Threading;

namespace SeleniumPOMWalkthrough
{
    [Binding]
    public class AP_CreateAccountSteps
    {
        public AP_Website AP_Website { get; } = new AP_Website("Chrome");

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
        }

        [Given(@"I entered the email ""(.*)""")]
        public void GivenIEnteredTheEmail(string email)
        {
            AP_Website.AP_SigninPage.InputCreateEmail(email);
        }

        [When(@"I click the create an account button")]
        public void WhenIClickTheCreateAnAccountButton()
        {
            AP_Website.AP_SigninPage.ClickCreateAccount();
            Thread.Sleep(2000);
        }

        [Then(@"I should go to a page with Url ""(.*)""")]
        public void ThenIShouldGoToAPageWithUrl(string expected)
        {
            Assert.That(AP_Website.SeleniumDriver.Url, Is.EqualTo(expected));
        }

        [Then(@"I see an alert containing the error message ""(.*)""")]
        public void ThenISeeAnAlertContainingTheErrorMessage(string expected)
        {
            Thread.Sleep(2000);
            Assert.That(AP_Website.AP_SigninPage.GetCreateAccountAlert(), Does.Contain(expected));
        }




        [AfterScenario]
        public void DisposeWebDriver()
        {
            //Quit this driver, closing every assocciated window
            AP_Website.SeleniumDriver.Quit();
            AP_Website.SeleniumDriver.Dispose();
        }
    }
}
