using Guna.UI2.WinForms;
using System.Text.RegularExpressions;

namespace FlightReservationSystem
{
    public class DataAuthenticator
    {
        private static readonly ErrorProvider errorProvider = new()
        {
            BlinkStyle = ErrorBlinkStyle.NeverBlink
        };
        private static readonly DataAuthenticator instance = new();
        private readonly string integerPattern = @"^-?\d+$";
        private readonly string emailPattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
        private readonly string phoneNumberPattern = @"^\d{11}$";
        private readonly string namePattern = @"^[a-zA-Z]+$";
        private readonly string cardNumberPattern = @"^(?:\d[ -]*?){16}$";
        private readonly string cardExpiryDatePattern = @"^(0[1-9]|1[0-2])\/(\d{2})$";
        private readonly string cardCVVPattern = @"^\d{3}$";
        private readonly string passportNumberPattern = @"^[a-zA-Z]\w{8}$";
        private readonly string doublePattern = @"^[0-9]+(\.[0-9]+)?$";
        private readonly string manufactureYearPattern = @"^(19|20)\d{2}$";

        private DataAuthenticator() {}

        public static DataAuthenticator Instance
        {
            get { return instance; }
        }

        public bool ValidateDouble(string doubleType)
        {
            return Regex.IsMatch(doubleType, doublePattern);
        }

        public bool ValidateInteger(string integer)
        {
            return Regex.IsMatch(integer, integerPattern);
        }
        public bool ValidateManufactureYear(string manufactureYear)
        {
            return Regex.IsMatch(manufactureYear, manufactureYearPattern);
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
        public void SetAuthenticatorError(string error, Control obj)
        {
            errorProvider.SetError(obj, error);
            obj.Focus();
        }

        public bool ValidateTime(Guna2DateTimePicker deptDateTimePicker, Guna2DateTimePicker arrivalDateTimePicker, string deptTime, string arrivalTime)
        {
            if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(deptDateTimePicker.Value.ToShortDateString())
                || DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(arrivalDateTimePicker.Value.ToShortDateString()))
            {
                SetAuthenticatorError("Invalid Date. Please make sure that departure and arrival date is after the current date", deptDateTimePicker);
                return false;
            }
            else if (DateTime.Parse(DateTime.Now.ToShortDateString()) == DateTime.Parse(deptDateTimePicker.Value.ToShortDateString()))
            {
                TimeSpan deptTimeSpan = DateTime.Parse(deptTime).TimeOfDay;
                if (DateTime.Now.TimeOfDay > deptTimeSpan)
                {
                    SetAuthenticatorError("Invalid Date. Please make sure that departure and arrival date is after the current date", deptDateTimePicker);
                    return false;
                }
            }
            if (deptDateTimePicker.Value > arrivalDateTimePicker.Value)
            {
                SetAuthenticatorError("Invalid Departure Date. Please make sure that the departure date is before the arrival date", deptDateTimePicker);
                return false;
            }
            else if (deptDateTimePicker.Value == arrivalDateTimePicker.Value)
            {
                TimeSpan deptTimeSpan = DateTime.Parse(deptTime).TimeOfDay;
                TimeSpan arrivalTimeSpan = DateTime.Parse(arrivalTime).TimeOfDay;
                if (deptTimeSpan > arrivalTimeSpan)
                {
                    SetAuthenticatorError("Invalid Departure Date. Please make sure that the departure date is before the arrival date", deptDateTimePicker);
                    return false;
                }
            }
            return true;
        }
    }
}