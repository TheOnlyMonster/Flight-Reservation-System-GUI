using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace FlightReservationSystem
{

    public partial class UpdateAirCraft : MainMenu, IProcessQuery
    {
        public UpdateAirCraft()
        {
            InitializeComponent();
            this.dataManager = new(databaseConnection, this);
        }

        private void UpdateAirCraft_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM AirCraft;";
            this.dataManager.UpdateDataGrid(aircraftDataGridView, query);
        }

        private void SearchTextChanged(object sender, EventArgs e)
        {
            List<string> filters = new()
            {
                aircraftIDTextBoxPanel1.Text,
                modelTextBoxPanel1.Text
            };
            List<string> columnsIDs = new()
            {
                "AirCraftID",
                "Model"
            };
            if (statusComboBoxPanel1.SelectedItem != null)
            {
                filters.Add(statusComboBoxPanel1.SelectedItem.ToString());
                columnsIDs.Add("Status");
            }
            dataManager.ApplyFilters(filters, columnsIDs, aircraftDataGridView);
        }

        private void AirCraftdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow selectedRow = aircraftDataGridView.Rows[e.RowIndex];
                this.aircraftIDTextBoxPanel2.Text = selectedRow.Cells["AirCraftID"].Value.ToString();
                this.modelTextBoxPanel2.Text = selectedRow.Cells["Model"].Value.ToString();
                this.manufactureTextBoxPanel2.Text = selectedRow.Cells["ManufactureYear"].Value.ToString();
                this.manufactureTextBox.Text = selectedRow.Cells["Manufacturer"].Value.ToString();
                this.capacityTextBox.Text = selectedRow.Cells["Capacity"].Value.ToString();
                this.statusComboBoxPanel2.Text = selectedRow.Cells["Status"].Value.ToString();
                this.aircrafTypeTextBoxPanel2.Text = selectedRow.Cells["AirCraftType"].Value.ToString();
            }
        }

        private void confirmButton_Click(object sender, EventArgs e)
        {
            string capacity = this.capacityTextBox.Text;
            string query = "Update Aircraft Set Model = @Model, Manufacturer = @Manufacturer, AircraftType = @AircraftType, ManufactureYear = @ManufactureYear, Status = @Status where AircraftID = @AircraftID;";
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
                command.Parameters.AddWithValue("@Model", this.modelTextBoxPanel2.Text);
                command.Parameters.AddWithValue("@Manufacturer", this.manufactureTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", this.aircrafTypeTextBoxPanel2.Text);
                command.Parameters.AddWithValue("@ManufactureYear", int.Parse(this.manufactureTextBoxPanel2.Text));
                command.Parameters.AddWithValue("@Status", this.statusComboBoxPanel2.Text);
                command.Parameters.AddWithValue("@AircraftID", int.Parse(this.aircraftIDTextBoxPanel2.Text));
            }
            else if (queryType == QueryType.Delete)
            {
                command.Parameters.AddWithValue("@RecordId", int.Parse(aircraftIDTextBoxPanel2.Text));
            }
        }
    }
}
