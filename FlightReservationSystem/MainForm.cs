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

            Panel signUpPanel = new Panel();
            signUpPanel.Dock = DockStyle.Fill;
            signUpPanel.BackColor = Color.White;
            signUpPanel.BackgroundImage = Properties.Resources.background2;
            signUpPanel.BackgroundImageLayout = ImageLayout.Stretch;

            Label labelEmail = new Label();
            labelEmail.Text = "Email:";
            labelEmail.Location = new Point(50, 30);
            labelEmail.Font = new Font(labelEmail.Font, FontStyle.Bold);

            TextBox textBoxEmail = new TextBox();
            textBoxEmail.Location = new Point(150, 30);
            textBoxEmail.Size = new Size(200, 20);

            Label labelFirstName = new Label();
            labelFirstName.Text = "First Name:";
            labelFirstName.Location = new Point(50, 70);
            labelFirstName.Font = new Font(labelFirstName.Font, FontStyle.Bold);

            TextBox textBoxFirstName = new TextBox();
            textBoxFirstName.Location = new Point(150, 70);
            textBoxFirstName.Size = new Size(200, 20);

            Label labelLastName = new Label();
            labelLastName.Text = "Last Name:";
            labelLastName.Location = new Point(50, 110);
            labelLastName.Font = new Font(labelLastName.Font, FontStyle.Bold);

            TextBox textBoxLastName = new TextBox();
            textBoxLastName.Location = new Point(150, 110);
            textBoxLastName.Size = new Size(200, 20);

            Label labelPassword = new Label();
            labelPassword.Text = "Password:";
            labelPassword.Location = new Point(50, 150);
            labelPassword.Font = new Font(labelPassword.Font, FontStyle.Bold);

            TextBox textBoxPassword = new TextBox();
            textBoxPassword.Location = new Point(150, 150);
            textBoxPassword.Size = new Size(200, 20);
            textBoxPassword.PasswordChar = '*';

            Label labelPhone = new Label();
            labelPhone.Text = "Phone:";
            labelPhone.Location = new Point(50, 190);
            labelPhone.Font = new Font(labelPhone.Font, FontStyle.Bold);

            TextBox textBoxPhone = new TextBox();
            textBoxPhone.Location = new Point(150, 190);
            textBoxPhone.Size = new Size(200, 20);

            Button signUpButton = new Button();
            
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.Text = "Sign Up";
            signUpButton.Location = new Point(150, 250);
            signUpButton.Size = new Size(100, 30);
            signUpButton.BackColor = Color.FromArgb(0, 123, 255);
            signUpButton.ForeColor = Color.White;
            signUpButton.Font = new Font(signUpButton.Font, FontStyle.Bold);
            signUpButton.Click += signUpButton_Click;

            signUpPanel.Controls.Add(labelEmail);
            signUpPanel.Controls.Add(textBoxEmail);
            signUpPanel.Controls.Add(labelFirstName);
            signUpPanel.Controls.Add(textBoxFirstName);
            signUpPanel.Controls.Add(labelLastName);
            signUpPanel.Controls.Add(textBoxLastName);
            signUpPanel.Controls.Add(labelPassword);
            signUpPanel.Controls.Add(textBoxPassword);
            signUpPanel.Controls.Add(labelPhone);
            signUpPanel.Controls.Add(textBoxPhone);
            signUpPanel.Controls.Add(signUpButton);

            contentSplitContainer.Panel2.Controls.Add(signUpPanel);
        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            // Logic to process the submitted sign-up data
        }




        private void exploreFlightsButton_Click(object sender, EventArgs e)
        {
            contentSplitContainer.Panel2.Controls.Clear();
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