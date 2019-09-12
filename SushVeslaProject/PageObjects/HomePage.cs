using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace SushVeslaProject.PageObjects
{
    class HomePage
    {       
        [FindsBy(How = How.XPath, Using = "//*[@id='page']/div[1]/header/div/div[3]/div/div[2]/div[1]/a[1]")]
        [CacheLookup]
        public IWebElement login { get; set; }
        
        [System.Obsolete]
      
        public void ClickOnMyAccount()
        {
            login.Click();
        }
              
    }
}
