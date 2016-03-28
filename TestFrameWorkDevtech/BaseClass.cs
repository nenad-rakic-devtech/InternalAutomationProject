using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestFrameWorkDevtech
{
    public class BaseClass : PropertyCollection
    {
        public void SetWebPage(IWebDriver driver)
        {
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(PropertyValues.LoginUrl);
        }

        public void StartWebBrowsers()
        {
            // FireFox
            DriverFireFox = new FirefoxDriver();
            WaitFireFox = new WebDriverWait(DriverFireFox, TimeSpan.FromSeconds(30));
            SetWebPage(DriverFireFox);
            HwndHomePage = DriverFireFox.CurrentWindowHandle;
            

            // Chrome
            //DriverChrome = new ChromeDriver(@"C:\SeleniumBrowserServers");
            //WaitChrome = new WebDriverWait(DriverChrome, TimeSpan.FromSeconds(30));
            //SetWebPage(DriverChrome);
        }

        //Check for Title on HomePage on FireFox
        public static string TitleOnFireFox => DriverFireFox.Title;
        //Check for Title on HomePage on Chrome
        public static string TitleOnChrome => DriverChrome.Title;

        [TestCleanup]
        public void QuitOption()
        {
            //Driver.Quit();
            //DriverFireFox.Quit();
            //DriverChrome.Quit();
        }

        [TestInitialize]
        public void RunBrowsers()
        {
            StartWebBrowsers();
        }
    }
}
