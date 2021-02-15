using NUnit.Framework;
using System.Threading;

namespace SeleniumPOMWalkthrough
{
    public class AP_Signin_Tests
    {
        //We are going to need to instantiate  our pages in our test
        //These classes will include all functionality with the pages
        //No need for using statements

        public AP_Website AP_Website { get; } = new AP_Website("Chrome");
        
        [Test]
        public void GivenIAmOnTheHomepage_WhenIClickTheSigninButton_ThenIShouldLandOnTheSigninPage()
        {
            AP_Website.AP_HomePage.VisitHomePage();
            AP_Website.AP_HomePage.VisitSigninPage();
            Assert.That(AP_Website.AP_HomePage.GetPageTitle(), Does.Contain("Login - My Store"));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterA4DigitPassword_WhenIClickTheSigninButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputEmail("example@spartglobal.com");
            AP_Website.AP_SigninPage.InputPassword("bree");
            AP_Website.AP_SigninPage.ClickSignin();
            AP_Website.AP_SigninPage.GetAlert();
            Assert.That(AP_Website.AP_SigninPage.GetAlert(), Does.Contain("Invalid password."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndThereAreNoInputs_WhenIClickTheSigninButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.ClickSignin();
            AP_Website.AP_SigninPage.GetAlert();
            Assert.That(AP_Website.AP_SigninPage.GetAlert(), Does.Contain("An email address required."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterOnlyAnEmail_WhenIClickTheSigninButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputEmail("example@spartglobal.com");
            AP_Website.AP_SigninPage.ClickSignin();
            AP_Website.AP_SigninPage.GetAlert();
            Assert.That(AP_Website.AP_SigninPage.GetAlert(), Does.Contain("Password is required."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterOnlyAPassword_WhenIClickTheSigninButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputPassword("breesha");
            AP_Website.AP_SigninPage.ClickSignin();
            AP_Website.AP_SigninPage.GetAlert();
            Assert.That(AP_Website.AP_SigninPage.GetAlert(), Does.Contain("An email address required."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterAnInvalidEmail_WhenIClickTheSigninButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputEmail("example");
            AP_Website.AP_SigninPage.InputPassword("breesha");
            AP_Website.AP_SigninPage.ClickSignin();
            AP_Website.AP_SigninPage.GetAlert();
            Assert.That(AP_Website.AP_SigninPage.GetAlert(), Does.Contain("Invalid email address."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterAnInvalidEmailAndPassword_WhenIClickTheSigninButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputEmail("example");
            AP_Website.AP_SigninPage.InputPassword("bree");
            AP_Website.AP_SigninPage.ClickSignin();
            AP_Website.AP_SigninPage.GetAlert();
            Assert.That(AP_Website.AP_SigninPage.GetAlert(), Does.Contain("Invalid email address."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterNonRegisteredDetails_WhenIClickTheSigninButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputEmail("example@spartaglobal.com");
            AP_Website.AP_SigninPage.InputPassword("breesha");
            AP_Website.AP_SigninPage.ClickSignin();
            AP_Website.AP_SigninPage.GetAlert();
            Assert.That(AP_Website.AP_SigninPage.GetAlert(), Does.Contain("Authentication failed."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_WhenIClickTheForgottenPasswordButton_ThenIGoToPasswordPage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.ClickForgotPassword();
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("http://automationpractice.com/index.php?controller=password"));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndThereAreNoInputs_WhenIClickTheCreateButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.ClickCreateAccount();
            AP_Website.AP_SigninPage.GetCreateAccountAlert();
            Thread.Sleep(2000);
            Assert.That(AP_Website.AP_SigninPage.GetCreateAccountAlert(), Does.Contain("Invalid email address."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterAnInvalidEmail_WhenIClickTheCreateButton_ThenIGetAnErrorMessage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputCreateEmail("example");
            AP_Website.AP_SigninPage.ClickCreateAccount();
            AP_Website.AP_SigninPage.GetCreateAccountAlert();
            Thread.Sleep(2000);
            Assert.That(AP_Website.AP_SigninPage.GetCreateAccountAlert(), Does.Contain("Invalid email address."));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_AndIEnterAnEmailToCreateANAccount_WhenIClickTheCreateButton_ThenIGoToTheCreateAccountPage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.InputCreateEmail("example@spartaglobal.com");
            AP_Website.AP_SigninPage.ClickCreateAccount();
            Thread.Sleep(5000);
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("http://automationpractice.com/index.php?controller=authentication#account-creation"));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_WhenIClickTheHomeButton_ThenIGoToTheHomePage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.ClickHomeButton();
            Thread.Sleep(2000);
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("http://automationpractice.com/index.php"));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_WhenIClickTheLogo_ThenIGoToTheHomePage()
        {
            AP_Website.AP_SigninPage.VisitSigninPage();
            AP_Website.AP_SigninPage.ClickLogo();
            Thread.Sleep(5000);
            Assert.That(AP_Website.SeleniumDriver.Url.Contains("http://automationpractice.com/index.php"));
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
