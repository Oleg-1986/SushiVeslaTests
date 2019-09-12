using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Support.PageObjects;


namespace SushVeslaProject.PageObjects
{
    class OrderPaymentPage
    {
        [FindsBy(How =How.XPath, Using = "//input[@class='form-text required ui-autocomplete-input']")]
        IWebElement Street { get; set; }
        [FindsBy(How=How.XPath, Using = "//input[@id='edit-building-number']")]
        IWebElement BildingNumber { get; set; }
        [FindsBy(How=How.Id, Using= "edit-apartment")]
        IWebElement ApartmentNumber { get; set; }
        [FindsBy(How =How.Id, Using = "edit-customer")]
        IWebElement CustomerName { get; set; }
        [FindsBy(How =How.Id, Using = "edit-phone-number")]
        IWebElement CustomerCallNumber { get; set; }
        [FindsBy(How=How.Id, Using = "edit-terms-accepted")]
        IWebElement ChbAccepted { get; set; }
        [FindsBy(How=How.Id, Using = "order-cash")]
        IWebElement OrderCash { get; set; }
        public void Fill_In_The_Filds()
        {
            Street.SendKeys("Якуба Коласа");
            BildingNumber.SendKeys("69");
            ApartmentNumber.SendKeys("69");
            CustomerName.SendKeys("Олег");
            CustomerCallNumber.SendKeys("291388592");
        }
        public void ClickOnChb()
        {
            ChbAccepted.Click();
        }
        public void ClickOnCash()
        {
            OrderCash.Click();
        }
    }
}
