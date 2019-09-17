using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace SushVeslaProject.PageObjects
{
    class HomePage
    {       
        [FindsBy(How = How.XPath, Using = "//*[@id='site_content']/header/div/div[3]/a[1]/img")]
        [CacheLookup]
        public IWebElement login { get; set; }
        
        [System.Obsolete]
      
        public void ClickOnMyAccount()
        {
            login.Click();
        }
              
    }
}
