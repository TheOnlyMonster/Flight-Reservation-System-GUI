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

        private void AirCraftdataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow selectedRow = AirCraftdataGridView.Rows[e.RowIndex];
                this.AircraftIdTextBox.Text = selectedRow.Cells["AirCraftID"].Value.ToString();
                this.ModelTextBox.Text = selectedRow.Cells["Model"].Value.ToString();
                this.ManufactureTextBox.Text = selectedRow.Cells["ManufactureYear"].Value.ToString();
                this.ManufacturerTextBox.Text = selectedRow.Cells["Manufacturer"].Value.ToString();
                this.CapacityTextBox.Text = selectedRow.Cells["Capacity"].Value.ToString();
                this.StatusComboBox.Text = selectedRow.Cells["Status"].Value.ToString();
                this.AirCraftTextBox.Text = selectedRow.Cells["AirCraftType"].Value.ToString();
            }
        } 

        private void confirmButton_Click(object sender, EventArgs e) {
            string query = "Update Aircraft Set Model = @Model, Manufacturer = @Manufacturer, AircraftType = @AircraftType, ManufactureYear = @ManufactureYear, Capacity = @Capacity, Status = @Status where AircraftID = @AircraftID;";
            using (SqlConnection connection = new SqlConnection(databaseConnection)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@Model",this.ModelTextBox.Text);
                command.Parameters.AddWithValue("@Manufacturer", this.ManufacturerTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", this.AirCraftTextBox.Text);
                command.Parameters.AddWithValue("@ManufactureYear", int.Parse(this.ManufactureTextBox.Text));      
                command.Parameters.AddWithValue("@Capacity", int.Parse(this.CapacityTextBox.Text));    
                command.Parameters.AddWithValue("@Status", this.StatusComboBox.Text);    
                command.Parameters.AddWithValue("@AircraftID", int.Parse(this.AircraftIdTextBox.Text));    
                command.ExecuteNonQuery();
                connection.Close();
            }
            UpdateAirCraft_Load(sender,e);
            MessageBox.Show("Changes are Confirmed!");
        }
    }
}
