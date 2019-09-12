using NUnit.Framework;
using SushVeslaProject.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Chrome;
using System.Configuration;
using System;

namespace SushVeslaProject.TestCases
{
    class SmokeTest
    {
        IWebDriver driver = new ChromeDriver();
        [Test]
        [System.Obsolete]
        public void Order()
        {
            driver.Url = ConfigurationManager.AppSettings["url"];
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            var homePage = new HomePage();
            PageFactory.InitElements(driver, homePage);
            homePage.ClickOnMyAccount();
            var loginPage = new AccountPage();
            PageFactory.InitElements(driver, loginPage);
            loginPage.LoginToApplication();
            var account = new AccountPage();
            PageFactory.InitElements(driver, account);
            account.ClickOnSushiSet();
            var sushi16 = new Sushi16Page();
            PageFactory.InitElements(driver, sushi16);
            sushi16.ClickOnPlus();
            sushi16.ClickOnOrder();
            var orderMake = new OrderMakePage(driver);
            PageFactory.InitElements(driver, orderMake);
            //orderMake.ClickOnVassabiPlus();
            orderMake.ClickOnCheckOutNext();
            var orderPayment = new OrderPaymentPage();
            PageFactory.InitElements(driver, orderPayment);
            orderPayment.Fill_In_The_Filds();
            orderPayment.ClickOnChb();
            orderPayment.ClickOnCash();
            driver.Close();
        }
       
    }
}
