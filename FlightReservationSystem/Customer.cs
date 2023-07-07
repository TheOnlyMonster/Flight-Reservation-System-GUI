using System;
using System.Xml.Linq;

namespace FlightReservationSystem
{
    internal class Customer
    {
        private static Customer instance;
        private string Fname;
        private string Lname;
        private string password;
        private string identifier;
        private string email;
        private string phoneNumber;
        private string id;


        private Customer()
        {
        }

        public static Customer Instance
        {
            get
            {
                if (instance == null)
                {
                    instance = new Customer();
                }
                return instance;
            }
        }

        public string fname
        {
            get { return Fname; }
            set { Fname = value; }
        }
        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string Password
        {
            get { return password; }
            set { password = value; }
        }
        public string lname
        {
            get { return Lname; }
            set { Lname = value; }
        }

        public string Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        public string Email
        {
            get { return email; }
            set { email = value; }
        }

        public string PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
