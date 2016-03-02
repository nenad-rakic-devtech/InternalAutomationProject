using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFrameWorkDevtech;
using TestFrameWorkDevtech.PagesForFireFoxTesting;

namespace DevtechWebSiteTests.HomePageTests
{
    [TestClass]
    public class PageNavigationTests : BaseClass
    {
        [TestMethod]
        public void CanGoOnDevtechHomePage()
        {
            DevtechHomePageForFireFox onDevtechHomePageForFireFox = new DevtechHomePageForFireFox();

            Assert.IsTrue(onDevtechHomePageForFireFox.IsAtHomePageOnFireFox());
            Debug.Write("HomePAge on FireFox");                   

        }

        [TestMethod]
        public void CanGoOnContactPage()
        {
            DevtechHomePageForFireFox onDevtechHomePageForFireFox = new DevtechHomePageForFireFox();
            // Navigate to Contact page
            ContactPageForFireFox onContactPageForFireFox = onDevtechHomePageForFireFox.CanGoToContactPage();

            Assert.IsTrue(onContactPageForFireFox.IsAtContactPageOnFireFox());
            Debug.Write("Contact Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnCareersPage()
        {
            DevtechHomePageForFireFox onDevtechHomePageForFireFox = new DevtechHomePageForFireFox();
            // Navigate to Contact page
            CareesPageForFireFox onCareesPageForFireFox = onDevtechHomePageForFireFox.CanGoToCareerstPage();

            Assert.IsTrue(onCareesPageForFireFox.IsAtCareersPageOnFireFox());
            Debug.Write("Careers Page on FireFox");
        }

    }
}
