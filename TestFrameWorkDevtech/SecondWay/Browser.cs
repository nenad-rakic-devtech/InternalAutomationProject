using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace TestFrameWorkDevtech
{
    public static class Browser
    {
        static IWebDriver driver = new FirefoxDriver();
       
        public static string Title
        {
            get
            {
                return driver.Title;
            }
        }

        public static ISearchContext Driver
        {
            get { return driver; }

        }

        public static void GoTo(string url)
        {
            driver.Url = url;
        }

        public static void Close()
        {
            driver.Close();
        }
    }
}