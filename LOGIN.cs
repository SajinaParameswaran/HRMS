using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    public class LOGIN
{

    IWebDriver driver1;

    public LOGIN(IWebDriver driver1)
    {
        PageFactory.InitElements(driver1, this);
    }


        [FindsBy(How = How.XPath, Using = "//input[@id='iusername']")] IWebElement username;
        [FindsBy(How = How.XPath, Using = "//input[@id='ipassword']")] IWebElement password;
        [FindsBy(How = How.XPath, Using = "//button[text()=' Login']")] IWebElement loginbutton;



    public void Loginsite()
    {
        username.SendKeys("admin");
        Thread.Sleep(1000);
        password.SendKeys("123456");
        Thread.Sleep(1000);
        loginbutton.Click();
        Thread.Sleep(5000);
    }







    }
