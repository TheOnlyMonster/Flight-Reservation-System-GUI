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
    }
}
