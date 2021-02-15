using NUnit.Framework;
using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Threading;

namespace IntroToSeleniumWalkThrough
{

    public class SeleniumWalkThrough
    {
        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheSignInLink_ThenIGoToTheSignInPage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                ////ARRANGE
                //Maximise the browser so it is full screen
                driver.Manage().Window.Maximize();
                //navigate to the API site
                driver.Navigate().GoToUrl("http://automationpractice.com/");
                //Grab the sign in link so we can interact with it
                var signinLink = driver.FindElement(By.ClassName("login"));
                ////ACT
                ////Click the sign in link
                signinLink.Click();
                Thread.Sleep(5000);
                //ASSERT
                ///That we are now on the sign in page
                Assert.That(driver.Title, Is.EqualTo("Login - My Store"));

            }
        }

        [Test]
        public void GivenIAmOnTheSignInPage_AndIEntrerA4DigitPassword_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my=account");
                var emailField = driver.FindElement(By.Id("email"));
                emailField.SendKeys("testing@snailmail.ccm");
                var passwordField = driver.FindElement(By.Id("passwd"));
                passwordField.SendKeys("nish");
                var signInButton = driver.FindElement(By.Id("SubmitLogin"));
                signInButton.Click();
                var alert = driver.FindElement(By.ClassName("alert"));
                Assert.That(alert.Text.Contains("Invalid password."));
            }
        }

        [Test]
        public void GivenIAmOnTheSignInPage_WithNoInputs_WhenIClickTheSignInButton_ThenIGetAnErrorMessage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/index.php?controller=authentication&back=my=account");
                
                var signInButton = driver.FindElement(By.Id("SubmitLogin"));
                signInButton.Click();
                var alert = driver.FindElement(By.ClassName("alert"));
                Assert.That(alert.Text.Contains("An email address required."));
            }
        }

        [Test]
        public void GivenIAmOnTheHomePage_WhenIClickTheWomenLink_ThenIGoToTheWomenPage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/");
                var signinLink = driver.FindElement(By.LinkText("Women"));
                
                signinLink.Click();
                Thread.Sleep(5000);
                
                Assert.That(driver.Title, Is.EqualTo("Women - My Store"));
            }
        }

        [Test]
        public void GivenIAmOnTheHomenPage_AndITypeAnInvalidSearch_WhenIClickTheSearchBar_ThenIGoToTheSearchPage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/");

                var searchBar = driver.FindElement(By.Id("search_query_top"));
                searchBar.SendKeys("testing@snailmail.ccm");
                var searchButton = driver.FindElement(By.Name("submit_search"));
                searchButton.Click();

                Assert.That(driver.Url, Is.EqualTo("http://automationpractice.com/index.php?controller=search&orderby=position&orderway=desc&search_query=testing%40snailmail.ccm&submit_search="));

            }
        }

        [Test]
        public void GivenIAmOnTheHomenPage_WhenITypeInTheSearchBar_ThenICheckTheBoxContentMatches()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/");

                var searchBar = driver.FindElement(By.Id("search_query_top"));
                searchBar.SendKeys("tomatoes");
                var search = driver.FindElement(By.Id("searchbox"));

                Assert.That(search.Text.Contains("tomatoes"));

            }
        }

        [Test]
        public void GivenIAmOnTheHomenPage_AndITypeAnInvalidSearch_WhenIClickTheSearchBar_ThenIGetAnErrorMessage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/");

                var searchBar = driver.FindElement(By.Id("search_query_top"));
                searchBar.SendKeys("tomatoes");
                var searchButton = driver.FindElement(By.Name("submit_search"));
                searchButton.Click();

                var alert = driver.FindElement(By.ClassName("alert"));
                Assert.That(alert.Text.Contains("No results were found for your search \"tomatoes\""));
            }
        }

        [Test]
        public void GivenIAmOnTheHomenPage_WhenIClickTheSearchBarSubmit_ThenIGoToTheEmptySearchPage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/");

                var searchButton = driver.FindElement(By.Name("submit_search"));
                searchButton.Click();

                Assert.That(driver.Url, Is.EqualTo("http://automationpractice.com/index.php?controller=search&orderby=position&orderway=desc&search_query=&submit_search="));
            }
        }

        [Test]
        public void GivenIAmOnTheHomenPage_WhenIClickTheSearchBarSubmit_ThenIGetAnErrorMessage()
        {
            //Allows us to access out selenium code through out chromedriver
            using (IWebDriver driver = new ChromeDriver())
            {
                driver.Manage().Window.Maximize();
                driver.Navigate().GoToUrl("http://automationpractice.com/");

                var searchButton = driver.FindElement(By.Name("submit_search"));
                searchButton.Click();

                var alert = driver.FindElement(By.ClassName("alert"));
                Assert.That(alert.Text.Contains("Please enter a search keyword"));
            }
        }

    }
}
