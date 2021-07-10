﻿using Mars_QA.Commoanclass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars_QA.Steps.Profile_Skills
{
    [Binding]
    public class AddSkill
    {
        IWebDriver driver = new ChromeDriver(@"D:\onboarding.specflow-master\MarsQA-1\");

        Login_page login = new Login_page();

        [Given(@"click to the Add Skill")]
        public void GivenClickToTheSkillButtonAndNewAdd()
        {
            login.Login(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // click to the Skill Button
            driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add new Skill
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/thead[1]/tr[1]/th[3]/div[1]")).Click();


        }

        [When(@"filled the data to the Add Skill")]
        public void WhenFilledTheDataOfTheSkill()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add Skill
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[1]/input[1]")).SendKeys("Testing");

            //choose level
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var education = driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(education);
            //select by value
            selectElement.SelectByIndex(2);

            //add lan
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/div[1]/span[1]/input[1]")).Click();


        }

        [Then(@"validation to the Add Skill")]
        public void ThenValidationOfTheSkill()
        {

        }
    }
}
