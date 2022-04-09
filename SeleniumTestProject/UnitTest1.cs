using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.IO;
using System.Threading;

namespace SeleniumTestProject
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            string path = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
            driver = new ChromeDriver(path + @"\Driver\");
            driver.Manage().Window.Maximize();
        
        }

        [Test]
        public void Test1()
        {
            driver.Navigate().GoToUrl("https://www.google.com/");
            Console.WriteLine("Launch Browser Sucessfully");
            

            Thread.Sleep(3000);
            // Switch to first frame
            driver.SwitchTo().Frame(0);

            // Click First Frame No Thanks Button page 
            IWebElement firstFrame = driver.FindElement(By.XPath("//*[@id='yDmH0d']/c-wiz/div/div/c-wiz/div/div/div/div[2]/div[2]/button"));
            String firstFrameName = firstFrame.Text;
            Console.WriteLine(firstFrameName);
            firstFrame.Click();


            /*
             // First Frame Sigin Button
             IWebElement firstFrame = driver.FindElement(By.LinkText("Sign in"));
             String firstFrameName = firstFrame.Text; 
             Console.WriteLine(firstFrameName); 
             firstFrame.click();*/

            // Switch to default frame
            driver.SwitchTo().DefaultContent();
            
            Thread.Sleep(3000);
            IWebElement element = driver.FindElement(By.Name("q"));
            element.SendKeys("Harry Potter");
            element.Click();
            Thread.Sleep(3000);

            /*WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(30));
            IWebElement SearchResult = wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementExists(By.XPath(target_xpath)));
            SearchResult.Click();*/

            //sdgsa

        }

        [TearDown]
        public void Close_Browser()
        {
            driver.Quit();
        }


    }
}