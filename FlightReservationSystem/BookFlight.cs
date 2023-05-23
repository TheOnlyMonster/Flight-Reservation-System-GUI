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
using System.Globalization;
using System.Text.RegularExpressions;

namespace FlightReservationSystem
{

    public partial class BookFlight : MainMenu
    {
        private Dictionary<string, double> FlightClasses = new Dictionary<string, double>();
        private ErrorProvider errorProvider;
        public BookFlight()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void bookFlightComboBox_Changed(object sender, EventArgs e)
        {
            string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight " +
                    "WHERE deptCountry = @deptCountry AND arrivalCountry = @arrivalCountry AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND AvailableSeats <> 0";
            if (this.deptCountriesComboBox.SelectedItem == null && this.arrivalCountriesComboBox.SelectedItem == null)
            {
                query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats,Rank1Price, Rank2Price, Rank3Price FROM Flight where " +
                    "AvailableSeats <> 0 AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE)";
            }else if(this.deptCountriesComboBox.SelectedItem == null)
            {
                query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats,Rank1Price, Rank2Price, Rank3Price FROM Flight where AvailableSeats <> 0 " +
                    "AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND arrivalCountry = @arrivalCountry";
            }
            else if(this.arrivalCountriesComboBox.SelectedItem == null)
            {
                query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats,Rank1Price, Rank2Price, Rank3Price FROM Flight where" +
                    " AvailableSeats <> 0 AND CAST(deptDate AS DATE) = CAST(@deptDate AS DATE) AND deptCountry = @deptCountry";
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
            fillComboBox($"Select DISTINCT deptCountry from Flight where AvailableSeats <> 0", deptCountriesComboBox);
        }
        private void arrivalCountriesComboBox_OnDropDown(object sender, EventArgs e)
        {
            arrivalCountriesComboBox.Items.Clear();
            fillComboBox($"Select DISTINCT arrivalCountry from Flight where AvailableSeats <> 0", arrivalCountriesComboBox);
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
            FlightClasses.Clear();
            string[] SelectionOptions = { "A Class", "B Class", "C Class" };
            this.ClassComboBox.DataSource = SelectionOptions;
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = flightDataGrid.Rows[e.RowIndex];
                this.flightNoTextBox.Text = selectedRow.Cells["FlightNo"].Value.ToString();
                this.seatsAvailableTextBox.Text = selectedRow.Cells["AvailableSeats"].Value.ToString();
                this.arrivalCountryTextBox.Text = selectedRow.Cells["arrivalCountry"].Value.ToString();
                this.arrivalDateTextBox.Text = selectedRow.Cells["expectedArrivalDate"].Value.ToString();
                this.deptCountryTextBox.Text = selectedRow.Cells["deptCountry"].Value.ToString();
                FlightClasses.Add("A Class", Convert.ToDouble(selectedRow.Cells["Rank1Price"].Value));
                FlightClasses.Add("B Class", Convert.ToDouble(selectedRow.Cells["Rank2Price"].Value));
                FlightClasses.Add("C Class", Convert.ToDouble(selectedRow.Cells["Rank3Price"].Value));
                this.ClassPriceTextBox.Text = selectedRow.Cells["Rank1Price"].Value.ToString();
            }
        }
        private void ClassComboBox_SelectedValueChanged(object sender, EventArgs e)
        {
            string selectedClass = ClassComboBox.Text;
            if (FlightClasses.ContainsKey(selectedClass))
            {
                double price = FlightClasses[selectedClass];
                ClassPriceTextBox.Text = price.ToString();
                TotalPriceTextBox.Text = (Convert.ToDouble(seatsNumericUpDown.Value) * FlightClasses[this.ClassComboBox.Text]).ToString();
            }
            else
            {
                ClassPriceTextBox.Text = string.Empty;
            }
        }
        private void BookFlight_Load(object sender, EventArgs e)
        {
            bookFlightComboBox_Changed(sender, e);
            
            this.creditCardExpiryDateTextBox.Text = Customer.Instance.ExpirayDate;
            this.creditCardTextBox.Text = Customer.Instance.CardNum;
            
        }

        private void seatsNumericUpDown_UpButton(object sender, EventArgs e)
        {
            if (Convert.ToInt32(seatsAvailableTextBox.Text) < 7)
            {
                if (seatsNumericUpDown.Value >= Convert.ToInt32(seatsAvailableTextBox.Text))
                {
                    seatsNumericUpDown.Value = Convert.ToInt32(seatsAvailableTextBox.Text);
                }
            }
            else if (seatsNumericUpDown.Value >= 7)
            {
                seatsNumericUpDown.Value = 7;
            }
            TotalPriceTextBox.Text = (Convert.ToDouble(seatsNumericUpDown.Value) * FlightClasses[this.ClassComboBox.Text]).ToString();
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string cardNumber = this.creditCardTextBox.Text;
            if (!ValidateCardNumber(cardNumber))
            {
                errorProvider.SetError(creditCardTextBox, "Invalid Card number. Please enter a valid Card number.");
                this.creditCardTextBox.Focus();
                return;
            }

            string expiryDate = this.creditCardExpiryDateTextBox.Text;
            if (!ValidateExpiryDate(expiryDate))
            {
                errorProvider.SetError(creditCardExpiryDateTextBox, "Invalid Expiry Date address. Please enter a valid Expiry Date.");
                this.creditCardExpiryDateTextBox.Focus();
                return;
            }

            string cvv = this.cvvCreditCardTextBox.Text;
            if (!ValidateCVV(cvv))
            {
                 errorProvider.SetError(cvvCreditCardTextBox, "Invalid CVV address. Please enter a valid CVV.");
                this.cvvCreditCardTextBox.Focus();
                return;
            }



            if (string.IsNullOrEmpty(flightNoTextBox.Text) || string.IsNullOrEmpty(seatsAvailableTextBox.Text) || string.IsNullOrEmpty(arrivalCountryTextBox.Text) || string.IsNullOrEmpty(arrivalDateTextBox.Text) || string.IsNullOrEmpty(deptCountryTextBox.Text))
            {
                MessageBox.Show("You must select a Flight first!");
            }
            else
            {
                string ticketQuery = "INSERT INTO BookingDetails (CustomerID, FlightNo, BookingDate,SeatAssignment ,TicketPrice, Rank, Status) Values (@CustomerID, @FlightNo, @BookingDate, @SeatAssignment, @TicketPrice, @Rank, @Status);";
                string flightUpdateQuery = "Update Flight set AvailableSeats = @AvailableSeats where FlightNo = @FlightNo;";
                string updatePassportDetails = "Update CustomerTable SET PassportNumber = @PassportNumber, PassportExpirationDate = @PassportExpirationDate, CardNum = @CardNum, CVV = @CVV, ExpiryDate = @ExpiryDate where CustomerID = @CustomerID;";
                using (SqlConnection connection = new SqlConnection(databaseConnection))
                {
                    connection.Open();
                    using (SqlCommand command = new SqlCommand(ticketQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);
                        command.Parameters.AddWithValue("@FlightNo", int.Parse(this.flightNoTextBox.Text));
                        command.Parameters.AddWithValue("@BookingDate", DateTime.Now);
                        command.Parameters.AddWithValue("@TicketPrice", Decimal.Parse(this.ClassPriceTextBox.Text));
                        command.Parameters.AddWithValue("@Rank", this.ClassComboBox.Text);
                        command.Parameters.AddWithValue("@Status", "Confirmed");
                        
                        // Declare the SeatAssignment parameter outside the loop
                        SqlParameter seatAssignmentParam = command.Parameters.AddWithValue("@SeatAssignment", 0);
                        
                        for (int i = 0; i < seatsNumericUpDown.Value; i++)
                        {
                            // Update the value of SeatAssignment parameter inside the loop
                            seatAssignmentParam.Value = RandomIntGenerator(int.Parse(this.flightNoTextBox.Text));
                            command.ExecuteNonQuery();
                        }
                    }
                    using (SqlCommand command = new SqlCommand(flightUpdateQuery, connection))
                    {
                        command.Parameters.AddWithValue("@AvailableSeats", int.Parse(this.seatsAvailableTextBox.Text) - seatsNumericUpDown.Value);
                        command.Parameters.AddWithValue("@FlightNo", int.Parse(this.flightNoTextBox.Text));
                        command.ExecuteNonQuery();
                    }
                    using (SqlCommand command = new SqlCommand(updatePassportDetails, connection))
                    {
                        command.Parameters.AddWithValue("@PassportNumber", this.passportNumberTextBox.Text);

                        // Convert the date to the desired format
                        command.Parameters.AddWithValue("@PassportExpirationDate", DateTime.ParseExact(this.deptDateTimePicker.Text,"dddd, MMMM d, yyyy",CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                        command.Parameters.AddWithValue("@CardNum", this.creditCardTextBox.Text);
                        command.Parameters.AddWithValue("@CVV", int.Parse(this.cvvCreditCardTextBox.Text));
                        command.Parameters.AddWithValue("@ExpiryDate", this.creditCardExpiryDateTextBox.Text);
                        command.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);

                        Customer.Instance.PassportNumber = this.passportNumberTextBox.Text;
                        Customer.Instance.ExpirayDate = this.creditCardExpiryDateTextBox.Text;
                        Customer.Instance.PassportExpirayDate = this.passportDateTimePicker.Text.ToString();
                        Customer.Instance.CardNum = this.creditCardTextBox.Text;
                        Customer.Instance.Cvv = this.cvvCreditCardTextBox.Text;
                        MessageBox.Show("The Flight has been Confirmed!");
                        errorProvider.Clear();
                        connection.Close();
                    }
                    BookFlight_Load(sender,e);
                }
            }
        }
        private int RandomIntGenerator(int flightNo)
        {
            Random randGenerator = new Random();
            List<int> assignedSeats = new List<int>();
            int availableSeats = 0;
            
            string query = "SELECT B.SeatAssignment, F.AvailableSeats FROM BookingDetails B INNER JOIN Flight F ON B.FlightNo = F.FlightNo WHERE F.FlightNo = @FlightNo;";
            
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@FlightNo", flightNo);
                    
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            assignedSeats.Add(Convert.ToInt32(reader["SeatAssignment"]));
                            availableSeats = Convert.ToInt32(reader["AvailableSeats"]);
                        }
                    }
                }
            }       
            int randomNum = randGenerator.Next(1, availableSeats + 1); 
            while (assignedSeats.Contains(randomNum))
            {
                randomNum = randGenerator.Next(1, availableSeats + 1);
            }     
            return randomNum;
        }
        
        private bool ValidateCardNumber(string cardNumber)
        {
            // Regular expression pattern for Card Number.
            string pattern = @"^(?:\d[ -]*?){16}$";
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(cardNumber);
            return isValid;
        }

        
        private bool ValidateExpiryDate(string expiryDate)
        {
            // Regular expression pattern for Expiry Date.
            string pattern = @"^(0[1-9]|1[0-2])\/(\d{2})$";
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(expiryDate);
            return isValid;
        }

        private bool ValidateCVV(string cvv)
        {
            // Regular expression pattern for CVV.
            string pattern = @"^\d{3}$";
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(cvv);
            return isValid;
        }


    }
}

