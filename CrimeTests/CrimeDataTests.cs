using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using WPC_Crime_Data;

namespace CrimeTests
{
    [TestClass]
    public class CrimeDataTests
    {
        frmMain FrmMain;

        [TestInitialize]
        public void TestInitialise()
        {
            FrmMain = new frmMain();
        }

        [TestMethod]
        public void GettingCrimeData()
        {
            string latitude = "51.44237";
            string longitude = "-2.49810";
            DateTime date = DateTime.Parse("2021-01-01");
            string testResult = FrmMain.getData(latitude, longitude, date);
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

        [TestMethod]
        public void GettingInvalidData()
        {
            string latitude = "5146";
            string longitude = "8635.543";
            DateTime date = DateTime.Parse("2021-01-01");
            string testResult = FrmMain.getData(latitude, longitude, date);
            string expectedResult = @"No Crime Data Found";
            Assert.AreEqual(testResult, expectedResult);
        }
    }
}