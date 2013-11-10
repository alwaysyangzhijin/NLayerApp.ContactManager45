using NLayerApp.ContactManager45.Model.Enums;
using NLayerApp.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace NLayerApp.ContactManager45.Model
{
    public class Address : ValueObject<Address>, IValidatableObject
    {
        public string Street { get; private set; }
        public string ZipCode { get; private set; }
        public string City { get; private set; }
        public string Country { get; private set; }
        public ContactType ContactType { get; private set; }

        private Address() { }

        public Address(string street, string zipCode, string city, string country, ContactType contactType)
        {
            Street = street;
            City = city;
            ZipCode = zipCode;
            Country = country;
            ContactType = contactType;
        }

        public bool IsNull
        {
            get
            {
                return (string.IsNullOrEmpty(Street) && string.IsNullOrEmpty(ZipCode)
                        && string.IsNullOrEmpty(City) && string.IsNullOrEmpty(Country));
            }
        }
    }
}
