using System.Data;
using System.Text;
using System.Data.SqlClient;
using Guna.UI2.WinForms;

namespace FlightReservationSystem
{
    public partial class MainMenu : Form
    {      
        private readonly ErrorProvider errorProvider;
        protected static bool IsUserLoggedIn { get; set; } = false;
        protected static bool IsAdminLoggedIn { get; set; } = false;

        protected string databaseConnection = "Server = DESKTOP-FOQJ9FO\\ABDELRAHMANDB; Initial Catalog = FlightReservationSystem; Integrated Security = true; User ID = sa; Password = Admin#123";

        protected DataManager? dataManager;
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
            errorProvider = new ErrorProvider
            {
                BlinkStyle = ErrorBlinkStyle.NeverBlink
            };
        }
        protected void SetAuthenticatorError(string error, Control obj)
        {
            errorProvider.SetError(obj, error);
            obj.Focus();
        }
        
        private void OpenForm(MainMenu form)
        {
            form.Show();
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
                IEnumerable<string> fields = row.ItemArray.Select(field => field.ToString());
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
