﻿using System;
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
        ErrorProvider errorProvider;
        public AddAirCraft()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();   
            errorProvider.BlinkStyle = ErrorBlinkStyle.NeverBlink;
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            //validating Capacity.
            string capacity = this.CapacityTextBox.Text;
            if (!ValidateCapacity(capacity))
            {
                errorProvider.SetError(CapacityTextBox, "Invalid Card number. Please enter a valid Card number.");
                this.CapacityTextBox.Focus();
                return;
            }

            
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "INSERT INTO Aircraft VALUES(@Model,@Manufacturer,@AircraftType,@ManufactureYear,@Capacity,@Status)";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Model", AirCraftTextBox.Text);
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

        private bool ValidateCapacity(string capacity)
        {
            //Regular expression pattern for capacity.
            string pattern = @"^[0-9]+$";
            Regex regex = new Regex(pattern);
            bool isValid = regex.IsMatch(capacity);
            return isValid;
        }

    }
}
