using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactModificationTests : AuthTestBase
    {
        [Test]
        public void ContactModificationTest()
        {
            ContactData newData = new ContactData("Dmitriy");
            newData.MiddleName = "Ivanovich";
            newData.LastName = "Ivanov";

            app.Contacts.Modify(1, newData);
        }
    }
}
