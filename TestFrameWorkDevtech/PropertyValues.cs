using System.Collections.Generic;

namespace TestFrameWorkDevtech
{
    public class PropertyValues
    {
        //Devtech page URL
        //public const string LoginUrl = "http://192.168.88.226";
        public const string LoginUrl = "http://devtechgroup.com/";
#region Titles
        public static string DevtechPageTitle = "DEVTECH | The Cloud Experts";

        public static string ContactPageTitle = "DEVTECH | The Cloud Experts - Contact us";

        public static string CareersPageTitle = "DEVTECH | The Cloud Experts - Careers";

        public static string CloudIntegrationPageTitle = "DEVTECH | The Cloud Experts - Cloud Integration";

        public static string ProjectBasedPageTitle = "DEVTECH | The Cloud Experts - Project Based Engagement";

        public static string TeamAsAServicePageTitle = "DEVTECH | The Cloud Experts - Team as a Service";

        public static string OurProcessesPageTitle = "DEVTECH | The Cloud Experts - Our processes";

        public static string QualityAssurancePageTitle = "DEVTECH | The Cloud Experts - Quality assurance";

        public static string VPointPageTitle = "DEVTECH | The Cloud Experts - vPoint";

        public static string VPointSupportPageTitle = "Your ticket details - Powered by Kayako Help Desk Software";

        public static string CompanyOverviewPageTitle = "DEVTECH | The Cloud Experts - Company Overview";

        public static string ManagementTeamPageTitle = "DEVTECH | The Cloud Experts - Management team";

        public static string WhitePaperPageTitle = "DEVTECH_Structure_and_Processes.pdf";

        public static string TaaSPodcastPageTitle = "Microsoft Word - Document3 - DEVTECH_TAAS Podcast_Transcript.pdf";

        public static string LinkedInPageTitle = "DEVTECH | LinkedIn";

        public static string TwitterPageTitle = "DEVTECH (@DEVTECHGroup) | Twitter";

        public static string FacebookPageTitle = "(1) DEVTECH";

        public static string GooglePageTitle = "DEVTECH - Google+";
        #endregion
#region URLS
        public static string WhitePaperPageUrl = "http://devtechgroup.com/sites/default/files/DEVTECH_Structure_and_Processes.pdf";
        public static string TaasPodcastPageUrl = "http://devtechgroup.com/sites/default/files/DEVTECH_TAAS%20Podcast_Transcript.pdf";
        public static string FacebookPageUrl = "https://www.facebook.com/devtechgroup/";
        public static string GooglePageUrl = "";
        #endregion
        #region Names
        public static string FirstName = "ALEKSANDAR TOMIC";
        public static string SecondName = "MILICA DJURICIC";
        public static string ThirdName = "FILIP INJAC";
        public static string FourthName = "MILICA PRIJOVIC";
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
