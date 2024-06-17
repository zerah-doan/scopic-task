using OpenQA.Selenium;
using ScopicTask.WebDriver;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Page;

namespace ScopicTask.Page
{
    public class SignIn : BasePage<SignIn>
    {
        public bool LogIn(string email, string password)
        {
            Type(By.Name("email"), email);
            Click(By.Id("continue"));
            Type(By.Name("password"), password);
            Click(By.Id("signInSubmit"));
            return !Manager.Driver.Title.Equals("Amazon Sign-In"); //Suppose return true when logging in successfully
        }
    }
}
