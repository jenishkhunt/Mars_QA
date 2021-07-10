using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Text;

namespace Mars_QA.Commoanclass
{
    class Login_page
    {
       
        public void Login(IWebDriver driver)
        {
            //IWebDriver driver = new ChromeDriver(@"D:\onboarding.specflow-master\MarsQA-1\");
            //Enter Url
            driver.Manage().Window.Maximize();

            // enter url
            driver.Navigate().GoToUrl("http://localhost:5000");

            driver.FindElement(By.XPath("//A[@class='item'][text()='Sign In']")).Click();

            //Enter Username
            driver.FindElement(By.XPath("(//INPUT[@type='text'])[2]")).SendKeys("jenishkhunt07@gmail.com");

            //Enter password
            driver.FindElement(By.XPath("//INPUT[@type='password']")).SendKeys("jenish1997");

            driver.FindElement(By.XPath("// html / body / div[2] / div / div / div[1] / div / div[4] / button")).Click();

        }
    }
}
