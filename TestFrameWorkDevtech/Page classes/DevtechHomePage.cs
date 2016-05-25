using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;

namespace TestFrameWorkDevtech.Page_classes
{
    public class DevtechHomePage : PropertyCollection
    {      
        public DevtechHomePage()
        {
            PageFactory.InitElements(Driver, this);
        }
        #region Page Factoring
        //Email
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > a.logo.pull-left > img.hidden-phone")]
        public IWebElement HomeDefault { get; set; }

        //Contact page Link
        [FindsBy(How = How.CssSelector, Using = "body > footer > div > section.span2 > div > div > ul > li > a")]
        public IWebElement Contact { get; set; }

        //Careers page Link
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > div > nav > ul > li:nth-child(4) > a")]
        public IWebElement Career { get; set; }
        #endregion
        
        // Check Title on HomePage
        public bool IsAtHomePage()
        {
            return BaseClass.Driver.Title == PropertyValues.DevtechPageTitle;
        }

        #region Page navigation
        //Go to home page link(Default Page)
        public void CanGoToDefaultPage()
        {
            var home = Wait.Until(ExpectedConditions.ElementToBeClickable(HomeDefault));
            home.Click();
        }

        //Go to Contact page
        public ContactPage CanGoToContactPage()
        {
            var contact = Wait.Until(ExpectedConditions.ElementToBeClickable(Contact));
            contact.Click();
            return new ContactPage();
        }

        //Go to Carrers page
        public CareesPage CanGoToCareerstPage()
        {
            var career = Wait.Until(ExpectedConditions.ElementToBeClickable(Career));
            career.Click();
            return new CareesPage();
        }
        #endregion

        // All links from home page
        public static List<string> CanGetAllLinksFromTopBar()
        {
            IWebElement a = Driver.FindElement(By.Id("navbar"));
            List<string> value = new List<string>();
            List<IWebElement> options = new List<IWebElement>(a.FindElements(By.TagName("a")));
            foreach (IWebElement option in options)
            {               
                value.Add(option.Text.Trim());                
            }
            value.RemoveAll(item => item.Length == 0);
          return value;
        }
        //
        public static List<string> AllLinksFromTopBar()
        {           
            List<string> value = new List<string>();
            value.Add("SERVICES");
            value.Add("PRODUCTS");
            value.Add("ABOUT US");
            value.Add("CAREERS");
            value.Add("CONTACT");
            return value;
        }


        public bool FooterNavigationBar()
        {
            IWebElement region = Driver.FindElement(By.ClassName("region-footer"));
            Dictionary<IWebElement, List<IWebElement>> first = new Dictionary<IWebElement, List<IWebElement>>();
            List<IWebElement> headers = new List<IWebElement>(region.FindElements(By.ClassName("block-title")));
            List<IWebElement> options = new List<IWebElement>(region.FindElements(By.ClassName("menu")));

            for (int j = 0; j < options.Count; j++ )
            {
                first.Add(headers[j], new List<IWebElement> { options[j] });
            }

            //comparison of headings
            var second = PropertyValues.FooterNavigationBar;

            foreach (var pair1 in first)
            {
                var key1 = pair1.Key.Text;

                if (second.ContainsKey(key1))
                {
                    System.Console.WriteLine("true");
                }
                else return false;
            }

            //comparison of links
            foreach (var pair1 in first)
            {
                List<IWebElement> sht1;
                first.TryGetValue(pair1.Key, out sht1);
                var newSht = sht1[0].Text.Replace("\r\n",",").Split(',');

                List<string> sht2;
                second.TryGetValue(pair1.Key.Text, out sht2);
                sht2.ToArray();

                for (int i = 0; i < newSht.Length; i++)
                {
                    if (newSht[i] == sht2[i])
                        System.Console.WriteLine("true");
                    else
                        return false;
                }
            }
            return true;
        }
    }
}
