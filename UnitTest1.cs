using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;

public class Tests : Launchsiteinbrowser
{
    public LOGIN LO;
    public DASHBOARD DB;
    public STAFF ST;
    public ORGANISATION ORG;
    public LOGOUT LG;
    //public ExtentReports Extreport;
    //public ExtentTest extTest;


    [OneTimeSetUp]
    public void Setup()
    {

        ReportsHandling();
        launchsite();

    }

    //TEST CASES

    [Test, Order(1)]
    public void TEST1_HRMS_TC_LOGIN()
    {
        extTest = Extreport.CreateTest("Admin Login").Info("Login as Admin user");
        LO = new LOGIN(driver1);
        LO.Loginsite();
        extTest.Log(Status.Info, "Logged in as Admin");
    }
    [Test, Order(2)]
    //,Ignore("Pls ignore")
    public void TEST2_HRMS_TC_DASHBOARD()
    {
        extTest = Extreport.CreateTest("DASHBOARD").Info("Login as Admin user");
        DB =new DASHBOARD(driver1);
        DB.Dashboardpage();
        extTest.Log(Status.Pass, "DASHBOARD");
    }

    [Test, Order(3)]
    public void TEST3_HRMS_TC_STAFF()
    {
        extTest = Extreport.CreateTest("STAFF").Info("Login as Admin user");
        ST =new STAFF(driver1);
        
        ST.Staffmainpage();
        ST.Employeemainpage();
        ST.Employeesearch();
        extTest.Log(Status.Pass, "STAFF");

    }

    [Test, Order(4)]

    public void TEST4_HRMS_TC_STAFF_EMPLOYEE_REPORT()
    {
        extTest = Extreport.CreateTest("EMPLOYEE REPORT").Info("Login as Admin user");
        ST.Employeereport();
        windowhandle();
        ST.Employeereportsearch();
        windowhandletoparent();

        extTest.Log(Status.Pass, "EMPLOYEE REPORT");

    }

    [Test, Order(5)]
    public void TEST5_HRMS_TC_STAFF_DOWNLOAD_EMPLOYEE()
    {
        extTest = Extreport.CreateTest("IMPORT EMPLOYEE").Info("Login as Admin user");
        //ST.Staffmainpage();
        //ST.Employeemainpage();
        ST.Importemployee();
        ST.Importemployeedownloadfile();

        extTest.Log(Status.Pass, "IMPORT EMPLOYEE");
    }

    [Test, Order(6)]
    public void TEST6_HRMS_TC_STAFF_UPLOAD_EMPLOYEE()
    {
        extTest = Extreport.CreateTest("UPLOAD EMPLOYEE").Info("Login as Admin user");
        //ST.Staffmainpage();
        //ST.Employeemainpage();
        //ST.Importemployee();
        ST.Importemployeeuploadfile();
        ST.Staffmainpage();

        extTest.Log(Status.Pass, "UPLOAD EMPLOYEE");

    }
    [Test, Order(7)]
    public void TEST7_HRMS_TC_ORG_COMPANY_ADD_NEW()
    {
        extTest = Extreport.CreateTest("COMPANY_ADD_NEW").Info("Login as Admin user");

        ORG = new ORGANISATION(driver1);

        ORG.organizationmainpage();

        screensSetup();
        ss.SaveAsFile("C:\\Users\\sthandam\\OneDrive - RM PLC\\Evolution\\AUTOMATION C#Selenium\\HRMS\\SCREENSHOTS\\Organization.jpeg", ScreenshotImageFormat.Jpeg);

        ORG.companymainpage();
        ORG.companysearch();

        extTest.Log(Status.Pass, "COMPANY_ADD_NEW");

    }
    [Test, Order(8)]
    public void TEST8_HRMS_TC_ORG_COMPANY_EDIT()
    {
        extTest = Extreport.CreateTest("ORG_COMPANY_EDIT").Info("Login as Admin user");

        //ORG.organizationmainpage();
        //ORG.companymainpage();
        //ORG.companysearch();
        ORG.companyedit();

        extTest.Log(Status.Pass, "ORG_COMPANY_EDIT");

    }

    [Test, Order(9)]
    public void TEST9_HRMS_TC_ORG_COMPANY_DELETE()
    {
        extTest = Extreport.CreateTest("ORG_COMPANY_DELETE").Info("Login as Admin user");
        //ORG.organizationmainpage();
        // ORG.companymainpage();
        // ORG.companysearch();
        ORG.companydelete();

        extTest.Log(Status.Pass,"ORG_COMPANY_DELETE");
    }

    [Test, Order(10)]
    public void TEST10_HRMS_TC_LOGOUT()
    {
       extTest = Extreport.CreateTest("HRMS_LOGOUT").Info("LOGOUT");
       LG =new LOGOUT(driver1);
       LG.HRMSLogout();

       extTest.Log(Status.Pass, "LOGOUT");

    }

    [OneTimeTearDown]
    public void Quitallbrowsers()
    {
       
        Quitbrowsers();
        CloseReport();
    }

    

}
