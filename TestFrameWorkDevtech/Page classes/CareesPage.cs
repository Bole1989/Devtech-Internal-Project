using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;

namespace TestFrameWorkDevtech.Page_classes
{
    public class CareersPage : PropertyCollection
    {
        /*[FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[4]/div/div[2]/div/ul/li[1]/article/a")]
        public IWebElement Details1 { get; set; }*/

        public bool IsAtCareersPage()
        {
            return BaseClass.Title == PropertyValues.CareersPageTitle;
        }


        public void ClickOnDetails1()
        {
            System.Threading.Thread.Sleep(2000);
            var detail = Wait.Until(ExpectedConditions.ElementToBeClickable(By.XPath("/html/body/div[2]/div/section/section[4]/div/div[2]/div/ul/li[1]/article/a")));
            detail.Click();
        }


        public string getFirstLine()
        {

            IWebElement FirstLine = Driver.FindElement(By.XPath("/html/body/div[2]/div/section/section[4]/div/div[2]/div/ul/li[1]/article/section/article[1]/div/div[2]/div/ul/li[1]"));
            System.Threading.Thread.Sleep(200);
            string firstline = FirstLine.Text;
            return firstline;
        }
    }
}