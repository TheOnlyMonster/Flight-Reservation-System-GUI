using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                contentSplitContainer.Panel1.Controls.Add(this.UpdateInfo);

            }
            else if (IsAdminLoggedIn)
            {

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
    }
}
