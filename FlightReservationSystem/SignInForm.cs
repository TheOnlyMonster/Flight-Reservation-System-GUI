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

namespace FlightReservationSystem
{
    public partial class SignInForm : MainMenu
    {
        public SignInForm()
        {
            InitializeComponent();
        }

        private void signInPanelButton_Click(object sender, EventArgs e)
        {
            string email = usernameSignInTextBox.Text;
            string password = passwordSignInTextBox.Text;

            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();

                string query = "SELECT * FROM UserTable WHERE Email = @Email AND Password = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {

                    Customer customer = Customer.Instance;
                    customer.Email = reader[1].ToString();
                    customer.fname = reader[2].ToString();
                    customer.lname = reader[3].ToString();
                    customer.Password = reader[4].ToString();
                    customer.Identifier = reader[5].ToString();
                    MessageBox.Show("Logged In Successfully");
                    if (customer.Identifier == "C")
                    {

                        MainMenu.IsUserLoggedIn = true;
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else if(customer.Identifier == "A")
                    {
                        MainMenu.IsAdminLoggedIn=true;
                        //TODO: Admin Login
                    }
                }
                else
                {
                    MessageBox.Show("Log In Failed");
                }

                reader.Close();
            }
        }
    }
}
