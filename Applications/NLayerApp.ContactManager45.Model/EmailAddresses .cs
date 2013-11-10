using NLayerApp.ContactManager45.Model.Enums;
using NLayerApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.ContactManager45.Model
{
    public class EmailAddresses : CollectionBase<EmailAddress>
    {
        public EmailAddresses() { }

        public EmailAddresses(IList<EmailAddress> initialList)
            : base(initialList)
        { }

        public EmailAddresses(CollectionBase<EmailAddress> initialList)
            : base(initialList)
        { }

        public void Add(string emailAddressText, ContactType contactType)
        {
            Add(new EmailAddress { ContactType = contactType, EmailAddressText = emailAddressText });
        }
    }
}
