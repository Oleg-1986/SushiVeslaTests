using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;


namespace SushVeslaProject.PageObjects
{
    class OrderMakePage
    {
        IWebDriver driver;
        [FindsBy(How = How.Id, Using = "241 - add")]
        [CacheLookup]
        public IWebElement VassabiPlus { get; set; }
        [FindsBy(How = How.XPath, Using = "//div[@class='button med sv-checkout-next']")]
        [CacheLookup]
        public IWebElement CheckOutNext { get; set; }
        [System.Obsolete]
        public OrderMakePage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver, this);
        }
        public void ClickOnVassabiPlus()
        {
            VassabiPlus.Click();
        }
        public void ClickOnCheckOutNext()
        {
            System.Threading.Thread.Sleep(1000);
            Actions action = new Actions(driver);
            action.MoveToElement(CheckOutNext).Click();
            
            
        }
    }
}
