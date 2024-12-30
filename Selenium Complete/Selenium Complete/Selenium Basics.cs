using Microsoft.UI.Xaml.Controls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Microsoft.VisualStudio.TestTools.UnitTesting.AppContainer;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading;

namespace Selenium_Complete
{
    [TestClass]
    public class SeleniumBasics
    {
        [TestMethod]
        //public void LaunchBroweser()
        //{
            // WebDriver driver = new ChromeDriver();

            // driver.Url =  "http://google.com";
            //IWebElement searchBox = driver.FindElement(By.Name("q"));
            // searchBox.SendKeys("India");
            // searchBox.Submit();
            //Thread.Sleep(3000);
            //driver.Quit();
        //}
           // public void Main()
            //{

                //WebDriverManager.cromedriver().setup();
                //WebDriver driver = new ChromeDriver();
                // driver.Url = ("https://ldinsights.azurewebsites.net/");
                // driver.FindElement(By.Id("username")).SendKeys("Admin");
                //driver.FindElement(By.Id("password")).SendKeys("Admin@123");
                //driver.FindElement(By.Id("btnLogin")).Click();
                //driver.FindElement(By.Id("component-nav")).Click();
                //Thread.Sleep(3000);
                //driver.Quit();
           // }
            public void CSSSelectors()
            {

            }
        [TestMethod]
        public void MyTestMethod()
        {

            IWebDriver driver = new ChromeDriver();
            //driver.Url = ("https://ldinsights.azurewebsites.net/");
            //var count = driver.FindElements(By.CssSelector("*")).Count;

            //Console.WriteLine("Number of elements found in css selector" + count);
            Console.WriteLine("Hello bhanu");
            // driver.FindElement(By.CssSelector("#username")).SendKeys("Admin");
            Thread.Sleep(3000);
            driver.Quit();

        }
        }
    }

            
        


        
    
