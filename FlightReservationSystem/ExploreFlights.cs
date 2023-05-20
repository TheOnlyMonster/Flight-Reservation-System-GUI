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

namespace FlightReservationSystem
{
    public partial class ExploreFlights : MainMenu
    {
        public ExploreFlights()
        {
            InitializeComponent();
        }

        private void ExploreFlights_Load(object sender, EventArgs e)
        {
            flightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight where AvailableSeats <> 0";
                SqlCommand command = new SqlCommand(query, connection);
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
    }
}
