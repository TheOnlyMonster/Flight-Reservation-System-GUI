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
        private string city;
        private string country;
        private string email;
        private string phoneNumber;
        private string passportNumber;
        private string cardNum;
        private string cvv;
        private string expirayDate;
        private string passportExpirayDate;
        private string id;
        private string nationality;


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
        public string PassportNumber
        {
            get { return passportNumber; }
            set { passportNumber = value; }
        }
        public string ExpirayDate
        {
            get { return expirayDate; }
            set { expirayDate = value; }
        }
        public string PassportExpirayDate
        {
            get { return passportExpirayDate; }
            set { passportExpirayDate = value; }
        }
        public string CardNum
        {
            get { return cardNum; }
            set { cardNum = value; }
        }
        public string Cvv
        {
            get { return cvv; }
            set { cvv = value; }
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

        public string City
        {
            get { return city; }
            set { city = value; }
        }

        public string Country
        {
            get { return country; }
            set { country = value; }
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
        public string Nationality
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
