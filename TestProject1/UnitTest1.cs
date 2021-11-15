using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace TestProject1
{
    public class Tests
    {
        
        [Test]
        public void Test1()
        {
            IWebDriver driver = new ChromeDriver(@"D:\software\chromedriver_win32");

            driver.Manage().Window.Maximize();

            driver.Navigate().GoToUrl(https://www.google.co.in/);


        }
    }
}