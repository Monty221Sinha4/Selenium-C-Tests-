using System;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;

namespace ZoomTesting
{
    [TestClass]
    public class ChromeTest
    {
        [TestMethod]
        public void ChromeTesting()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://personality.co.uk/nyss2/c/pfam-bg.php";
            Thread.Sleep(2000);
            driver.Quit();

        }

      
    }
}
