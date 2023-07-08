using System.Data.SqlClient;

namespace FlightReservationSystem
{
    public partial class SignUpForm : MainMenu
    {
        public SignUpForm()
        {
            InitializeComponent();
            dataAuthenticator = new();
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (!dataAuthenticator.ValidateEmail(this.textBoxEmail.Text))
            {
                SetAuthenticatorError("Invalid Email Address. Please enter a valid email address.", textBoxEmail);
                return;
            }
            if (!dataAuthenticator.ValidatePhoneNumber(this.textBoxPhone.Text))
            {
                SetAuthenticatorError("Invalid Phone number. Please enter a valid phone number.", textBoxPhone);
                return;
            }
            if (!dataAuthenticator.ValidateName(this.textBoxFirstName.Text) || !dataAuthenticator.ValidateName(this.textBoxLastName.Text))
            {
                SetAuthenticatorError("Invalid Name. Please enter a valid name.", textBoxFirstName);
                SetAuthenticatorError("Invalid Name. Please enter a valid name.", textBoxLastName);
                return;
            }
            if (textBoxEmail.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPassword.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Please fill all fields and try again!");
                return;
            }
            using SqlConnection connection = new(databaseConnection);
            connection.Open();
            string checkingQuery = "SELECT Count(Email) from UserTable where Email = @email";
            using (SqlCommand command = new(checkingQuery, connection))
            {
                command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                int filterKey = Convert.ToInt32(command.ExecuteScalar());
                if (filterKey == 1)
                {
                    MessageBox.Show("Email already taken!");
                    connection.Close();
                    return;
                }
            }
            string parentInsertQuery = "INSERT INTO UserTable (Email, Fname, Lname, Password, Identifier) VALUES (@email, @fname, @lname, @password, @identifier); SELECT SCOPE_IDENTITY();";
            using (SqlCommand parentCmd = new(parentInsertQuery, connection))
            {
                parentCmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                parentCmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
                parentCmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
                parentCmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                parentCmd.Parameters.AddWithValue("@identifier", "C");
                int parentID = Convert.ToInt32(parentCmd.ExecuteScalar());
                string childInsertQuery = "INSERT INTO CustomerTable (CustomerID,PhoneNumber) VALUES (@cid, @phone);";
                using SqlCommand childCmd = new(childInsertQuery, connection);
                childCmd.Parameters.AddWithValue("@cid", parentID);
                childCmd.Parameters.AddWithValue("@phone", textBoxPhone.Text);
                int rowsAffected = childCmd.ExecuteNonQuery();
                if (rowsAffected > 0)
                {
                    MessageBox.Show("Data Added Successfully");
                }
                else
                {
                    MessageBox.Show("Failed To Add Data");
                }
            }
            connection.Close();

        }
        private void PasswordShow_CheckedChanged(object sender, EventArgs e)
        {
            this.textBoxPassword.UseSystemPasswordChar = !textBoxPassword.UseSystemPasswordChar;
        }
    }
}
