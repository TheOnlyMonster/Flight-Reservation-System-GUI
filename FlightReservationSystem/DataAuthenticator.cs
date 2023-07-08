using System.Text.RegularExpressions;
using Guna.UI2.AnimatorNS;

namespace FlightReservationSystem
{
    public class DataAuthenticator
    {
        private static readonly DataAuthenticator instance = new();

        private readonly string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        private readonly string phoneNumberPattern = @"^\d{11}$";
        private readonly string namePattern = @"^[a-zA-Z]+$";
        private readonly string cardNumberPattern = @"^(?:\d[ -]*?){16}$";
        private readonly string cardExpiryDatePattern = @"^(0[1-9]|1[0-2])\/(\d{2})$";
        private readonly string cardCVVPattern = @"^\d{3}$";
        private readonly string passportNumberPattern = @"^[a-zA-Z]\w{8}$";
        private readonly string validateDoublePattern = @"^[0-9]+(\.[0-9]+)?$";

        private DataAuthenticator() {}

        public static DataAuthenticator Instance
        {
            get { return instance; }
        }

        public bool ValidateDouble(string doubleType)
        {
            return Regex.IsMatch(doubleType, validateDoublePattern);
        }

        public bool ValidateEmail(string email)
        {
            return Regex.IsMatch(email, emailPattern);
        }

        public bool ValidatePhoneNumber(string phoneNumber)
        {
            return Regex.IsMatch(phoneNumber, phoneNumberPattern);
        }

        public bool ValidateName(string name)
        {
            return Regex.IsMatch(name, namePattern);
        }

        public bool ValidateCardNumber(string cardNumber)
        {
            return Regex.IsMatch(cardNumber, cardNumberPattern);
        }

        public bool ValidateCardExpiryDate(string cardExpiryDate)
        {
            return Regex.IsMatch(cardExpiryDate, cardExpiryDatePattern);
        }

        public bool ValidateCardCVV(string cardCVV)
        {
            return Regex.IsMatch(cardCVV, cardCVVPattern);
        }

        public bool ValidatePassportNumber(string passportNumber)
        {
            return Regex.IsMatch(passportNumber, passportNumberPattern);
        }
    }
}