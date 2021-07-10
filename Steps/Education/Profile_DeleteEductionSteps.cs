using Mars_QA.Commoanclass;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Mars_QA.Steps.Education
{
    [Binding]
    public class Profile_DeleteEductionSteps
    {
        IWebDriver driver = new ChromeDriver(@"D:\onboarding.specflow-master\MarsQA-1\");

        Login_page login = new Login_page();

        [Given(@"click to the language Education button")]
        public void GivenClickToTheLanguageEducationButton()
        {
            login.Login(driver);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

            driver.FindElement(By.XPath("//body/div[@id='account-profile-section']/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[1]/a[3]")).Click();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }
        
        [When(@"Click the delete Education button")]
        public void WhenClickTheDeleteEducationButton()
        {
            driver.FindElement(By.XPath("//body[1]/div[1]/div[1]/section[2]/div[1]/div[1]/div[1]/div[3]/form[1]/div[4]/div[1]/div[2]/div[1]/table[1]/tbody[last()]/tr[1]/td[6]/span[2]/i[1]")).Click();
         
        }

        [Then(@"validation to the delete Education")]
        public void ThenValidationToTheDeleteEducation()
        {
            
        }
    }
}
