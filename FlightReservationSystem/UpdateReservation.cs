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
                string query = "SELECT * FROM BookingDetails;";
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

        private void UpdateReservationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex >= 0) {
                DataGridViewRow selectedRow = UpdateReservationDataGridView.Rows[e.RowIndex];
                this.CustomerIdTextBox2.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                this.FlightNoTextBox2.Text = selectedRow.Cells["FlightNo"].Value.ToString();
                this.BookingIdTextBox.Text = selectedRow.Cells["BookingID"].Value.ToString();
                this.BookingDateTextBox.Text = selectedRow.Cells["BookingDate"].Value.ToString();
                this.SeatAssignmentTextBox.Text = selectedRow.Cells["SeatAssignment"].Value.ToString();
                this.TicketPriceTextBox.Text = selectedRow.Cells["TicketPrice"].Value.ToString();
                this.StatusComboBox.Text = selectedRow.Cells["Status"].Value.ToString();
                this.RankComboBox.Text = selectedRow.Cells["Rank"].Value.ToString();
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e) {
            string query = "UPDATE BookingDetails SET SeatAssignment = @SeatAssignment , TicketPrice = @TicketPrice, Rank = @Rank ,Status = @Status where BookingID = @BookingID";
            using (SqlConnection connection = new SqlConnection(databaseConnection)) {
                connection.Open();
                SqlCommand command = new SqlCommand(query,connection);
                command.Parameters.AddWithValue("@SeatAssignment",int.Parse(this.SeatAssignmentTextBox.Text));
                command.Parameters.AddWithValue("@TicketPrice",Double.Parse(this.TicketPriceTextBox.Text));
                command.Parameters.AddWithValue("@Rank",this.RankComboBox.Text);
                command.Parameters.AddWithValue("@Status",this.StatusComboBox.Text);
                command.Parameters.AddWithValue("BookingID",this.BookingIdTextBox.Text);
                command.ExecuteNonQuery();
                UpdateReservation_Load(sender,e);
                MessageBox.Show("Changes Made Successfully!");
                connection.Close();
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
