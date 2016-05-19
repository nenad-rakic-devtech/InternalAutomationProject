using OpenQA.Selenium;
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
        public static IWebDriver DriverChrome, Driver;
        public static WebDriverWait Wait;
        public static string Hwnd;

    }
}
