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
            ContactData newData = new ContactData("Dmitriy", "Ivanov");
            newData.MiddleName = "Ivanovich";

            app.Contacts.CreateContactForTests();

            app.Contacts.Modify(0, newData);
        }
    }
}
