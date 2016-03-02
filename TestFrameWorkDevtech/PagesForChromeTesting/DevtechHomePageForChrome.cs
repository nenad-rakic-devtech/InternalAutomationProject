using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestFrameWorkDevtech.PagesForChromeTesting
{
    public class DevtechHomePageForChrome : PropertyCollection
    {
        public DevtechHomePageForChrome()
        {
            PageFactory.InitElements(DriverChrome, this);
        }
        #region Page Factoring
        //Email
        [FindsBy(How = How.LinkText, Using = "Home")]
        public IWebElement HomeDefault { get; set; }

        //Contact page Link
        [FindsBy(How = How.LinkText, Using = "Contact")]
        public IWebElement Contact { get; set; }

        //Careers page Link
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > div > nav > ul > li.leaf.active-trail.active > a")]
        public IWebElement Career { get; set; }
        #endregion

        //Check Title on HomePage on Chrome
        public bool IsAtHomePageOnChrome()
        {
            return BaseClass.TitleOnChrome == PropertyValues.DevtechPageTitle;
        }

        public void CanGoToDefaultPage()
        {
            var home = WaitChrome.Until(ExpectedConditions.ElementToBeClickable(HomeDefault));
            home.Click();
        }

        public void CanGoToContactPage()
        {
            var contact = WaitChrome.Until(ExpectedConditions.ElementToBeClickable(Contact));
            contact.Click();
        }

        public void CanGoToCareerstPage()
        {
            var career = WaitChrome.Until(ExpectedConditions.ElementToBeClickable(DriverChrome.FindElement(By.LinkText("Careers"))));
            career.Click();
        }
    }
}
