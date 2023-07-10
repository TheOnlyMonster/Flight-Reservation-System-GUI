using Guna.UI2.WinForms;
using System.Data.SqlClient;
namespace FlightReservationSystem
{
    public partial class AddFlight : MainMenu, IProcessQuery
    {
        public AddFlight()
        {
            InitializeComponent();
            dataManager = new(databaseConnection, this);
            ChangeButton(addFlightButton);
        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if (queryType == QueryType.Insert)
            {
                string deptDate = deptDateTimePicker.Value.ToShortDateString();
                string deptTime = $"{deptHourComboBox.Text}:{deptMinutesComboBox.Text} {deptMiddayStatusComboBox.Text}";
                string dept = $"{deptDate} {deptTime}";

                string arrivalDate = arrivalDateTimePicker.Value.ToShortDateString();
                string arrivalTime = $"{arrivalHourComboBox.Text}:{arrivalMinutesComboBox.Text} {arrivalMiddayStatusComboBox.Text}";
                string arrival = $"{arrivalDate} {arrivalTime}";
                command.Parameters.AddWithValue("@DeptDate", dept);
                command.Parameters.AddWithValue("@ExpectedArrival", arrival);
                command.Parameters.AddWithValue("@AirCraftID", int.Parse(aircaftIDComboBox.Text));
                command.Parameters.AddWithValue("@ArrivalCountry", arrivalCountryTextBox.Text);
                command.Parameters.AddWithValue("@DeptCountry", deptCountryTextBox.Text);
                command.Parameters.AddWithValue("@AvailableSeats", int.Parse(availableSeatsTextBox.Text));
                command.Parameters.AddWithValue("@Rank1Price", Double.Parse(rankAPriceTextBox.Text));
                command.Parameters.AddWithValue("@Rank2Price", Double.Parse(rankBPriceTextBox.Text));
                command.Parameters.AddWithValue("@Rank3Price", Double.Parse(rankCPriceTextBox.Text));
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(aircaftIDComboBox.Text) || string.IsNullOrEmpty(deptCountryTextBox.Text)
                || string.IsNullOrEmpty(arrivalCountryTextBox.Text) || string.IsNullOrEmpty(rankAPriceTextBox.Text)
                || string.IsNullOrEmpty(rankBPriceTextBox.Text) || string.IsNullOrEmpty(rankCPriceTextBox.Text)
                || string.IsNullOrEmpty(deptHourComboBox.Text) || string.IsNullOrEmpty(deptMinutesComboBox.Text) || string.IsNullOrEmpty(deptMiddayStatusComboBox.Text)
                || string.IsNullOrEmpty(arrivalHourComboBox.Text) || string.IsNullOrEmpty(arrivalMinutesComboBox.Text) || string.IsNullOrEmpty(arrivalMiddayStatusComboBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Please fill in all the required fields.", aircaftIDComboBox);
                return;
            }
            string deptTime = $"{deptHourComboBox.Text}:{deptMinutesComboBox.Text} {deptMiddayStatusComboBox.Text}";
            string arrivalTime = $"{arrivalHourComboBox.Text}:{arrivalMinutesComboBox.Text} {arrivalMiddayStatusComboBox.Text}";
            if (!DataAuthenticator.Instance.ValidateTime(deptDateTimePicker, arrivalDateTimePicker, deptTime, arrivalTime))
            {
                return;
            }
            if (!DataAuthenticator.Instance.ValidateDouble(rankAPriceTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Rank Price. Please enter valid rank price and try again!", rankAPriceTextBox);
                return;
            }

            if (!DataAuthenticator.Instance.ValidateDouble(rankBPriceTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Rank Price. Please enter valid rank price and try again!", rankBPriceTextBox);
                return;
            }

            if (!DataAuthenticator.Instance.ValidateDouble(rankCPriceTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Rank Price. Please enter valid rank price and try again!", rankCPriceTextBox);
                return;
            }
            string query = "INSERT INTO Flight  VALUES (@AircraftID , @DeptDate, @ExpectedArrival, @ArrivalCountry , @DeptCountry ,  @AvailableSeats , @Rank1Price , @Rank2Price , @Rank3Price);";
            dataManager?.ExcuteDataQuery(query);
            MessageBox.Show("Flight Added!");
        }

        private void AircaftIDComboBox_DropDown(object sender, EventArgs e)
        {
            dataManager?.FillComboBox("SELECT AircraftID From Aircraft", aircaftIDComboBox);
        }

        private void AircaftIDComboBox_TextChanged(object sender, EventArgs e)
        {
            string query = "SELECT Model,Capacity,RankASeats,RankBSeats,RankCSeats FROM Aircraft WHERE AircraftID=@AircraftID";
            SqlConnection connection = new(databaseConnection);
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@AircraftID", int.Parse(aircaftIDComboBox.Text));
            connection.Open();
            SqlDataReader reader = command.ExecuteReader();
            if (reader.Read())
            {
                this.modelTextBox.Text = reader[0].ToString();
                this.availableSeatsTextBox.Text = reader[1].ToString();
                this.rankASeatsTextBox.Text = reader[2].ToString();
                this.rankBSeatsTextBox.Text = reader[3].ToString();
                this.rankCSeatsTextBox.Text = reader[4].ToString();
            }
            connection.Close();
        }

        private void AddFlight_Load(object sender, EventArgs e)
        {
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
    }
}
