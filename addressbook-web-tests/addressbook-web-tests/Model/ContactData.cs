using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAddressbookTests
{
    public class ContactData : IEquatable<ContactData>, IComparable<ContactData>
    {
        private string firstname;
        private string middlename = "";
        private string lastname = "";
        private string nickname = "";
        private string title = "";
        private string company = "";
        private string address = "";
        private string telHome = "";
        private string telMobile = "";
        private string telWork = "";
        private string telFax = "";
        private string email1 = "";
        private string email2 = "";
        private string email3 = "";
        private string homepage = "";

        public ContactData(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
        }

        public bool Equals(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return false;
            }
            if (Object.ReferenceEquals(this, other))
            {
                return true;
            }
            return LastName == other.LastName && FirstName == other.FirstName;          
        }

        public override int GetHashCode()
        {
            return 0;
        }

        public override string ToString()
        {
            return "firstname = " + FirstName + " lastname = " + LastName;
        }

        public int CompareTo(ContactData other)
        {
            if (Object.ReferenceEquals(other, null))
            {
                return 1;
            }
            return FirstName.CompareTo(other.FirstName) + LastName.CompareTo(other.LastName);
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
            set
            {
                firstname = value;
            }
        }

        public string MiddleName
        {
            get
            {
                return middlename;
            }
            set
            {
                middlename = value;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
            set
            {
                lastname = value;
            }
        }

        public string NickName
        {
            get
            {
                return nickname;
            }
            set
            {
                nickname = value;
            }
        }

        public string Title
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public string Company
        {
            get
            {
                return company;
            }
            set
            {
                company = value;
            }
        }

        public string Address
        {
            get
            {
                return address;
            }
            set
            {
                address = value;
            }
        }

        public string TelHome
        {
            get
            {
                return telHome;
            }
            set
            {
                telHome = value;
            }
        }

        public string TelMobile
        {
            get
            {
                return telMobile;
            }
            set
            {
                telMobile = value;
            }
        }

        public string TelWork
        {
            get
            {
                return telWork;
            }
            set
            {
                telWork = value;
            }
        }

        public string TelFax
        {
            get
            {
                return telFax;
            }
            set
            {
                telFax = value;
            }
        }

        public string Email1
        {
            get
            {
                return email1;
            }
            set
            {
                email1 = value;
            }
        }

        public string Email2
        {
            get
            {
                return email2;
            }
            set
            {
                email2 = value;
            }
        }

        public string Email3
        {
            get
            {
                return email3;
            }
            set
            {
                email3 = value;
            }
        }

        public string HomePage
        {
            get
            {
                return homepage;
            }
            set
            {
                homepage = value;
            }
        }
    }
}
