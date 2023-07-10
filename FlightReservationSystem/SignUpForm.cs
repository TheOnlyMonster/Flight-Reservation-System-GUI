using System.Data.SqlClient;

namespace FlightReservationSystem
{
    public partial class SignUpForm : MainMenu
    {
        public SignUpForm()
        {
            InitializeComponent();
            ChangeButton(signUpButton);
        }
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxEmail.Text) || string.IsNullOrEmpty(textBoxFirstName.Text) ||
                string.IsNullOrEmpty(textBoxLastName.Text) || string.IsNullOrEmpty(textBoxPassword.Text)
                || string.IsNullOrEmpty(textBoxPhone.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Error. Please fill all fields.", textBoxEmail);
                return;
            }
            if (!DataAuthenticator.Instance.ValidateEmail(this.textBoxEmail.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Email Address. Please enter a valid email address.", textBoxEmail);
                return;
            }
            if (!DataAuthenticator.Instance.ValidatePhoneNumber(this.textBoxPhone.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Phone number. Please enter a valid phone number.", textBoxPhone);
                return;
            }
            if (!DataAuthenticator.Instance.ValidateName(this.textBoxFirstName.Text) || !DataAuthenticator.Instance.ValidateName(this.textBoxLastName.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Name. Please enter a valid name.", textBoxFirstName);
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Name. Please enter a valid name.", textBoxLastName);
                return;
            }
            using SqlConnection connection = new(databaseConnection);
            try
            {
                connection.Open();  
            }catch (Exception)
            {
                MessageBox.Show("Your IP is not authorized to access the database please contact the owner of the application!");
                return;
            }
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
