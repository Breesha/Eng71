using System;
using TechTalk.SpecFlow;
using NUnit.Framework;

namespace SeleniumPOMWalkthrough
{
    [Binding]
    public class AP_SigninSteps
    {
        public AP_Website AP_Website { get; } = new AP_Website("Chrome");

        [Given(@"I am on the singin page")]
        public void GivenIAmOnTheSinginPage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
        }
        
        [Given(@"I have entered the email ""(.*)""")]
        public void GivenIHaveEnteredTheEmail(string email)
        {
            AP_Website.AP_SigninPage.InputEmail(email); 
        }
        
        [Given(@"I have entered the password (.*)")]
        public void GivenIHaveEnteredThePassword(string password)
        {
            AP_Website.AP_SigninPage.InputPassword(password);
        }
        
        [When(@"I click the sign in button")]
        public void WhenIClickTheSignInButton()
        {
            AP_Website.AP_SigninPage.ClickSignin();
        }

        [When(@"I click the forgot your password\? link")]
        public void WhenIClickTheForgotYourPasswordLink()
        {
            AP_Website.AP_SigninPage.ClickForgotPassword();
        }

        [Then(@"I will go to a form to reset my password")]
        public void ThenIWillGoToAFormToResetMyPassword()
        {
            Assert.That(AP_Website.SeleniumDriver.Title, Is.EqualTo("Forgot your password - My Store"));
        }


        [Then(@"I should see an alert containing the error message ""(.*)""")]
        public void ThenIShouldSeeAnAlertContainingTheErrorMessage(string expected)
        {
            Assert.That(AP_Website.AP_SigninPage.GetAlert().Contains(expected));
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
