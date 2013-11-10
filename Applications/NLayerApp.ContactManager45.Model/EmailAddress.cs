using NLayerApp.ContactManager45.Model.Enums;
using NLayerApp.Infrastructure;
using System;
using System.ComponentModel.DataAnnotations;

namespace NLayerApp.ContactManager45.Model
{
    public class EmailAddress : DomainEntity<int>
    {
        [Required]
        [EmailAddressAttribute]
        public string EmailAddressText { get; set; }
        public ContactType ContactType { get; set; }       
        public int OwnerId { get; set; }

        public virtual Person Owner { get; set; }
    }
}
