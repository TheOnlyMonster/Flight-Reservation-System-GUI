namespace FlightReservationSystem
{
    internal class Customer
    {
        private static Customer? instance;
        private string? firstName;
        private string? lastName;
        private string? password;
        private string? identifier;
        private string? email;
        private string? phoneNumber;
        private string? id;


        private Customer()
        {
        }

        public static Customer Instance
        {
            get
            {
                instance ??= new Customer();
                return instance;
            }
        }

        public string? Fname
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string? Id
        {
            get { return id; }
            set { id = value; }
        }

        public string? Password
        {
            get { return password; }
            set { password = value; }
        }
        public string? Lname
        {
            get { return lastName; }
            set { lastName = value; }
        }

        public string? Identifier
        {
            get { return identifier; }
            set { identifier = value; }
        }

        public string? Email
        {
            get { return email; }
            set { email = value; }
        }

        public string? PhoneNumber
        {
            get { return phoneNumber; }
            set { phoneNumber = value; }
        }
    }
}
