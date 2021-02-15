using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumPOMWalkthrough
{
    public class AP_SigninPage
    {
        private IWebDriver _seleniumDriver;
        private string _signInPageUrl = AppConfigReader.SignInPageUrl;

        //Web elements (ie thing the driver can interact with
        private IWebElement _emailField => _seleniumDriver.FindElement(By.Id("email"));
        private IWebElement _passwordField => _seleniumDriver.FindElement(By.Id("passwd"));
        private IWebElement _signinButton => _seleniumDriver.FindElement(By.Id("SubmitLogin"));
        private IWebElement _homeButton => _seleniumDriver.FindElement(By.ClassName("home"));
        private IWebElement _forgotPasswordLink => _seleniumDriver.FindElement(By.LinkText("Forgot your password?"));
        private IWebElement _createEmailField => _seleniumDriver.FindElement(By.Id("email_create"));
        private IWebElement _createButton => _seleniumDriver.FindElement(By.Id("SubmitCreate"));
        private IWebElement _alert => _seleniumDriver.FindElement(By.ClassName("alert"));
        private IWebElement _alertCreate => _seleniumDriver.FindElement(By.Id("create_account_error"));
        private IWebElement _logo => _seleniumDriver.FindElement(By.Id("header_logo"));


        public AP_SigninPage(IWebDriver seleniumDriver)
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

        public void ClickPassword()
        {
            _passwordField.Click();
        }

        public void InputPassword(string password)
        {
            _passwordField.SendKeys(password);
        }

        public void ClickSignin()
        {
            _signinButton.Click();
        }

        public string GetAlert()
        {
            return _alert.Text;
        }

        public void ClickForgotPassword()
        {
            _forgotPasswordLink.Click();
        }

        public void InputCreateEmail(string email)
        {
            _createEmailField.SendKeys(email);
        }

        public void ClickCreateAccount()
        {
            _createButton.Click();
        }

        public string GetCreateAccountAlert()
        {
            return _alertCreate.Text;
        }

        public void ClickHomeButton()
        {
            _homeButton.Click();
        }

        public void ClickLogo()
        {
            _logo.Click();
        }
    }
}
