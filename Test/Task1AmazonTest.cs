using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;
using ScopicTask.WebDriver;
using ScopicTask.Page;
using ScopicTask.Util;

namespace ScopicTask.Test
{
    public class Task1AmazonTest
    {
        [SetUp]
        public void Setup()
        {
            Manager.Driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(0.5);
            Manager.Driver.Manage().Window.Maximize();
            Home.Page.GoTo();
            Thread.Sleep(10000); //Pause to bypass capcha
        }

        [TearDown]
        public void TearDown()
        {
            Manager.Dispose();
        }

        [Test]
        public void E2E_RegisterToLogin()
        {
            Home.Page.Register();
            
            //1. Empty input
            Assert.That(Registration.Page.CreateAccount("", "", ""), Is.False, "Assert registration is not successfull");
            //2. Empty name
            Assert.That(Registration.Page.CreateAccount("", "testmail".AddTimeStamp() + "@yopmail.com", "P@ssword123"), Is.False, "Assert registration is not successfull");
            //3. Empty password
            Assert.That(Registration.Page.CreateAccount("Cus Name", "testmail".AddTimeStamp() + "@yopmail.com", ""), Is.False, "Assert registration is not successfull");

        }
    }
}
