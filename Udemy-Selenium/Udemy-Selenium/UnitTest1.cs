using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Udemy_Selenium
{
    public class Tests
    {

        // Hooks in NUnit
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            IWebDriver webDriver = new ChromeDriver(@"C:\Driver");
            webDriver.Navigate().GoToUrl("http://eaapp.somee.com");
        }
    }
}