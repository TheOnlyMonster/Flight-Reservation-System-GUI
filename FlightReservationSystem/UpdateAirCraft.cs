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
using System.Text.RegularExpressions;

namespace FlightReservationSystem
{

    public partial class UpdateAirCraft : MainMenu, IProcessQuery
    {
        private ErrorProvider errorProvider;

        public UpdateAirCraft()
        {
            InitializeComponent();
            errorProvider = new()
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };
            this.dataManager = new(databaseConnection, this);
        }

        private void UpdateAirCraft_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM AirCraft;";
            this.dataManager.UpdateDataGrid(AirCraftdataGridView, query);
        }

        private void SearchTextChanged(object sender, EventArgs e)
        {
            List<string> filters = new()
            {
                AirCraftIdTextBoxPanel1.Text,
                ModelTextBoxPnanel1.Text
            };
            List<string> columnsIDs = new()
            {
                "AirCraftID",
                "Model"
            };
            if (StatusComboBoxPanel1.SelectedItem != null)
            {
                filters.Add(StatusComboBoxPanel1.SelectedItem.ToString());
                columnsIDs.Add("Status");
            }
            dataManager.ApplyFilters(filters, columnsIDs, AirCraftdataGridView);
        }

        private void AirCraftdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
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

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string capacity = this.CapacityTextBox.Text;
            if (!ValidateCapacity(capacity))
            {
                errorProvider.SetError(CapacityTextBox, "Invalid capacity. Please enter a valid capacity.");
                this.CapacityTextBox.Focus();
                return;
            }

            string manufactureYear = this.ManufactureTextBox.Text;
            if (!ValidateManufactureYear(manufactureYear))
            {
                errorProvider.SetError(ManufactureTextBox, "Invalid manufacture year. Please enter a valid manufacture year.");
                this.ManufactureTextBox.Focus();
                return;
            }

            string query = "Update Aircraft Set Model = @Model, Manufacturer = @Manufacturer, AircraftType = @AircraftType, ManufactureYear = @ManufactureYear, Capacity = @Capacity, Status = @Status where AirCraftID = @AirCraftID;";
            dataManager.ExcuteDataQuery(query);
            UpdateAirCraft_Load(sender, e);
            MessageBox.Show("Changes are Confirmed!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Aircraft WHERE AirCraftID = @RecordId;";
                dataManager.ExcuteDataQuery(query);
                UpdateAirCraft_Load(sender, e);
            }
        }

        private bool ValidateCapacity(string capacity)
        {
            //Regular expression pattern for capacity.
            string pattern = @"^[0-9]+$";
            Regex regex = new(pattern);
            bool isValid = regex.IsMatch(capacity);
            return isValid;
        }

        private bool ValidateManufactureYear(string capacity)
        {
            //Regular expression pattern for Manufacture Year.
            string pattern = @"^(19|20)\d{2}$";
            Regex regex = new(pattern);
            bool isValid = regex.IsMatch(capacity);
            return isValid;
        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if (queryType == QueryType.Update)
            {
                command.Parameters.AddWithValue("@Model", this.ModelTextBox.Text);
                command.Parameters.AddWithValue("@Manufacturer", this.ManufacturerTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", this.AirCraftTextBox.Text);
                command.Parameters.AddWithValue("@ManufactureYear", int.Parse(this.ManufactureTextBox.Text));
                command.Parameters.AddWithValue("@Capacity", int.Parse(this.CapacityTextBox.Text));
                command.Parameters.AddWithValue("@Status", this.StatusComboBox.Text);
                command.Parameters.AddWithValue("@AirCraftID", int.Parse(this.AircraftIdTextBox.Text));
            }
            else if (queryType == QueryType.Delete)
            {
                command.Parameters.AddWithValue("@RecordId", int.Parse(AircraftIdTextBox.Text));
            }
        }
    }
}
