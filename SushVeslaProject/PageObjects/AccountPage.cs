﻿using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace SushVeslaProject.PageObjects
{
    class AccountPage
    {      
        [FindsBy(How=How.Id, Using = "email")]
        [CacheLookup]
        public IWebElement Name { get; set; }
        [FindsBy(How=How.Id, Using = "password")]
        [CacheLookup]
        public IWebElement Password { get; set; }
        [FindsBy(How=How.XPath, Using = "//input[contains(@class, 'btn-primary')]")]
        [CacheLookup]
        public IWebElement Submit { get; set; }
        [FindsBy(How = How.XPath, Using = "//li[contains(@class, 'dish-downlevel-item dish-item-16')]")]
        [CacheLookup]
        public IWebElement SushiSets { get; set; }
        [System.Obsolete]

        public void LoginToApplication()
        {
            Name.SendKeys("olegbishkevitch@gmail.com");
            Password.SendKeys("Sushitest2019");
            Submit.Submit();
        }
        public void ClickOnSushiSet()
        {
            SushiSets.Click();
        }
    }
}
