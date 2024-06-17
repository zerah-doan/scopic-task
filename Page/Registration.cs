using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestAssignment.Page;

namespace ScopicTask.Page
{
    public class Registration : BasePage<Registration>
    {
        public bool CreateAccount(string name, string email, string password)
        {
            Type(By.Name("customerName"), name);
            Type(By.Name("email"), email);
            Type(By.Name("password"), password);
            Type(By.Name("passwordCheck"), password);
            Click(By.Id("continue"));
            return false;
        }
    }
}
