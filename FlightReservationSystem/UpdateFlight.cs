using Guna.UI2.WinForms;
using System.Data.SqlClient;
namespace FlightReservationSystem
{
    public partial class UpdateFlight : MainMenu, IProcessQuery, IProcessDataGrid
    {

        public UpdateFlight()
        {
            InitializeComponent();
            this.dataManager = new(databaseConnection, this, this);
            ChangeButton(this.updateFlightButton);
        }

        private void UpdateFlightComboBox_Changed(object sender, EventArgs e)
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
                query += "WHERE CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND deptCountry = @deptCountry";
            }
            else
            {
                query += "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
            }
            dataManager?.UpdateDataGrid(flightDataGrid, query);
        }

        private void AdminDeptCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            dataManager?.FillComboBox($"Select DISTINCT deptCountry from Flight", deptCountriesComboBox);
        }

        private void AdminArrivalCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            dataManager?.FillComboBox($"Select DISTINCT arrivalCountry from Flight", arrivalCountriesComboBox);
        }

        private void UpdateFlight_Load(object sender, EventArgs e)
        {
            UpdateFlightComboBox_Changed(sender, e);
            List<Guna2ComboBox> hoursComboBoxes = new()
            {
                deptHourComboBox, arrivalHourComboBox
            };
            List<Guna2ComboBox> minutesComboBoxes = new()
            {
                deptMinutesComboBox, arrivalMinutesComboBox
            };
            List<Guna2ComboBox> middayComboBoxes = new()
            {
                deptMiddayStatusComboBox, arrivalMiddayStatusComboBox
            };
            FillTimeComboBoxes(hoursComboBoxes, minutesComboBoxes, middayComboBoxes);
        }

        private void AdminFlightDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex >= 0)
            {
                DataGridViewRow SelectedRow = flightDataGrid.Rows[e.RowIndex];
                this.arrivalCountryTextBox.Text = SelectedRow.Cells["arrivalCountry"].Value.ToString();
                this.deptDatePanel2TimePicker.Text = SelectedRow.Cells["deptDate"].Value.ToString();
                this.arrivalDateTimePicker.Text = SelectedRow.Cells["expectedArrivalDate"].Value.ToString();
                this.flightNoTextBox.Text = SelectedRow.Cells["FlightNo"].Value.ToString();
                this.aircraftIDTextBox.Text = SelectedRow.Cells["AirCraftID"].Value.ToString();
                this.rankATextBox.Text = SelectedRow.Cells["Rank1Price"].Value.ToString();
                this.rankBTextBox.Text = SelectedRow.Cells["Rank2Price"].Value.ToString();
                this.rankCTextBox.Text = SelectedRow.Cells["Rank3Price"].Value.ToString();
                this.deptCountryTextBox.Text = SelectedRow.Cells["deptCountry"].Value.ToString();
                this.seatsAvailableTextBox.Text = SelectedRow.Cells["AvailableSeats"].Value.ToString();
                string? currentDepartureDate = SelectedRow.Cells["deptDate"].Value.ToString();
                string? currentArrivalDate = SelectedRow.Cells["expectedArrivalDate"].Value.ToString();
                //spliting the date format to tokens.
                if (currentDepartureDate != null && currentArrivalDate != null)
                {
                    string[]? currentDepartureDateTokens = currentDepartureDate.Split(' ');
                    string[]? currentArrivalDateTokens = currentArrivalDate.Split(' ');
                    //setting the depatrment Date and arrival date to the first token from each string.
                    this.deptDatePanel2TimePicker.Text = currentDepartureDateTokens?[0];
                    this.arrivalDateTimePicker.Text = currentArrivalDateTokens?[0];
                    //spliting the time token to two tokens the hours and minutes.
                    string[]? deptTime = currentDepartureDateTokens?[1].Split(':');
                    string[]? arrivalTime = currentArrivalDateTokens?[1].Split(':');
                    //assigning the hours  and minutes to both the dept and arrival.
                    this.deptHourComboBox.Text = deptTime?[0];
                    this.deptMinutesComboBox.Text = deptTime?[1];
                    this.arrivalHourComboBox.Text = arrivalTime?[0];
                    this.arrivalMinutesComboBox.Text = arrivalTime?[1];
                    // assigning the midday status to both the dept and arrival.
                    this.deptMiddayStatusComboBox.Text = currentDepartureDateTokens?[2];
                    this.arrivalMiddayStatusComboBox.Text = currentArrivalDateTokens?[2];
                }

            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightNoTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Flight Number. Please choose flight to edit and try again!", flightNoTextBox);
                return;
            }
            string deptTime = $"{deptHourComboBox.Text}:{deptMinutesComboBox.Text} {deptMiddayStatusComboBox.Text}";
            string arrivalTime = $"{arrivalHourComboBox.Text}:{arrivalMinutesComboBox.Text} {arrivalMiddayStatusComboBox.Text}";
            if (!DataAuthenticator.Instance.ValidateTime(deptDatePanel2TimePicker, arrivalDateTimePicker, deptTime, arrivalTime))
            {
                return;
            }
            if (!DataAuthenticator.Instance.ValidateDouble(rankATextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Rank Price. Please enter valid rank price and try again!", rankATextBox);
                return;
            }

            if (!DataAuthenticator.Instance.ValidateDouble(rankBTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Rank Price. Please enter valid rank price and try again!", rankBTextBox);
                return;
            }

            if (!DataAuthenticator.Instance.ValidateDouble(rankCTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Rank Price. Please enter valid rank price and try again!", rankCTextBox);
                return;
            }
            string query = "UPDATE Flight Set DeptDate = @DeptDate, AircraftID = @AircraftID, ExpectedArrival = @ExpectedArrival, Rank1Price = @Rank1Price, Rank2Price = @Rank2Price, Rank3Price = @Rank3Price, AvailableSeats = @AvailableSeats Where FlightNo = @FlightNo;";
            dataManager?.ExcuteDataQuery(query);
            UpdateFlight_Load(sender, e);
            MessageBox.Show("Changes Has Been Confirmed");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightNoTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Flight Number. Please choose flight to edit and try again!", flightNoTextBox);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Flight WHERE FlightNO = @RecordId;";
                dataManager?.ExcuteDataQuery(query);
                UpdateFlight_Load(sender, e);
            }
        }

        public void SetDataGridCommandParams(SqlCommand command)
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
            command.Parameters.AddWithValue("@deptDate", this.deptDatePanel1TimePicker.Value);
        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if (queryType == QueryType.Update)
            {
                string deptDate = deptDatePanel2TimePicker.Value.ToShortDateString();
                string deptTime = $"{deptHourComboBox.Text}:{deptMinutesComboBox.Text} {deptMiddayStatusComboBox.Text}";
                string dept = $"{deptDate} {deptTime}";

                string arrivalDate = arrivalDateTimePicker.Value.ToShortDateString();
                string arrivalTime = $"{arrivalHourComboBox.Text}:{arrivalMinutesComboBox.Text} {arrivalMiddayStatusComboBox.Text}";
                string arrival = $"{arrivalDate} {arrivalTime}";

                command.Parameters.AddWithValue("@DeptDate", dept);
                command.Parameters.AddWithValue("@ExpectedArrival", arrival);
                command.Parameters.AddWithValue("@Rank1Price", Double.Parse(rankATextBox.Text));
                command.Parameters.AddWithValue("@Rank2Price", Double.Parse(rankBTextBox.Text));
                command.Parameters.AddWithValue("@Rank3Price", Double.Parse(rankCTextBox.Text));
                command.Parameters.AddWithValue("@AvailableSeats", int.Parse(seatsAvailableTextBox.Text));
                command.Parameters.AddWithValue("@FlightNo", int.Parse(flightNoTextBox.Text));
                command.Parameters.AddWithValue("@AircraftID", int.Parse(aircraftIDTextBox.Text));
            }
            else if (queryType == QueryType.Delete)
            {
                command.Parameters.AddWithValue("@RecordId", int.Parse(flightNoTextBox.Text));
            }
        }
    }
}
