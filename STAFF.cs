using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class STAFF 
    {

    IWebDriver driver1;

    public STAFF(IWebDriver driver1)
    {
        PageFactory.InitElements(driver1, this);
    }



    //STAFF
    [FindsBy(How = How.XPath, Using = "//span[text()='Staff']")] IWebElement Staffbutton;

    //EMPLOYEE
    [FindsBy(How = How.XPath, Using = "//a[text()=' Employees']")] IWebElement employeebutton;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control input-sm']")] IWebElement empsearch;
    [FindsBy(How=How.XPath,Using = "//button[text()=' Report ']")] IWebElement report;

    //REPORT
    [FindsBy(How = How.XPath, Using = "//a[text()='Employement Report']")] IWebElement empreport;
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control input-sm']")] IWebElement empreportsearch;
    
    //IMPORT EMPLOYEES
    [FindsBy(How = How.XPath, Using = "//a[text()=' Import Employees']")] IWebElement importemp;

    //DOWNLOAD SAMPLE FILE
    [FindsBy(How = How.XPath, Using = "//a[text()=' Download sample File ']")] IWebElement empdownloadsamplefile;

    //UPLOAD FILE
    [FindsBy(How = How.XPath, Using = "//input[@class='form-control-file']")] IWebElement empuploadfile;
    [FindsBy(How = How.XPath, Using = "//button[text()=' Save']")] IWebElement empuploadfilesave;

    public void Staffmainpage()
    {
        Staffbutton.Click();
        Thread.Sleep(3000);
    }

    public void Employeemainpage()

    {
        employeebutton.Click();
        Thread.Sleep(3000);
    }


    public void Employeesearch()
    {
        empsearch.Click();
        empsearch.SendKeys("Ameyaa AS");
        Thread.Sleep(3000);
        empsearch.Clear();
        Thread.Sleep(3000);
    }


    public void Employeereport()
    {
        report.Click();
        Thread.Sleep(3000);
        empreport.Click();
        Thread.Sleep(3000);

    }

    public void Employeereportsearch()
    {
        empreportsearch.Click();
        Thread.Sleep(3000);
        empreportsearch.SendKeys("Ameyaa AS");
        Thread.Sleep(3000);
    }    

     public void Importemployee()
    {
        importemp.Click();
        Thread.Sleep(3000);
    }

    public void Importemployeedownloadfile()
    {
        empdownloadsamplefile.Click();
        Thread.Sleep(3000);
    }

    public void Importemployeeuploadfile()
    {
        String path = @"C:\Users\sthandam\OneDrive - RM PLC\Evolution\AUTOMATION C#Selenium\HRMS\FILES\EMP UPLOAD FILE.csv";
        empuploadfile.SendKeys(path);
        Thread.Sleep(3000);
        empuploadfilesave.Click();
        Thread.Sleep(3000);
    }
}

