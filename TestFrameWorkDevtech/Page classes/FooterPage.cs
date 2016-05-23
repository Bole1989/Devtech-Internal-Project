using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestFrameWorkDevtech.Page_classes
{
    public class FooterPage: PropertyCollection
    {
        public FooterPage()
        {
            PageFactory.InitElements(Driver,this);
        }
        #region Page Factoring
        //LinkedIn link
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/span[1]/div[2]/a[1]/div")]
        public IWebElement LinkedInLink { get; set; }

        //Twitter link
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/span[1]/div[2]/a[2]/div")]
        public IWebElement TwitterLink { get; set; }

        //Facebook link
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/span[1]/div[2]/a[3]/div")]
        public IWebElement FacebookLink { get; set; }

        //Google+
        [FindsBy(How = How.XPath, Using = "/html/body/section/div/span[1]/div[2]/a[4]/div")]
        public IWebElement GoogleLink { get; set; }
        #endregion

        #region Page navigation

        public LinkedInPage CanGoToLinkedInPage()
        {
            var element = Wait.Until(ExpectedConditions.ElementToBeClickable(LinkedInLink));
            element.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            return new LinkedInPage();
        }

        public TwitterPage CanGoToTwitterPage()
        {
            var element = Wait.Until(ExpectedConditions.ElementToBeClickable(TwitterLink));
            element.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            return new TwitterPage();
        }

        public FacebookPage CanGoToFacebookPage()
        {
            var element = Wait.Until(ExpectedConditions.ElementToBeClickable(FacebookLink));
            element.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            return new FacebookPage();
        }

        public GooglePage CanGoToGooglePage()
        {
            var element = Wait.Until(ExpectedConditions.ElementToBeClickable(GoogleLink));
            element.Click();
            Driver.SwitchTo().Window(Driver.WindowHandles.Last());
            return new GooglePage();
        }
        #endregion
    }
}
