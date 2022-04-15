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

            Console.WriteLine("Test 2:");
            Boolean blnTest02;
            blnTest02 = FinalUnitTests.Test2(driver);
            TestResult(blnTest02);
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
