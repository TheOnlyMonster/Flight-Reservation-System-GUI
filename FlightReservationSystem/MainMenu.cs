using Guna.UI2.AnimatorNS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Excel = Microsoft.Office.Interop.Excel;
using System.Data.SqlClient;


namespace FlightReservationSystem
{
    public partial class MainMenu : Form
    {
        protected static bool IsUserLoggedIn { get; set; } = false;
        protected static bool IsAdminLoggedIn { get; set; } = false;


        protected string databaseConnection = "Server = LAPTOP-9HP7VCU2; Initial Catalog = FlightReservationSystem; Integrated Security = true; User ID = sa; Password = Admin#123";
        public MainMenu()
        {
            InitializeComponent();
            if (IsUserLoggedIn)
            {
                contentSplitContainer.Panel1.Controls.Add(this.bookFlightButton);
                this.contentSplitContainer.Panel1.Controls.Add(this.customerReservations);
                contentSplitContainer.Panel1.Controls.Add(this.UpdateInfo);
                contentSplitContainer.Panel1.Controls.Add(SignOutButton);

            }
            else if (IsAdminLoggedIn)
            {
                contentSplitContainer.Panel1.Controls.Add(this.UpdateAircraft);
                contentSplitContainer.Panel1.Controls.Add(this.AddAircraft);
                contentSplitContainer.Panel1.Controls.Add(this.AddFlight);
                contentSplitContainer.Panel1.Controls.Add(this.UpdateFlight);
                contentSplitContainer.Panel1.Controls.Add(this.UpdateReservation);
                contentSplitContainer.Panel1.Controls.Add(SignOutButton);
                this.contentSplitContainer.Panel1.Controls.Add(this.generateReport);
            }
            else
            {
                this.contentSplitContainer.Panel1.Controls.Add(this.signInButton);
                this.contentSplitContainer.Panel1.Controls.Add(this.signUpButton);
            }
        }
        private void exploreFlightsButton_Click(object sender, EventArgs e)
        {
            ExploreFlights exploreFlights = new ExploreFlights();
            exploreFlights.Show();
            this.Hide();
        }
        private void bookFlightButton_Click(object sender, EventArgs e)
        {
            BookFlight bookFlight = new BookFlight();
            bookFlight.Show();
            this.Hide();
        }
        private void signUpButton_Click(object sender, EventArgs e)
        {
            SignUpForm signUpForm = new SignUpForm();
            signUpForm.Show();
            this.Hide();
        }

        private void signInButton_Click(object sender, EventArgs e)
        {
            SignInForm signInForm = new SignInForm();
            signInForm.Show();
            this.Hide();
        }

        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            UpdateInfo UpdateInfoForm = new UpdateInfo();
            UpdateInfoForm.Show();
            this.Hide();
        }


        private void AddAircraft_Click(object sender, EventArgs e)
        {
            AddAirCraft AddAirCraft = new AddAirCraft();
            AddAirCraft.Show();
            this.Hide();
        }

        private void UpdateAircraft_Click(object sender, EventArgs e)
        {
            UpdateAirCraft UpdateAirCraft = new UpdateAirCraft();
            UpdateAirCraft.Show();
            this.Hide();

        }



        private void UpdateReservation_Click(object sender, EventArgs e)
        {
            UpdateReservation UpdateReservation = new UpdateReservation();
            UpdateReservation.Show();
            this.Hide();
        }



        private void AddFlight_Click(object sender, EventArgs e)
        {
            AddFlight AddFlight = new AddFlight();
            AddFlight.Show();
            this.Hide();
        }

        private void UpdateFlight_Click(object sender, EventArgs e)
        {
            UpdateFlight UpdateFlight = new UpdateFlight();
            UpdateFlight.Show();
            this.Hide();

        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            IsUserLoggedIn = false;
            IsAdminLoggedIn = false;
            this.Close();
            MainMenu MainMenu = new MainMenu();

            MainMenu.Show();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {   
            DataTable dataTable = new DataTable();
            string query = "SELECT f.FlightNo, f.DeptCountry, f.ArrivalCountry, f.ExpectedArrival, f.DeptDate, COUNT(B.CustomerID) AS Reservations, Count(TicketPrice) As TotalPrice FROM Flight f LEFT JOIN BookingDetails B ON f.FlightNo = B.FlightNo GROUP BY f.FlightNo, f.DeptCountry, f.ArrivalCountry, f.ExpectedArrival, f.DeptDate;";
            using(SqlConnection connection = new SqlConnection(databaseConnection)) {
                connection.Open();
                SqlCommand command= new SqlCommand(query,connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(dataTable);
                connection.Close();
            }
            
            string filePath = "file.csv";
            GenerateCSVFile(dataTable, filePath);
            MessageBox.Show("CSV file generated successfully.");
        }

        private void GenerateCSVFile(DataTable dataTable, string filePath)
        {
            StringBuilder sb = new StringBuilder();
            IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));
            foreach (DataRow row in dataTable.Rows)
            {
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
                sb.AppendLine(string.Join(",", fields));
            }
            File.WriteAllText(filePath, sb.ToString());
        }

        private void helpButton_Click(object sender, EventArgs e)
        {
            Help help = new Help();
            help.Show();
            this.Hide();
        }

        private void customerReservations_Click(object sender, EventArgs e)
        {
            CustomerReservations reservations = new CustomerReservations();
            reservations.Show();
            this.Hide();
        }
    }
}
