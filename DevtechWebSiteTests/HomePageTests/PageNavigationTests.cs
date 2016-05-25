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
            DevtechHomePage onDevtechHomePage = new DevtechHomePage();

            Assert.IsTrue(onDevtechHomePage.IsAtHomePage());
            Debug.Write("HomePAge on FireFox");                   

        }

        [TestMethod]
        public void CanGoOnContactPage()
        {
            DevtechHomePage onDevtechHomePage = new DevtechHomePage();
            // Navigate to Contact page
            ContactPage onContactPage = onDevtechHomePage.CanGoToContactPage();

            Assert.IsTrue(onContactPage.IsAtContactPageOnFireFox());
            Debug.Write("Contact Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnCareersPage()
        {
            DevtechHomePage onDevtechHomePage = new DevtechHomePage();
            // Navigate to Contact page
            CareesPage onCareesPage = onDevtechHomePage.CanGoToCareerstPage();

            Assert.IsTrue(onCareesPage.IsAtCareersPage());
            Debug.Write("Careers Page on FireFox");
        }



        [TestMethod]
        public void FooterLinksCheckup()
        {
            DevtechHomePage navigationBar =  new DevtechHomePage();
            var result  = navigationBar.FooterNavigationBar();
            Assert.IsTrue(result);
        }

    }
}
