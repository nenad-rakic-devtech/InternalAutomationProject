using Microsoft.VisualStudio.TestTools.UnitTesting;
using TestFrameWorkDevtech;
using TestFrameWorkDevtech.Page_classes;

namespace DevtechWebSiteTests.HomePageTests
{
    [TestClass]
    public class TestElementsOnPage : BaseClass
    {
        [TestMethod]
        //Check for elements(links) on the top of the page
        public void CheckForTheExistingElementOnTheTopOfTheHomePage()
        {
            CollectionAssert.AreEqual(DevtechHomePage.CanGetAllLinksFromTopBar(), DevtechHomePage.AllLinksFromTopBar());
        }

    }
}
