using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace FlightReservationSystem
{
    
    public partial class SignUpForm : MainMenu
    {
        private ErrorProvider errorProvider;
        public SignUpForm()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            //Email regex validation.

            string email = this.textBoxEmail.Text;
            if (!ValidateEmail(email))
            {
                errorProvider.SetError(textBoxEmail, "Invalid Card number. Please enter a valid Card number.");
                this.textBoxEmail.Focus();
                return;
            }


            //Phone number validation.

            string phoneNumber = this.textBoxPhone.Text;
            if (!ValidatePhoneNumber(phoneNumber))
            {
                errorProvider.SetError(textBoxPhone, "Invalid Phone number. Please enter a valid Phone number.");
                this.textBoxPhone.Focus();
                return;
            }



            if (textBoxEmail.Text == "" || textBoxFirstName.Text == "" || textBoxLastName.Text == "" || textBoxPassword.Text == "" || textBoxPhone.Text == "")
            {
                MessageBox.Show("Null values aren't valid!");
                return;
            }
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string checkingQuery = "SELECT Count(Email) from UserTable where Email = @email";
                using (SqlCommand command = new SqlCommand(checkingQuery, connection))
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
                using (SqlCommand parentCmd = new SqlCommand(parentInsertQuery, connection))
                {
                    parentCmd.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    parentCmd.Parameters.AddWithValue("@fname", textBoxFirstName.Text);
                    parentCmd.Parameters.AddWithValue("@lname", textBoxLastName.Text);
                    parentCmd.Parameters.AddWithValue("@password", textBoxPassword.Text);
                    parentCmd.Parameters.AddWithValue("@identifier", "C");
                    int parentID = Convert.ToInt32(parentCmd.ExecuteScalar());
                    string childInsertQuery = "INSERT INTO CustomerTable (CustomerID,PhoneNumber) VALUES (@cid, @phone);";
                    using (SqlCommand childCmd = new SqlCommand(childInsertQuery, connection))
                    {
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
                }
                connection.Close();
            }

        }
        private bool ValidateEmail(string email)
        {
            // Define the regex pattern for email validation
            string pattern = @"^[a-zA-Z0-9_.+-]+@[a-zA-Z0-9-]+\.[a-zA-Z0-9-.]+$";
            bool isValid = Regex.IsMatch(email, pattern);
            return isValid;
        }

        private bool ValidatePhoneNumber(string phoneNumber)
        {
            // Regular expression pattern for a numeric phone number with 11 digits
            string pattern = @"^\d{11}$";
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(phoneNumber);
            return isValid;
        }

    }

}
