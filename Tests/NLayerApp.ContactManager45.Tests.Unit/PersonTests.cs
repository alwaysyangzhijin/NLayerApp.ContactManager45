using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLayerApp.ContactManager45.Model;
using FluentAssertions;

namespace NLayerApp.ContactManager45.Tests.Unit
{
    [TestClass]
    public class PersonTests
    {
        [TestMethod]
        public void NewPersonEmptyId()
        {
            var person = new Person();
            //Assert.AreEqual(0, person.Id);
            person.IsNew().Should().BeTrue();
        }
    }
}
