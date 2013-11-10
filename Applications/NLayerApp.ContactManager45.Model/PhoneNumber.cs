using NLayerApp.ContactManager45.Model.Enums;
using NLayerApp.Infrastructure;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayerApp.ContactManager45.Model
{
    public class PhoneNumber : DomainEntity<int>
    {
        public string Number { get; set; }
        public ContactType ContactType { get; set; }
        public int OwnerId { get; set; }

        public virtual Person Owner { get; set; }
    }
}
