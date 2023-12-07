using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;

public class Launchsiteinbrowser
    {
    public IWebDriver driver1;
    public ExtentReports Extreport;
    public ExtentTest extTest;
    public ITakesScreenshot Iss;
    public Screenshot ss;



    public void launchsite()
    {
        driver1 = new ChromeDriver();
        driver1.Url = "http://hrm.qabible.in/hrms/admin";
        Thread.Sleep(1000);

        driver1.Manage().Window.Maximize();               
    }

    public void windowhandle()
    {

        //To move to the new tab
        List<String> child = driver1.WindowHandles.ToList();
        String ch = child[1];
        driver1.SwitchTo().Window(ch);
        Thread.Sleep(3000);
    }
    public void windowhandletoparent()
    {
        //To move back to the main employee page
        driver1.SwitchTo().Window(driver1.WindowHandles[0]);
    }

    public void ReportsHandling()
    {
        var path = new ExtentHtmlReporter(@"C:\Users\sthandam\OneDrive - RM PLC\Evolution\AUTOMATION C#Selenium\HRMS\REPORTS\extentReport.html");
        Extreport = new ExtentReports();

        Extreport.AttachReporter(path);

    }
    public void CloseReport()
    {
        Extreport.Flush();
    }

    public void screensSetup()
    {
        Iss = (ITakesScreenshot)driver1;
        ss = Iss.GetScreenshot();
    }


    public void Quitbrowsers()
    {
        driver1.Quit();
    }

    public void close()
    {
        driver1.Close();
    }

}



    

