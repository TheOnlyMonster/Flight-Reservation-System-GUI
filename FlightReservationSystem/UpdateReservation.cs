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
            string query = "SELECT BookingID, CustomerID, FlightNo, BookingDate, SeatAssignment, TicketPrice, Rank, Status, FirstName, LastName, PassportNumber, PassportEXPDate FROM BookingDetails;";
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
                this.firstNameTextBox.Text = selectedRow.Cells["Fname"].Value.ToString();
                this.lastNameTextBox.Text = selectedRow.Cells["Lname"].Value.ToString();
                this.passportNumTextBox.Text = selectedRow.Cells["PassportNumber"].Value.ToString();
                this.passportExpDateTextBox.Text = selectedRow.Cells["PassportExpDate"].Value.ToString();
            }
        }

        private void ConfirmButton_Click(object sender, EventArgs e)
        {
            if (seatAssignmentTextBox.Text == "")
            {
                SetAuthenticatorError("Invalid Seat Assignment. Please choose seat and try again!", seatAssignmentTextBox);
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
            int availableSeats = dataManager.NormalizeSeatsDataGrid(seatsTableLayoutPanel, rankComboBox, flightNoTextBoxPanel2);
            string query = "select COUNT(*) from BookingDetails where Rank=@Rank and FlightNo=@FlightNo and SeatAssignment=@Seat";
            int row = -1;
            bool isUserInRank = false;
            SqlConnection connection = new(databaseConnection);
            SqlCommand command;
            connection.Open();
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
                seatsTableLayoutPanel.Controls.Add(obj, col, row);
            }
            connection.Close();
            if (!isUserInRank)
            {
                foreach (Control control in seatsTableLayoutPanel.Controls)
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
            dataManager.ToggleSeatButton(seatsTableLayoutPanel, seatAssignmentTextBox, seat, sender);
        }
    }
}
