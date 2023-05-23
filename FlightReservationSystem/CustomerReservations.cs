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
    public partial class CustomerReservations : MainMenu
    {
        public CustomerReservations()
        {
            InitializeComponent();
        }

        private void CustomerReservations_Load(object sender, EventArgs e)
        {
            //load the Grid.

            reservationsDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "SELECT  b.BookingID , f.DeptCountry , f.ArrivalCountry , b.BookingDate , b.SeatAssignment , b.TicketPrice , b.Rank , b.Status  FROM BookingDetails b INNER JOIN FLight f  ON b.FlightNo=f.FLightNo  WHERE CustomerID=@CustomerID;";
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@CustomerID", Customer.Instance.Id);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                reservationsDataGrid.Rows.Add(rowData);
            }
        }
    }
}
