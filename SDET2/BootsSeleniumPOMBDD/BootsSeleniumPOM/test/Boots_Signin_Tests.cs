using NUnit.Framework;
using System.Threading;

namespace BootsSeleniumPOM
{
    public class Boots_Signin_Tests
    {

        public Boots_Website Boots_Website { get; } = new Boots_Website("Chrome");

        [Test]
        public void GivenIAmOnTheSigninpage_WhenIEnterDetails_ThenTheyAppearInTheBoxes()
        {
            Boots_Website.Boots_SigninPage.VisitSigninPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_SigninPage.InputEmail("example@spartglobal.com");
            Boots_Website.Boots_SigninPage.InputPassword("bree");
            Thread.Sleep(5000);
            
            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle, Does.Contain("Sign In"));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_WhenIClickTheForgottenPasswordLink_ThenIGoToADifferentPage()
        {
            Boots_Website.Boots_SigninPage.VisitSigninPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_SigninPage.ClickForgottenPassword();
            Thread.Sleep(5000);

            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle, Does.Contain("Forget password?"));
        }

        [Test]
        public void GivenIAmOnTheSigninpage_WhenIClickTheRegisterButton_ThenIGoToADifferentPage()
        {
            Boots_Website.Boots_SigninPage.VisitSigninPage();
            Thread.Sleep(5000);
            Boots_Website.Boots_HomePage.ClickAcceptCookies();
            Thread.Sleep(2000);
            Boots_Website.Boots_SigninPage.ClickRegister();
            Thread.Sleep(5000);

            Assert.That(Boots_Website.Boots_HomePage.GetPageTitle, Does.Contain("Register"));
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
