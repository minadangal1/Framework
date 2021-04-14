using Assignment1.Helper;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.View
{
    class HomePageView
    {
        #region
        string BankLinkText = "Bank Project";
        string BankXpath = "//*[@href='http://demo.guru99.com/V1/index.php']";
        string UseridName = "uid";
        string PasswordName = "password";
        string LoginName = "btnLogin";
        #endregion

        internal void LoginAccount(string UserId, string Password)
        {
            FrameworkHelper.ClickElement(BankXpath, IdentifierType.Xpath);
            FrameworkHelper.SetTest(UserId, UseridName, IdentifierType.Name);
            FrameworkHelper.SetTest(Password, PasswordName, IdentifierType.Name);
            FrameworkHelper.ClickElement(LoginName, IdentifierType.Name);
        }
    }
}