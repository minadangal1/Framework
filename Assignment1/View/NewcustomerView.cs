using Assignment1.Helper;
using Assignment1.TestDataObject;
using NUnit.Framework;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.View
{
    class NewcustomerView
    {
        #region
        string NameName = "name";
        string NewCustomerXpath = "//*[@href='addcustomerpage.php']";
        string GenderXpath = "//td/descendant::input[@type='radio']";
        string DobId = "dob";
        string AddressName = "addr";
        string CityName = "city";
        string StateName = "state";
        string PinName = "pinno";
        string TeliphoneName = "telephoneno";
        string EmailName = "emailid";
        string SubmitName = "sub";
        string ResetName = "res";
        string LogoutXpath = "//*[@href='Logout.php']";





        #endregion
        internal void clickNewCustomer()
        {
            FrameworkHelper.ClickElement(NewCustomerXpath, IdentifierType.Xpath);

        }
        internal void setName(string text, bool clear = false)
        {



            FrameworkHelper.SetTest(text, NameName, IdentifierType.Name);
        }
        internal void SetDOb(string Dob)
        {

            FrameworkHelper.SetTest(Dob, DobId, IdentifierType.Id);
        }
        internal void SetAddress(string Address)
        {
            FrameworkHelper.SetTest(Address, AddressName, IdentifierType.Name);
        }
        internal void SetCity(string Cityname)
        {
            FrameworkHelper.SetTest(Cityname, CityName, IdentifierType.Name);
        }
        internal void SetState(string Statename)
        {
            FrameworkHelper.SetTest(Statename, StateName, IdentifierType.Name);
        }
        internal void SetPin(string pin)
        {
            FrameworkHelper.SetTest(pin, PinName, IdentifierType.Name);
        }
        internal void SetTeliphone(string PhoneNo)
        {
            FrameworkHelper.SetTest(PhoneNo, TeliphoneName, IdentifierType.Name);
        }
        internal void SetEmail(string email) {
            FrameworkHelper.SetTest(email, EmailName, IdentifierType.Name);


        }
        internal void RegisterAccount(List<RegisterTestDataObject> registerTestDataObjects)
        {
            for (int i = 0; i < registerTestDataObjects.Count; i++)
            {





                setName(registerTestDataObjects[i].CustomerName);
                SetDOb(registerTestDataObjects[i].DOB);
                SetAddress(registerTestDataObjects[i].Address);
                SetCity(registerTestDataObjects[i].City);
                SetState(registerTestDataObjects[i].State);
                SetPin(registerTestDataObjects[i].PIN);
                SetTeliphone(registerTestDataObjects[i].TelephoneNumber);
                SetEmail(registerTestDataObjects[i].Email);

                if (registerTestDataObjects[i].Gender.Equals("male"))
                {
                    FrameworkHelper.ClickElement(GenderXpath, IdentifierType.Xpath);

                }
                else if (registerTestDataObjects[i].Gender.Equals("Female"))
                {
                    FrameworkHelper.ClickElement(GenderXpath, IdentifierType.Xpath);

                }
                SubmitAccount();
                FrameworkHelper.ClickElement(SubmitName, IdentifierType.Name);

                if (registerTestDataObjects[i].status.Equals("valid"))
                {
                    //Actions actions = new Actions(FrameworkHelper.WebDriver);
                    //FrameworkHelper.WebDriver.SwitchTo().Alert().Accept();
                    //FrameworkHelper.WebDriver.SwitchTo().DefaultContent();
                }

            }
        }
                internal void SubmitAccount()
                {
                    FrameworkHelper.ClickElement(SubmitName, IdentifierType.Name);
                }
                 internal void Clicklogout()
                {
            FrameworkHelper.ClickElement(LogoutXpath, IdentifierType.Xpath);

                  }

    }

  } 

