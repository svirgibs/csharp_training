using System;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace WebAddressbookTests
{
    [TestFixture]
    public class ContactCreationTests : TestBase
    {
        // Тест. Создание контакта
        [Test]
        public void ContactCreationTest()
        {
            ContactData contact = new ContactData("Denis");
            contact.MiddleName = "Timourovich";
            contact.LastName = "Yavorskiy";

            app.Contacts.Create(contact);
            app.Auth.Logout();
        }

        // Тест. Создание контакта (с пустыми полями)
        [Test]
        public void EmptyContactCreationTest()
        {
            ContactData contact = new ContactData("");
            contact.MiddleName = "";
            contact.LastName = "";

            app.Contacts.Create(contact);
            app.Auth.Logout();
        }


    }
}
