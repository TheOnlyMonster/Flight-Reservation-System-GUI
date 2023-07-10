using System.Data.SqlClient;

namespace FlightReservationSystem
{
    public partial class AddAirCraft : MainMenu, IProcessQuery
    {
        public AddAirCraft()
        {
            InitializeComponent();
            dataManager = new(databaseConnection, this);
            ChangeButton(addAircraftButton);
        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if (queryType == QueryType.Insert)
            {
                command.Parameters.AddWithValue("@Model", modelTextBox.Text);
                command.Parameters.AddWithValue("@Manufacturer", manufacturerTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", aircraftTypeTextBox.Text);
                command.Parameters.AddWithValue("@ManufactureYear", int.Parse(manufacturerYear.Text));
                command.Parameters.AddWithValue("@Capacity", int.Parse(capacityTextBox.Text));
                command.Parameters.AddWithValue("@Status", statusComboBox.Text);
                command.Parameters.AddWithValue("@RankASeats", int.Parse(rankASeats.Text));
                command.Parameters.AddWithValue("@RankBSeats", int.Parse(rankBSeats.Text));
                command.Parameters.AddWithValue("@RankCSeats", int.Parse(rankCSeats.Text));
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(modelTextBox.Text) || string.IsNullOrEmpty(manufacturerTextBox.Text)
                || string.IsNullOrEmpty(aircraftTypeTextBox.Text) || string.IsNullOrEmpty(manufacturerYear.Text)
                || string.IsNullOrEmpty(capacityTextBox.Text) || string.IsNullOrEmpty(statusComboBox.Text)
                || string.IsNullOrEmpty(rankASeats.Text) || string.IsNullOrEmpty(rankBSeats.Text)
                || string.IsNullOrEmpty(rankCSeats.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Please fill all required fields and try again!", modelTextBox);
                return;
            }
            if (!DataAuthenticator.Instance.ValidateManufactureYear(manufacturerYear.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid Manufacture Year. Please enter valid year and try again!", manufacturerYear);
                return;
            }
            if (!DataAuthenticator.Instance.ValidateInteger(capacityTextBox.Text) || !DataAuthenticator.Instance.ValidateInteger(rankASeats.Text)
                || !DataAuthenticator.Instance.ValidateInteger(rankBSeats.Text) || !DataAuthenticator.Instance.ValidateInteger(rankCSeats.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("Invalid seats. Please enter valid seats and try again!", capacityTextBox);
                return;
            }
            if (int.Parse(rankASeats.Text) + int.Parse(rankBSeats.Text) + int.Parse(rankCSeats.Text) != int.Parse(capacityTextBox.Text))
            {
                DataAuthenticator.Instance.SetAuthenticatorError("The total sum of seats in each rank must be equal to the total capacity of the aircraft.", capacityTextBox);
                return;
            }
            string query = "INSERT INTO Aircraft VALUES(@Model,@Manufacturer,@AircraftType,@ManufactureYear,@Capacity,@Status,@RankASeats,@RankBSeats,@RankCSeats)";
            dataManager?.ExcuteDataQuery(query);
            MessageBox.Show("Aircraft Added Successfully!");
        }

    }
}
