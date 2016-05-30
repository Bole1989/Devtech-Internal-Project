using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Support.PageObjects;
using TestFrameWorkDevtech.Page_classes;

namespace TestFrameWorkDevtech
{
    public class BaseClass : PropertyCollection
    {
        protected DevtechHomePage onDevtechHomePage;
        protected FooterPage onFooterPage;
        public string[] browserArray = new string[] { "Chrome", "Firefox" };

        [TestInitialize]
        public void ReferencesOfThePages()
        {
            onDevtechHomePage = new DevtechHomePage();
            onFooterPage = new FooterPage();
        }
        public void SetWebPage(IWebDriver driver)
        {
            driver.Navigate().GoToUrl(PropertyValues.LoginUrl);
            driver.Manage().Window.Maximize();
        }
        public void StartWebBrowsers()
        {
            // Chrome
            ChromeOptions chromeOptions = new ChromeOptions();
            chromeOptions.AddArguments("chrome.switches", "--disable-extensions");
            chromeOptions.AddArgument("test-type");
            chromeOptions.AddArgument("start-maximized");
            chromeOptions.LeaveBrowserRunning = true;
            Driver = new ChromeDriver(@"C:\ChromeServer", chromeOptions);

            // FireFox
            FirefoxOptions firefoxOptions = new FirefoxOptions();
           // Driver = new FirefoxDriver();
             Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));



            /*switch (browser)
            {
                case "Chrome":
                    Driver = new ChromeDriver(@"C:\ChromeServer", chromeOptions);
                    break;
                case "Firefox":
                    FirefoxProfile profile = new FirefoxProfile();
                    //profile.AcceptUntrustedCertificates = true;
                    Driver = new FirefoxDriver(profile);
                    Wait = new WebDriverWait(Driver, TimeSpan.FromSeconds(30));
                    break;
                default:
                    // Trace.WriteLine(String.Format("Browser '{0}' not recognized.  Spawning default Firefox browser.", browser));
                    Driver = new FirefoxDriver();
                    break;
            }*/
            SetWebPage(Driver);
        }

        //Check for Title on HomePage
        public static string Title => Driver.Title;
        public static string CurrentUrl => Driver.Url;

        [TestCleanup]
        public void QuitOption()
        {
            Driver.Quit();
        }

        [TestInitialize]
  
        public void RunBrowsers()
        {
            StartWebBrowsers();
        }
    }
}

