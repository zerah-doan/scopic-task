using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScopicTask.WebDriver
{
    public class Manager
    {
        private Manager() { }

        private static readonly ThreadLocal<IWebDriver> _driver = new ThreadLocal<IWebDriver>(() => Factory.Create(EBrowser.Chrome));
        public static IWebDriver Driver
        {
            get
            {
                if (_driver.Value == null)
                {
                    _driver.Value = Factory.Create(EBrowser.Chrome);
                }
                return _driver.Value;
            }
        }
        private static readonly ThreadLocal<WebDriverWait> _wait = new ThreadLocal<WebDriverWait>(() => new WebDriverWait(Driver, TimeSpan.FromMinutes(1)));

        public static WebDriverWait Wait
        {
            get
            {
                if (_wait.Value == null)
                {
                    _wait.Value = new WebDriverWait(Driver, TimeSpan.FromMinutes(1));

                }
                return _wait.Value;
            }
        }

        public static void Dispose()
        {
            Driver?.Quit();
            _driver.Value = null;
            _wait.Value = null;
        }
    }
}
