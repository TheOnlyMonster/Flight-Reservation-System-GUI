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

namespace FlightReservationSystem
{
    public partial class AddFlight : MainMenu
    {
        public AddFlight()
        {
            InitializeComponent();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            string airCraftId = AirCraftIdTextBox.Text;
            string deptDate = DepartureDateTimePicker3.Text;
            string expectedArrival = ExpectedDateTimePicker4.Text;
            string arrivalCountry = ArrivalTextBox.Text;
            string availableSeats = SeatsTextBox.Text;
            string rankAPrice = RankATextBox.Text;
            string rankBPrice = RankBTextBox.Text;
            string rankCPrice = RankCTextBox.Text;
            string deptCountry=DepatureTextBox.Text;

            if (string.IsNullOrEmpty(airCraftId) || string.IsNullOrEmpty(deptDate) || string.IsNullOrEmpty(expectedArrival)
             || string.IsNullOrEmpty(arrivalCountry) || string.IsNullOrEmpty(availableSeats) || string.IsNullOrEmpty(rankAPrice)
             || string.IsNullOrEmpty(rankBPrice) || string.IsNullOrEmpty(rankCPrice) || string.IsNullOrEmpty(deptCountry))
            {
                MessageBox.Show("Please fill in all the required fields.", "Incomplete Form", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                string query = "INSERT INTO Flight  VALUES (@AircraftID , @DeptDate, @ExpectedArrival, @ArrivalCountry , @DeptCountry ,  @AvailableSeats , @Rank1Price , @Rank2Price , @Rank3Price);";
                using (SqlConnection connection = new SqlConnection(databaseConnection))
                {
                    connection.Open();
                    SqlCommand command = new SqlCommand(query, connection);
                    command.Parameters.AddWithValue("@AircraftID", int.Parse(airCraftId));
                    command.Parameters.AddWithValue("@DeptDate", DateTime.ParseExact(deptDate, "dd MMMM yyyy", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@ExpectedArrival", DateTime.ParseExact(expectedArrival, "dd MMMM yyyy", CultureInfo.CurrentCulture).ToString("yyyy-MM-dd"));
                    command.Parameters.AddWithValue("@ArrivalCountry", arrivalCountry);
                    command.Parameters.AddWithValue("@DeptCountry", deptCountry);
                    command.Parameters.AddWithValue("@AvailableSeats", int.Parse(availableSeats));
                    command.Parameters.AddWithValue("@Rank1Price", Double.Parse(rankAPrice));
                    command.Parameters.AddWithValue("@Rank2Price", Double.Parse(rankBPrice));
                    command.Parameters.AddWithValue("@Rank3Price", Double.Parse(rankCPrice));

                    command.ExecuteNonQuery();
                    connection.Close();
                }
                MessageBox.Show("Flight Added");
            }
        }
    }
}
