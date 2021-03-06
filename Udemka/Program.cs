﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using System.Threading;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using System.Collections;


// Selenium WebDriver 2016
namespace Udemka
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://tripadvisor.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

            driver.FindElement(By.XPath(".//*[@id='rdoFlights']/div")).Click();
            driver.FindElement(By.XPath(".//*[@id='searchbox']"));
            driver.FindElement(By.XPath(".//*[@id='metaFlightTo']")).SendKeys("Tallinn");
            driver.FindElement(By.XPath(".//*[@id='checkIn']")).Click();
           
            string date = "30-Dec 2016";
            string[] spliter = date.Split('-');
            string month_year = spliter[1];
            string day = spliter[0];

           IList <IWebElement> elem = driver.FindElements(By.XPath("//div[@class='calendar']/div[@class='month']/table/thead/tr/th[@class='caption']"));
            for (int i = 0; i < elem.Count; i++)
            {
                Console.WriteLine(elem[i].Text.Contains("month_year"));


                        


            }
        
                
                 

        }
    }
}

/*IWebDriver driver = new ChromeDriver(@"C: \Users\monk\Desktop");
driver.Navigate().GoToUrl("http://demoqa.com/registration/");
driver.Manage().Window.Maximize();
driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
IWebElement elem = driver.FindElement(By.XPath("//*[@id='profile_pic_10']"));
elem.Click();
elem.SendKeys("‪C:\\Users\\monk\\Desktop\\technology.docx");





 
/*         int num1, num2, temp;
            Console.Write("\nEnter the First Number : ");
            num1 = int.Parse(Console.ReadLine());
            Console.Write("\nEnter the Second Number : ");
           num2 = int.Parse(Console.ReadLine());
            temp = num1;
            num1 = num2;
            num2 = temp;
           Console.Write("\nAfter Swapping : ");
           Console.Write("\nFirst Number : " + num1);
            Console.Write("\nSecond Number : " + num2);
           Console.Read();

           



/*IWebDriver driver = new ChromeDriver();
driver.Navigate().GoToUrl("http://echoecho.com/htmlforms10.htm");
driver.Manage().Window.Maximize();
driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
SelectElement se=new SelectElement(driver.FindElement(By.XPath(".//input[@name='group1']"));)














}
}
}









//create a list of elements under "selenium" keyword  in the search box (e.g. selenium webdriver, selenium training )
// all these elements start with  similar id, find them using "starts-with" locator



//printout a list, showing amount of those elements (e.g. 12)

//Click on one element from the list. Element is selected by the  index (0, out of 12)
//list.get(0).click();






/*IList<IWebElement> elementCount = newSelect.Options;
Console.WriteLine(elementCount.Count);





/* IWebDriver driver = new FirefoxDriver();
driver.Navigate().GoToUrl("http://www.rediff.com/");
driver.Manage().Window.Maximize();
driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
driver.FindElement(By.XPath(".//*[@id='signin_info']/a[@title='Already a user? Sign in']")).Click();
driver.FindElement(By.CssSelector("input[id='login1']")).SendKeys("zora");



/*IWebDriver driver = new FirefoxDriver();
driver.Navigate().GoToUrl("http://www.w3schools.com/");
driver.Manage().Window.Maximize();
driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
driver.FindElement(By.XPath("//*[@id='mySidenav']/a[text()='Learn HTML']")).Click()


//getting a "no such element" exception on this one !
//driver.FindElement(By.XPath("//div[@class='w3-container w3-padding-top']/a[text()='Learn']")).Click();


// driver.FindElement(By.XPath("//nav[starts-with(@id,'mySidenav')]")).Click();

// driver.FindElement(By.XPath("//nav[contains(@id,'mySidenav')]")).Click();




/*IList<IWebElement> list = driver.FindElements(By.TagName("a"));

for (int i = 0; i < list.Count; i++)
{

if (list[i].Text.Equals("Learn SQL"))
{
list[i].Click();
break;






/*IWebDriver driver = new FirefoxDriver();
driver.Navigate().GoToUrl("http://www.w3schools.com/");
driver.Manage().Window.Maximize();

IList<IWebElement> list = driver.FindElements(By.TagName("a"));

for (int i = 0; i < list.Count; i++) 
{
Console.WriteLine(list[i].Text);



}
Console.Read();













/*

IWebDriver driver = new FirefoxDriver();

driver.Navigate().GoToUrl("http://webexpedition18.com/articles/tables-in-web-design-beautiful-examples-and-best-practices/");

IWebElement table = driver.FindElement(By.XPath(".//*[@id='post-4315']/div/div/p[8]/a/img"));
IList <IWebElement> nemo =table.FindElements(By.TagName("a"));
Console.WriteLine("no of rows "+ nemo.Count ());
Thread.Sleep(5000);
driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
Console.ReadLine();

*/





//driver.Manage().Cookies.DeleteAllCookies();
// driver.Manage().Window.Maximize();
// for (int i = 0; i < footer.FindElements(By.TagName("a")).Count(); i++)
//{

// if (footer.FindElement(By.TagName("a")).Text.Contains("Style captains")) ;

//Console.WriteLine("Links in the page");
//Console.WriteLine(driver.FindElements(By.TagName("a")).Count());
//Console.ReadLine();



// IWebElement table  = driver.FindElement(By.Id("inningsBat1"));
//List<IWebElement>noofrows=table.FindElements(By.TagName("tr"))>
//Console.WriteLine("no of rows" + noofrows.)




//Console.WriteLine(driver.PageSource);
//driver.FindElement(By.CssSelector("input[class='input password']")).SendKeys("1000");
//iframe id=
//driver.SwitchTo().Frame(3);
// driver.FindElement(By.CssSelector("input[class='input password']")).SendKeys("1000");
// Console.WriteLine(driver.PageSource();
//driver.SwitchTo(default);






// driver.Manage().Window.Maximize();

//Actions abs = new Actions(driver);
//IWebElement element = driver.FindElement(By.ClassName("nav-line-1"));
//abs.MoveToElement(element).Build().Perform();
//IWebElement xyz = driver.FindElement(By.ClassName("nav-input"));
//abs.KeyDown(Keys.Shift).MoveToElement(xyz).SendKeys("smalletters").Build().Perform();
//abs.ContextClick(xyz).Build().Perform();



// driver.FindElement()



//driver.FindElement(By.Id("twotabsearchtextbox")).SendKeys("12345");




//driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));

//driver.FindElement(By.XPath(".//*[@id='managed-overlay']/div/div/div/div[4]/div/div/div/div/div/a")).Click();

// driver.FindElement(By.XPath(".//*[@id='hdr-service']")).Click();
// driver.FindElement(By.XPath(".//*[@id='hdr-help']")).Click();
// driver.Quit();



// SelectElement se = new SelectElement(driver.FindElement(By.XPath(".//*[@id='hdr-feedback']"))); //Locating select list
// se.SelectByText("Item1"); //Select item from list having option text as "Item1"



//IWebElement address = driver.FindElement(By.XPath(".//*[@id='hdr-feedback']"));
//SelectElement ab = new SelectElement(address);
//ab.SelectByText("feedback");
//alert al=driver.SwitchTo().alert();


//SelectElement abc=new SelectElement(driver.FindElement(By.CssSelector(".//*[@id='roundWay']/form/ul/li[1]/input[1]")));

// abc.SelectByText("Daipur");


//SelectElement se = new SelectElement(driver.FindElement(By.id("select_element_id"))); //Locating select list
//se.SelectByText("Item1"); //Select item from list having option text as "Item1"

//se.SelectByValue("Item1"); //Select item from list having option value as "Item1"
//driver.Quit();

//driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));






//address показывает, где находится; abc выбирает,использую address




//abc.SelectByText("Suede");




//driver.FindElement(By.CssSelector("input[id='quick_email']")).SendKeys("14802464690");
//driver.FindElement(By.CssSelector("input[id='quick_pass']")).SendKeys("Vertuta22!");

//driver.FindElement(By.Id("quick_email")).SendKeys("14802464690");
//driver.FindElement(By.Id("quick_pass")).SendKeys("Vertuta22!");
// driver.FindElement(By.XPath(".//*[@id='quick_login_button']")).Click();
// driver.FindElement(By.XPath("//button[@class='flat_button button_wide button_big']")).Click();

//driver.FindElement(By.Id("quick_login_button")).Click();
//driver.FindElement(By.LinkText("Forgot your password?")).Click();
//driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10));
//driver.FindElement(By.CssSelector("[id='quick_email']")).SendKeys("testing");
//driver.FindElement(By.XPath(".//*[@id='quick_email'] ")).SendKeys("14802464690");
// driver.FindElement(By.XPath(" .//*[@id='quick_pass']")).SendKeys("Vertuta22!");
//driver.FindElement(By.XPath("//button[@class='flat_button button_wide button_big']")).Click();




