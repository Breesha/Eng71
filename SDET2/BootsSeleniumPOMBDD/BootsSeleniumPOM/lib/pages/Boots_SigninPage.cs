using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BootsSeleniumPOM
{
    public class Boots_SigninPage
    {
        private IWebDriver _seleniumDriver;

        private string _signInPageUrl = AppConfigReader.SignInPageUrl;
        private IWebElement _emailField => _seleniumDriver.FindElement(By.Id("gigya-loginID-126189670420823710"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("gigya-password-21094567555302330"));
        private IWebElement _forgottenPassword => _seleniumDriver.FindElement(By.LinkText("Forgotten your password?"));
        private IWebElement _registerButton => _seleniumDriver.FindElement(By.CssSelector(".gigya-composite-control-link > input"));

        public Boots_SigninPage(IWebDriver seleniumDriver)
        {
            _seleniumDriver = seleniumDriver;
        }

        public void VisitSigninPage()
        {
            _seleniumDriver.Navigate().GoToUrl(_signInPageUrl);
        }

        public void InputEmail(string email)
        {
            _emailField.SendKeys(email);
        }

        public void InputPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void ClickForgottenPassword()
        {
            _forgottenPassword.Click();
        }

        public void ClickRegister()
        {
            _registerButton.Click();
        }
    }
}
