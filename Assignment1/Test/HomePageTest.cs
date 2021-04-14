using Assignment1.View;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment1.Test
{
    class HomePageTest:basePageTest
    {
        [Test]
        public void VerifyLogIn()
        {
            HomePageView pageView = new HomePageView();
            pageView.LoginAccount("mngr318486", "UrYgYpA");
          
        }
    }
}
