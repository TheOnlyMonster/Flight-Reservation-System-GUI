using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlightReservationSystem
{
    public class DataManager
    {
        private IProcessDataGrid _processDataGrid;
        private SqlConnection sqlConnection;
        public DataManager(string connection, IProcessDataGrid _processDataGrid)
        {
            sqlConnection = new SqlConnection(connection);
            this._processDataGrid = _processDataGrid;
        }
        public void UpdateDataGrid(DataGridView dataGrid, string query)
        {
            dataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            sqlConnection.Open();
            SqlCommand command = new SqlCommand(query, sqlConnection);
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            _processDataGrid.ProccessDataGrid(command);
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
