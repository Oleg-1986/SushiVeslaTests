using OpenQA.Selenium;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;

namespace SushVeslaProject.PageObjects
{
    class Sushi16Page
    {
        [FindsBy(How =How.Id, Using = "//a[@id='998 - plushalf']")]
        [CacheLookup]
        public IWebElement PlusElement { get; set; }
        [FindsBy(How=How.Id, Using = "basket-order")]
        [CacheLookup]
        public IWebElement OrderMake { get; set; }
        [System.Obsolete]
        public void ClickOnPlus()
        {
            PlusElement.Click();
        }
        public void ClickOnOrder()
        {
            OrderMake.Click();
        }
    }
}
