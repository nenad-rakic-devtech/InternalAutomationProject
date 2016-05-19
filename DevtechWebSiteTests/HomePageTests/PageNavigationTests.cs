using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFrameWorkDevtech;
using TestFrameWorkDevtech.Page_classes;

namespace DevtechWebSiteTests.HomePageTests
{
    [TestClass]
    public class PageNavigationTests : BaseClass
    {
       
        [TestMethod]
        public void CanGoOnDevtechHomePage()
        {
            Assert.IsTrue(OnDevtechHomePage.IsAtHomePage());
            Debug.Write("HomePAge on FireFox");                   
        }

        [TestMethod]
        public void CanGoOnContactPage()
        {
            // Navigate to Contact page
            ContactPage onContactPage = OnDevtechHomePage.CanGoToContactPage();

            Assert.IsTrue(onContactPage.IsAtContactPageOnFireFox());
            Debug.Write("Contact Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnCareersPage()
        {
            // Navigate to Contact page
            CareesPage onCareesPage = OnDevtechHomePage.CanGoToCareerstPage();

            Assert.IsTrue(onCareesPage.IsAtCareersPage());
            Debug.Write("Careers Page on FireFox");
        }

    }
}
