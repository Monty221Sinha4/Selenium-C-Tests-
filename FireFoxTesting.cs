using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;

namespace ZoomTesting
{
    [TestClass]
    public class FireFoxTesting
    {
        [TestMethod]
        public void FireFoxTesitng()
        {
            IWebDriver driver = new FirefoxDriver();
            driver.Url = "https://personality.co.uk/nyss2/c/pfam-bg.php";
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
