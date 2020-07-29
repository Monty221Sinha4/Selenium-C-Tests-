using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.IE;
using OpenQA.Selenium;

namespace ZoomTesting
{
    [TestClass]
    public class InternExpolerDriver
    {
        [TestMethod]
        public void InternetExpolerDriver()
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "https://personality.co.uk/nyss2/c/pfam-bg.php";
            Thread.Sleep(2000);
            driver.Quit();
        }
    }
}
