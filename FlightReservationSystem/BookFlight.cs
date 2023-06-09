﻿using Guna.UI2.WinForms;
using System.Data.SqlClient;
namespace FlightReservationSystem
{

    public partial class BookFlight : MainMenu, IProcessDataGrid
    {
        private readonly Dictionary<string, double> flightRanks;
        private readonly List<string> tempBookedSeats;
        private readonly List<SqlCommand> commands;
        public BookFlight()
        {
            InitializeComponent();
            dataManager = new(databaseConnection, this);
            flightRanks = new();
            commands = new();
            tempBookedSeats = new();
            deptDateTimePicker.Value = DateTime.Now;
            ChangeButton(bookFlightButton);
        }
        private void LoadGrid(object sender, EventArgs e)
        {
            string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight ";
            if (this.deptCountriesComboBox.SelectedItem == null && this.arrivalCountriesComboBox.SelectedItem == null)
            {
                query += "WHERE AvailableSeats <> 0 AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
            }
            else if (this.deptCountriesComboBox.SelectedItem == null)
            {
                query += "WHERE AvailableSeats <> 0 AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND arrivalCountry = @arrivalCountry";
            }
            else if (this.arrivalCountriesComboBox.SelectedItem == null)
            {
                query += "WHERE AvailableSeats <> 0 AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND deptCountry = @deptCountry";
            }
            else
            {
                query += "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND AvailableSeats <> 0";
            }
            dataManager?.UpdateDataGrid(flightDataGrid, query);
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
            command.Parameters.AddWithValue("@deptDate", this.deptDateTimePicker.Value);
        }
        private void DeptCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            dataManager?.FillComboBox($"Select DISTINCT deptCountry from Flight where AvailableSeats <> 0", deptCountriesComboBox);
        }
        private void ArrivalCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            dataManager?.FillComboBox($"Select DISTINCT arrivalCountry from Flight where AvailableSeats <> 0", arrivalCountriesComboBox);
        }
        private void FlightDataGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flightRanks.Clear();
            string[] SelectionOptions = { "A Class", "B Class", "C Class" };
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = flightDataGrid.Rows[e.RowIndex];
                this.flightNoTextBox.Text = selectedRow.Cells["FlightNo"].Value.ToString();
                this.seatsAvailableTextBox.Text = selectedRow.Cells["AvailableSeats"].Value.ToString();
                this.arrivalCountryTextBox.Text = selectedRow.Cells["arrivalCountry"].Value.ToString();
                this.arrivalDateTextBox.Text = selectedRow.Cells["expectedArrivalDate"].Value.ToString();
                this.deptCountryTextBox.Text = selectedRow.Cells["deptCountry"].Value.ToString();
                this.departureDateTextBox.Text = selectedRow.Cells["deptDate"].Value.ToString();
                flightRanks.Add("A Class", Convert.ToDouble(selectedRow.Cells["Rank1Price"].Value));
                flightRanks.Add("B Class", Convert.ToDouble(selectedRow.Cells["Rank2Price"].Value));
                flightRanks.Add("C Class", Convert.ToDouble(selectedRow.Cells["Rank3Price"].Value));
                this.rankComboBox.DataSource = SelectionOptions;
            }
        }
        private void SeatsNoNumericUpDown_UpButton(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seatsAvailableTextBox.Text))
            {
                seatsNoNumericUpDown.Value = 1;
                return;
            }
            if (Convert.ToInt32(seatsAvailableTextBox.Text) < 7)
            {
                if (seatsNoNumericUpDown.Value >= Convert.ToInt32(seatsAvailableTextBox.Text))
                {
                    seatsNoNumericUpDown.Value = Convert.ToInt32(seatsAvailableTextBox.Text);
                }
            }
            else if (seatsNoNumericUpDown.Value >= 7)
            {
                seatsNoNumericUpDown.Value = 7;
            }
        }
        private void ChangePanel2State(bool state)
        {
            seatsNoNumericUpDown.Enabled = state;
            confirmButton.Enabled = state;
            topPanel.Visible = state;
            creditCardTextBox.ReadOnly = !state;
            creditCardExpiryDateTextBox.ReadOnly = !state;
            cvvCreditCardTextBox.ReadOnly = !state;
            seatAssignmentPanel.Visible = !state;
            Color backColor;
            if (state)
            {
                backColor = Color.White;
            }
            else
            {
                backColor = totalPriceTextBox.FillColor;
            }
            seatsNoNumericUpDown.FillColor = backColor;
            creditCardTextBox.FillColor = backColor;
            creditCardExpiryDateTextBox.FillColor = backColor;
            cvvCreditCardTextBox.FillColor = backColor;
        }
        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(flightNoTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Please select flight and try again!", flightNoTextBox);
                return;
            }
            if (seatsNoNumericUpDown.Value == 0)
            {
                return;
            }
            string[] deptDate = departureDateTextBox.Text.Split(" ");
            string deptShortDate = deptDate[0];
            string deptTime = deptDate[1];
            string deptMidday = deptDate[2];
            if (DateTime.Parse(DateTime.Now.ToShortDateString()) > DateTime.Parse(deptShortDate))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Departure Date. Please choose a future date for your flight.", deptDateTimePicker);
                return;
            }
            else if (DateTime.Parse(DateTime.Now.ToShortDateString()) == DateTime.Parse(deptShortDate))
            {
                TimeSpan deptTimeSpan = DateTime.Parse(deptTime + " " + deptMidday).TimeOfDay;
                if (DateTime.Now.TimeOfDay > deptTimeSpan)
                {
                    DataAuthenticator.Instance.SetAuthenticatorError("Invalid Departure Date. Please choose a future date for your flight.", deptDateTimePicker);
                    return;
                }
            }
            if (!DataAuthenticator.Instance.ValidateCardNumber(creditCardTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Card Number. Please enter valid card number and try again!", creditCardTextBox);
                return;
            }
            if (!DataAuthenticator.Instance.ValidateCardExpiryDate(creditCardExpiryDateTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Card Expiry Date. Please enter valid card expiry date and try again!", creditCardExpiryDateTextBox);
                return;
            }
            if (!DataAuthenticator.Instance.ValidateCardCVV(cvvCreditCardTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Card CVV. Please enter valid card cvv and try again!", cvvCreditCardTextBox);
                return;
            }
            ChangePanel2State(false);
            RankComboBox_SelectedValueChanged(sender, e);
        }
        private void RankComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            this.rankPriceTextBox.Text = flightRanks[rankComboBox.Text].ToString();
            if (!seatsTableLayoutPanel.Visible)
            {
                return;
            }
            int? availableSeats = dataManager?.NormalizeSeatsDataGrid(seatsTableLayoutPanel, rankComboBox, flightNoTextBox);
            string query = "select COUNT(*) from BookingDetails where Rank=@Rank and FlightNo=@FlightNo and SeatAssignment=@Seat";
            int row = -1;
            SqlConnection connection = new(databaseConnection);
            SqlCommand command;
            connection.Open();
            for (int i = 0; i < availableSeats; i++)
            {
                bool isBooked = false;
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rank", this.rankComboBox.Text);
                command.Parameters.AddWithValue("@FlightNo", this.flightNoTextBox.Text);
                command.Parameters.AddWithValue("@Seat", i + 1);
                int result = Convert.ToInt32(command.ExecuteScalar());
                if (result == 1)
                {
                    isBooked = true;
                }
                int col = i % 6;
                if (col == 0)
                {
                    row++;
                }
                Guna2Button obj = new()
                {
                    Image = seat.Image,
                    HoverState = seat.HoverState,
                    FillColor = seat.FillColor,
                    ImageSize = seat.ImageSize,
                    Tag = (i + 1).ToString()
                };
                if (isBooked || tempBookedSeats.Contains(this.rankComboBox.Text + obj.Tag.ToString()))
                {
                    obj.Enabled = false;
                    obj.FillColor = Color.Black;
                }
                else
                {
                    obj.HoverState.Image = seat.HoverState.Image;
                    obj.Cursor = Cursors.Hand;
                    obj.Click += Seat_Click;
                }
                seatsTableLayoutPanel.Controls.Add(obj, col, row);
            }
            foreach (Control control in seatsTableLayoutPanel.Controls)
            {
                if (control is Guna2Button button && button.Enabled == true)
                {
                    this.seatAssignmentTextBox.Text = (string)button.Tag;
                    this.Seat_Click(button, e);
                    break;
                }
            }
        }
        private void Seat_Click(object? sender, EventArgs e)
        {
            DataManager.ToggleSeatButton(seatsTableLayoutPanel, seatAssignmentTextBox, seat, sender);
        }
        private void CancelReservationButton_Click(object sender, EventArgs e)
        {
            totalPriceTextBox.Text = string.Empty;
            tempBookedSeats.Clear();
            commands.Clear();
            ChangePanel2State(true);
            LoadGrid(sender, e);
        }
        private void NextSeatButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(seatAssignmentTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Please choose seat and try again!", seatAssignmentTextBox);
                return;
            }
            if (string.IsNullOrEmpty(passportNumberTextBox.Text) || !DataAuthenticator.Instance.ValidatePassportNumber(passportNumberTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Passport Number. Please enter a valid passport number and try again!", passportNumberTextBox);
                return;
            }
            if (string.IsNullOrEmpty(firstNameTextBox.Text) || !DataAuthenticator.Instance.ValidateName(firstNameTextBox.Text) || string.IsNullOrEmpty(lastNameTextBox.Text) || !DataAuthenticator.Instance.ValidateName(lastNameTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Name. Please enter a valid name and try again!", firstNameTextBox);
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Name. Please enter a valid name and try again!", lastNameTextBox);
                return;
            }
            string ticketQuery = "INSERT INTO BookingDetails (CustomerID, FlightNo, BookingDate,SeatAssignment ,TicketPrice, Rank, Status, FirstName, LastName, PassportNumber, PassportEXPDate) Values (@CustomerID, @FlightNo, @BookingDate, @SeatAssignment, @TicketPrice, @Rank, @Status, @FirstName, @LastName, @PassportNumber, @PassportEXPDate);";
            SqlCommand sqlCommand = new(ticketQuery);
            sqlCommand.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);
            sqlCommand.Parameters.AddWithValue("@FlightNo", flightNoTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@BookingDate", DateTime.Now.ToShortDateString());
            sqlCommand.Parameters.AddWithValue("@SeatAssignment", seatAssignmentTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@TicketPrice", rankPriceTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@Rank", rankComboBox.Text);
            sqlCommand.Parameters.AddWithValue("@Status", "Confirmed");
            sqlCommand.Parameters.AddWithValue("@FirstName", firstNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@LastName", lastNameTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PassportNumber", passportNumberTextBox.Text);
            sqlCommand.Parameters.AddWithValue("@PassportEXPDate", DateTime.Parse(passportExpiryDateTimePicker.Text).ToShortDateString());
            tempBookedSeats.Add(rankComboBox.Text + seatAssignmentTextBox.Text);
            commands.Add(sqlCommand);
            double totalPrice;
            if (totalPriceTextBox.Text == "")
            {
                totalPrice = Convert.ToDouble(rankPriceTextBox.Text);
            }
            else
            {
            totalPrice = Convert.ToDouble(totalPriceTextBox.Text) + Convert.ToDouble(rankPriceTextBox.Text);
            }
            totalPriceTextBox.Text = totalPrice.ToString();
            this.passportNumberTextBox.Text = string.Empty;
            this.firstNameTextBox.Text = string.Empty;
            this.lastNameTextBox.Text = string.Empty;
            if (commands.Count == Convert.ToInt32(seatsNoNumericUpDown.Value))
            {
                DialogResult result = MessageBox.Show($"Are you sure you want to book {this.seatsNoNumericUpDown.Value} ticket/s? this will cost you {this.totalPriceTextBox.Text}.", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if(result == DialogResult.No) {
                    CancelReservationButton_Click(sender, e);
                    return;
                }
                SqlConnection connection = new(databaseConnection);
                connection.Open();
                foreach (var command in commands)
                {
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
                string flightUpdateQuery = "Update Flight set AvailableSeats = @AvailableSeats where FlightNo = @FlightNo;";
                sqlCommand = new(flightUpdateQuery, connection);
                sqlCommand.Parameters.AddWithValue("@AvailableSeats", int.Parse(this.seatsAvailableTextBox.Text) - seatsNoNumericUpDown.Value);
                sqlCommand.Parameters.AddWithValue("@FlightNo", this.flightNoTextBox.Text);
                sqlCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show($"Booked {this.seatsNoNumericUpDown.Value} Tickets Successfully!");
                CancelReservationButton_Click(sender, e);
            }
            else
            {
                RankComboBox_SelectedValueChanged(sender, e);
            }
        }
    }
}