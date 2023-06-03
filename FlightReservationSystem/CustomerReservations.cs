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
    public partial class CustomerReservations : MainMenu,IProcessDataGrid
    {
        public CustomerReservations()
        {
            InitializeComponent();
            this.dataManager = new DataManager(databaseConnection, this);
        }

        public void ProccessDataGrid(SqlCommand command)
        {
            command.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);
        }

        private void CustomerReservations_Load(object sender, EventArgs e)
        {
            string query = "SELECT  b.BookingID , f.DeptCountry , f.ArrivalCountry , b.BookingDate , b.SeatAssignment , b.TicketPrice , b.Rank , b.Status  FROM BookingDetails b INNER JOIN FLight f  ON b.FlightNo=f.FLightNo  WHERE CustomerID=@CustomerID;";
            this.dataManager.UpdateDataGrid(reservationsDataGrid, query);
        }
    }
}
