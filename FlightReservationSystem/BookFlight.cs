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
        }

        private void bookFlightComboBox_Changed(object sender, EventArgs e)
        {
            string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight " +
                    "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
            if (this.deptCountriesComboBox.SelectedItem == null || this.arrivalCountriesComboBox.SelectedItem == null)
            {
                query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats,Rank1Price, Rank2Price, Rank3Price FROM Flight";
            }

            flightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (this.deptCountriesComboBox.SelectedItem != null && this.arrivalCountriesComboBox.SelectedItem != null)
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

        private void flightDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = flightDataGrid.Rows[e.RowIndex];
                this.flightNoTextBox.Text = selectedRow.Cells["FlightNo"].Value.ToString();
                this.seatsAvailableTextBox.Text = selectedRow.Cells["AvailableSeats"].Value.ToString();
                this.arrivalCountryTextBox.Text = selectedRow.Cells["arrivalCountry"].Value.ToString();
                this.arrivalDateTextBox.Text = selectedRow.Cells["expectedArrivalDate"].Value.ToString();
                this.deptCountryTextBox.Text = selectedRow.Cells["deptCountry"].Value.ToString();
            }
        }
        private void BookFlight_Load(object sender, EventArgs e)
        {
            bookFlightComboBox_Changed(sender, e);
        }

        private void seatsNumericUpDown_UpButton(object sender, EventArgs e)
        {
            if (seatsNumericUpDown.Value >= 7)
            {
                seatsNumericUpDown.Value = 7;
            }

        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightNoTextBox.Text) || string.IsNullOrEmpty(seatsAvailableTextBox.Text) || string.IsNullOrEmpty(arrivalCountryTextBox.Text) || string.IsNullOrEmpty(arrivalDateTextBox.Text) || string.IsNullOrEmpty(deptCountryTextBox.Text))
            {
                MessageBox.Show("You must select a Flight first!");
            }
            else
            {
                string query = "INSERT INTO BookingDetails Values(CustomerID, FlightNo, BookingDate, SeatAssignment, TicketPrice)";

            }
        }
    }
}