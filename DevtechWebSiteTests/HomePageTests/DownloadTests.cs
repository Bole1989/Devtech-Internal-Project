using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestFrameWorkDevtech;
using TestFrameWorkDevtech.Page_classes;

namespace DevtechWebSiteTests.HomePageTests
{
    [TestClass]
    public class DownloadTests: BaseClass
    {
        [TestMethod]
        public void CanDowloadWhitePaper()
        {
            WhitePaperPage onWhitePaperPage = onDevtechHomePage.CanGoToWhitePaperPage();
            Assert.IsTrue(onWhitePaperPage.IsAtWhitePaperPage());
            Debug.Write("Whitepaper pdf on FireFox");
        }

        [TestMethod]
        public void CanDowloadTaaSPodcast()
        {
            TaaSPodcastPage onTaaSPodcastPage = onDevtechHomePage.CanGoToTaaSPodcastPage();
            Assert.IsTrue(onTaaSPodcastPage.IsAtTaaSPodcastPage());
            Debug.Write("TaaS podcast transcript pdf on FireFox");
        }
    }
}
