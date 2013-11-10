using Microsoft.VisualStudio.TestTools.UnitTesting;
using NLayerApp.ContactManager45.Repository;

namespace NLayerApp.ContactManager45.Tests.Integration
{
    [TestClass]
    public class PeopleRepositoryTests
    {
        [TestMethod]
        public void CanInstantiatePeopleRepository()
        {
            var peopleRepository = new PeopleRepository();
            Assert.IsNotNull(peopleRepository);
        }
    }
}
