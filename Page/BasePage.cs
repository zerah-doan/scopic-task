using OpenQA.Selenium;
using SeleniumExtras.WaitHelpers;
using System.Collections.ObjectModel;
using ScopicTask.WebDriver;

namespace TestAssignment.Page
{
    public class BasePage<P> where P : class, new()
    {
        private static readonly Lazy<P> _page = new Lazy<P>(() => new P());
        public static P Page { get { return _page.Value; } }

        #region Common page actions
        public IWebElement WaitForElementClickable(By by)
        {
            return Manager.Wait.Until(ExpectedConditions.ElementToBeClickable(by));
        }

        public IWebElement WaitForElementExists(By by)
        {
            return Manager.Wait.Until(ExpectedConditions.ElementExists(by));
        }

        public ReadOnlyCollection<IWebElement> FindElements(By by)
        {
            return Manager.Driver.FindElements(by);
        }
        public void Click(By by)
        {
            WaitForElementClickable(by).Click();
        }

        public void JsClick(By by)
        {
            var ele = WaitForElementExists(by);
            IJavaScriptExecutor ije = (IJavaScriptExecutor)Manager.Driver;
            ije.ExecuteScript("arguments[0].click();", ele);
        }
        public void Type(By by, string txt, bool clearCurrentTxt = true)
        {
            var ele = WaitForElementClickable(by);
            if (clearCurrentTxt) ele.Clear();
            ele.SendKeys(txt);
        }

        public bool IsDisplayed(By by)
        {
            try
            {
                return WaitForElementClickable(by).Displayed;
            }
            catch { return false; }
        }
        public string Screenshot(string fileName)
        {
            Screenshot img = ((ITakesScreenshot)Manager.Driver).GetScreenshot();
            string imgPath = Path.Combine(TestContext.CurrentContext.TestDirectory, $"{fileName}.png");
            img.SaveAsFile(imgPath);
            return imgPath;
        }
        #endregion



    }
}
