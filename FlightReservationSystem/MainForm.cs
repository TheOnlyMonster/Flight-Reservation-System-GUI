using System;
using System.Data;
using System.Data.SqlClient;
namespace FlightReservationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string databaseConnection = "Server = DESKTOP-FOQJ9FO\\ABDELRAHMANDB; Initial Catalog = FlightReservationSystem; Integrated Security = true; User ID = sa; Password = Admin#123";
        private void MainForm_Load(object sender, EventArgs e)
        {
            exploreFlightsButton_Click(sender, e);
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            contentSplitContainer.Panel2.Controls.Clear();
            contentSplitContainer.Panel2.Controls.Add(signUpPanel);
        }
        private void textBoxValidation(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            //TODO: Add Data To The Database
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string checkingQuery = "SELECT Count(Email) from UserTable where Email = '@email'";
                using (SqlCommand command = new SqlCommand(checkingQuery, connection))
                {
                    command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                    if (command.ExecuteNonQuery() < 0)
                    {
                        MessageBox.Show("User already taken!");
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
                        MessageBox.Show(childCmd.ExecuteNonQuery() < 0 ? "Failed" : "Success");
                    }
                }
                connection.Close();
            }

        }
        private void exploreFlightsButton_Click(object sender, EventArgs e)
        {
            contentSplitContainer.Panel2.Controls.Clear();
            contentSplitContainer.Panel2.Controls.Add(flightDataGrid);
            flightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival FROM Flight";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                flightDataGrid.Rows.Add(rowData);
            }
            contentSplitContainer.Panel2.Controls.Add(flightDataGrid);
        }
        private void signInButton_Click(object sender, EventArgs e)
        {
            contentSplitContainer.Panel2.Controls.Clear();
            contentSplitContainer.Panel2.Controls.Add(signInPanel);
        }
    }
}