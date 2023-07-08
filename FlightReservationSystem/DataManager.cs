using Guna.UI2.WinForms;
using System.Data;
using System.Data.SqlClient;

namespace FlightReservationSystem
{
    public class DataManager
    {
        private IProcessQuery _processQuery;
        private IProcessDataGrid _processDataGrid;
        private SqlConnection sqlConnection;
        public DataManager(string connection)
        {
            sqlConnection = new SqlConnection(connection);
        }
        public DataManager(string connection, IProcessQuery _processQuery)
        {
            sqlConnection = new SqlConnection(connection);
            this._processQuery = _processQuery;
        }
        public DataManager(string connection, IProcessDataGrid _processDataGrid)
        {
            sqlConnection = new SqlConnection(connection);
            this._processDataGrid = _processDataGrid;
        }
        public DataManager(string connection, IProcessDataGrid _processDataGrid, IProcessQuery _processQuery)
        {
            sqlConnection = new SqlConnection(connection);
            this._processDataGrid = _processDataGrid;
            this._processQuery = _processQuery;
        }
        public int NormalizeSeatsDataGrid(TableLayoutPanel seatsTableLayoutPanel, Guna2ComboBox rankComboBox, Guna2TextBox flightNoTextBox)
        {
            seatsTableLayoutPanel.Controls.Clear();
            string rank;
            if (rankComboBox.Text == "A Class")
            {
                rank = "RankASeats";
            }
            else if (rankComboBox.Text == "B Class")
            {
                rank = "RankBSeats";
            }
            else
            {
                rank = "RankCSeats";
            }
            string query = $"select {rank} from Aircraft where AircraftID = (select AircraftID from Flight where FlightNo=@FlightNo);";
            sqlConnection.Open();
            SqlCommand command = new(query, sqlConnection);
            command.Parameters.AddWithValue("@FlightNo", flightNoTextBox.Text);
            int availableSeats = Convert.ToInt32(command.ExecuteScalar());
            sqlConnection.Close();
            int rows = (int)Math.Ceiling((decimal)availableSeats / 6);
            seatsTableLayoutPanel.RowCount = rows;
            seatsTableLayoutPanel.ColumnCount = 6;
            seatsTableLayoutPanel.RowStyles.Clear();
            seatsTableLayoutPanel.ColumnStyles.Clear();
            float rowHeight = 100f / rows;
            for (int i = 0; i < rows; i++)
            {
                seatsTableLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, rowHeight));
            }
            float colWidth = 100f / 6;
            for (int j = 0; j < 6; j++)
            {
                seatsTableLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, colWidth));
            }
            return availableSeats;
        }
        public void ApplyFilters(List<string> textBoxes,List<string> columnsIDs, DataGridView dataGridView)
        {
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                bool showRow = true;

                for(int i = 0; i< textBoxes.Count; i++)
                {
                    if (!string.IsNullOrEmpty(textBoxes[i]))
                    {
                        string? resultRow = row.Cells[columnsIDs[i]].Value?.ToString();
                        if (resultRow == null || !resultRow.Contains(textBoxes[i]))
                        {
                            showRow = false;
                        }
                    }
                }
                row.Visible = showRow;
            }
        }
        public void ExcuteDataQuery(string query)
        {
            sqlConnection.Open();
            SqlCommand command = new(query, sqlConnection);
            if(_processQuery != null)
            {
                if (query.ToLower().Contains("update"))
                {
                    _processQuery.SetQueryCommandParams(command, QueryType.Update);
                }
                else if (query.ToLower().Contains("delete"))
                {
                    _processQuery.SetQueryCommandParams(command, QueryType.Delete);
                }else if (query.ToLower().Contains("insert"))
                {
                    _processQuery.SetQueryCommandParams(command, QueryType.Insert);
                }
            }
            command.ExecuteNonQuery();
            sqlConnection.Close();
        }
        public void UpdateDataGrid(DataGridView dataGrid, string query)
        {
            dataGrid.Rows.Clear();
            DataTable dataTable = new();
            sqlConnection.Open();
            SqlCommand command = new(query, sqlConnection);
            SqlDataAdapter adapter = new(command);
            if(_processDataGrid != null)
            {
                _processDataGrid.SetDataGridCommandParams(command);
            }
            adapter.Fill(dataTable);
            sqlConnection.Close();
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                dataGrid.Rows.Add(rowData);
            }
        }
        public void ToggleSeatButton(TableLayoutPanel seatsTableLayoutPanel, Guna2TextBox seatAssignmentTextBox, Guna2Button seat, object sender)
        {
            foreach (Control control in seatsTableLayoutPanel.Controls)
            {
                if (control is Guna2Button button && button.Tag != null && button.Tag.ToString() == seatAssignmentTextBox.Text)
                {
                    button.Image = seat.Image;
                    button.HoverState.Image = seat.HoverState.Image;
                    break;
                }
            }
            if (sender is Guna2Button clickedButton)
            {
                clickedButton.Image = seat.HoverState.Image;
                seatAssignmentTextBox.Text = (string)clickedButton.Tag;
            }
        }
    }
}
