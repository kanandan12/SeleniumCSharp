using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace SeleniumTestProject
{
    [TestFixture]
    public class Tests
    {
        IWebDriver driver = new ChromeDriver();

        [SetUp]
        public void Setup()
        {
            driver.Manage().Window.Maximize();
            driver.Url = "https://www.google.com/";
            Console.WriteLine("Launch Browser Sucessfully");

        }

        [Test]
        public void Test1()
        {
            IWebElement element = driver.FindElement(By.Name("q"));

            Thread.Sleep(1000);
            element.SendKeys("Harry Potter");
            Console.WriteLine("Launch Browser Sucessfully");
                   

            //driver.Close();



        }
    }
}