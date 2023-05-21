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
    public partial class UpdateReservation : MainMenu
    {
        public UpdateReservation()
        {
            InitializeComponent();
        }
        private void UpdateReservation_Load(object sender, EventArgs e)
        {
            //load the Grid.


            UpdateReservationDataGridView.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "SELECT * FROM AirCraft;";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                UpdateReservationDataGridView.Rows.Add(rowData);
            }

        }

        private void CustomerIdTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }

        private void FlighNoTextBox_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            string CustomerText = CustomerIdTextBox.Text;
            string FlightText = FlighNoTextBox.Text;


            foreach (DataGridViewRow row in UpdateReservationDataGridView.Rows)
            {
                bool showRow = true;

                if (!string.IsNullOrEmpty(CustomerText))
                {
                    string aircraftId = row.Cells["BookingID"].Value?.ToString();
                    if (aircraftId == null || !aircraftId.Contains(CustomerText))
                    {
                        showRow = false;
                    }
                }

                if (!string.IsNullOrEmpty(FlightText))
                {
                    string model = row.Cells["FlightNo"].Value?.ToString();
                    if (model == null || !model.Contains(FlightText))
                    {
                        showRow = false;
                    }
                }

                row.Visible = showRow;
            }
        }
    }
}
