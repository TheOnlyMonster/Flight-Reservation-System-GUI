namespace FlightReservationSystem
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.button4 = new System.Windows.Forms.Button();
            this.exploreFlightsButton = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.labelEmail = new System.Windows.Forms.Label();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.labelLastName = new System.Windows.Forms.Label();
            this.labelPassword = new System.Windows.Forms.Label();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.signUpButton = new System.Windows.Forms.Button();
            this.submitButton = new System.Windows.Forms.Button();
            this.flightDataGrid = new System.Windows.Forms.DataGridView();
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.IsSplitterFixed = true;
            this.contentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contentSplitContainer.Name = "splitContainer1";
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.contentSplitContainer.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("splitContainer1.Panel1.BackgroundImage")));
            this.contentSplitContainer.Panel1.Controls.Add(this.button4);
            this.contentSplitContainer.Panel1.Controls.Add(this.exploreFlightsButton);
            this.contentSplitContainer.Panel1.Controls.Add(this.button2);
            this.contentSplitContainer.Panel1.Controls.Add(this.signUpButton);
            this.contentSplitContainer.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // splitContainer1.Panel2
            // 
            
            this.contentSplitContainer.Size = new System.Drawing.Size(1401, 701);
            this.contentSplitContainer.SplitterDistance = 276;
            this.contentSplitContainer.TabIndex = 0;
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Dock = System.Windows.Forms.DockStyle.Top;
            this.button4.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button4.Location = new System.Drawing.Point(0, 171);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(276, 63);
            this.button4.TabIndex = 3;
            this.button4.Text = "Help";
            this.button4.UseVisualStyleBackColor = false;
            // 
            // exploreFlightsButton
            // 
            this.exploreFlightsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exploreFlightsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exploreFlightsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exploreFlightsButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exploreFlightsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exploreFlightsButton.Location = new System.Drawing.Point(0, 114);
            this.exploreFlightsButton.Name = "button3";
            this.exploreFlightsButton.Size = new System.Drawing.Size(276, 57);
            this.exploreFlightsButton.TabIndex = 2;
            this.exploreFlightsButton.Text = "Explore Flights";
            this.exploreFlightsButton.UseVisualStyleBackColor = false;
            this.exploreFlightsButton.Click += new System.EventHandler(this.exploreFlightsButton_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Dock = System.Windows.Forms.DockStyle.Top;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.button2.Location = new System.Drawing.Point(0, 57);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(276, 57);
            this.button2.TabIndex = 1;
            this.button2.Text = "Sign In";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signUpButton.Location = new System.Drawing.Point(0, 0);
            this.signUpButton.Name = "button1";
            this.signUpButton.Size = new System.Drawing.Size(276, 57);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // flightDataGrid
            // 
            //flightDataGrid.Hide();
            this.flightDataGrid.AllowUserToAddRows = false;
            this.flightDataGrid.AllowUserToDeleteRows = false;
            this.flightDataGrid.AllowUserToResizeColumns = false;
            this.flightDataGrid.AllowUserToResizeRows = false;
            this.flightDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.flightDataGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FlightNo,
            this.deptDate,
            this.deptCountry,
            this.arrivalCountry,
            this.expectedArrivalDate});
            this.flightDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightDataGrid.Location = new System.Drawing.Point(0, 0);
            this.flightDataGrid.Name = "flightDataGrid";
            this.flightDataGrid.ReadOnly = true;
            this.flightDataGrid.RowTemplate.Height = 25;
            this.flightDataGrid.Size = new System.Drawing.Size(1121, 701);
            this.flightDataGrid.TabIndex = 0;
            // 
            // signUpPanel
            // 
            this.signUpPanel.Dock = DockStyle.Fill;
            this.signUpPanel.BackColor = Color.White;
            this.signUpPanel.BackgroundImage = Properties.Resources.background2;
            this.signUpPanel.BackgroundImageLayout = ImageLayout.Stretch;
            this.signUpPanel.Controls.Add(labelEmail);
            this.signUpPanel.Controls.Add(textBoxEmail);
            this.signUpPanel.Controls.Add(labelFirstName);
            this.signUpPanel.Controls.Add(textBoxFirstName);
            this.signUpPanel.Controls.Add(labelLastName);
            this.signUpPanel.Controls.Add(textBoxLastName);
            this.signUpPanel.Controls.Add(labelPassword);
            this.signUpPanel.Controls.Add(textBoxPassword);
            this.signUpPanel.Controls.Add(labelPhone);
            this.signUpPanel.Controls.Add(textBoxPhone);
            this.signUpPanel.Controls.Add(submitButton);
            // 
            // FlightNo
            // 
            this.FlightNo.HeaderText = "Flight Number";
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            // 
            // deptDate
            // 
            this.deptDate.HeaderText = "Departure Date";
            this.deptDate.Name = "deptDate";
            this.deptDate.ReadOnly = true;
            // 
            // deptCountry
            // 
            this.deptCountry.HeaderText = "Departure Country";
            this.deptCountry.Name = "deptCountry";
            this.deptCountry.ReadOnly = true;
            // 
            // arrivalCountry
            // 
            this.arrivalCountry.HeaderText = "Arrival Country";
            this.arrivalCountry.Name = "arrivalCountry";
            this.arrivalCountry.ReadOnly = true;
            // 
            // expectedArrivalDate
            // 
            this.expectedArrivalDate.HeaderText = "Expected Arrival Date";
            this.expectedArrivalDate.Name = "expectedArrivalDate";
            this.expectedArrivalDate.ReadOnly = true;
            // 
            // Main Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 701);
            this.Controls.Add(this.contentSplitContainer);
            this.Name = "Form1";
            this.Text = "Flight Reservation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            this.ResumeLayout(false);


            labelEmail.Text = "Email:";
            labelEmail.Location = new Point(50, 30);
            labelEmail.Font = new Font(labelEmail.Font, FontStyle.Bold);

            textBoxEmail.Location = new Point(150, 30);
            textBoxEmail.Size = new Size(200, 20);

            labelFirstName.Text = "First Name:";
            labelFirstName.Location = new Point(50, 70);
            labelFirstName.Font = new Font(labelFirstName.Font, FontStyle.Bold);

            textBoxFirstName.Location = new Point(150, 70);
            textBoxFirstName.Size = new Size(200, 20);
            textBoxFirstName.KeyPress += textBoxValidation;

            labelLastName.Text = "Last Name:";
            labelLastName.Location = new Point(50, 110);
            labelLastName.Font = new Font(labelLastName.Font, FontStyle.Bold);

            textBoxLastName.Location = new Point(150, 110);
            textBoxLastName.Size = new Size(200, 20);
            textBoxLastName.KeyPress += textBoxValidation;

            labelPassword.Text = "Password:";
            labelPassword.Location = new Point(50, 150);
            labelPassword.Font = new Font(labelPassword.Font, FontStyle.Bold);

            textBoxPassword.Location = new Point(150, 150);
            textBoxPassword.Size = new Size(200, 20);
            textBoxPassword.PasswordChar = '*';

            labelPhone.Text = "Phone:";
            labelPhone.Location = new Point(50, 190);
            labelPhone.Font = new Font(labelPhone.Font, FontStyle.Bold);

            textBoxPhone.Location = new Point(150, 190);
            textBoxPhone.Size = new Size(200, 20);

            submitButton.Cursor = Cursors.Hand;
            submitButton.Text = "Sign Up";
            submitButton.Location = new Point(150, 250);
            submitButton.Size = new Size(100, 30);
            submitButton.BackColor = Color.FromArgb(0, 123, 255);
            submitButton.ForeColor = Color.White;
            submitButton.Font = new Font(submitButton.Font, FontStyle.Bold);
            submitButton.Click += submitButton_Click;

        }

        #endregion
        private SplitContainer contentSplitContainer;
        private Button button2;
        private Button signUpButton;
        private Button button4;
        private Button exploreFlightsButton;
        private DataGridView flightDataGrid;
        private DataGridViewTextBoxColumn FlightNo;
        private DataGridViewTextBoxColumn deptDate;
        private DataGridViewTextBoxColumn deptCountry;
        private DataGridViewTextBoxColumn arrivalCountry;
        private DataGridViewTextBoxColumn expectedArrivalDate;
        private Panel signUpPanel;
        private Label labelEmail;
        private Label labelFirstName;
        private Label labelLastName;
        private Label labelPassword;
        private Label labelPhone;
        private TextBox textBoxEmail;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private TextBox textBoxPassword;
        private TextBox textBoxPhone;
        private Button submitButton;
    }
}