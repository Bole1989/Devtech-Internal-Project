using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;

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
        /*
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
        */

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/h2")]
        public IWebElement TestemonialBlock { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[3]/h2")]
        public IWebElement OurOffices { get; set; }

        [FindsBy(How = How.XPath, Using = "/html/body/div[2]/div/section/section[2]/div/div/div/ol")]
        public IWebElement TestimonialNods { get; set; }

        [FindsBy(How = How.CssSelector, Using = "article.nod.node-employee-testimonial header h2")]
        public IWebElement EmployeeNames { get; set; }

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
            action.MoveToElement(TestemonialBlock);
            action.Perform();
        }

        public void canClickOnVacantPosition()
        {
            var vacantposition = Wait.Until(ExpectedConditions.ElementToBeClickable(VacantPosition));
            vacantposition.Click();
        }
        #region Testimonials V.1
        /*
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
        */
        #endregion

        public bool getTestimonialNods()
        {
            int i = 0;
            int j = 0;
            IList<IWebElement> nods = Driver.FindElements(By.CssSelector("ol.flex-control-nav li"));
            IList<IWebElement> EmployeeNames = Driver.FindElements(By.CssSelector("article.node.node-employee-testimonial header h2"));
            List<bool> statements = new List<bool>();
            String[] allNames = new String[EmployeeNames.Count];

            foreach (IWebElement element in EmployeeNames)
            {
                var el = Wait.Until(ExpectedConditions.ElementToBeClickable(element));
                allNames[j++] = el.Text;
            }

            foreach (IWebElement nod in nods)
            {
                
                var testimonial = Wait.Until(ExpectedConditions.ElementToBeClickable(nod));
                System.Threading.Thread.Sleep(1000);
                testimonial.Click();
                switch (i)
                {
                    case 0:
                        if (allNames[i].Equals(PropertyValues.FirstName))
                            statements.Add(true);
                        else statements.Add(false);
                        break;
                    case 1:
                        if (allNames[i].Equals(PropertyValues.SecondName))
                            statements.Add(true);
                        else statements.Add(false);
                        break;
                    case 2:
                        if (allNames[i].Equals(PropertyValues.ThirdName))
                            statements.Add(true);
                        else statements.Add(false);
                        break;
                    case 3:
                        if (allNames[i].Equals(PropertyValues.FourthName))
                            statements.Add(true);
                        else statements.Add(false);
                        break;
                    default:
                        statements.Add(false);
                        break;
                }
                i++;

            }
            if (statements.Contains(false)){
                return false;
            }
            else return true;
        }
        /*
        # region getNames()
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

        #endregion
        */
    }
}