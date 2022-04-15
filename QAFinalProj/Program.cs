using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
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

            Console.WriteLine("Test 3:");
            Boolean blnTest03;
            blnTest03 = FinalUnitTests.Test3(driver);
            TestResult(blnTest03);

            Console.WriteLine("Test 4:");
            Boolean blnTest04;
            blnTest04 = FinalUnitTests.Test4(driver);
            TestResult(blnTest04);

            Console.WriteLine("Test 5:");
            Boolean blnTest05;
            blnTest05 = FinalUnitTests.Test5(driver);
            TestResult(blnTest05);

            Console.WriteLine("Test 6:");
            Boolean blnTest06;
            blnTest06 = FinalUnitTests.Test6(driver);
            TestResult(blnTest06);

            Console.WriteLine("Test 7:");
            Boolean blnTest07;
            blnTest07 = FinalUnitTests.Test7(driver);
            TestResult(blnTest07);

            Console.WriteLine("Test 8:");
            Boolean blnTest08;
            blnTest08 = FinalUnitTests.Test8(driver);
            TestResult(blnTest08);

            Thread.Sleep(30000);
            driver.Quit();
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
