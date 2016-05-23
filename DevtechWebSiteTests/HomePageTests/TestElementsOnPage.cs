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

        [TestMethod]
        //Check for p1 text on homepage
        public void CheckForExistingText()
        {
            DevtechHomePage onDevtechHomePage = new DevtechHomePage();

            string text = "DevTech provides Cloud enablement solutions to ISVs, Cloud Service Providers, Fortune 500 and some of the world’s largest telecommunication companies. ";
            Assert.AreEqual(onDevtechHomePage.GetTextOnPage(), text);
           
        }


        [TestMethod]
        //Check if top menu elements are gone
        public void CheckIfTopMenuElementsAreGone()
        {
            Assert.AreEqual(DevtechHomePage.CanGetAllLinksFromTopBar().Count, 0);
        }

        [TestMethod]
        //Check if side bar is visible
        public void CheckIfSideBarIsVisible()
        {
            DevtechHomePage onDevtechHomePage = new DevtechHomePage();
            onDevtechHomePage.CanClickOnSideBar();
            CollectionAssert.AreEqual(DevtechHomePage.CanGetAllLinksFromTopBar(), DevtechHomePage.AllLinksFromSideBar());
        }
    }
}
