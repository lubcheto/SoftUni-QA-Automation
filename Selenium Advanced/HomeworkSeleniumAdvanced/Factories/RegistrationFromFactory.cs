using AutoFixture;
using RegistrationForm.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace RegistrationForm.Factories
{
    public static class UserFactory
    {
        public static RegistrationFormModels CreateValidUser()
        {
            var fixture = new Fixture();
            fixture.Customizations.Add(new RandomDateTimeSequenceGenerator(new DateTime(1990, 1, 1), new DateTime(2020, 6, 1)));

            var dateTime = fixture.Create<DateTime>();

            return new RegistrationFormModels

            {
                CustomerFirstName = "TestFirstName",
                CustomerLastName = "TestLastName",
                CustomerPassword = "TestPassword",
                CustomerEmail = "test@test.test",
                Year = dateTime.Year.ToString(), 
                Month = dateTime.Month.ToString(),
                Day = dateTime.Day.ToString(),
                CustomerAddress = "TestAddress",
                CustomerCity = "TestCity",
                CustomerState = "Alabama",
                CustomerPostCode = "00001",
                CustomerPhoneMobile = "100-100-100"
            };

        }
    }
}


