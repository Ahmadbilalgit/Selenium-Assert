


using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Threading;

class Entrypoint
{


    public static void Main ()
    {
        IWebDriver driver = new ChromeDriver("./");
        driver.Navigate().GoToUrl("https://www.phptravels.net/login");
        driver.Manage().Window.Maximize();
        driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromMilliseconds(5000);


        IWebElement Userid = driver.FindElement(By.Name("username"));
        Userid.SendKeys("user@phptravels.com");
        //Thread.Sleep(2000);

        

        IWebElement Cookie = driver.FindElement(By.CssSelector("#cookyGotItBtnBox > div > button"));
        Cookie.Click();
       // Thread.Sleep(2000);


        IWebElement Password = driver.FindElement(By.Name("password"));
        Password.SendKeys("demouser");
       // Thread.Sleep(2000);


        IWebElement Button = driver.FindElement(By.CssSelector("button.btn:nth-child(2)"));
        Thread.Sleep(5000);
        Button.Click();
        Thread.Sleep(4000);

        //try
        //{
        //    Assert.IsTrue(driver.FindElement(By.TagName("body")).Text.Contains("Hi, Demo User"));
        //    Console.Write("\n Greeting text is present");
        //}
        //catch (Exception)
        //{
        //    Console.Write("\nGreeting Text is not present");
        //}

        //IWebElement linkText = driver.FindElement(By.LinkText("Rendezvous Hotels"));

        //if (linkText.Displayed)
        //{

        //    Console.Write("\nHotel name present");
        //}

        //else
        //{
        //    Console.Write("\nHotel name is not present");

        //}

        String X = "Hi, Demo Usffer"; //Tests whether the specified condition is true and throws an exception if the condition is false.
        Assert.IsTrue(driver.PageSource.Contains(X));

       
        //element.Click();
        //driver.Quit();
    }



}