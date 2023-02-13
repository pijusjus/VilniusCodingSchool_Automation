using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using static System.Net.WebRequestMethods;
using OpenQA.Selenium.Support.UI;

namespace Homework
{
    public class HomeworkTestTwo
    {
        [Test]
        public void FieldFill()
        {
            IWebDriver driver = new ChromeDriver();

            driver.Url = "https://demoqa.com/text-box";

            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(10));

            string name = "Pijus Jusys";
            string email = "dummyEmail@gmail.com";
            string cAdress = "Test street 101 Avenue";
            string pAdress = "Test street 302 Avenue";

            IWebElement fullName = driver.FindElement(By.XPath("//*[@id=\"userName\"]"));
            IWebElement emailField = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            IWebElement currentAdress = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            IWebElement permanentAddress = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));
            IWebElement submit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));
            
            fullName.SendKeys(name);
            emailField.SendKeys(email);
            currentAdress.SendKeys(cAdress);
            permanentAddress.SendKeys(pAdress);
            submit.Click();

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(By.XPath("//*[@id=\"name\"]")));

            IWebElement nameResult = driver.FindElement(By.XPath("//*[@id=\"name\"]"));
            IWebElement emailResult = driver.FindElement(By.XPath("//*[@id=\"email\"]"));
            IWebElement cAddressResult = driver.FindElement(By.XPath("//*[@id=\"currentAddress\"]"));
            IWebElement pAddressResult = driver.FindElement(By.XPath("//*[@id=\"permanentAddress\"]"));

            Assert.AreEqual(name,nameResult.Text,"Names are not matching");
            Assert.AreEqual(email,emailResult.Text, "Emails are not matching");
            Assert.AreEqual(cAdress,cAddressResult.Text, "Adresses are not matching");
            Assert.AreEqual(pAdress,pAddressResult.Text, "Permanent Addresses are not matching");

            driver.Quit();
        }

        [Test]
        public void EmailFieldError()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://demoqa.com/text-box";

            string dummyEmail = "1234567890";

            IWebElement emailField = driver.FindElement(By.XPath("//*[@id=\"userEmail\"]"));
            IWebElement submit = driver.FindElement(By.XPath("//*[@id=\"submit\"]"));

            emailField.SendKeys(dummyEmail);
            submit.Click();


            if (emailField.GetAttribute("class").Contains("field-error"))
            {
                Assert.IsTrue(true);
            }

            else
            {
                Assert.IsTrue(false, "The error is not working");
            }
        }
    }
}
