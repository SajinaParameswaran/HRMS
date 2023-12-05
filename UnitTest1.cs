using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
public class Tests : Launchsiteinbrowser
{
    public LOGIN LO;
    public DASHBOARD DB;
    public STAFF ST;
    public ORGANISATION ORG;
    public LOGOUT LG;


    [OneTimeSetUp]
    public void Setup()
    {

        launchsite();
    }

    //TEST CASES

    [Test, Order(1)]
    public void TEST1_HRMS_TC_LOGIN()
    {
        LO = new LOGIN(driver1);
        LO.Loginsite();
    }
    [Test, Order(2)]
    //,Ignore("Pls ignore")
    public void TEST2_HRMS_TC_DASHBOARD()
    {
        DB=new DASHBOARD(driver1);
        DB.Dashboardpage();
    }

    [Test, Order(3)]
    public void TEST3_HRMS_TC_STAFF()
    {
        ST=new STAFF(driver1);
        
        ST.Staffmainpage();
        ST.Employeemainpage();
        ST.Employeesearch();
        
    }

    [Test, Order(4)]

    public void TEST4_HRMS_TC_STAFF_EMPLOYEE_REPORT()
    {

        ST.Employeereport();
        windowhandle();
        ST.Employeereportsearch();
        windowhandletoparent();
    }

    [Test, Order(5)]
    public void TEST5_HRMS_TC_STAFF_DOWNLOAD_EMPLOYEE()
    {
       
         //ST.Staffmainpage();
        //ST.Employeemainpage();
        ST.Importemployee();
        ST.Importemployeedownloadfile();
    }

    [Test, Order(6)]
    public void TEST6_HRMS_TC_STAFF_UPLOAD_EMPLOYEE()
    {

        //ST.Staffmainpage();
        //ST.Employeemainpage();
        //ST.Importemployee();
        ST.Importemployeeuploadfile();
        ST.Staffmainpage();
    }
    [Test, Order(7)]
    public void TEST7_HRMS_TC_ORG_COMPANY_ADD_NEW()
    {
        ORG = new ORGANISATION(driver1);

        ORG.organizationmainpage();
        ORG.companymainpage();
        ORG.companysearch();
    }
    [Test, Order(8)]
    public void TEST8_HRMS_TC_ORG_COMPANY_EDIT()
    {
        //ORG.organizationmainpage();
        //ORG.companymainpage();
        //ORG.companysearch();
         ORG.companyedit();
    }

    [Test, Order(9)]
    public void TEST9_HRMS_TC_ORG_COMPANY_DELETE()
    {
        //ORG.organizationmainpage();
       // ORG.companymainpage();
       // ORG.companysearch();
        ORG.companydelete();
    }

    [Test, Order(10)]
    public void TEST10_HRMS_TC_LOGOUT()
    {
       LG=new LOGOUT(driver1);
       LG.HRMSLogout();
    }

    [OneTimeTearDown]
    public void Quitallbrowsers()
    {
        Quitbrowsers();
    }

}
