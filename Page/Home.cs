﻿using OpenQA.Selenium;
using ScopicTask.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Page;

namespace ScopicTask.Page
{
    public class Home : BasePage<Home>
    {
        public Home GoTo()
        {
            Manager.Driver.Navigate().GoToUrl("https://www.amazon.com/");
            return this;
        }

        public Registration Register()
        {
            JsClick(By.XPath("//a[./text()='Start here.']"));
            return Registration.Page;
        }
    }
}
