using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic.Devices;
using static System.Net.Mime.MediaTypeNames;
using System.Text.RegularExpressions;

namespace FlightReservationSystem
{
    public partial class AddFlight : MainMenu, IProcessQuery
    {
        public AddFlight()
        {
            InitializeComponent();
            dataManager = new(databaseConnection, this);

        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if(queryType == QueryType.Insert)
            {
                command.Parameters.AddWithValue("@AirCraftID", int.Parse(AirCraftIdTextBox.Text));
                command.Parameters.AddWithValue("@DeptDate", DateTime.ParseExact(DepartureDateTimePicker3.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@ExpectedArrival", DateTime.ParseExact(ExpectedDateTimePicker4.Text, "yyyy-MM-dd HH:mm:ss", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                command.Parameters.AddWithValue("@ArrivalCountry", ArrivalTextBox.Text);
                command.Parameters.AddWithValue("@DeptCountry", DepatureTextBox.Text);
                command.Parameters.AddWithValue("@AvailableSeats", int.Parse(SeatsNumericUpDown.Text));
                command.Parameters.AddWithValue("@Rank1Price", Double.Parse(RankATextBox.Text));
                command.Parameters.AddWithValue("@Rank2Price", Double.Parse(RankBTextBox.Text));
                command.Parameters.AddWithValue("@Rank3Price", Double.Parse(RankCTextBox.Text));
            } 
        }

        private void AddButton_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(AirCraftIdTextBox.Text) || string.IsNullOrEmpty(DepartureDateTimePicker3.Text) || string.IsNullOrEmpty(ExpectedDateTimePicker4.Text)
             || string.IsNullOrEmpty(ArrivalTextBox.Text) || string.IsNullOrEmpty(SeatsNumericUpDown.Text) || string.IsNullOrEmpty(RankATextBox.Text)
             || string.IsNullOrEmpty(RankBTextBox.Text) || string.IsNullOrEmpty(RankCTextBox.Text) || string.IsNullOrEmpty(DepatureTextBox.Text))
            {
                MessageBox.Show("Please fill in all the required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string query = "INSERT INTO Flight  VALUES (@AirCraftID , @DeptDate, @ExpectedArrival, @ArrivalCountry , @DeptCountry ,  @AvailableSeats , @Rank1Price , @Rank2Price , @Rank3Price);";
            dataManager.ExcuteDataQuery(query);
            MessageBox.Show("Flight Added");
        }
    }
}
