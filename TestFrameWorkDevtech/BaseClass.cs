using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using TestFrameWorkDevtech.Page_classes;

namespace TestFrameWorkDevtech
{
    public class BaseClass : PropertyCollection
    {
        protected DevtechHomePage OnDevtechHomePage { get; set; }

        [TestInitialize]
        public void ReferencesOfThePages()
        {
            OnDevtechHomePage = new DevtechHomePage();
        }
        public void SetWebPage(IWebDriver driver)
        {           
            driver.Navigate().GoToUrl(PropertyValues.LoginUrl);
            driver.Manage().Window.Maximize();
        }
        public void StartWebBrowsers()
        {
            // Chrome
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("chrome.switches", "--disable-extensions");
            chromeOptions.AddArgument("test-type");
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.LeaveBrowserRunning = true;
            //Driver = new ChromeDriver(@"C:\SeleniumBrowserServers", chromeOptions);

            // FireFox
            FirefoxOptions firefoxOptions = new FirefoxOptions();
            Driver = new FirefoxDriver();

            Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
            SetWebPage(Driver);                   
        }

        //Check for Title on HomePage
        public static string Title => Driver.Title;

        [TestCleanup]
        public void QuitOption()
        {
            Driver.Quit();
        }

        [TestInitialize]
        public void RunBrowsers()
        {
            StartWebBrowsers();            
        }
    }
}
