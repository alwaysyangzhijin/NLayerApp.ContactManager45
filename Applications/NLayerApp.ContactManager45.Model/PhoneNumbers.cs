using NLayerApp.ContactManager45.Model.Enums;
using NLayerApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.ContactManager45.Model
{
    public class PhoneNumbers : CollectionBase<PhoneNumber>
    {
        public PhoneNumbers() { }

        public PhoneNumbers(IList<PhoneNumber> initialList)
            : base(initialList)
        { }

        public PhoneNumbers(CollectionBase<PhoneNumber> initialList)
            : base(initialList)
        { }

        public void Add(string number, ContactType contactType)
        {
            Add(new PhoneNumber { Number = number,  ContactType = contactType });
        }
    }
}
