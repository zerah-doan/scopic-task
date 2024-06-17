using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebDriverManager.DriverConfigs.Impl;
using WebDriverManager;

namespace ScopicTask.WebDriver
{
    public class Factory
    {
        public static IWebDriver Create(EBrowser browser)
        {
            switch (browser)
            {
                case EBrowser.Chrome:
                    new DriverManager().SetUpDriver(new ChromeConfig());                    
                    return new ChromeDriver();
                default:
                    throw new Exception("Not support yet");
            }
        }
    }
}
