using System.Data.SqlClient;
using Guna.UI2.WinForms;
namespace FlightReservationSystem
{
    public partial class UpdateReservation : MainMenu, IProcessQuery
    {
        public UpdateReservation()
        {
            InitializeComponent();
            dataManager = new(databaseConnection, this);
            this.ChangeButton(this.UpdateReservation);
        }

        private void UpdateReservation_Load(object sender, EventArgs e)
        {
            string query = "SELECT * FROM BookingDetails;";
            dataManager.UpdateDataGrid(updateReservationDataGridView, query);
        }

        private void UpdateReservationDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                this.panel3.Dock = DockStyle.None;
                updateReservationDataGridView.Size = new Size(867, 687);

                DataGridViewRow selectedRow = updateReservationDataGridView.Rows[e.RowIndex];
                this.customerIdTextBoxPanel2.Text = selectedRow.Cells["CustomerID"].Value.ToString();
                this.flightNoTextBoxPanel2.Text = selectedRow.Cells["FlightNo"].Value.ToString();
                this.bookingIdTextBox.Text = selectedRow.Cells["BookingID"].Value.ToString();
                this.bookingDateTextBox.Text = selectedRow.Cells["BookingDate"].Value.ToString();
                this.seatAssignmentTextBox.Text = selectedRow.Cells["SeatAssignment"].Value.ToString();
                this.ticketPriceTextBox.Text = selectedRow.Cells["TicketPrice"].Value.ToString();
                this.statusComboBox.Text = selectedRow.Cells["Status"].Value.ToString();
                this.rankComboBox.Text = selectedRow.Cells["Rank"].Value.ToString();
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (seatAssignmentTextBox.Text == "")
            {
                MessageBox.Show("Error, please try again.");
                return;
            }
            string query = "UPDATE BookingDetails SET SeatAssignment = @SeatAssignment , Rank = @Rank ,Status = @Status where BookingID = @BookingID";
            dataManager.ExcuteDataQuery(query);
            UpdateReservation_Load(sender, e);
            MessageBox.Show("Changes Made Successfully!");
        }

        private void SearchTextBox_TextChanged(object sender, EventArgs e)
        {

            List<string> filters = new()
            {
                customerIdTextBoxPanel1.Text,
                flightNoTextBoxPanel1.Text
            };
            List<string> columnsIDs = new()
            {
                "CustomerID",
                "FlightNo"
            };
            dataManager.ApplyFilters(filters, columnsIDs, updateReservationDataGridView);
        }

        public void SetQueryCommandParams(SqlCommand command, QueryType queryType)
        {
            if (queryType == QueryType.Update)
            {
                command.Parameters.AddWithValue("@SeatAssignment", int.Parse(this.seatAssignmentTextBox.Text));
                command.Parameters.AddWithValue("@Rank", this.rankComboBox.Text);
                command.Parameters.AddWithValue("@Status", this.statusComboBox.Text);
                command.Parameters.AddWithValue("BookingID", this.bookingIdTextBox.Text);
            }
        }

        private void SeatAssignmentButton_Click(object sender, EventArgs e)
        {
            this.panel3.Dock = DockStyle.Right;
            updateReservationDataGridView.Size = new Size(589, 687);
            tableLayoutPanel1.Controls.Clear();

            using SqlConnection connection = new(databaseConnection);
            connection.Open();
            string rank;
            if (this.rankComboBox.Text == "A Class")
            {
                rank = "RankASeats";
            }
            else if (this.rankComboBox.Text == "B Class")
            {
                rank = "RankBSeats";
            }
            else
            {
                rank = "RankCSeats";
            }
            string query = $"select {rank} from Aircraft where AircraftID = (select AircraftID from Flight where FlightNo=@FlightNo);";
            SqlCommand command = new(query, connection);
            command.Parameters.AddWithValue("@FlightNo", this.flightNoTextBoxPanel2.Text);
            int availableSeats = Convert.ToInt32(command.ExecuteScalar());
            int rows = (int)Math.Ceiling((decimal)availableSeats / 6);
            tableLayoutPanel1.RowCount = rows;
            tableLayoutPanel1.ColumnCount = 6;
            tableLayoutPanel1.RowStyles.Clear();
            tableLayoutPanel1.ColumnStyles.Clear();
            float rowHeight = 100f / rows;
            for (int i = 0; i < rows; i++)
            {
                tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeight));
            }
            float colWidth = 100f / 6;
            for (int j = 0; j < 6; j++)
            {
                tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colWidth));
            }

            query = "select COUNT(*) from BookingDetails where Rank=@Rank and FlightNo=@FlightNo and SeatAssignment=@Seat";
            int row = -1;
            bool isUserInRank = false;
            for (int i = 0; i < availableSeats; i++)
            {
                bool isBooked = false;
                command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Rank", this.rankComboBox.Text);
                command.Parameters.AddWithValue("@FlightNo", this.flightNoTextBoxPanel2.Text);
                command.Parameters.AddWithValue("@Seat", i + 1);
                int result = Convert.ToInt32(command.ExecuteScalar());
                if (result == 1)
                {
                    isBooked = true;
                }
                int col = i % 6;
                if (col == 0)
                {
                    row++;
                }
                Guna2Button obj = new()
                {
                    Image = seat.Image,
                    HoverState = seat.HoverState,
                    FillColor = seat.FillColor,
                    ImageSize = seat.ImageSize,
                    Tag = (i + 1).ToString()
                };
                string myQuery = "select SeatAssignment from BookingDetails where CustomerID=@CustomerID and FlightNo=@FlightNo and Rank=@Rank;";
                SqlCommand myCommand = new(myQuery, connection);
                myCommand.Parameters.AddWithValue("@CustomerID", this.customerIdTextBoxPanel2.Text);
                myCommand.Parameters.AddWithValue("@FlightNo", this.flightNoTextBoxPanel2.Text);
                myCommand.Parameters.AddWithValue("@Rank", this.rankComboBox.Text);
                int myResult = Convert.ToInt32(myCommand.ExecuteScalar());
                if (i + 1 == myResult)
                {
                    this.Seat_Click(obj, e);
                    isUserInRank = true;
                }
                else
                {
                    if (isBooked)
                    {
                        obj.Enabled = false;
                        obj.FillColor = Color.Black;
                    }
                    else
                    {
                        obj.HoverState.Image = seat.HoverState.Image;
                        obj.Cursor = Cursors.Hand;
                        obj.Click += Seat_Click;
                    }
                }

                tableLayoutPanel1.Controls.Add(obj, col, row);
            }
            connection.Close();
            if (!isUserInRank)
            {
                foreach (Control control in tableLayoutPanel1.Controls)
                {
                    if (control is Guna2Button button && button.Enabled == true)
                    {
                        this.seatAssignmentTextBox.Text = (string)button.Tag;
                        this.Seat_Click(button, e);
                        break;
                    }
                }
            }
        }

        private void Seat_Click(object sender, EventArgs e)
        {
            foreach (Control control in tableLayoutPanel1.Controls)
            {
                if (control is Guna2Button button && button.Tag != null && button.Tag.ToString() == this.seatAssignmentTextBox.Text)
                {
                    button.Image = seat.Image;
                    button.HoverState.Image = seat.HoverState.Image;
                    break;
                }
            }
            if (sender is Guna2Button clickedButton)
            {
                clickedButton.Image = seat.HoverState.Image;
                this.seatAssignmentTextBox.Text = (string)clickedButton.Tag;
            }
        }
    }
}
