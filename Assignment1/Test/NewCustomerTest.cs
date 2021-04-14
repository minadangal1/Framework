using Assignment1.Helper;
using Assignment1.TestDataObject;
using Assignment1.View;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.Test
{
    class NewCustomerTest:basePageTest
    {
        [Test]
        public void verifyNewCuntumer()
        {
            HomePageView homePage = new HomePageView();
            homePage.LoginAccount("mngr318643", "pArehEt");

            NewcustomerView newcustomer = new NewcustomerView();
            newcustomer.clickNewCustomer();
            var allData = ExcelHelper.GetTestData<RegisterTestDataObject>("New Microsoft Excel Worksheet", "sheet1");
            newcustomer.RegisterAccount(allData);

            // newcustomer.SubmitAccount();
            newcustomer.Clicklogout();
           
         }
    }
}
