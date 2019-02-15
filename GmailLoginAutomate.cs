using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace SeleniumTest
{
    class Program
    {
        static void Main(string[] args)
        {            
            var driver = new ChromeDriver(@"C:\Libraries");
            driver.Url = "https://gmail.com";            
            var emailIdBox = driver.FindElement(By.Id("identifierId"));
            emailIdBox.SendKeys("iloveyousachin10");
            var nextButton = driver.FindElement(By.Id("identifierNext"));
            nextButton.Click();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            
            // 2nd page
            var passwordBox = driver.FindElement(By.Name("password"));
            passwordBox.SendKeys("mypasswordhaschanged");            
            var submitButton = driver.FindElement(By.Id("passwordNext"));
            submitButton.Click();          
        }
    }
}
