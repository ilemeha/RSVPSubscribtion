using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using OpenQA.Selenium.Support.UI;
using RSVPForm.TestsData;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace RSVPForm.PageObject
{
    public class ModernWeekArchitec

    {
        private IWebDriver _driver;

        public ModernWeekArchitec(IWebDriver driver)
        {
            _driver = driver;
        }
        private IWebElement PageTitle => _driver.FindElement(By.CssSelector(".hero__content .section-story__preheader"));
        //private IWebElement JoinBtn => _driver.FindElement(By.XPath("//a[contains(text(),'Sign Up')]"));
        private IWebElement JoinBtn => _driver.FindElement(By.XPath("//a[@href='#signup']"));
        private IWebElement FirstName => _driver.FindElement(By.Id("mce-FNAME"));
        private IWebElement FNameError => _driver.FindElement(By.Id("mce-FNAME-error"));
        private IWebElement LastName => _driver.FindElement(By.Id("mce-LNAME"));
        private IWebElement EmailInput => _driver.FindElement(By.Id("mce-EMAIL"));
        private IWebElement PhoneNumberInput => _driver.FindElement(By.Id("mce-PHONE"));
        private IWebElement YesOffers => _driver.FindElement(By.XPath("//label[@id='EL__51__']/span"));
        private IWebElement YesON => _driver.FindElement(By.Id("check"));

        //List of Prorfession radio button
        private IWebElement DesignerProf => _driver.FindElement(By.XPath("//*[@id='mce-PROFESS-0']/parent::label"));
        private IWebElement Architec => _driver.FindElement(By.XPath("//*[@id='mce-PROFESS-1']/parent::label"));
        private IWebElement ServiceTech => _driver.FindElement(By.XPath("//*[@id='mce-PROFESS-2']/parent::label"));
        private IWebElement SalesAssocit => _driver.FindElement(By.XPath("//*[@id='mce-PROFESS-3']/parent::label"));
        private IWebElement Builder => _driver.FindElement(By.XPath("//*[@id='mce-PROFESS-4']/parent::label"));
        private IWebElement Installer => _driver.FindElement(By.XPath("//*[@id='mce-PROFESS-5']/parent::label"));
        private IWebElement OtherProf => _driver.FindElement(By.XPath("//*[@id='mce-PROFESS-6']/parent::label"));

        private IWebElement FirmName => _driver.FindElement(By.Id("mce-FIRM"));
        private IWebElement CompanyName => _driver.FindElement(By.Id("mce-COMPANY"));
        


        //List brands checkboxes
        private IWebElement SubZero => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-1']/parent::label"));
        private IWebElement Viking => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-4']/parent::label"));
        private IWebElement Wolf => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-2']/parent::label"));
        private IWebElement Cove => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-3']/parent::label"));
        private IWebElement Miele => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-7']/parent::label"));
        private IWebElement Dacor => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-6']/parent::label"));
        private IWebElement Jennair => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-0']/parent::label"));
        private IWebElement Other => _driver.FindElement(By.XPath("//*[@id='mce-group[7567]-7567-8']/parent::label"));

        //Years projects
        private IWebElement OneTenYer => _driver.FindElement(By.XPath("//*[@id='mce-PROJECTFR-0']/parent::label"));
        private IWebElement ElevenTwenty => _driver.FindElement(By.XPath("//*[@id='mce-PROJECTFR-1']/parent::label"));
        private IWebElement TwentyPlus => _driver.FindElement(By.XPath("//*[@id='mce-PROJECTFR-2']/parent::label"));

        //What is the average TOTAL project
        private IWebElement ZeroHundFH => _driver.FindElement(By.XPath("//*[@id='mce-MMERGE15-0']/parent::label"));
        private IWebElement OneThreeH => _driver.FindElement(By.XPath("//*[@id='mce-MMERGE15-1']/parent::label"));
        private IWebElement ThreeSevenH => _driver.FindElement(By.XPath("//*[@id='mce-MMERGE15-2']/parent::label"));
        private IWebElement SevenMill => _driver.FindElement(By.XPath("//*[@id='mce-MMERGE15-3']/ parent::label"));
        private IWebElement MillPlus => _driver.FindElement(By.XPath("//*[@id='mce-MMERGE15-4']/parent::label"));
        //What is the average TOTAL value of your KITCHEN projects?
        private IWebElement Kitchen50 => _driver.FindElement(By.XPath("//*[@id='mce-KITCHENPRO-0']/parent::label"));
        private IWebElement Kitchen150=> _driver.FindElement(By.XPath("//*[@id='mce-KITCHENPRO-1']/parent::label"));
        private IWebElement Kitchen250 => _driver.FindElement(By.XPath("//*[@id='mce-KITCHENPRO-2']/parent::label"));
        private IWebElement Kitchen251 => _driver.FindElement(By.XPath("//*[@id='mce-KITCHENPRO-3']/parent::label"));

        //What type of projects do you work on most? (Select one) 
        private IWebElement Residential => _driver.FindElement(By.XPath("//*[@id='mce-PROJTYPE-1']/parent::label"));
        private IWebElement Commercial => _driver.FindElement(By.XPath("//*[@id='mce-PROJTYPE-0']/parent::label"));
        private IWebElement Both => _driver.FindElement(By.XPath("//*[@id='mce-PROJTYPE-2']/parent::label"));

        //What are your professional social media handles?
        private IWebElement TwitterH => _driver.FindElement(By.Id("mce-MMERGE9"));
        private IWebElement InstagramH => _driver.FindElement(By.Id("mce-MMERGE10"));
        private IWebElement LinkedH => _driver.FindElement(By.Id("mce-MMERGE11"));
        //Would you like to be contacted about a project starting soon?*
        private IWebElement ContactYes => _driver.FindElement(By.XPath("//*[@id='mce-PROJECTCON-0']/parent::label"));
        private IWebElement ContactNo => _driver.FindElement(By.XPath("//*[@id='mce-PROJECTCON-1']/parent::label"));
        private IWebElement YesNoError => _driver.FindElement(By.XPath("//*[@id='PROJECTCON-error']"));
        
        //When will your project start?
        private IWebElement NumMonth => _driver.FindElement(By.Id("mce-SDATE-month"));
        private IWebElement NumDay => _driver.FindElement(By.Id("mce-SDATE-day"));
        private IWebElement NumYear => _driver.FindElement(By.Id("mce-SDATE-year"));
        private IWebElement HaveRead => _driver.FindElement(By.Id("terms-checkmark"));
        private IWebElement SubmitBtn => _driver.FindElement(By.Id("mc-embedded-subscribe"));
        //Message that saiyng  application is submited
        private IWebElement VerifyMessage => _driver.FindElement(By.XPath("//*[@id='EL__17__']/h2"));

        public string VerifyPageTitle()
        {
            return PageTitle.Text;
        }
        public void ClickFirstButton()
        {
            JoinBtn.Click();
        }

        public void FillOutPerson(Person person)
        {
            FirstName.SendKeys(person.FirstName);
            LastName.SendKeys(person.LastName);
            EmailInput.SendKeys(person.Email);
            PhoneNumberInput.SendKeys("3124545656");
            PhoneNumberInput.SendKeys(Keys.Tab);
            PhoneNumberInput.SendKeys(Keys.PageDown);
        }
        public string FNameErrorMessage()
        {
            return FNameError.Text;
        
        }

        public void CheckedYes()
        {
            // Boolean btnValue = true;
            //     btnValue = YesON.isSelected();
            if (YesON == null)
            {
                YesON.Click();
            }
        }
        //What is your profession? (Select one) *
        public void YourProfession(string profes)
        {

            if (profes == "DESIGNER")
            {
                DesignerProf.Click();
            }
            else if (profes == "ARCHITECT")
            {
                Architec.Click();
            }
            else if (profes == "SERVICE TECH")
            {
                ServiceTech.Click();
            }
            else if (profes == "SALES ASSOCIATE")
            {
                SalesAssocit.Click();
            }
            else if (profes == "INSTALLER")
            {
                Installer.Click();
            }
            else if(profes == "BUILDER")
            {
                Builder.Click();
            }
            else
            {
                OtherProf.Click();
            }

        }
        public void FirmesName(Person person)
        {
            FirmName.SendKeys(person.CompanyName);
     
        }
        public void CompName(Person person)
        {
         
            CompanyName.SendKeys(person.CompanyName);
        }
        //Which brands do you prefer to specify? (Select all that apply)*
        public void BrandChoice(string subz, string wolf, string cov, string viki, string miel, string daco, string jenn, string otherl)
        {

            if (subz == "Sub-Zero")
            {
                SubZero.Click();
            }
            if (wolf == "Wolf")
            {
                Wolf.Click();
            }
            if (cov == "Cove")
            {
                Cove.Click();
            }
            if (viki == "Viking")
            {
                Viking.Click();
            }

            if (miel == "Miele")
            {
                Miele.Click();
            }

            if (daco == "Dacor")
            {
                Dacor.Click();
            }

            if (jenn == "Jennair")
            {
                Jennair.Click();
            }
            if (otherl == "Other Luxe")
            {
                Other.Click();
            }

        }
        //What is your average project years frequency? (Select one)*

        public void ProjectYears(string totalYears)
        {

            if (totalYears == "1-10")
            {
                OneTenYer.Click();
            }
            else if (totalYears == "11-20")
            {
                ElevenTwenty.Click();
            }
            else if (totalYears == "21")
            {
                TwentyPlus.Click();
            }
            //Thread.Sleep(3000);
            //TwentyPlus.SendKeys(Keys.Tab);
        }

        //What is the average TOTAL value of your projects? (Select one)*
        public void ProjectTotalAv(string tot1, string tot2, string tot3, string tot4,string tot5)
        {
            if (tot1 == "$0-151")
            {
                ZeroHundFH.Click();
            }
            else if (tot2== "$151-300")
            {
                OneThreeH.Click();
            }
            else if (tot3 == "$301-750")
            {
                ThreeSevenH.Click();
            }
            else if (tot4 == "$751-1.5M")
            {
                SevenMill.Click();
            }
            else
            {
                MillPlus.Click();
            }
        }


        //What is the average TOTAL value of your KITCHEN projects?*

        public void KitchenProj(string kitchenP)
        {
            if (kitchenP == "$0-50")
            {
                Kitchen50.Click();
            }
            else if (kitchenP == "$51-150")
            {
                Kitchen150.Click();
            }
            else if (kitchenP == "$151-250")
            {
                Kitchen250.Click();
            }
            else
            {
                Kitchen251.Click();
            }
            //Kitchen251.SendKeys(Keys.Tab);
        }
        //What type of projects do you work on most? (Select one)*
        public void ProjectsType(string typeP)
        {
            if (typeP == "Residential")
            {
                Residential.Click();
            }
            else if (typeP== "Commercial")
            {
                Commercial.Click();
            }
            else if(typeP == "Both")
            {
                Both.Click();
            }
         // Both.SendKeys(Keys.Tab);
        }
        //What are your professional social media handles?
        public void TwitMedia(string twit)
        {
            TwitterH.SendKeys(twit);
        }
        public void InstagMedia( string instag)
        {
            InstagramH.SendKeys(instag);   
        }
        public void LinkMedia(string linked)
        {
            LinkedH.SendKeys(linked);
        }
        //Would you like to be contacted about a project starting soon?*
        public void ContactedYesNO(string contact)
        {
            if (contact == "Yes")
            {
                ContactYes.Click();
            }
            else if (contact == "No")
            {
                ContactNo.Click();
            }
            else 
            {
                ContactNo.SendKeys(Keys.Tab);
            }
        }
        public string YesNoErrorMessage()
        {
           
            return YesNoError.Text;
        }

        //When will your project start?
        public void EnterDate()
        {

            var date = DateTime.Now.AddDays(1);
            var month = date.ToString("MM");
            var day = date.ToString("dd");
            var year = date.ToString("yyyy");
           // var day = DateTime.Now.Day.ToString();
          // var month = DateTime.Now.Month.ToString();
           //String year = DateTime.Now.Year.ToString();
            NumMonth.SendKeys(month);
            NumDay.SendKeys(day);
            NumYear.SendKeys(year);

        }
        public void AgreeI()
        {
            HaveRead.Click();
        }
        public void FinalSubmit()
        {
            SubmitBtn.Click();
        }
        public string VerifyText()
        {
            return VerifyMessage.Text;
        }
    }
}

