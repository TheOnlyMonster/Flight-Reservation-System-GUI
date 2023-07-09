using System.Data.SqlClient;

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
            textBoxFirstName.Text = Customer.Instance.Fname;
            textBoxLastName.Text = Customer.Instance.Lname;
            textBoxPhone.Text = Customer.Instance.PhoneNumber;
            textBoxEmail.Text = Customer.Instance.Email;
            textBoxPassword.Text = Customer.Instance.Password;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxFirstName.Text) || string.IsNullOrEmpty(textBoxLastName.Text)
                || string.IsNullOrEmpty(textBoxPhone.Text) || string.IsNullOrEmpty(textBoxPassword.Text))
            {
                SetAuthenticatorError("Error. Please fill all fields and try again", textBoxFirstName);
                return;
            }
            if (!DataAuthenticator.Instance.ValidatePhoneNumber(this.textBoxPhone.Text))
            {
                SetAuthenticatorError("Invalid Phone number. Please enter a valid phone number.", textBoxPhone);
                return;
            }
            if (!DataAuthenticator.Instance.ValidateName(this.textBoxFirstName.Text) || !DataAuthenticator.Instance.ValidateName(this.textBoxLastName.Text))
            {
                SetAuthenticatorError("Invalid Name. Please enter a valid name.", textBoxFirstName);
                SetAuthenticatorError("Invalid Name. Please enter a valid name.", textBoxLastName);
                return;
            }
            Customer.Instance.Fname = textBoxFirstName.Text;
            Customer.Instance.Lname = textBoxLastName.Text;
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
    }
}
