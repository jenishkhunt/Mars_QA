using Mars_QA.Commoanclass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using TechTalk.SpecFlow;

namespace Mars_QA.Steps.Education
{
    [Binding]
    public class Profile_addEductionSteps
    {
        IWebDriver driver = new ChromeDriver(@"D:\onboarding.specflow-master\MarsQA-1\");

        Login_page login = new Login_page();

        [Given(@"click to the Education button and new add")]
        public void GivenClickToTheEducationButtonAndNewAdd()
        {

            login.Login(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // click to the Education Button
            driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add new Education
            driver.FindElement(By.XPath("//thead/tr[1]/th[6]/div[1]")).Click();

        }

        [When(@"filled the data to the Education")]
        public void WhenFilledTheDataToTheEducation()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add College
            driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")).SendKeys("Wintec");

            //choose College......
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var college = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(college);
            //select by value
            selectElement.SelectByIndex(3);

            //choose Title......
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var title = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[1]/select[1]"));
            //create select element object 
            var selectElement1 = new SelectElement(title);
            //select by value
            selectElement1.SelectByIndex(1);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add Degree
            driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[2]/input[1]")).SendKeys("Engineering");

            //choose Year......
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var year = driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[2]/div[3]/select[1]"));
            //create select element object 
            var selectElement2 = new SelectElement(year);
            //select by value
            selectElement2.SelectByIndex(3);



            //add Education
            driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/div[1]/div[3]/div[1]/input[1]")).Click();


        }

        [Then(@"validation to the Education")]
        public void ThenValidationToTheEducation()
        {
            
        }
    }
}
