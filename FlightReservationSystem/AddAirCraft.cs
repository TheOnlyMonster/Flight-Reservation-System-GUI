using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace FlightReservationSystem
{
    public partial class AddAirCraft : MainMenu
    {
        public AddAirCraft()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //TODO: Check Regex Amd Validate Input
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "INSERT INTO Aircraft VALUES(@Model,@Manufacturer,@AircraftType,@ManufactureYear,@Capacity,@Status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Model",ModelTextBox.Text);
                command.Parameters.AddWithValue("@Manufacturer", ManfucaturerTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", AirCraftTextBox.Text);
                command.Parameters.AddWithValue("@ManufactureYear", DateTime.ParseExact(manuYearDateTimePicker.Text, "yyyy", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@Capacity", int.Parse(CapacityTextBox.Text));
                command.Parameters.AddWithValue("@Status", AirCraftComboBox.Text);
                //string expectedArrivalDate = DateTime.ParseExact(ArrivaldateTimePicker.Text, "dddd, MMMM d, yyyy", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd");
                //SqlDataAdapter adapter = new SqlDataAdapter(command);
                command.ExecuteNonQuery();
                connection.Close();
            }

        }
    }
}
