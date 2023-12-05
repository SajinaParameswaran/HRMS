using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Interactions;


public class ORGANISATION
    {
    IWebDriver driver1;

    //public Actions act;

    public ORGANISATION(IWebDriver driver1)
    {
        PageFactory.InitElements(driver1, this);
    }


    

    //ORGANISATION COMPANY
    [FindsBy(How = How.XPath, Using = "//span[text()='Organization']")] IWebElement organisationbutton;
    [FindsBy(How = How.XPath, Using = "//a[text()=' Company']")] IWebElement companybutton;

    //ORGANISATION COMPNAY ADD NEW
    [FindsBy(How = How.XPath, Using = "//button[text()=' Add New']")] IWebElement Addnewbutton;

    //ADD NEW COMPANY - Fields

    //Company Name
    [FindsBy(How = How.XPath, Using = "//input[@name='name']")] IWebElement compname;


    //Company Type
    [FindsBy(How = How.XPath, Using = "//span[text()='Company Type']")] IWebElement comptype;
    //Compnay type input - coorporation
    [FindsBy(How = How.XPath, Using = "//li[text()=' Corporation']")] IWebElement comtypevalue1;
    

   //Legal / Trading Name
   [FindsBy(How = How.XPath, Using = "//input[@name='trading_name']")] IWebElement legaltradingname;

    //Registration Number
    [FindsBy(How = How.XPath, Using = "//input[@name='registration_no']")] IWebElement regnumber;

    //Contact Number
    [FindsBy(How = How.XPath, Using = "//input[@name='contact_number']")] IWebElement contacnumber;

    //Email
    [FindsBy(How = How.XPath, Using = "//input[@name='email']")] IWebElement email;

    //webbsite
    [FindsBy(How = How.XPath, Using = "//input[@name='website']")] IWebElement weburl;

    //Tax Number / EIN
    [FindsBy(How = How.XPath, Using = "//input[@name='xin_gtax']")] IWebElement taxEIN;

    //Address
    [FindsBy(How = How.XPath, Using = "//input[@name='address_1']")] IWebElement add1;
    [FindsBy(How = How.XPath, Using = "//input[@name='address_2']")] IWebElement add2;
    [FindsBy(How = How.XPath, Using = "//input[@name='city']")] IWebElement city;
    [FindsBy(How = How.XPath, Using = "//input[@name='state']")] IWebElement state;
    [FindsBy(How = How.XPath, Using = "//input[@name='zipcode']")] IWebElement zip;
    [FindsBy(How = How.XPath, Using = "//span[text()='Country']")] IWebElement country;
    [FindsBy(How = How.XPath, Using = "//li[text()=' Afghanistan']")] IWebElement countryinput1;

    //Username
    [FindsBy(How = How.XPath, Using = "//input[@name='username']")] IWebElement usrname;

    //Password
    [FindsBy(How = How.XPath, Using = "//input[@name='password']")] IWebElement pswd;

    //Company Logo - Upload
    [FindsBy(How = How.XPath, Using = "//input[@name='logo']")] IWebElement logoupload;

    //Save
    [FindsBy(How = How.XPath, Using = "//button[text()=' Save ']")] IWebElement compsave;

    //SEARCH
    [FindsBy(How = How.XPath, Using = "//input[@type='search']")] IWebElement compsearch;
    [FindsBy(How = How.XPath, Using = "//div[contains(text(),'Showing 1 to 1 of 1 entries')]")] IWebElement searchresulttext;

    // //ORGANISATION COMPNAY EDIT
    [FindsBy(How = How.XPath, Using = "(//input[@name='name'])[2]")] IWebElement compnameedit;
    
    [FindsBy(How = How.XPath, Using = "//span[@class='fa fa-pencil']")] IWebElement comedit;
    //Update button
    [FindsBy(How = How.XPath, Using = "//button[text()='Update']")] IWebElement compupdate;

    // //ORGANISATION COMPNAY DELETE
    [FindsBy(How = How.XPath, Using = "//span[@class='fa fa-trash']")] IWebElement compdel;
    //Confirm button
    [FindsBy(How = How.XPath, Using = "//button[text()=' Confirm']")] IWebElement compdelconfirm;

    public void organizationmainpage()
    {
        organisationbutton.Click();
        Thread.Sleep(1000);

    }

    public void companymainpage()
    {
//        act = new Actions(driver1);

        companybutton.Click();
        Thread.Sleep(3000);

        Addnewbutton.Click();
        Thread.Sleep(3000);

        compname.Click();
        Thread.Sleep(3000);
        compname.SendKeys("HEVELS TECHNOLOGIES");
        Thread.Sleep(3000);

        comptype.Click();
        Thread.Sleep(3000);
        comtypevalue1.Click();
        Thread.Sleep(3000);
        //act.SendKeys("CORPORATION").KeyDown(comptype, Keys.Enter).Perform();

        legaltradingname.Click();
        Thread.Sleep(3000);
        legaltradingname.SendKeys("Test legal trading name");
        Thread.Sleep(3000);

        regnumber.Click();
        Thread.Sleep(3000);
        regnumber.SendKeys("12061900");
        Thread.Sleep(3000);

        contacnumber.Click();
        Thread.Sleep(3000);
        contacnumber.SendKeys("11223344556677");
        Thread.Sleep(3000);

        email.Click();
        Thread.Sleep(3000);
        email.SendKeys("hevel@testrm.com");
        Thread.Sleep(3000);

        weburl.Click();
        Thread.Sleep(3000);
        weburl.SendKeys("www.hevels.com");
        Thread.Sleep(3000);

        usrname.Click();
        Thread.Sleep(3000);
        usrname.SendKeys("hevels");
        Thread.Sleep(3000);

        pswd.Click();
        Thread.Sleep(3000);
        pswd.SendKeys("123456");
        Thread.Sleep(3000);

        taxEIN.Click();
        Thread.Sleep(3000);
        taxEIN.SendKeys("1020304050");
        Thread.Sleep(3000);

        add1.Click();
        Thread.Sleep(3000);
        add1.SendKeys("test address1");
        Thread.Sleep(3000);

        add2.Click();
        Thread.Sleep(3000);
        add2.SendKeys("test address2");
        Thread.Sleep(3000);

        city.Click();
        Thread.Sleep(3000);
        city.SendKeys("test city");
        Thread.Sleep(3000);

        state.Click();
        Thread.Sleep(3000);
        state.SendKeys("test state");
        Thread.Sleep(3000);

        zip.Click();
        Thread.Sleep(3000);
        zip.SendKeys("695581");
        Thread.Sleep(3000);

        country.Click();
        Thread.Sleep(3000);
        countryinput1.Click();
        Thread.Sleep(3000);

        string Path = "C:\\Users\\sthandam\\OneDrive - RM PLC\\Evolution\\AUTOMATION C#Selenium\\HRMS\\FILES\\Hevels_Logo.jpg";
        logoupload.SendKeys(Path);

        compsave.Click();
        Thread.Sleep(3000);

    }

    public void companysearch()
    {
        compsearch.Click();
        Thread.Sleep(3000);
        compsearch.SendKeys("HEVELS TECHNOLOGIES");
        Thread.Sleep(3000);

        if (searchresulttext.Displayed)
        {
            Console.WriteLine("Newly added company displayed");
        }
    }

        public void companyedit()
        {
        //compsearch.Click();
        //Thread.Sleep(3000);
        //compsearch.SendKeys("HEVELS TECHNOLOGIES");
        //Thread.Sleep(3000);

        comedit.Click();
        Thread.Sleep(3000);

        compnameedit.Clear();
        Thread.Sleep(3000);
        compnameedit.SendKeys("HEVELS TECHNOLOGIES EDITED");
        Thread.Sleep(3000);
        compupdate.Click();
        Thread.Sleep(3000);
    }

    public void companydelete()
    {
        compsearch.Click();
        Thread.Sleep(3000);
        compsearch.SendKeys("HEVELS TECHNOLOGIES EDITED");
        Thread.Sleep(3000);
        compdel.Click();
        Thread.Sleep(10000);
        compdelconfirm.Click();
        Thread.Sleep(10000);
      }

    //excel
    //extendedreport
    //screenshot

}
