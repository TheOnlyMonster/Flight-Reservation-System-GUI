using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace FlightReservationSystem
{
    public partial class UpdateFlight : MainMenu
    {
        public UpdateFlight()
        {
            InitializeComponent();
        }

        private void AdminDeptCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            deptCountriesComboBox.Items.Clear();
            fillComboBox($"Select DISTINCT deptCountry from Flight where AvailableSeats <> 0", deptCountriesComboBox);
        }
        private void AdminArrivalCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            comboBox1.Items.Clear();
            fillComboBox($"Select DISTINCT arrivalCountry from Flight where AvailableSeats <> 0", comboBox1);
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


        private void UpdateFlight_Load(object sender, EventArgs e) {


            //load the Grid.
            
            AdminFlightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight where AvailableSeats <> 0";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                AdminFlightDataGrid.Rows.Add(rowData);
            }
        }

        private void UpdateFlightComboBox_Changed(object sender, EventArgs e)
        {
            string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight " +
                    "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND AvailableSeats <> 0";
            if (this.deptCountriesComboBox.SelectedItem == null || this.comboBox1.SelectedItem == null)
            {
                query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats,Rank1Price, Rank2Price, Rank3Price FROM Flight where AvailableSeats <> 0";
            }

            AdminFlightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                if (this.deptCountriesComboBox.SelectedItem != null && this.comboBox1.SelectedItem != null)
                {
                    command.Parameters.AddWithValue("@deptCountry", this.deptCountriesComboBox.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@arrivalCountry", this.comboBox1.SelectedItem.ToString());
                    command.Parameters.AddWithValue("@deptDate", this.deptDateTimePicker.Value);
                }

                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                AdminFlightDataGrid.Rows.Add(rowData);
            }
        }

        private void AdminFlightDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //load Data from a single Row on click

            if (e.RowIndex >= 0) {  //the row that I'm clicking is not the labels Row.
                DataGridViewRow SelectedRow = AdminFlightDataGrid.Rows[e.RowIndex];
                this.ArrivalCountryTextBox.Text = SelectedRow.Cells["arrivalCountry"].Value.ToString();
                this.ArrivalDateTextBox.Text = SelectedRow.Cells["expectedArrivalDate"].Value.ToString();
                this.FlightNumberTextBox.Text = SelectedRow.Cells["FlightNo"].Value.ToString();
                this.RankATextBox.Text = SelectedRow.Cells["Rank1Price"].Value.ToString();
                this.RankBTextBox.Text = SelectedRow.Cells["Rank2Price"].Value.ToString();
                this.RankCTextBox.Text = SelectedRow.Cells["Rank3Price"].Value.ToString();
                this.DepartureTextBox.Text = SelectedRow.Cells["deptCountry"].Value.ToString();
                this.SeatsAvailabilityTextBox.Text = SelectedRow.Cells["AvailableSeats"].Value.ToString();
            }
        }

        private void confirmButton_Click (object sender, EventArgs e) {
            //we need to add Aircraft ID.
            
            string query = "UPDATE Flight Set ArrivalCountry = @ArrivalCountry, ExpectedArrival = @ExpectedArrival, Rank1Price = @Rank1Price, Rank2Price = @Rank2Price, Rank3Price = @Rank3Price, AvailableSeats = @AvailableSeats Where FlightNo = @FlightNo";
            using(SqlConnection connection = new SqlConnection(databaseConnection)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@ArrivalCountry",ArrivalCountryTextBox.Text);
                MessageBox.Show(DateTime.ParseExact(ArrivalDateTextBox.Text,"yyyy-MM-dd",CultureInfo.CurrentCulture).ToString());
                command.Parameters.AddWithValue("@ExpectedArrival",DateTime.ParseExact(ArrivalDateTextBox.Text,"yyyy-MM-dd",CultureInfo.CurrentCulture));
                command.Parameters.AddWithValue("@Rank1Price",Double.Parse(RankATextBox.Text));
                command.Parameters.AddWithValue("@Rank2Price",Double.Parse(RankBTextBox.Text));
                command.Parameters.AddWithValue("@Rank3Price",Double.Parse(RankCTextBox.Text));
                command.Parameters.AddWithValue("@AvailableSeats",int.Parse(SeatsAvailabilityTextBox.Text));
                command.Parameters.AddWithValue("@FlightNo",FlightNumberTextBox.Text);
                UpdateFlight_Load(sender,e);    //not working properly!
                command.ExecuteNonQuery();
                connection.Close();
                
            }
        }
    }
}
