using System.Collections.Generic;

namespace TestFrameWorkDevtech
{
    public class PropertyValues
    {
        //Devtech page URL
        public const string LoginUrl = "http://192.168.88.226";

#region Titles
        public static string DevtechPageTitle = "DEVTECH | The Cloud Experts";

        public static string ContactPageTitle = "DEVTECH | The Cloud Experts - Contact us";

        public static string CareersPageTitle = "DEVTECH | The Cloud Experts - Careers";

#endregion

        
        public static Dictionary<string, List<string>> FooterNavigationBar = new Dictionary<string, List<string>>()
        {
            {"SERVICES", new List<string> {"Cloud Integration","Cloud Migration","Cloud Operational Support"}},
            {"PRODUCTS", new List<string> {"vPoint","vPoint Support"}},
            {"ABOUT US", new List<string> {"Company overview","Management Team"}},
            {"CONTACT", new List<string> {"Contact Us"}}

        };
        
        
            

        
    }
}
