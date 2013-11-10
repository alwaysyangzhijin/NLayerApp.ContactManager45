using System;
using NLayerApp.Infrastructure;
using NLayerApp.ContactManager45.Model.Enums;
using System.ComponentModel.DataAnnotations;

namespace NLayerApp.ContactManager45.Model
{
    public class Person : DomainEntity<int>, IDateTracking
    {
        [Required]
        public string FirstName { get; set; }
         [Required]
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public PersonType Type { get; set; }
        public string FullName 
        {
            get 
            {
                string fullName = FirstName ?? String.Empty;
                if (!String.IsNullOrEmpty(LastName))
                {
                    if (fullName.Length > 0)
                    {
                        fullName += " ";
                    }
                    fullName += LastName;
                }
                return fullName;
            }
        }
        public Address HomeAddress { get; set; }
        public Address WorkAddress { get; set; }

        public EmailAddresses EmailAddresses { get; set; }
        public PhoneNumbers PhoneNumbers { get; set; }

        public DateTime DateCreated { get; set; }
        public DateTime DateModified { get; set; }

        public Person()
        {
            EmailAddresses = new EmailAddresses();
            PhoneNumbers = new PhoneNumbers();
            HomeAddress = new Address(null, null, null, null, ContactType.Personal);
            WorkAddress = new Address(null, null, null, null, ContactType.Business);
        }

       
        
    }
}
