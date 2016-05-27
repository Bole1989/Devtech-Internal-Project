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
        #region Listlink
        
        public static List<string> CanGetAllLinksFromFooter()
        {
            IWebElement a = Driver.FindElement(By.XPath("/html/body/footer/div"));
            List <string> value = new List<string>();
            List<IWebElement> options = new List<IWebElement>(a.FindElements(By.TagName("a")));
            foreach (IWebElement option in options)
            {
                value.Add(option.GetAttribute("href"));
            }
            return value;
        }


        public static List<string> AllLinksFromFooter()
        {
            List<string> value = new List<string>();
            value.Add("http://devtechgroup.com/cloud-integration");
            value.Add("http://devtechgroup.com/contact-us");
            value.Add("http://devtechgroup.com/contact-us");
            value.Add("http://devtechgroup.com/vpoint");
            value.Add("http://devtech.kayako.com/vPoint/Tickets/Submit/RenderForm/8");
            value.Add("http://devtechgroup.com/company-overview");
            value.Add("http://devtechgroup.com/management-team");
            value.Add("http://devtechgroup.com/contact-us");
     
            return value;
        }
        
        #endregion


        #region Dictionary Link
        public static bool CanGetAllDictionaryLinksFromFooter()
        {
            IWebElement a = Driver.FindElement(By.XPath("/html/body/footer/div"));

            Dictionary<IWebElement,List<IWebElement>> links = new Dictionary<IWebElement, List<IWebElement>>();
            List<IWebElement> keys = new List<IWebElement>(a.FindElements(By.ClassName("block-title")));
            List<IWebElement> menu = new List<IWebElement>(a.FindElements(By.ClassName("menu")));
            //ist<IWebElement> options = new List<IWebElement>(a.FindElements(By.TagName("a")));

            var expectedLinks = PropertyValues.FooterNavigationBar;

            for (int i = 0; i < menu.Count; i++)
            {
                links.Add(keys[i], new List<IWebElement> { menu[i] });
            }
            foreach (var pair in links)
            {
                var key1 = pair.Key.Text;
                if (expectedLinks.ContainsKey(key1))
                    Console.WriteLine("True");
                else
                return false;


            }

            foreach(var pair in links)
            {
                List<IWebElement> value1;
                links.TryGetValue(pair.Key, out value1);
                var newValue= value1[0].Text.Replace("\r\n", ",").Split(',');

                List<string> value2;
                expectedLinks.TryGetValue(pair.Key.Text, out value2);

                for(int i=0;i<value1.Count;i++)
                {
                    if (value1[i].Equals(value2[i]))
                        Console.WriteLine("True");
                    else return false;
                }
            }

            return true;
        }
        #endregion

    }
}
