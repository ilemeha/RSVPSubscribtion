﻿using NUnit.Framework;
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
    public class ModInstallerTest
    {
        [Test]
        public void InstallerTestFrom()
        {
            var person = new Person();
            using (var driver = DriverUtils.CreateWebDriver())
            {
                driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(50);
                driver.Navigate().GoToUrl("https://www.jennair.com/faux-stage---do-not-delete/modweek-2020.html?cache66");

                var rsvpForm = new ModernWeekArchitec(driver);
                //rsvpForm.VerifyPageTitle().ShouldBe("KBIS 2020");
                //Thread.Sleep(2000);
                rsvpForm.ClickFirstButton();
                Thread.Sleep(2000);
                rsvpForm.FillOutPerson(person);
                Thread.Sleep(2000);
                rsvpForm.CheckedYes();
                Thread.Sleep(2000);
                //"DESIGNER",  "ARCHITECT", "SERVICE TECH","SALES ASSOCIATE",  "INSTALLER",
                rsvpForm.YourProfession("INSTALLER");
                Thread.Sleep(2000);
               // rsvpForm.FirmesName(person);
                rsvpForm.CompName(person);
                Thread.Sleep(3000);

                //Which brands
                //Follow this order "Sub-Zero","Wolf","Cove","Viking", "Miele","Dacor","Jennair","Other Luxe"
                rsvpForm.BrandChoice("", "Wolf", "Cove", "", "Miele", "", "", "Other Luxe");
                Thread.Sleep(2000);

                //What is your average project years
                //Follow this order 1-10 PER YEAR, 11-20 PER YEAR, 21+ PER YEAR
                rsvpForm.ProjectYears("21");
                Thread.Sleep(2000);

                // Follow this order "$0-151", "$151-300", "$301-750", "$751-1.5M", "$1.6M"
               // rsvpForm.ProjectTotalAv("", "$151-300", "", "", "");
               //Thread.Sleep(3000);


                //What is the average TOTAL value of your KITCHEN projects?*
                //Follow this order "$0-50", "$51-150", "$151-250","$251K"
               // rsvpForm.KitchenProj("$251K");
               // Thread.Sleep(3000);

                //What type of projects do you work on most? (Select one)*
                //"Residential", "Commercial", "Both"
                rsvpForm.ProjectsType("Residential");
                Thread.Sleep(3000);

                //What are your professional social media handles?
               // rsvpForm.TwitMedia("tw/mytweeet");
                //rsvpForm.InstagMedia("");
                //rsvpForm.LinkMedia("dfdgdg/fdf");
               
                Thread.Sleep(3000);
                //rsvpForm.EnterDate();
                rsvpForm.ContactedYesNO("No");
                Thread.Sleep(3000);
                //rsvpForm.EnterDate();
                //Thread.Sleep(3000);
                rsvpForm.AgreeI();
                Thread.Sleep(3000);
                //rsvpForm.FinalSubmit();
               // Thread.Sleep(3000);
               

               // rsvpForm.VerifyText().ShouldBe("FORM SUBMITTED SUCCESSFULLY");
                //Thread.Sleep(3000);

            }
        }  
    }
}
