using System;
using System.Data;
using System.Data.SqlClient;
namespace FlightReservationSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        private string databaseConnection = "Server = DESKTOP-FOQJ9FO\\ABDELRAHMANDB; Initial Catalog = FlightReservationSystem; Integrated Security = true; User ID = sa; Password = Admin#123";
        private void MainForm_Load(object sender, EventArgs e)
        {
            exploreFlightsButton_Click(sender, e);
        }

        private void signUpButton_Click(object sender, EventArgs e)
        {
            contentSplitContainer.Panel2.Controls.Clear();
            contentSplitContainer.Panel2.Controls.Add(signUpPanel);
        }
        
        private void textBoxValidation(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void submitButton_Click(object sender, EventArgs e)
        {
            
        }
        private void exploreFlightsButton_Click(object sender, EventArgs e)
        {
            contentSplitContainer.Panel2.Controls.Clear();
            contentSplitContainer.Panel2.Controls.Add(flightDataGrid);
            flightDataGrid.Rows.Clear();
            DataTable dataTable = new DataTable();
            using (SqlConnection connection = new SqlConnection(databaseConnection))
            {
                connection.Open();
                string query = "SELECT FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrival FROM Flight";
                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            foreach (DataRow row in dataTable.Rows)
            {
                object[] rowData = row.ItemArray;
                flightDataGrid.Rows.Add(rowData);
            }
            contentSplitContainer.Panel2.Controls.Add(flightDataGrid);
        }
    }
}