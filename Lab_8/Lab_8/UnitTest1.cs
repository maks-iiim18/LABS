using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using System;

namespace Lab_8
{
    public class Tests
    {
        private IWebDriver driver;
        private WebDriverWait wait;

        private const string TestEmail = "dziadziukmaksim@gmail.com";
        private const string TestPassword = "12345678Aa";
        [SetUp]
        public void Setup()
        {
            driver = new OpenQA.Selenium.Chrome.ChromeDriver();
            driver.Navigate().GoToUrl("https://www.binary.me/en/home.html?account_tabs=binary_options&market_tabs=binary");
            driver.Manage().Window.Maximize();

            var logInBtn = driver.FindElement(By.XPath("//a[@id='btn_login']//span"));
            logInBtn.Click();

            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var inputEmail = driver.FindElement(By.XPath("//input[@id='txtEmail']"));
            inputEmail.SendKeys(TestEmail);

            var inputPassword = driver.FindElement(By.XPath("//input[@id='txtPass']"));
            inputPassword.SendKeys(TestPassword);

            var submitBtn = driver.FindElement(By.XPath("//button[@type='submit']"));
            submitBtn.Click();


        }

        [Test]
        public void Test1()
        {
            //wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            //var selectTrading = driver.FindElement(By.XPath("//div[@class='gr-3 gr-12-m gr-12-p gr-no-gutter logo']//div"));
            //Actions action = new Actions(driver);
            //action.MoveToElement(selectTrading).Perform();
            //selectTrading.Click();

            
            wait = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
            var inputTime = driver.FindElement(By.XPath("//span[@id='purchase_button_top']"));
            inputTime.Click();
        }

        [TearDown]
        public void TearDown()
        {
            //driver.Quit();
        }
    }
}