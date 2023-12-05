using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class DASHBOARD
    {

    IWebDriver driver1;

        public DASHBOARD(IWebDriver driver1)
    {
        PageFactory.InitElements(driver1, this);
    }

    [FindsBy(How = How.XPath,Using ="//span[text()='Dashboard']")] IWebElement dashboardbutton;
    [FindsBy(How = How.XPath, Using= "//small[text()='Employees']")] IWebElement employeesbutton;
    [FindsBy(How = How.XPath, Using = "//a[text()=' Home']")] IWebElement homebutton;
    [FindsBy(How = How.XPath, Using = "//a[text()=' Roles ']")] IWebElement Rolesbutton;
    [FindsBy(How = How.XPath, Using = "//a[text()=' Leave ']")] IWebElement leavemanagementbutton;
    [FindsBy(How = How.XPath, Using = "//a[text()=' HRMS ']")] IWebElement HRMSsettingsbutton;



    public void Dashboardpage()
    {

        dashboardbutton.Click();
        Thread.Sleep(1000);

        employeesbutton.Click();
        Thread.Sleep(3000);
        homebutton.Click();
        Thread.Sleep(3000);

        Rolesbutton.Click();
        Thread.Sleep(3000);
        homebutton.Click();
        Thread.Sleep(3000);

        leavemanagementbutton.Click();
        Thread.Sleep(3000);
        homebutton.Click();
        Thread.Sleep(3000);

        HRMSsettingsbutton.Click();
        Thread.Sleep(3000);
        homebutton.Click();
        Thread.Sleep(3000);




    }
        

    
    }

