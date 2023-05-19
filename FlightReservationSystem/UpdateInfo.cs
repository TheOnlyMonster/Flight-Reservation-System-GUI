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
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
  
                string userQuery = "UPDATE UserTable SET Fname = @Fname , Lname = @Lname , Password = @Password   WHERE UserID = @UserID";

                using (SqlCommand command = new SqlCommand(userQuery, connection))
                {
                    command.Parameters.AddWithValue("@Fname", FirstNameTextBox.Text);
                    command.Parameters.AddWithValue("@Lname", LastNameTextBox.Text);
                    command.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                    command.Parameters.AddWithValue("@UserID", Customer.Instance.Id);

                    command.ExecuteNonQuery();
                  
                }
                string customerQuery= "UPDATE CustomerTable SET City = @City , Country = @Country , CardNum = @CardNum , CVV = @CVV , ExpiryDate = @ExpiryDate   WHERE CustomerID = @CustomerID";
                using (SqlCommand command = new SqlCommand(customerQuery, connection))
                {
                    command.Parameters.AddWithValue("@City", CityTextBox.Text);
                    command.Parameters.AddWithValue("@Country", CountryTextBox.Text);
                    command.Parameters.AddWithValue("@CardNum", CardNumberTextBox.Text);
                    command.Parameters.AddWithValue("@CVV", CVVTextBox.Text);
                    command.Parameters.AddWithValue("@ExpiryDate", ExpirayDateTextBox.Text);
                    command.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);

                    `command.ExecuteNonQuery();

                }
                connection.Close();
            }


        }


    }
}
