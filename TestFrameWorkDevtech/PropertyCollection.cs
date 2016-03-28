using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;

namespace TestFrameWorkDevtech
{
    enum PropertyType
    {
        Id,
        Name,
        LinkText,
        CssName,
        ClassName
    }
    public class PropertyCollection
    {
        public static IWebDriver Driver, DriverChrome;
        public static WebDriverWait Wait, WaitFireFox, WaitChrome;
        public static FirefoxDriver DriverFireFox;
        public static string HwndHomePage;

    }
}
