using AutoFixture;
using NUnit.Framework;
using NUnit.Framework.Interfaces;
using NUnit.Framework.Internal;
using OpenQA.Selenium;
using RegistrationForm.Factories;
using RegistrationForm.Models;
using RegistrationForm.Pages;

namespace RegistrationForm.Tests
{
    [TestFixture]
    public class TestsRegistration : BaseTest
    {
        private RegistrationTests _registrationTests;
        private RegistrationFormModels _user;

        [SetUp]
        public void Setup()
        {
            Initialize();
            _registrationTests = new RegistrationTests(Driver);
            _user = UserFactory.CreateValidUser();
            _registrationTests.SignIn();
            
        }

        [Test]
        public void ErrorOnRegisterWithoutFirstName()
        {

            _user.CustomerFirstName = string.Empty;


            _registrationTests.FillForm(_user);


            Assert.AreEqual("firstname is required.", _registrationTests.ErrorBox.Text);

        }


        [Test]
        public void ErrorOnRegisterWithoutLastName()
        {

            _user.CustomerLastName = string.Empty;


            _registrationTests.FillForm(_user);

            Assert.AreEqual("lastname is required.", _registrationTests.ErrorBox.Text);

        }

        [Test]
        public void ErrorOnRegisterWithoutPassword()
        {

            _user.CustomerPassword = string.Empty;


            _registrationTests.FillForm(_user);

          
            Assert.AreEqual("passwd is required.", _registrationTests.ErrorBox.Text);

        }


        [Test]
        public void ErrorOnRegisterWithoutAddress()
        {

            _user.CustomerAddress = string.Empty;


            _registrationTests.FillForm(_user);


            Assert.AreEqual("address1 is required.", _registrationTests.ErrorBox.Text);

        }

        [Test]
        public void ErrorOnRegisterWithoutCity()
        {

            _user.CustomerCity = string.Empty;


            _registrationTests.FillForm(_user);


            Assert.AreEqual("city is required.", _registrationTests.ErrorBox.Text);

        }

        [Test]
        public void ErrorOnRegisterWithoutPickingState()
        {

            _user.CustomerState = string.Empty;


            _registrationTests.FillForm(_user);


            Assert.AreEqual("This country requires you to choose a State.", _registrationTests.ErrorBox.Text);

        }


        [Test]
        public void ErrorOnRegisterWithoutMobile()
        {

            _user.CustomerPhoneMobile = string.Empty;


            _registrationTests.FillForm(_user);


            Assert.AreEqual("You must register at least one phone number.", _registrationTests.ErrorBox.Text);

        }

        [Test]
        public void ErrorOnRegisterWithWrongFirstNameFormat()
        {

            _user.CustomerFirstName = "12345";


            _registrationTests.FillForm(_user);


            Assert.AreEqual("firstname is invalid.", _registrationTests.ErrorBox.Text);
        }


        [Test]
        public void ErrorOnRegisterWithShorterPassword()
        {
            // In the js on the site the lenght of the valid password is set to >=5 && <255. 

            _user.CustomerPassword = "1234";


            _registrationTests.FillForm(_user);


            Assert.AreEqual("passwd is invalid.", _registrationTests.ErrorBox.Text);

        }



        [Test]
        public void ErrorOnRegisterWitWrongPostcodeFormat()
        {

            _user.CustomerPostCode = "aaaaa";


            _registrationTests.FillForm(_user);


            Assert.AreEqual("The Zip/Postal code you've entered is invalid. It must follow this format: 00000", _registrationTests.ErrorBox.Text);

        }

        [Test]
        public void ErrorOnRegisterWithWrongMobileFormat()
        {

            _user.CustomerPhoneMobile = "aaaaa";


            _registrationTests.FillForm(_user);


            Assert.AreEqual("phone_mobile is invalid.", _registrationTests.ErrorBox.Text);

        }


        [TearDown]
        public void Teardown()
        {

            Driver.Quit();
        }
    }
}

