using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.ApplicationServices;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FlightReservationSystem
{
    public partial class UpdateInfo : MainMenu
    {
        public UpdateInfo()
        {
            InitializeComponent();
        }

        private void UpdateInfo_Load(object sender, EventArgs e)
        {
            this.FirstNameTextBox.Text = Customer.Instance.fname;
            this.CityTextBox.Text= Customer.Instance.City;
            this.CountryTextBox.Text = Customer.Instance.Country;
            this.LastNameTextBox.Text = Customer.Instance.lname;
            this.ExpirayDateTextBox.Text = Customer.Instance.ExpirayDate;
            this.CVVTextBox.Text = Customer.Instance.Cvv.ToString();
            this.CardNumberTextBox.Text=Customer.Instance.CardNum.ToString();
   

        }
        private void SaveButton_Click(object sender, EventArgs e)
        {
            // Perform data validation before updating the database
            if (!ValidateData())
            {
                // Data validation failed, display an error message or handle it accordingly
                return;
            }

            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();

                string userQuery = "UPDATE UserTable SET Fname = @Fname, Lname = @Lname, Password = @Password WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(userQuery, connection))
                {
                    command.Parameters.AddWithValue("@Fname", FirstNameTextBox.Text);
                    command.Parameters.AddWithValue("@Lname", LastNameTextBox.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                    command.Parameters.AddWithValue("@UserID", Customer.Instance.Id);

                    command.ExecuteNonQuery();
                }

                string customerQuery = "UPDATE CustomerTable SET City = @City, Country = @Country, CardNum = @CardNum, CVV = @CVV, ExpiryDate = @ExpiryDate WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(customerQuery, connection))
                {
                    command.Parameters.AddWithValue("@City", CityTextBox.Text);
                    command.Parameters.AddWithValue("@Country", CountryTextBox.Text);
                    command.Parameters.AddWithValue("@CardNum", CardNumberTextBox.Text);
                    command.Parameters.AddWithValue("@CVV", CVVTextBox.Text);
                    command.Parameters.AddWithValue("@ExpiryDate", DateTime.ParseExact(ExpirayDateTextBox.Text, "MM/yy", CultureInfo.InvariantCulture));
                    command.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);

                    try
                    {
                        // Execute the update command
                        command.ExecuteNonQuery();
                        MessageBox.Show("Data updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Update the customer properties with the new values
                        Customer.Instance.City = CityTextBox.Text;
                        Customer.Instance.Country = CountryTextBox.Text;
                        Customer.Instance.CardNum = CardNumberTextBox.Text;
                        Customer.Instance.Cvv = CVVTextBox.Text;
                        Customer.Instance.ExpirayDate = ExpirayDateTextBox.Text;
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while executing the SQL query: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

                connection.Close();
            }

        }

        private bool ValidateData()
        {
            // Perform data validation for each input field
            if (string.IsNullOrWhiteSpace(FirstNameTextBox.Text))
            {
                MessageBox.Show("First name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(LastNameTextBox.Text))
            {
                MessageBox.Show("Last name is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrWhiteSpace(PasswordTextBox.Text))
            {
                MessageBox.Show("Password is required.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            // Validate CardNum using a regular expression
            string cardNumPattern = @"^\d{16}$"; // Assuming CardNum should be exactly 16 digits
            if (!Regex.IsMatch(CardNumberTextBox.Text, cardNumPattern))
            {
                MessageBox.Show("Card number is invalid. It should be a 16-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate CVV using a regular expression
            string cvvPattern = @"^\d{3}$"; // Assuming CVV should be exactly 3 digits
            if (!Regex.IsMatch(CVVTextBox.Text, cvvPattern))
            {
                MessageBox.Show("CVV is invalid. It should be a 3-digit number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Validate ExpiryDate format (MM/YY) using a regular expression
            string expiryDatePattern = @"^\d{2}/\d{2}$"; // Assuming ExpiryDate should be in the format MM/YY
            if (!Regex.IsMatch(ExpirayDateTextBox.Text, expiryDatePattern))
            {
                MessageBox.Show("Expiry date is invalid. It should be in the format MM/YY.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            // Additional validation checks for other fields

            return true;
        }

        
    }
}

