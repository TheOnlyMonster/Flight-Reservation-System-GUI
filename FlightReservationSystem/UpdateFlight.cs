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
using System.Text.RegularExpressions;
using System.Collections;

namespace FlightReservationSystem
{
    public partial class UpdateFlight : MainMenu, IProcessDataGrid
    {
        private ErrorProvider errorProvider;
        public UpdateFlight()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
            this.dataManager = new DataManager(databaseConnection, this);
        }
        private void updateFlightComboBox_Changed(object sender, EventArgs e)
        {
            string query = "SELECT FlightNo, AirCraftID, deptCountry, arrivalCountry, deptDate, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight ";
            if (this.deptCountriesComboBox.SelectedItem == null && this.arrivalCountriesComboBox.SelectedItem == null)
            {
                query += "WHERE CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
            }
            else if (this.deptCountriesComboBox.SelectedItem == null)
            {
                query += "WHERE CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND arrivalCountry = @arrivalCountry";
            }
            else if (this.arrivalCountriesComboBox.SelectedItem == null)
            {
                query +=  "WHERE CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND deptCountry = @deptCountry";
            }
            else
            {
                query += "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
            }
            this.dataManager.UpdateDataGrid(AdminFlightDataGrid, query);
        }

        private void AdminDeptCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            fillComboBox($"Select DISTINCT deptCountry from Flight", deptCountriesComboBox);
        }
        private void AdminArrivalCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            fillComboBox($"Select DISTINCT arrivalCountry from Flight", arrivalCountriesComboBox);
        }

        


        private void UpdateFlight_Load(object sender, EventArgs e)
        {
            updateFlightComboBox_Changed(sender, e);
        }


        private void AdminFlightDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //load Data from a single Row on click

            if (e.RowIndex >= 0)
            {  //the row that I'm clicking is not the labels Row.
                DataGridViewRow SelectedRow = AdminFlightDataGrid.Rows[e.RowIndex];
                this.ArrivalCountryTextBox.Text = SelectedRow.Cells["arrivalCountry"].Value.ToString();
                this.DeparturedateTimePicker.Text = SelectedRow.Cells["deptDate"].Value.ToString();
                this.ArrivaldateTimePicker.Text = SelectedRow.Cells["expectedArrivalDate"].Value.ToString();
                this.FlightNumberTextBox.Text = SelectedRow.Cells["FlightNo"].Value.ToString();
                this.AirCraftIdTextBox.Text = SelectedRow.Cells["AirCraftID"].Value.ToString();
                this.RankATextBox.Text = SelectedRow.Cells["Rank1Price"].Value.ToString();
                this.RankBTextBox.Text = SelectedRow.Cells["Rank2Price"].Value.ToString();
                this.RankCTextBox.Text = SelectedRow.Cells["Rank3Price"].Value.ToString();
                this.DepartureTextBox.Text = SelectedRow.Cells["deptCountry"].Value.ToString();
                this.SeatsAvailabilityTextBox.Text = SelectedRow.Cells["AvailableSeats"].Value.ToString();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string seatsAvailable = this.SeatsAvailabilityTextBox.Text;
            if (!ValidateIntegers(seatsAvailable)) {
                errorProvider.SetError(SeatsAvailabilityTextBox, "Invalid seat, Please enter a valid seat.");
                this.SeatsAvailabilityTextBox.Focus();
                return;
            }
            
            string airCraftId = this.AirCraftIdTextBox.Text;
            if (!ValidateIntegers(airCraftId)) {
                errorProvider.SetError(AirCraftIdTextBox, "Invalid aircraftID, Please enter a valid aircraftID.");
                this.AirCraftIdTextBox.Focus();
                return;
            }

            string rankAPrice = this.RankATextBox.Text;
            if (!ValidateDouble(rankAPrice)) {
                errorProvider.SetError(RankATextBox, "Invalid Rank A Price, Please enter a valid Rank A Price.");
                this.RankATextBox.Focus();
                return;
            }

            string rankBPrice = this.RankBTextBox.Text;
            if (!ValidateDouble(rankAPrice)) {
                errorProvider.SetError(RankBTextBox, "Invalid Rank B Price, Please enter a valid Rank B Price.");
                this.RankBTextBox.Focus();
                return;
            }

            string rankCPrice = this.RankCTextBox.Text;
            if (!ValidateDouble(rankAPrice)) {
                errorProvider.SetError(RankCTextBox, "Invalid Rank C Price, Please enter a valid Rank C Price.");
                this.RankCTextBox.Focus();
                return;
            }



            string query = "UPDATE Flight Set DeptDate = @DeptDate, AirCraftID = @AirCraftID, ExpectedArrival = @ExpectedArrival, Rank1Price = @Rank1Price, Rank2Price = @Rank2Price, Rank3Price = @Rank3Price, AvailableSeats = @AvailableSeats Where FlightNo = @FlightNo;";
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);


                //Differs From One Computer To Another. Previous was dd MMMM yyyy 
                command.Parameters.AddWithValue("@DeptDate", DateTime.ParseExact(DeparturedateTimePicker.Text, "dddd, MMMM d, yyyy", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@ExpectedArrival", DateTime.ParseExact(ArrivaldateTimePicker.Text, "dddd, MMMM d, yyyy", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                
                
                
                command.Parameters.AddWithValue("@Rank1Price", Double.Parse(RankATextBox.Text));
                command.Parameters.AddWithValue("@Rank2Price", Double.Parse(RankBTextBox.Text));
                command.Parameters.AddWithValue("@Rank3Price", Double.Parse(RankCTextBox.Text));
                command.Parameters.AddWithValue("@AvailableSeats", int.Parse(SeatsAvailabilityTextBox.Text));
                command.Parameters.AddWithValue("@FlightNo", int.Parse(FlightNumberTextBox.Text));
                command.Parameters.AddWithValue("@AirCraftID", int.Parse(AirCraftIdTextBox.Text));
                command.ExecuteNonQuery();
                connection.Close();

            }
           
            UpdateFlight_Load(sender, e);
            MessageBox.Show("Changes Has Been Confirmed");

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Flight WHERE FlightNO = @RecordId;";
                using (SqlConnection connection = new SqlConnection(databaseConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@RecordId", int.Parse(FlightNumberTextBox.Text));
                    command.ExecuteNonQuery();
                    connection.Close();

                }
                UpdateFlight_Load(sender, e);
            }
        }
        
        private bool ValidateIntegers(string integer)
        {
            //Regular Expression of Validating Price.
            string pattern = @"^[0-9]+$";
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(integer);
            return isValid;
        }

        private bool ValidateDouble(string doubleType)
        {
            //Regular Expression of Validating Seats.
            string pattern = @"^[0-9]+(\.[0-9]+)?$";
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(doubleType);
            return isValid;
        }

        public void ProccessDataGrid(SqlCommand command)
        {
            if (this.deptCountriesComboBox.SelectedItem != null && this.arrivalCountriesComboBox.SelectedItem != null)
            {
                command.Parameters.AddWithValue("@deptCountry", this.deptCountriesComboBox.SelectedItem.ToString());
                command.Parameters.AddWithValue("@arrivalCountry", this.arrivalCountriesComboBox.SelectedItem.ToString());
            }
            else if (this.deptCountriesComboBox.SelectedItem == null && this.arrivalCountriesComboBox.SelectedItem != null)
            {
                command.Parameters.AddWithValue("@arrivalCountry", this.arrivalCountriesComboBox.SelectedItem.ToString());
            }
            else if (this.arrivalCountriesComboBox.SelectedItem == null && this.deptCountriesComboBox.SelectedItem != null)
            {
                command.Parameters.AddWithValue("@deptCountry", this.deptCountriesComboBox.SelectedItem.ToString());
            }
            command.Parameters.AddWithValue("@deptDate", this.deptDateTimePicker.Value);
        }
    }
}
