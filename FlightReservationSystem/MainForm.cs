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
        private void PhoneValidation(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != '\b')
            {
                e.Handled = true;
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {   
            if (textBoxEmail.Text != "" && textBoxFirstName.Text != "" && textBoxLastName.Text != "" && textBoxPassword.Text != "" && textBoxPhone.Text != "") {
                using (SqlConnection connection = new SqlConnection(databaseConnection))
                {
                    connection.Open();
                    string checkingQuery = "SELECT Count(Email) from UserTable where Email = @email";
                    using (SqlCommand command = new SqlCommand(checkingQuery, connection)) {
                        command.Parameters.AddWithValue("@email", textBoxEmail.Text);
                        int filterKey = Convert.ToInt32(command.ExecuteScalar());
                        if(filterKey == 1){
                            MessageBox.Show("Email already taken!");
                            connection.Close();
                            return;
                        }
                    }
                    string parentInsertQuery = "INSERT INTO UserTable (Email, Fname, Lname, Password, Identifier) VALUES (@email, @fname, @lname, @password, @identifier); SELECT SCOPE_IDENTITY();";
                    using (SqlCommand parentCmd = new SqlCommand(parentInsertQuery, connection)) {
                        parentCmd.Parameters.AddWithValue("@email",textBoxEmail.Text);
                        parentCmd.Parameters.AddWithValue("@fname",textBoxFirstName.Text);
                        parentCmd.Parameters.AddWithValue("@lname",textBoxLastName.Text);
                        parentCmd.Parameters.AddWithValue("@password",textBoxPassword.Text);
                        parentCmd.Parameters.AddWithValue("@identifier","C");
                        int parentID = Convert.ToInt32(parentCmd.ExecuteScalar());
                        string childInsertQuery = "INSERT INTO CustomerTable (CustomerID,PhoneNumber) VALUES (@cid, @phone);";
                        using (SqlCommand childCmd = new SqlCommand(childInsertQuery,connection)) {
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
            else {
                MessageBox.Show("Null values aren't valid!");
            }
        }
        private void exploreFlightsButton_Click(object sender, EventArgs e)
        {
            this.flightDataGrid.Dock = DockStyle.Fill;
            this.flightDataGrid.Location = new Point(0, 0);
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
                    this.signInPanel.Hide();
                    if (reader[2].ToString() == "C"){
                        contentSplitContainer.Panel1.Controls.Add(bookFlightButton);
                        contentSplitContainer.Panel1.Controls.Remove(signInButton);
                        contentSplitContainer.Panel1.Controls.Remove(signUpButton);
                    }
                    else{
                        //TODO: Admin Login
                    }
                }
                else{
                    MessageBox.Show("Log In Failed");
                }

                reader.Close();
            }
        }
        private void fillComboBox(string query, ComboBox comboBox)
        {
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataReader sqlDataReader = command.ExecuteReader();
                while (sqlDataReader.Read())
                {
                    comboBox.Items.Add(sqlDataReader.GetString(0));
                }
                connection.Close();
            }
        }
        private void deptCountriesComboBox_OnDropDown(object sender, EventArgs e) {
            deptCountriesComboBox.Items.Clear();
            fillComboBox($"Select DISTINCT deptCountry from Flight", deptCountriesComboBox);
        }

        private void ArrivalCountriesComboBox_OnDropDown(object sender, EventArgs e) {
            arrivalCountriesComboBox.Items.Clear();
            fillComboBox($"Select DISTINCT arrivalCountry from Flight", arrivalCountriesComboBox);
        }

        private void bookFlightButton_Click(object sender, EventArgs e)
        {
            flightDataGrid.Rows.Clear();
            contentSplitContainer.Panel2.Controls.Clear();
            contentSplitContainer.Panel2.Controls.Add(bookFlightPanel);
            this.flightDataGrid.Dock = DockStyle.Bottom;
            this.flightDataGrid.Size = new Size(1121, 522);
            this.flightDataGrid.Location = new Point(0, 179);


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
            this.bookFlightPanel.Controls.Add(this.flightDataGrid);
        }

        private void bookFlightComboBox_Changed(object sender, EventArgs e)
        {
            if (this.deptCountriesComboBox.SelectedItem == null || this.arrivalCountriesComboBox.SelectedItem == null) return;

            flightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival FROM Flight " +
                    "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@deptCountry", this.deptCountriesComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@arrivalCountry", this.arrivalCountriesComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@deptDate", this.deptDateTimePicker.Value);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                flightDataGrid.Rows.Add(rowData);
            }
            this.bookFlightPanel.Controls.Add(this.flightDataGrid);
        }


    }
}