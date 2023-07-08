using System.Data.SqlClient;

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
            this.dataManager?.UpdateDataGrid(aircraftDataGridView, query);
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
                this.aircraftIDTextBoxPanel2.Text = selectedRow.Cells["AircraftID"].Value.ToString();
                this.modelTextBoxPanel2.Text = selectedRow.Cells["Model"].Value.ToString();
                this.manufactureYearTextBox.Text = selectedRow.Cells["ManufactureYear"].Value.ToString();
                this.manufacturerTextBox.Text = selectedRow.Cells["Manufacturer"].Value.ToString();
                this.capacityTextBox.Text = selectedRow.Cells["Capacity"].Value.ToString();
                this.statusComboBoxPanel2.Text = selectedRow.Cells["Status"].Value.ToString();
                this.aircrafTypeTextBox.Text = selectedRow.Cells["AircraftType"].Value.ToString();
                this.rankASeatsTextBox.Text = selectedRow.Cells["RankASeats"].Value.ToString();
                this.rankASeatsTextBox.Text = selectedRow.Cells["RankBSeats"].Value.ToString();
                this.rankCSeatsTextBox.Text = selectedRow.Cells["RankCSeats"].Value.ToString();
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            string query = "Update Aircraft Set Model = @Model, Manufacturer = @Manufacturer, AircraftType = @AircraftType, ManufactureYear = @ManufactureYear, Status = @Status where AircraftID = @AircraftID;";
            dataManager?.ExcuteDataQuery(query);
            UpdateAirCraft_Load(sender, e);
            MessageBox.Show("Changes are Confirmed!");
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Are you sure you want to delete the record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.Yes)
            {
                string query = "DELETE FROM Aircraft WHERE AircraftID = @RecordId;";
                dataManager?.ExcuteDataQuery(query);
                UpdateAirCraft_Load(sender, e);
            }
        }

        //private bool ValidateManufactureYear(string capacity)
        //{
        //    //Regular expression pattern for Manufacture Year.
        //    string pattern = @"^(19|20)\d{2}$";
        //    Regex regex = new(pattern);
        //    bool isValid = regex.IsMatch(capacity);
        //    return isValid;
        //}

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if (queryType == QueryType.Update)
            {
                command.Parameters.AddWithValue("@Model", this.modelTextBoxPanel2.Text);
                command.Parameters.AddWithValue("@Manufacturer", this.manufacturerTextBox.Text);
                command.Parameters.AddWithValue("@AircraftType", this.aircrafTypeTextBox.Text);
                command.Parameters.AddWithValue("@ManufactureYear", int.Parse(this.manufactureYearTextBox.Text));
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
