using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FlightReservationSystem
{
    public partial class UpdateInfo : MainMenu, IProcessQuery
    {
        public UpdateInfo()
        {
            InitializeComponent();
            dataManager = new(databaseConnection, this);
            ChangeButton(UpdateInfo);
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            textBoxFirstName.Text = Customer.Instance.fname;
            textBoxLastName.Text = Customer.Instance.lname;
            textBoxPhone.Text = Customer.Instance.PhoneNumber;
            textBoxEmail.Text = Customer.Instance.Email;
            textBoxPassword.Text = Customer.Instance.Password;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text)
                || string.IsNullOrEmpty(textBoxPhone.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                MessageBox.Show("Please Fill All Fields And Try Again!");
                return;
            }

            if (!int.TryParse(textBoxPhone.Text, out _))
            {
                MessageBox.Show("Phone number must be a valid integer. Please try again.");
                return;
            }

            string firstName = textBoxFirstName.Text;
            string lastName = textBoxLastName.Text;

            if (!IsValidEnglishName(firstName) || !IsValidEnglishName(lastName))
            {
                MessageBox.Show("First name and last name can only contain English alphabetic characters. Please try again.");
                return;
            }
            Customer.Instance.fname = textBoxFirstName.Text;
            Customer.Instance.lname = textBoxLastName.Text;
            Customer.Instance.PhoneNumber = textBoxPhone.Text;
            Customer.Instance.Password = textBoxPassword.Text;
            string userQuery = "UPDATE UserTable SET Fname = @Fname, Lname = @Lname, Password = @Password where UserID = @UserID";
            dataManager.ExcuteDataQuery(userQuery);
            string customerQuery = "UPDATE CustomerTable SET PhoneNumber = @PhoneNumber where CustomerID = @CustomerID";
            dataManager.ExcuteDataQuery(customerQuery);
            MessageBox.Show("Changes Made Successfully!");
            UpdateInfo_Load(sender, e);
        }
        private void PasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            command.Parameters.AddWithValue("@Fname", textBoxFirstName.Text);
            command.Parameters.AddWithValue("@Lname", textBoxLastName.Text);
            command.Parameters.AddWithValue("@Password", textBoxPassword.Text);
            command.Parameters.AddWithValue("@UserID", Customer.Instance.Id);
            command.Parameters.AddWithValue("@PhoneNumber", textBoxPhone.Text);
            command.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);
        }
        private bool IsValidEnglishName(string name)
        {
            string pattern = @"^[a-zA-Z]+$";
            return Regex.IsMatch(name, pattern);
        }
    }
}
