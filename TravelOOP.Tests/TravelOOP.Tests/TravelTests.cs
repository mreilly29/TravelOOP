using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelOOP.Tests
{
    //Maggie, Tim, Ken Homework due 10/8/2018
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
            var response = traveller.TtlTravel(9,13,2018);
            //assert
            Assert.That(response, Is.EqualTo(5));
        }

        [Test]
        public void Selection_Method()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetSelection(5);
            //assert
            Assert.That(response, Is.EqualTo("Cali"));
        }

        [Test]
        public void Selection_Method_4_Georgia()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetSelection(4);
            //assert
            Assert.That(response, Is.EqualTo("Georgia"));
        }

        [Test]
        public void Selection_Method_3_Florida()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetSelection(3);
            //assert
            Assert.That(response, Is.EqualTo("Florida"));
        }

        [Test]
        public void Selection_Method_2_Nashville()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetSelection(2);
            //assert
            Assert.That(response, Is.EqualTo("Nashville"));
        }

        [Test]
        public void Selection_Method_1_Put_in_Bay()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetSelection(1);
            //assert
            Assert.That(response, Is.EqualTo("Put in Bay"));
        }

        [Test]
        public void Selection_Method_0_Stay_Home()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetSelection(0);
            //assert
            Assert.That(response, Is.EqualTo("Stay Home"));
        }

        [Test]
        public void Selection_Method_Greater_Than_5()
        {
            //arrange
            Travel traveller = new Travel();
            //action
            var response = traveller.GetSelection(6);
            //assert
            Assert.That(response, Is.EqualTo("The World is Yours"));
        }

        [Test]
        public void Selection_Method_Greater_Than_5_Destination()
        {
            //arrange
            Destination destination = new Destination();
            //action
            var response = destination.GetSelection(6);
            //assert
            Assert.That(response, Is.EqualTo("The World is Yours"));
        }

        [Test]
        public void Selection_Method_Greater_Than_5_Destination_TTT_Method_Input()
        { 
            //arrange
            Destination destination = new Destination();
            //action
            var response = destination.GetSelection(destination.TtlTravel(9,14,2018));
            //assert
            Assert.That(response, Is.EqualTo("The World is Yours"));

        }

        [Test]
        public void Selection_Method_5_Destination_TTT_Method_Input()
        {
            //arrange
            Destination destination = new Destination();
            //action
            var response = destination.GetSelection(destination.TtlTravel(9, 13, 2018));
            //assert
            Assert.That(response, Is.EqualTo("Cali"));
        }
    }
}
