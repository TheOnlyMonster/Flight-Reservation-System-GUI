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
    public partial class BookFlight : MainMenu
    {
        public BookFlight()
        {
            InitializeComponent();
            contentSplitContainer.Panel1.Controls.Remove(this.signUpButton);
            contentSplitContainer.Panel1.Controls.Remove(this.signInButton);
        }

        private void bookFlightComboBox_Changed(object sender, EventArgs e)
        {
            string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival FROM Flight " +
                    "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
            if (this.deptCountriesComboBox.SelectedItem == null || this.arrivalCountriesComboBox.SelectedItem == null) {
                query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival FROM Flight";
            }

            //flightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                
                SqlCommand command = new SqlCommand(query, connection);
                if(this.deptCountriesComboBox.SelectedItem != null && this.arrivalCountriesComboBox.SelectedItem != null)
                {
                    command.Parameters.AddWithValue("@deptCountry", this.deptCountriesComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@arrivalCountry", this.arrivalCountriesComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@deptDate", this.deptDateTimePicker.Value);
                }
                
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                flightDataGrid.Rows.Add(rowData);
            }
            //this.contentSplitContainer.Panel2.Controls.Add(this.flightDataGrid);
            //this.bookFlightPanel.Controls.Add(this.flightDataGrid);
        }
        private void deptCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            deptCountriesComboBox.Items.Clear();
            fillComboBox($"Select DISTINCT deptCountry from Flight", deptCountriesComboBox);
        }
        private void arrivalCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            arrivalCountriesComboBox.Items.Clear();
            fillComboBox($"Select DISTINCT arrivalCountry from Flight", arrivalCountriesComboBox);
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

        

        private void BookFlight_Load(object sender, EventArgs e)
        {
            bookFlightComboBox_Changed(sender, e);
        }
    }
}
