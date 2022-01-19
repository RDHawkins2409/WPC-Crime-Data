using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPC_Crime_Data;

namespace CrimeTests
{
    [TestClass]
    public class CrimeDataTests
    {
        [TestMethod]
        public void GettingCrimeData()
        {
            string latitude = "51.44237";
            string longitude = "-2.49810";
            DateTime date = DateTime.Parse("2021-01-01");
            frmMain frmMain = new frmMain();
            string testResult = frmMain.getData(latitude, longitude, date);
            string expectedResult = @"anti-social-behaviour - 23
burglary - 6
criminal-damage-arson - 10
drugs - 1
other-crime - 1
other-theft - 6
public-order - 7
shoplifting - 13
vehicle-crime - 13
violent-crime - 50
";
            Assert.AreEqual(testResult, expectedResult);
        }
    }
}