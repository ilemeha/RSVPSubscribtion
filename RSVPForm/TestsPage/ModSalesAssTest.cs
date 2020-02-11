using NUnit.Framework;
using RSVPForm.TestsData;
using RSVPForm.WebDriver;
using RSVPForm.Configuration;
using RSVPForm.PageObject;
using Shouldly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Firefox;
using System.Threading;
using OpenQA.Selenium.Interactions;
using System.Windows;

namespace RSVPForm.TestsPage
{
    [TestFixture]
    public class ModSalesAssTest
    {
        [Test]
        public void ModSalesAssTestForm()
        {
            var person = new Person();
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
                driver.Navigate().GoToUrl("https://www.jennair.com/faux-stage---do-not-delete/modweek-2020.html?cache66");

                var rsvpForm = new ModernWeekArchitec(driver);
                //rsvpForm.VerifyPageTitle().ShouldBe("KBIS 2020");
                Thread.Sleep(2000);
                rsvpForm.ClickFirstButton();
                Thread.Sleep(2000);
                rsvpForm.FillOutPerson(person);



                Thread.Sleep(2000);
                rsvpForm.CheckedYes();
                Thread.Sleep(2000);
                //"DESIGNER",  "ARCHITECT", "SERVICE TECH","SALES ASSOCIATE",  "INSTALLER",
                rsvpForm.YourProfession("SALES ASSOCIATE");
                Thread.Sleep(2000);
                rsvpForm.CompName(person);
                Thread.Sleep(3000);

                //Which brands
                //Follow this order "Sub-Zero","Wolf","Cove","Viking", "Miele","Dacor","Jennair","Other Luxe"
                rsvpForm.BrandChoice("Sub-Zero", "Viking", "Cove", "", "Miele", "", "Jennair", "");

                //rsvpForm.EnterDate();
                rsvpForm.ContactedYesNO("Yes");
                Thread.Sleep(3000);
                rsvpForm.EnterDate();
                Thread.Sleep(3000);
                rsvpForm.AgreeI();
                Thread.Sleep(3000);
               // rsvpForm.FinalSubmit();
               // Thread.Sleep(3000);  

              //  rsvpForm.VerifyText().ShouldBe("FORM SUBMITTED SUCCESSFULLY");
               // Thread.Sleep(3000);

            }
        }  
    }
}
