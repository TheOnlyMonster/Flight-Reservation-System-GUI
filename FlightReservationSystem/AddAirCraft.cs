using System.Data.SqlClient;

namespace FlightReservationSystem
{
    public partial class AddAirCraft : MainMenu, IProcessQuery
    {
        public AddAirCraft()
        {
            InitializeComponent();
            dataManager = new(databaseConnection, this);
        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if(queryType == QueryType.Insert)
            {
                command.Parameters.AddWithValue("@Model", AirCraftTextBox.Text);
                command.Parameters.AddWithValue("@Manufacturer", ManfucaturerTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", AircraftTypeTextBox.Text);
                command.Parameters.AddWithValue("@ManufactureYear", int.Parse(manuYearDateTimePicker.Text));
                command.Parameters.AddWithValue("@Capacity", int.Parse(CapacityTextBox.Text));
                command.Parameters.AddWithValue("@Status", AirCraftComboBox.Text);
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO Aircraft VALUES(@Model,@Manufacturer,@AircraftType,@ManufactureYear,@Capacity,@Status)";
            dataManager?.ExcuteDataQuery(query);        
            MessageBox.Show("Aircraft Added Successfully!");
        }

    }
}
