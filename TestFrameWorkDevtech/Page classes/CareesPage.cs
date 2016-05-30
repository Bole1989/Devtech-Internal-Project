using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFrameWorkDevtech.Page_classes
{
    public class CareersPage : PropertyCollection
    {


        public CareersPage()
        {
            PageFactory.InitElements(Driver, this);
        }
        #region WebElements

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[4]/div/div[2]/div/ul/li[1]/article/a")]
        public IWebElement Details1 { get; set; }

        //Vacant Position
        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/article/a")]
        public IWebElement VacantPosition { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ol/li[1]/a")]
        public IWebElement Testemonial1 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ol/li[2]/a")]
        public IWebElement Testemonial2 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ol/li[3]/a")]
        public IWebElement Testemonial3 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ol/li[4]/a")]
        public IWebElement Testemonial4 { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ul/li[1]/article/header/h2")]
        public IWebElement FirstName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ul/li[2]/article/header/h2")]
        public IWebElement SecondName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ul/li[3]/article/header/h2")]
        public IWebElement ThirdName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ul/li[4]/article/header/h2")]
        public IWebElement FourthName { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/h2")]
        public IWebElement TestemonialBlock { get; set; }


        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[3]/h2")]
        public IWebElement OurOffices { get; set; }
        #endregion
        public bool IsAtCareersPage()
        {
            return BaseClass.Title == PropertyValues.CareersPageTitle;
        }


        public void ClickOnDetails1()
        {
            System.Threading.Thread.Sleep(2000);
            
            var detail = Wait.Until(ExpectedConditions.ElementToBeClickable(Details1));
            detail.Click();
        }


        public string getFirstLine()
        {

            IWebElement FirstLine = Driver.FindElement(By.XPath("/html/body/div[2]/div/section/section[4]/div/div[2]/div/ul/li[1]/article/section/article[1]/div/div[2]/div/ul/li[1]"));
            System.Threading.Thread.Sleep(200);
            string firstline = FirstLine.Text;
            return firstline;
        }

        public void hoverOverTestemonials()
        {
            Actions action = new Actions(Driver);
            action.MoveToElement(OurOffices);
            action.Perform();
        }

        public void canClickOnVacantPosition()
        {
            var vacantposition = Wait.Until(ExpectedConditions.ElementToBeClickable(VacantPosition));
            vacantposition.Click();
        }

        public void clickOnTestemonial1()
        {
            var testemonial = Wait.Until(ExpectedConditions.ElementToBeClickable(Testemonial1));
            testemonial.Click();
        }
        public void clickOnTestemonial2()
        {
            var testemonial = Wait.Until(ExpectedConditions.ElementToBeClickable(Testemonial2));
            testemonial.Click();
        }
        public void clickOnTestemonial3()
        {
            var testemonial = Wait.Until(ExpectedConditions.ElementToBeClickable(Testemonial3));
            testemonial.Click();
        }
        public void clickOnTestemonial4()
        {
            var testemonial = Wait.Until(ExpectedConditions.ElementToBeClickable(Testemonial4));
            testemonial.Click();
        }


        public string getFirstName()
        {
            string firstname = FirstName.Text;
            return firstname;
        }

        public string getSecondName()
        {
            string secondname = SecondName.Text;
            return secondname;
        }

        public string getThirdName()
        {
            string thirdname = ThirdName.Text;
            return thirdname;
        }

        public string getFourthName()
        {
            string fourthname = FourthName.Text;
            return fourthname;
        }
    }
}