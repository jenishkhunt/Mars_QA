using Mars_QA.Commoanclass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_QA.Steps.Profile_Skills
{
    [Binding]
    public class Profile_DeleteSkillSteps
    {
        IWebDriver driver = new ChromeDriver(@"D:\onboarding.specflow-master\MarsQA-1\");

        Login_page login = new Login_page();

        [Given(@"click to the Delete Skill")]
        public void GivenClickToTheDeleteSkill()
        {
            login.Login(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            // click to the Skill Button
            driver.FindElement(By.XPath("//a[contains(text(),'Skills')]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [When(@"filled the data to the delete Skill")]
        public void WhenFilledTheDataToTheDeleteSkill()
        {
            driver.FindElement(By.XPath("/html[1]/body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[3]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[3]/span[2]/i[1]")).Click();

        }

        [Then(@"validation to the delete Skill")]
        public void ThenValidationToTheDeleteSkill()
        {
            
        }
    }
}
