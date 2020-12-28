using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace Inegration_Testing
{
    class ITesting
    {
        IWebDriver driver;
        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(); //Browser opening prompt
        }
        [Test]
        public void test()
        {
            driver.Url = "http://google.com";
            //IWebElement element = driver.FindElement(By.XPath("username"));
            //element.SendKeys("170042004");

            //
            //IWebElement element = driver.FindElement(By.Name("txtstudid"));
            //element.SendKeys("Your Id");
            //IWebElement password = driver.FindElement(By.Name("txtpass"));
            //password.SendKeys("Your Password");
            //driver.FindElement(By.Id("studlogin")).Click();
            String at = driver.Title;

            String et = "East West University";
            if (at == et)
            {
                Console.WriteLine("Test Successful");
                IWebElement element2 =
                driver.FindElement(By.XPath("/html/body/table/tbody/tr[4]/td/div/div/div[2]/a"));
                element2.Click();
            }
            else
            {
                Console.WriteLine("Unsuccessful");
            }
        }
        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
        }
    }
}