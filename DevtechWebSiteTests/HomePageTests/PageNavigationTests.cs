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
            Assert.IsTrue(onDevtechHomePage.IsAtHomePage());
            Debug.Write("HomePAge on FireFox");                   

        }

        [TestMethod]
        public void CanGoOnContactPage()
        {

            // Navigate to Contact page
            ContactPage onContactPage = onDevtechHomePage.CanGoToContactPage();

            Assert.IsTrue(onContactPage.IsAtContactPage());
            Debug.Write("Contact Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnCloudMigrationPage()
        {
            // Navigate to Contact page
            ContactPage onContactPage = onDevtechHomePage.CanGoToCloudMigrationPage();
            Assert.IsTrue(onContactPage.IsAtContactPage());
            Debug.Write("Careers Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnCloudOperationalSupportPage()
        {
            // Navigate to Contact page
            ContactPage onContactPage = onDevtechHomePage.CanGoToCloudOperationalSupportPage();
            Assert.IsTrue(onContactPage.IsAtContactPage());
            Debug.Write("Careers Page on FireFox");
        }
        [TestMethod]
        public void CanGoOnCareersPage()
        {
            // Navigate to Contact page
            CareersPage onCareersPage = onDevtechHomePage.CanGoToCareersPage();

            Assert.IsTrue(onCareersPage.IsAtCareersPage());
            Debug.Write("Careers Page on FireFox");
        }


        [TestMethod]
        public void CanGoOnCloundIntegrationPage()
        {
            //DevtechHomePage onDevtechHomePage = new DevtechHomePage();
            CloudIntegrationPage onCloudIntegrationPage = onDevtechHomePage.CanGoToCloudIntegrationPage();
            Assert.IsTrue(onCloudIntegrationPage.IsAtCloudIntegrationPage());
            Debug.Write("Cloud Integration Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnProjectBasedPage()
        {
            ProjectBasedPage onProjectBasedPage = onDevtechHomePage.CanGoToProjectBasedPage();
            Assert.IsTrue(onProjectBasedPage.IsAtProjectBasedPage());
            Debug.Write("Project Based Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnOurProcessesPage()
        {
            OurProcessesPage onOurProcessesPage = onDevtechHomePage.CanGoToOurProcessesPage();
            Assert.IsTrue(onOurProcessesPage.IsAtOurProcessesPage());
            Debug.Write("Our Processes Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnAQualityAssurancePage()
        {
            QualityAssurancePage onQualityAssurancePage = onDevtechHomePage.CanGoToQualityAssurancePage();
            Assert.IsTrue(onQualityAssurancePage.IsAtQualityAssurancePage());
            Debug.Write("Quality Assurance on FireFox");
        }

        [TestMethod]
        public void CanGoOnTeamAsAServicePage()
        {
            TeamAsAServicePage onTeamAsAServicePage = onDevtechHomePage.CanGoToTeamAsAServicePage();
            Assert.IsTrue(onTeamAsAServicePage.isAtTeamAsAServicePage());
            Debug.Write("Team As A Service Page on FireFox");
        }


        [TestMethod]
        public void CanGoOnVPointPage()
        {
            VPointPage onVPointPage = onDevtechHomePage.CanGoToVPointPage();
            Assert.IsTrue(onVPointPage.IsAtVPointPage());
            Debug.Write("vPoint Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnVPointSupportPage()
        {
            VPointSupportPage onVPointSupportPage = onDevtechHomePage.CanGoToVPointSupportPage();
            Assert.IsTrue(onVPointSupportPage.IsAtVPointSupportPage());
            Debug.Write("vPointSupport Page on FireFox");
        }


        [TestMethod]
        public void CanGoOnCompanyOverviewtPage()
        {
            CompanyOverviewPage onCompanyOverviewPage = onDevtechHomePage.CanGoToCompanyOverviewPage();
            Assert.IsTrue(onCompanyOverviewPage.IsAtCompanyOverviewPage());
            Debug.Write("Company Overview Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnManagementTeamPage()
        {
            ManagementTeamPage onManagementTeamPage = onDevtechHomePage.CanGoToManagementTeamPage();
            Assert.IsTrue(onManagementTeamPage.IsAtManagementTeamPage());
            Debug.Write("Management Team Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnLinkedInPage()
        {
            LinkedInPage onLinkedInPage = onFooterPage.CanGoToLinkedInPage();
            Assert.IsTrue(onLinkedInPage.IsAtLinkedInPage());
            Debug.Write("LinkedIn Page on FireFox");
        }

        [TestMethod]
        public void CanGoOnTwitterPage()
        {
            TwitterPage onTwitterPage = onFooterPage.CanGoToTwitterPage();
            Assert.IsTrue(onTwitterPage.IsAtTwitterPage());
            Debug.Write("Twitter Page on FireFox");
        }

        [TestMethod] // Captcha Fail
        public void CanGoOnFacebookPage()
        {
            FacebookPage onFacebookPage = onFooterPage.CanGoToFacebookPage();
            Assert.IsTrue(onFacebookPage.IsAtFacebookPage());
            Debug.Write("Facebook Page on FireFox");
        }

        [TestMethod] // Not Signed in fail
        public void CanGoOnGooglePage()
        {
            GooglePage onGooglePage = onFooterPage.CanGoToGooglePage();
            Assert.IsTrue(onGooglePage.IsAtGooglePage());
            Debug.Write("Google Page on FireFox");
        }

        [TestMethod] 
        public void CanClickOnVacantPostion()
        {

            CareersPage onCareerspage = onDevtechHomePage.CanGoToCareersPage();
            onCareerspage.canClickOnVacantPosition();
            //ASSERT FALI
        }


        [TestMethod]
        public void CanClickOnDetails()
        {
            string firstline;

            CareersPage onCareer = onDevtechHomePage.CanGoToCareersPage();
            onCareer.canClickOnVacantPosition();
            onCareer.ClickOnDetails1();
            firstline = onCareer.getFirstLine();
            Assert.AreEqual( "3 years’ experience supporting Linux environments ",firstline);
        }

    }
}
