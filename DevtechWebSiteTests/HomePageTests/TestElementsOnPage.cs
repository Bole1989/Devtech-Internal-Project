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
            DevtechHomePage onDevtechHomePage = new DevtechHomePage();
            onDevtechHomePage.MinimizeWindow();
            Assert.AreEqual(DevtechHomePage.CanGetAllLinksFromTopBar().Count, 0);
        }

        [TestMethod]
        //Check if side bar is visible
        public void CheckIfSideBarIsVisible()
        {
            DevtechHomePage onDevtechHomePage = new DevtechHomePage();
            onDevtechHomePage.MinimizeWindow();
            onDevtechHomePage.CanClickOnSideBar();
            CollectionAssert.AreEqual(DevtechHomePage.CanGetAllLinksFromTopBar(), DevtechHomePage.AllLinksFromSideBar());
        }
        
        [TestMethod]
        //Check footer links with lists
        public void CheckFooterLinks()
        {
            CollectionAssert.AreEqual(FooterPage.CanGetAllLinksFromFooter(), FooterPage.AllLinksFromFooter());
        }
        
        [TestMethod]
        //Check footer links with dictionary
        public void CheckDictionaryFooterLinks()
        {
            FooterPage.CanGetAllDictionaryLinksFromFooter();
        }
        
        [TestMethod]
        //Check Employ Testemonials 1
        public void CheckEmployTestemonial1()
        {
            CareersPage onCareersPage = onDevtechHomePage.CanGoToCareersPage();
            
            onCareersPage.hoverOverTestemonials();
            onCareersPage.clickOnTestemonial1();
            Assert.AreEqual(PropertyValues.FirstName,onCareersPage.getFirstName());
        }

        [TestMethod]
        //Check Employ Testemonials 2
        public void CheckEmployTestemonial2()
        {
            CareersPage onCareersPage = onDevtechHomePage.CanGoToCareersPage();

            onCareersPage.hoverOverTestemonials();
            onCareersPage.clickOnTestemonial2();
            Assert.AreEqual(PropertyValues.SecondName, onCareersPage.getSecondName());
        }

        [TestMethod]
        //Check Employ Testemonials 3
        public void CheckEmployTestemonial3()
        {
            CareersPage onCareersPage = onDevtechHomePage.CanGoToCareersPage();

            onCareersPage.hoverOverTestemonials();
            onCareersPage.clickOnTestemonial3();
            Assert.AreEqual(PropertyValues.ThirdName, onCareersPage.getThirdName());
        }

        [TestMethod]
        //Check Employ Testemonials 4
        public void CheckEmployTestemonial4()
        {
            CareersPage onCareersPage = onDevtechHomePage.CanGoToCareersPage();

            onCareersPage.hoverOverTestemonials();
            onCareersPage.clickOnTestemonial4();
            Assert.AreEqual(PropertyValues.FourthName, onCareersPage.getFourthName());
        }

    }
}
