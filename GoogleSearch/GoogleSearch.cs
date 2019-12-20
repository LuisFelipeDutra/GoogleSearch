using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

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

            driver.FindElementByXPath("//*[@title='Pesquisar']").SendKeys("Cotação do dólar");

            var list = driver.FindElementsByXPath("//*[@value='Pesquisa Google']");

            list[1].Click();

            driver.Close();
        }
    }
}
