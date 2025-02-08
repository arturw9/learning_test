using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace DotnetSelenium
{
    public class Tests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void Test1()
        {
            // Sudo code for setting up Selenium
            // 1. Create a new instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            // 2. Navigate to the URL
            driver.Navigate().GoToUrl("https://www.google.com/");
            // 2a. Maximize the browser window
            driver.Manage().Window.Maximize();

            // 3. Find the element
            IWebElement webElement = driver.FindElement(By.Name("q"));

            // 4. Type in the element
            webElement.SendKeys("Selenium");

            //5. Click on the element
            webElement.SendKeys(Keys.Return);

            webElement.Click();
        }

        [Test]
        public void EAWebSiteTest()
        {
            // Sudo code for setting up Selenium
            // 1. Create a new instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            // 2. Navigate to the URL
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            // 3. Find the login link
            IWebElement loginLink = driver.FindElement(By.Id("loginLink"));
            // 4. Click the login link
            loginLink.Click();
            // 5. Find the UserName text box
            IWebElement txtUserName = driver.FindElement(By.Name("UserName"));
            // 6. Type on the textUserName
            txtUserName.SendKeys("admin");
            // 7. Find the Password text box
            IWebElement txtPassword = driver.FindElement(By.Id("Password"));
            // 8. Type on the textUserName
            txtPassword.SendKeys("password");
            // 9. Identify the Login Button using Class Name
            //IWebElement btnLogin = driver.FindElement(By.ClassName("btn"));
            // 9. Identify the Login Button using CssSelector
            IWebElement btnLogin = driver.FindElement(By.CssSelector(".btn"));
            // 10. Click login button
            btnLogin.Submit();
        }

        [Test]
        public void EAWebSiteTestReduceSizeCode()
        {
            // Sudo code for setting up Selenium
            // 1. Create a new instance of Selenium Web Driver
            IWebDriver driver = new ChromeDriver();

            // 2. Navigate to the URL
            driver.Navigate().GoToUrl("http://eaapp.somee.com/");
            // 3. Find and Click the login link
            driver.FindElement(By.Id("loginLink")).Click();
            // 5. Find the UserName text box
            driver.FindElement(By.Name("UserName")).SendKeys("admin");
            // 7. Find the Password text box
            driver.FindElement(By.Id("Password")).SendKeys("password");
            // 9. Identify the Login Button using Class Name
            //IWebElement btnLogin = driver.FindElement(By.ClassName("btn"));
            // 9. Identify the Login Button using CssSelector
            driver.FindElement(By.CssSelector(".btn")).Submit();
        }
    }
}