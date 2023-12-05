using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    public class LOGOUT
   
    {
        IWebDriver driver1;
        public LOGOUT(IWebDriver driver1)
        {
            PageFactory.InitElements(driver1, this);
        }

        [FindsBy(How = How.XPath, Using = "(//i[@class='fa fa-power-off'])[2]")] IWebElement logout;

        public void HRMSLogout()
        {
            Thread.Sleep(1000);
            logout.Click();

        }

    }

   
   

