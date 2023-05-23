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
using System.Text.RegularExpressions;

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


            
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "INSERT INTO Aircraft VALUES(@Model,@Manufacturer,@AircraftType,@ManufactureYear,@Capacity,@Status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Model", AirCraftTextBox.Text);
                command.Parameters.AddWithValue("@Manufacturer", ManfucaturerTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", AircraftTypeTextBox.Text);
                command.Parameters.AddWithValue("@ManufactureYear", int.Parse(manuYearDateTimePicker.Text));
                command.Parameters.AddWithValue("@Capacity", int.Parse(CapacityTextBox.Text));
                command.Parameters.AddWithValue("@Status", AirCraftComboBox.Text);
                command.ExecuteNonQuery();
                connection.Close();
            }
            MessageBox.Show("Aircraft Added Successfully!");

        }

    }
}
