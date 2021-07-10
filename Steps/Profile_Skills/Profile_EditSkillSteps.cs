using Mars_QA.Commoanclass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace Mars_QA.Steps
{
    [Binding]
    public class Profile_SkillSteps
    {
        IWebDriver driver = new ChromeDriver(@"D:\onboarding.specflow-master\MarsQA-1\");

        Login_page login = new Login_page();
        
        [Given(@"click to the Edit Skill")]
        public void GivenClickToTheEditSkill()
        {

            login.Login(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // click to the Skill Button
            driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            //Edit button
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[3]/span[1]/i[1]")).Click();
            Thread.Sleep(1000);

        }
        
        [When(@"filled the data to the edit Skill")]
        public void WhenFilledTheDataToTheEditSkill()
        {
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).Clear();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[1]/input[1]")).SendKeys("Developing");
            Thread.Sleep(1000);
            //choose level
            var education = driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/div[2]/select[1]"));
            //create select element object 
            var selectElement = new SelectElement(education);
            //select by value
            selectElement.SelectByIndex(2);
            Thread.Sleep(1000);
            // update the language
            driver.FindElement(By.XPath("//tbody/tr[1]/td[1]/div[1]/span[1]/input[1]")).Click();

        }

        [Then(@"validation to the edit Skill")]
        public void ThenValidationToTheEditSkill()
        {
          
        }
    }
}
