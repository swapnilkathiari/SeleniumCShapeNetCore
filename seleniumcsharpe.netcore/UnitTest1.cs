using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace seleniumcsharpe.netcore
{
    public class Tests
    {
        public IWebDriver? Driver;
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("setup");
            Driver = new ChromeDriver();
        }

        [Test]
        public void Test1()
        {
            Driver.Navigate().GoToUrl("https://demo.aspnetawesome.com/");

            Driver.FindElement(By.Id("Meal")).SendKeys("tomato");
            IWebElement combocontrol = Driver.FindElement(By.XPath("//input[@id='AllMealsCombo-awed']"));
            combocontrol.Clear();
            combocontrol.SendKeys("tomato");

            Console.WriteLine("test1"); 
            Assert.Pass();
        }
    }
}