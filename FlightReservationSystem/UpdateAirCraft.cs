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
    public partial class UpdateAirCraft : MainMenu
    {
        public UpdateAirCraft()
        {
            InitializeComponent();
        }

        private void UpdateAirCraft_Load(object sender, EventArgs e)
        {
            //load the Grid.
            AirCraftdataGridView.Rows.Clear();
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
                AirCraftdataGridView.Rows.Add(rowData);
            }

        }

        private void AirCraftIdTextBoxPanel1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void ModelTextBoxPnanel1_TextChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }


        private void StatusComboBoxPanel1_SelectedIndexChanged(object sender, EventArgs e)
        {
            ApplyFilters();
        }
        private void ApplyFilters()
        {
            string searchText = AirCraftIdTextBoxPanel1.Text;
            string modelText = ModelTextBoxPnanel1.Text;
            string status = StatusComboBoxPanel1.SelectedItem?.ToString();

            foreach (DataGridViewRow row in AirCraftdataGridView.Rows)
            {
                bool showRow = true;

                if (!string.IsNullOrEmpty(searchText))
                {
                    string aircraftId = row.Cells["AirCraftID"].Value?.ToString();
                    if (aircraftId == null || !aircraftId.Contains(searchText))
                    {
                        showRow = false;
                    }
                }

                if (!string.IsNullOrEmpty(modelText))
                {
                    string model = row.Cells["Model"].Value?.ToString();
                    if (model == null || !model.Contains(modelText))
                    {
                        showRow = false;
                    }
                }

                if (!string.IsNullOrEmpty(status))
                {
                    string rowStatus = row.Cells["Status"].Value?.ToString();
                    if (rowStatus == null || rowStatus != status)
                    {
                        showRow = false;
                    }
                }

                row.Visible = showRow;
            }
        }


    }
}
