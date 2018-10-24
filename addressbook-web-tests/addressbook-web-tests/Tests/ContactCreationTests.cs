using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Collections.Generic;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : AuthTestBase
    {
        // Тест. Создание контакта
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Denis");
            contact.MiddleName = "Timourovich";
            contact.LastName = "Yavorskiy";

            //List<ContactData> oldContacts = app.Contacts.GetContactList();

            app.Contacts.Create(contact);

            //List<ContactData> newContacts = app.Contacts.GetContactList();
            //Assert.AreEqual(oldContacts, newContacts);
        }

        // Тест. Создание контакта (с пустыми полями)
        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("");
            contact.MiddleName = "";
            contact.LastName = "";

            app.Contacts.Create(contact);
        }


    }
}
