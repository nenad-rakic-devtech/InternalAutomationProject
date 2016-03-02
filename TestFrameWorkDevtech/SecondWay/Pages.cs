using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;

namespace TestFrameWorkDevtech
{
    public static class Pages
    {
        public static HomePage HomePage
        {
            get
            {
                var homePage = new HomePage();
                //PageFactory.InitElements(Browser.Driver, HomePage);
                return homePage;
            }
        }
        public static ContactPage ContactPage
        {
            get
            {
                var contactPage = new ContactPage();
                PageFactory.InitElements(Browser.Driver, ContactPage);
                return contactPage;
            }
        }
    }


    public class HomePage
    {       
        private static string Url = "http://192.168.88.226";

        private static string DevtechPageTitle = "DEVTECH | The Cloud Experts";

        // Devtech Page URL
        public void GoTo()
        {
            Browser.GoTo(Url);
            
        }
        //Comparison of the Devtech Title on the main page
        public bool IsAt()
        {
            return Browser.Title == DevtechPageTitle;
        }

    }

    public class ContactPage
    {
        private static string Url = "http://192.168.88.226";

        private static string DevtechContactPageTitle = "DEVTECH | The Cloud Experts - Contact us";

        // Devtech Page URL
        public void GoTo()
        {
            Browser.GoTo(Url);

        }
        //Comparison of the Devtech Title on the main page
        public bool IsAt()
        {
            return Browser.Title == DevtechContactPageTitle;
        }
        //Contact Link
        [FindsBy(How = How.LinkText, Using = "Contact")]
        public IWebElement Contact { get; set; }

        //Click on Contact Link
        public void GoToContactPage()
        {
            Contact.Click();
        }

    }


}
