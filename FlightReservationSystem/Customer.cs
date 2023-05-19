using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    internal class Customer
    {
        private static Customer instance;
        private string name;
        private int id;
        private string city;
        private string country;
        private string phone;
        private string email;
        private string phoneNumber;

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

    }
}
