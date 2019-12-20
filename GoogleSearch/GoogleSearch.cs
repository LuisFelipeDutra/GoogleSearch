using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Drawing;

namespace GoogleSearch
{
    [TestClass]
    public class GoogleSearch
    {
        [TestMethod]
        public void GoogleSearch_Test()
        {
            ChromeDriver driver = new ChromeDriver();

            driver.Navigate().GoToUrl("https://www.google.com/");

            driver.Manage().Window.Maximize();

            driver.FindElementByXPath("//*[@title='Pesquisar']").SendKeys("Cotação do dólar");
            var list = driver.FindElementsByXPath("//*[@value='Pesquisa Google']");
            list[1].Click();

            var timeSpan = DateTime.Now;
            var time = timeSpan.TimeOfDay.ToString();
            
            Screenshot print = ((ITakesScreenshot)driver).GetScreenshot();
            print.SaveAsFile(@"C:\prints\CotacaoDolar" + time.Replace(":", "") + ".png");

            driver.Close();
        }
    }
}
