using Mars_QA.Commoanclass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars_QA.Steps.Education
{
    [Binding]
    public class Profile_EditEductionSteps
    {
        IWebDriver driver = new ChromeDriver(@"D:\onboarding.specflow-master\MarsQA-1\");

        Login_page login = new Login_page();

        [Given(@"click to the Edit Education button")]
        public void GivenClickToTheEditEducationButton()
        {
            login.Login(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // click to the Education Button
            driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Edit button
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[1]/tr[1]/td[6]/span[1]/i[1]")).Click();
            Thread.Sleep(1000);
        }
        
        [When(@"filled the data to the edit to the Education")]
        public void WhenFilledTheDataToTheEditToTheEducation()
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add College
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).Clear();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).SendKeys("Unitec");

            //choose College......
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var college = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(college);
            //select by value
            selectElement.SelectByIndex(5);

            //choose Title......
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var title = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[1]/select[1]"));
            //create select element object 
            var selectElement1 = new SelectElement(title);
            //select by value
            selectElement1.SelectByIndex(3);

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Add Degree
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[2]/input[1]")).Clear();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[2]/input[1]")).SendKeys("Commerce");

            //choose Year......
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            var year = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[2]/div[3]/select[1]"));
            //create select element object 
            var selectElement2 = new SelectElement(year);
            //select by value
            selectElement2.SelectByIndex(1);



            //add Education
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[3]/input[1]")).Click();

        }

        [Then(@"validation to the edit Education")]
        public void ThenValidationToTheEditEducation()
        {
            
        }
    }
}
