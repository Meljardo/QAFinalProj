using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QAFinalProj
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Selenium");

            Console.WriteLine("Test 1:");
            Boolean blnTest01;
            blnTest01 = FinalUnitTests.Test1(driver);
            TestResult(blnTest01);
        }


        static void TestResult(Boolean blnResult)
        {
            if (blnResult)
            {
                Console.WriteLine("Passed!");
            }
            else
            {
                Console.WriteLine("Failed!");
            }
        }
    }
}
