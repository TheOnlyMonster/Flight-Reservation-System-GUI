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
using System.Globalization;

namespace FlightReservationSystem
{
    public partial class SignInForm : MainMenu
    {
        public SignInForm()
        {
            InitializeComponent();
            this.ChangeButton(this.signInButton);
        }

        private void signInPanelButton_Click(object sender, EventArgs e)
        {
            string email = usernameSignInTextBox.Text;
            string password = passwordSignInTextBox.Text;

            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();

                string userQuery = "SELECT * FROM UserTable WHERE Email = @Email AND Password = @Password";

                SqlCommand command = new SqlCommand(userQuery, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Customer customer = Customer.Instance;
                    customer.Id = reader[0].ToString();
                    customer.Email = reader[1].ToString();
                    customer.fname = reader[2].ToString();
                    customer.lname = reader[3].ToString();
                    customer.Password = reader[4].ToString();
                    customer.Identifier = reader[5].ToString();
                    string customerQuery = "select * FROM CustomerTable WHERE CustomerID = @userID";
                    SqlCommand comm = new SqlCommand(customerQuery, connection);
                    comm.Parameters.AddWithValue("@userID", reader[0].ToString());
                    reader.Close();
                    SqlDataReader userReader = comm.ExecuteReader();
                    if (userReader.Read())
                    {
                        customer.PhoneNumber = userReader[2].ToString();
                    }
                    userReader.Close();
                    MessageBox.Show("Logged In Successfully");
                    if (customer.Identifier == "C")
                    {
                        MainMenu.IsUserLoggedIn = true;
                        
                    }
                    else if(customer.Identifier == "A")
                    {
                        MainMenu.IsAdminLoggedIn = true;
                    }
                    MainMenu mainMenu = new MainMenu();
                    mainMenu.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Log In Failed");
                }

                connection.Close();
            }
           
        }

        private void showPassword_CheckedChanged(object sender, EventArgs e)
        {
            this.passwordSignInTextBox.UseSystemPasswordChar = !passwordSignInTextBox.UseSystemPasswordChar;
        }
    }
}
