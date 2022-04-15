using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace QAFinalProj
{
    class FinalUnitTests
    {
        public static Boolean Test1(IWebDriver driver)
        {
            try
            {
                driver.Url = "http://47.55.247.242/site5/login.php";

                IWebElement lnkSignUp = driver.FindElement(By.LinkText("Click Here"));
                lnkSignUp.Click();

                String isValid = driver.Url;

                if (isValid.Contains("http://47.55.247.242/site5/signup.php"))
                {
                    return true; ;
                }
                else
                {
                    return false;
                }

            }
            catch
            {
                return false;
            }
        }
    }
}
