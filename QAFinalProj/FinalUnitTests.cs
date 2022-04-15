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

        public static Boolean Test2(IWebDriver driver)
        {
            try
            {
                fillForm(driver, "Peirce", "Marks", "peircemarks@gmail.com", "Meff", "hackme", "hackme", "(506) 435-4542", "34 mackay drive", "new", "e4e 1m7", "google.com", "random gibberish", "BEHIND YOU");

                String isValid = driver.Url;

                if (isValid.Contains("http://47.55.247.242/site5/Login.php?message=Registration%20successful!"))
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



        static void fillForm(IWebDriver driver, string fName, string lName, string eMail, string user, string pass, string conFirm, string phone, string address, string province, string postal, string url, string desc, string loc)
        {
            driver.Url = "http://47.55.247.242/site5/login.php";

            IWebElement lnkSignUp = driver.FindElement(By.LinkText("Click Here"));
            lnkSignUp.Click();

            IWebElement txtFName = driver.FindElement(By.Id("firstname"));
            txtFName.SendKeys(fName);

            IWebElement txtLName = driver.FindElement(By.Id("lastname"));
            txtLName.SendKeys(lName);

            IWebElement email = driver.FindElement(By.Id("email"));
            email.SendKeys(eMail);

            IWebElement userName = driver.FindElement(By.Id("username"));
            userName.SendKeys(user);

            IWebElement passWord = driver.FindElement(By.Id("password"));
            passWord.SendKeys(pass);

            IWebElement confirm = driver.FindElement(By.Id("confirm"));
            confirm.SendKeys(conFirm);

            IWebElement txtPhone = driver.FindElement(By.Id("phone"));
            txtPhone.SendKeys(phone);

            IWebElement txtAddress = driver.FindElement(By.Id("address"));
            txtAddress.SendKeys(address);

            IWebElement ddlProvince = driver.FindElement(By.Id("province"));
            ddlProvince.SendKeys(province);

            IWebElement txtPCode = driver.FindElement(By.Id("postalCode"));
            txtPCode.SendKeys(postal);

            IWebElement txtUrl = driver.FindElement(By.Id("url"));
            txtUrl.SendKeys(url);

            IWebElement txtDesc = driver.FindElement(By.Id("desc"));
            txtDesc.SendKeys(desc);

            IWebElement txtLocation = driver.FindElement(By.Id("location"));
            txtLocation.SendKeys(loc);

            IWebElement btnSend = driver.FindElement(By.Id("button"));
            btnSend.Click();
        }
    }
}
