using System.Data;
using System.Text;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace FlightReservationSystem
{
    public partial class MainMenu : Form
    {
        protected static bool IsUserLoggedIn { get; set; } = false;
        protected static bool IsAdminLoggedIn { get; set; } = false;

        protected string databaseConnection = "Server = 34.122.92.128;Initial Catalog=FlightReservationSystem;Persist Security Info=True;User ID=sqlserver;Password=Admin#123";

        protected DataManager? dataManager;
        public MainMenu()
        {
            InitializeComponent();
            if (IsUserLoggedIn)
            {
                contentSplitContainer.Panel1.Controls.Add(this.bookFlightButton);
                contentSplitContainer.Panel1.Controls.Add(this.customerReservationsButton);
                contentSplitContainer.Panel1.Controls.Add(this.updateInfoButton);
                contentSplitContainer.Panel1.Controls.Add(this.signOutButton);

            }
            else if (IsAdminLoggedIn)
            {
                contentSplitContainer.Panel1.Controls.Add(this.updateAircraftButton);
                contentSplitContainer.Panel1.Controls.Add(this.addAircraftButton);
                contentSplitContainer.Panel1.Controls.Add(this.addFlightButton);
                contentSplitContainer.Panel1.Controls.Add(this.updateFlightButton);
                contentSplitContainer.Panel1.Controls.Add(this.updateReservationButton);
                contentSplitContainer.Panel1.Controls.Add(this.signOutButton);
                contentSplitContainer.Panel1.Controls.Add(this.generateReportButton);
            }
            else
            {
                contentSplitContainer.Panel1.Controls.Add(this.signInButton);
                contentSplitContainer.Panel1.Controls.Add(this.signUpButton);
            }

        }

        protected static void FillTimeComboBoxes(List<Guna2ComboBox> hoursComboBoxes, List<Guna2ComboBox> minutesComboBoxes, List<Guna2ComboBox> middayComboBoxes)
        {
            List<string> Hours = new();
            for (int i = 1; i <= 12; i++)
            {
                Hours.Add(i.ToString());
            }
            List<string> Minutes = new();
            for (int i = 1; i <= 60; i++)
            {
                Minutes.Add(i.ToString());
            }
            string[] middayStatus = { "AM", "PM" };
            foreach (Guna2ComboBox hourComboBox in hoursComboBoxes)
            {
                hourComboBox.DataSource = Hours.ToArray();
            }
            foreach (Guna2ComboBox minutesComboBox in minutesComboBoxes)
            {
                minutesComboBox.DataSource = Minutes.ToArray();
            }
            foreach (Guna2ComboBox middayComboBox in middayComboBoxes)
            {
                middayComboBox.DataSource = middayStatus.ToArray();
            }
        }

        private void OpenForm(MainMenu form)
        {
            form.Show();
            form.WindowState = this.WindowState;
            this.Hide();
        }
        protected static void ChangeButton(Guna2Button button)
        {
            button.FillColor = button.HoverState.FillColor;
            button.Image = button.HoverState.Image;
            button.ForeColor = button.HoverState.ForeColor;

        }
        private void ExploreFlightsButton_Click(object sender, EventArgs e)
        {
            OpenForm(new ExploreFlights());

        }
        private void BookFlightButton_Click(object sender, EventArgs e)
        {
            OpenForm(new BookFlight());
        }
        private void SignUpButton_Click(object sender, EventArgs e)
        {
            OpenForm(new SignUpForm());
        }

        private void SignInButton_Click(object sender, EventArgs e)
        {
            OpenForm(new SignInForm());
        }

        private void UpdateInfo_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateInfo());
        }


        private void AddAircraft_Click(object sender, EventArgs e)
        {
            OpenForm(new AddAirCraft());
        }

        private void UpdateAircraft_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateAircraft());
        }
        private void UpdateReservation_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateReservation());
        }
        private void AddFlight_Click(object sender, EventArgs e)
        {
            OpenForm(new AddFlight());
        }

        private void UpdateFlight_Click(object sender, EventArgs e)
        {
            OpenForm(new UpdateFlight());
        }

        private void SignOutButton_Click(object sender, EventArgs e)
        {
            Customer.Instance.PhoneNumber = null;
            Customer.Instance.Fname = null;
            Customer.Instance.Lname = null;
            Customer.Instance.Password = null;
            Customer.Instance.Identifier = null;
            Customer.Instance.Email = null;
            Customer.Instance.Id = null;
            IsUserLoggedIn = false;
            IsAdminLoggedIn = false;
            this.Close();
            MainMenu MainMenu = new();
            MainMenu.Show();
        }

        private void GenerateReport_Click(object sender, EventArgs e)
        {
            DataTable dataTable = new();
            string query = "SELECT f.FlightNo, f.DeptCountry, f.ArrivalCountry, f.ExpectedArrival, f.DeptDate, COUNT(B.CustomerID) AS Reservations, Count(TicketPrice) As TotalPrice FROM Flight f LEFT JOIN BookingDetails B ON f.FlightNo = B.FlightNo GROUP BY f.FlightNo, f.DeptCountry, f.ArrivalCountry, f.ExpectedArrival, f.DeptDate;";
            using (SqlConnection connection = new(databaseConnection))
            {
                connection.Open();
                SqlCommand command = new(query, connection);
                SqlDataAdapter adapter = new(command);
                adapter.Fill(dataTable);
                connection.Close();
            }

            string filePath = "file.csv";
            GenerateCSVFile(dataTable, filePath);
            MessageBox.Show("CSV file generated successfully.");
        }

        private static void GenerateCSVFile(DataTable dataTable, string filePath)
        {
            StringBuilder sb = new();
            IEnumerable<string> columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName);
            sb.AppendLine(string.Join(",", columnNames));
            foreach (DataRow row in dataTable.Rows)
            {
                IEnumerable<string?> fields = row.ItemArray.Select(field => field?.ToString());
                sb.AppendLine(string.Join(",", fields));
            }
            File.WriteAllText(filePath, sb.ToString());
        }

        private void HelpButton_Click(object sender, EventArgs e)
        {
            OpenForm(new Help());
        }

        private void CustomerReservations_Click(object sender, EventArgs e)
        {
            OpenForm(new CustomerReservations());
        }
    }
}
