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

        protected string databaseConnection = "Server = DESKTOP-FOQJ9FO\\ABDELRAHMANDB; Initial Catalog = FlightReservationSystem; Integrated Security = true; User ID = sa; Password = Admin#123";
        public MainMenu()
        {
            InitializeComponent();
            if (IsUserLoggedIn)
            {
                contentSplitContainer.Panel1.Controls.Add(this.bookFlightButton);
            }
            else
            {
                this.contentSplitContainer.Panel1.Controls.Add(this.signInButton);
                this.contentSplitContainer.Panel1.Controls.Add(this.signUpButton);
            }
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
    }
}
