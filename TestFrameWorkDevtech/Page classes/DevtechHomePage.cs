using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace TestFrameWorkDevtech.Page_classes
{
    public class DevtechHomePage : PropertyCollection
    {
        public DevtechHomePage()
        {
            PageFactory.InitElements(Driver, this);
        }
        #region Page Factoring
        //Email
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > a.logo.pull-left > img.hidden-phone")]
        public IWebElement HomeDefault { get; set; }

        //Contact page Link
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > div > nav > ul > li.last.leaf > a")]
        public IWebElement Contact { get; set; }

        //Careers page Link
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > div > nav > ul > li:nth-child(4) > a")]
        public IWebElement Career { get; set; }

        //Services link
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > div > nav > ul > li.first.expanded.dropdown > a")]
        public IWebElement Services { get; set; }

        //Cloud Integration link
        [FindsBy(How = How.CssSelector, Using = "#navbar > div > div > div > nav > ul > li.first.expanded.dropdown > ul > li.first.leaf > a")]
        public IWebElement CloudIntegration { get; set; }

        //Cloud Migration link
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/nav/ul/li[1]/ul/li[2]/a")]
        public IWebElement CloudMigration { get; set; }

        //Cloud Operational support link
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/nav/ul/li[1]/ul/li[3]/a")]
        public IWebElement CloudOperationalSupport { get; set; }

        //Service Delivery link
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/div/div/div/nav/ul/li[1]/ul/li[4]/a")]
        public IWebElement ServiceDelivery { get; set; }

        //Project based link
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/div/div/div/nav/ul/li[1]/ul/li[4]/ul/li[1]/a")]
        public IWebElement ProjectBased { get; set; }

        //TaaS link
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/div/div/div/nav/ul/li[1]/ul/li[4]/ul/li[2]/a")]
        public IWebElement TeamAsAService { get; set; }

        //Our processes link
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/div/div/div/nav/ul/li[1]/ul/li[4]/ul/li[3]/a")]
        public IWebElement OurProcesses { get; set; }

        //Quality Assurance
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/div/div/div/nav/ul/li[1]/ul/li[4]/ul/li[4]/a")]
        public IWebElement QualityAssurance { get; set; }

        //Products
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/div/div/div/nav/ul/li[2]/a")]
        public IWebElement Products { get; set; }

        //VPoint
        [FindsBy(How = How.XPath, Using = "//*[@id='navbar']/div/div/div/nav/ul/li[2]/ul/li[1]/a")]
        public IWebElement VPoint { get; set; }

        //VPoint Support
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/nav/ul/li[2]/ul/li[2]/a")]
        public IWebElement VPointSupport { get; set; }

        //About us
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/nav/ul/li[3]/a")]
        public IWebElement AboutUs { get; set; }

        //Company Overview
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/nav/ul/li[3]/ul/li[1]/a")]
        public IWebElement CompanyOverview { get; set; }

        //Management Team
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/div/nav/ul/li[3]/ul/li[2]/a")]
        public IWebElement ManagementTeam { get; set; }

        //P1 Text on HomePage
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/article/div/div/div/p[1]")]
        public IWebElement HomePagep1Text { get; set; }

        //Whitepaper holder
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/aside/div/section/section/div/div")]
        public IWebElement WhitepaperHolder { get; set; }

        //Whitepaper link
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/aside/div/section/section/div/ul/li/a")]
        public IWebElement Whitepaper { get; set; }

        //TaaSPodcast holder
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/aside/div/section/section/div/div")]
        public IWebElement TaasPodcastHolder { get; set; }

        //TaaSPodact download link
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/aside/div/section/section/div/ul/li/a")]
        public IWebElement TaasPodcast { get; set; }

        //Side bar
        [FindsBy(How = How.XPath, Using = "/html/body/header/div/div/a[1]")]
        public IWebElement SiderBar { get; set; }

        //Vacant Position
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/article/a")]
        public IWebElement VacantPosition { get; set; }

        
        #endregion

        // Check Title on HomePage
        public bool IsAtHomePage()
        {
            return BaseClass.Title == PropertyValues.DevtechPageTitle;
        }

        #region Page navigation
        //Go to home page link(Default Page)
        public void CanGoToDefaultPage()
        {
            var home = Wait.Until(ExpectedConditions.ElementToBeClickable(HomeDefault));
            home.Click();
        }

        //Go to Contact page
        public ContactPage CanGoToContactPage()
        {
            var contact = Wait.Until(ExpectedConditions.ElementToBeClickable(Contact));
            contact.Click();
            return new ContactPage();
        }

        public ContactPage CanGoToCloudMigrationPage()
        {
            MoveToElementAction.Perform(Services);
            var contact = Wait.Until(ExpectedConditions.ElementToBeClickable(CloudMigration));
            contact.Click();
            return new ContactPage();
        }

        public ContactPage CanGoToCloudOperationalSupportPage()
        {
            MoveToElementAction.Perform(Services);
            var contact = Wait.Until(ExpectedConditions.ElementToBeClickable(CloudOperationalSupport));
            contact.Click();
            return new ContactPage();
        }

        //Go to Carrers page
        public CareersPage CanGoToCareersPage()
        {
            var career = Wait.Until(ExpectedConditions.ElementToBeClickable(Career));
            career.Click();
            return new CareersPage();
        }

        //Go to Clound Integration page
        public CloudIntegrationPage CanGoToCloudIntegrationPage()
        {
            MoveToElementAction.Perform(Services);
            var integration = Wait.Until(ExpectedConditions.ElementToBeClickable(CloudIntegration));
            integration.Click();
            return new CloudIntegrationPage();
        }

        public ProjectBasedPage CanGoToProjectBasedPage()
        {
            MoveToElementAction.Perform(Services);
            MoveToElementAction.Perform(ServiceDelivery);
            var projectbased = Wait.Until(ExpectedConditions.ElementToBeClickable(ProjectBased));
            projectbased.Click();
            return new ProjectBasedPage();
        }

        public TeamAsAServicePage CanGoToTeamAsAServicePage()
        {
            MoveToElementAction.Perform(Services);
            MoveToElementAction.Perform(ServiceDelivery);
            var taas = Wait.Until(ExpectedConditions.ElementToBeClickable(TeamAsAService));
            taas.Click();
            return new TeamAsAServicePage();
        }


        public OurProcessesPage CanGoToOurProcessesPage()
        {
            MoveToElementAction.Perform(Services);
            MoveToElementAction.Perform(ServiceDelivery);
            var ourprocesses = Wait.Until(ExpectedConditions.ElementToBeClickable(OurProcesses));
            ourprocesses.Click();
            return new OurProcessesPage();
        }

        public QualityAssurancePage CanGoToQualityAssurancePage()
        {
            MoveToElementAction.Perform(Services);
            MoveToElementAction.Perform(ServiceDelivery);
            var qualityassurance = Wait.Until(ExpectedConditions.ElementToBeClickable(QualityAssurance));
            qualityassurance.Click();
            return new QualityAssurancePage();
        }

        public VPointPage CanGoToVPointPage()
        {

            MoveToElementAction.Perform(Products);
            var vpoint = Wait.Until(ExpectedConditions.ElementToBeClickable(VPoint));
            vpoint.Click();
            return new VPointPage();
        }

        public WhitePaperPage CanGoToWhitePaperPage()
        {
            CanGoToOurProcessesPage();
            MoveToElementAction.Perform(WhitepaperHolder);
            var whitepaper = Wait.Until(ExpectedConditions.ElementToBeClickable(Whitepaper));
            whitepaper.Click();

            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            return new WhitePaperPage();
        }

        public TaaSPodcastPage CanGoToTaaSPodcastPage()
        {
            CanGoToTeamAsAServicePage();
            MoveToElementAction.Perform(TaasPodcastHolder);
            var whitepaper = Wait.Until(ExpectedConditions.ElementToBeClickable(TaasPodcast));
            whitepaper.Click();

            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            return new TaaSPodcastPage();
        }

        public VPointSupportPage CanGoToVPointSupportPage()
        {
            MoveToElementAction.Perform(Products);
            var vpointsupport = Wait.Until(ExpectedConditions.ElementToBeClickable(VPointSupport));
            vpointsupport.Click();
            return new VPointSupportPage();

        }

        public CompanyOverviewPage CanGoToCompanyOverviewPage()
        {
            MoveToElementAction.Perform(AboutUs);
            var companyoverview = Wait.Until(ExpectedConditions.ElementToBeClickable(CompanyOverview));
            companyoverview.Click();
            return new CompanyOverviewPage();

        }

        public ManagementTeamPage CanGoToManagementTeamPage()
        {
            MoveToElementAction.Perform(AboutUs);
            var managementteam = Wait.Until(ExpectedConditions.ElementToBeClickable(ManagementTeam));
            managementteam.Click();
            return new ManagementTeamPage();

        }

   

        public void CanClickOnSideBar()
        {
            var sidebar = Wait.Until(ExpectedConditions.ElementToBeClickable(SiderBar));
            sidebar.Click();
        }


        public void canClickOnVacantPosition()
        {
            CanGoToCareersPage();
            var vacantposition = Wait.Until(ExpectedConditions.ElementToBeClickable(VacantPosition));
            vacantposition.Click();
        }


        #endregion

        public class MoveToElementAction
        {
            public static void Perform(IWebElement el)
            {
                Actions action = new Actions(Driver);
                action.MoveToElement(el);
                action.Perform();
            }
        }


        // All links from home page
        public static List<string> CanGetAllLinksFromTopBar()
        {
            IWebElement a = Driver.FindElement(By.Id("navbar"));
            List<string> value = new List<string>();
            List<IWebElement> options = new List<IWebElement>(a.FindElements(By.TagName("a")));
            foreach (IWebElement option in options)
            {               
                value.Add(option.Text.Trim());                
            }
            value.RemoveAll(item => item.Length == 0);
          return value;
        }
        //
        public static List<string> AllLinksFromTopBar()
        {           
            List<string> value = new List<string>();
            value.Add("SERVICES");
            value.Add("PRODUCTS");
            value.Add("ABOUT US");
            value.Add("CAREERS");
            value.Add("CONTACT");
            return value;
        }

        public static List<string> AllLinksFromSideBar()
        {
            List<string> value = new List<string>();
            value.Add("SERVICES");
            value.Add("CLOUD INTEGRATION");
            value.Add("CLOUD MIGRATION");
            value.Add("CLOUD OPERATIONAL SUPPORT");
            value.Add("SERVICE DELIVERY");
            value.Add("PROJECT BASED");
            value.Add("TEAM AS A SERVICE");
            value.Add("OUR PROCESSES");
            value.Add("QUALITY ASSURANCE");
            value.Add("PRODUCTS");
            value.Add("VPOINT");
            value.Add("VPOINT SUPPORT");
            value.Add("ABOUT US");
            value.Add("COMPANY OVERVIEW");
            value.Add("MANAGEMENT TEAM");
            value.Add("CAREERS");
            value.Add("CONTACT");
            return value;
        }

        public void MinimizeWindow()
        {
            Driver.Manage().Window.Size = new System.Drawing.Size(500, 1000);
        }

        public string GetTextOnPage()
        {
            var textElement= Wait.Until(ExpectedConditions.ElementToBeClickable(HomePagep1Text));
            string text = textElement.Text;
            return text;
        }

     
    }
}
