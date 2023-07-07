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
            this.dataManager = new(databaseConnection);
        }

        private void ExploreFlights_Load(object sender, EventArgs e)
        {
            string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival, AvailableSeats, Rank1Price, Rank2Price, Rank3Price FROM Flight where AvailableSeats <> 0";
            this.dataManager.UpdateDataGrid(flightDataGrid, query);
        }
    }
}
