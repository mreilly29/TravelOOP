using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOOP.Tests
{
    [TestFixture]
    public class TravelTests
    {
        [Test]
        public void Test_Default_CTR()
        {
            //arrange
            Travel traveller = new Travel("Harry");
            //action
            string response = traveller.FName;
            //assert
            Assert.That(response, Is.EqualTo("Harry"));
        }

        [Test]
        public void Test_LastName_Prop()
        {
            //arrange
            Travel traveller = new Travel("Harry Buffalo");
            //action
            string response = traveller.LName;
            //assert
            Assert.That(response, Is.EqualTo("Buffalo"));
        }

        [Test]
        public void Test_Address_Prop()
        {
            //arrange
            Travel traveller = new Travel("Harry Buffalo");
            //action
            traveller.Address=" ";
            string response = traveller.Address;
            //assert
            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Test_Address_Email()
        {
            //arrange
            Travel traveller = new Travel("Harry Buffalo");
            //action
            traveller.Email = " ";
            string response = traveller.Email;
            //assert
            Assert.That(response, Is.EqualTo(" "));
        }

        [Test]
        public void Test_Date_Travel_Method()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetDate(9, 8, 2018);
            //assert
            Assert.That(response, Is.EqualTo("9/8/2018"));
        }

        [Test]
        public void Test_Total_Travel_Time_Method()
        {
            //arrange
            Travel traveller = new Travel();
            //action
           var response = traveller.TtlTravel(9, 13, 2018);
            //assert
            Assert.That(response, Is.EqualTo(5));
        }
    }
}
