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

                string query = "SELECT Email,Password,Identifier FROM UserTable WHERE Email = @Email AND Password = @Password";

                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", email);
                command.Parameters.AddWithValue("@Password", password);

                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("Logged In Successfully");
                    if (reader[2].ToString() == "C")
                    {
                        Customer customer = new Customer();
                        
                        MainMenu.IsUserLoggedIn = true;
                        MainMenu mainMenu = new MainMenu();
                        mainMenu.Show();
                        this.Hide();
                    }
                    else
                    {
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
