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
            this.signInPanel = new System.Windows.Forms.Panel();
            this.usernameSignInLabel = new System.Windows.Forms.Label();
            this.usernameSignInTextBox = new System.Windows.Forms.TextBox();
            this.passwordSignInLabel = new System.Windows.Forms.Label();
            this.passwordSignInTextBox = new System.Windows.Forms.TextBox();
            this.signInPanelButton = new System.Windows.Forms.Button();
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.helpButton = new System.Windows.Forms.Button();
            this.exploreFlightsButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.bookFlightButton = new System.Windows.Forms.Button();
            this.bookFlightPanel = new System.Windows.Forms.Panel();
            this.arrivalCountryLabel = new System.Windows.Forms.Label();
            this.arrivalCountriesComboBox = new System.Windows.Forms.ComboBox();
            this.deptCountryLabel = new System.Windows.Forms.Label();
            this.deptCountriesComboBox = new System.Windows.Forms.ComboBox();
            this.deptDateLabel = new System.Windows.Forms.Label();
            this.deptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.flightDataGrid = new System.Windows.Forms.DataGridView();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.signUpPanel = new System.Windows.Forms.Panel();
            this.labelEmail = new System.Windows.Forms.Label();
            this.textBoxEmail = new System.Windows.Forms.TextBox();
            this.labelFirstName = new System.Windows.Forms.Label();
            this.textBoxFirstName = new System.Windows.Forms.TextBox();
            this.labelLastName = new System.Windows.Forms.Label();
            this.textBoxLastName = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelPhone = new System.Windows.Forms.Label();
            this.textBoxPhone = new System.Windows.Forms.TextBox();
            this.submitButton = new System.Windows.Forms.Button();
            this.signInPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.bookFlightPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            this.signUpPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // signInPanel
            // 
            this.signInPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("signInPanel.BackgroundImage")));
            this.signInPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signInPanel.Controls.Add(this.usernameSignInLabel);
            this.signInPanel.Controls.Add(this.usernameSignInTextBox);
            this.signInPanel.Controls.Add(this.passwordSignInLabel);
            this.signInPanel.Controls.Add(this.passwordSignInTextBox);
            this.signInPanel.Controls.Add(this.signInPanelButton);
            this.signInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInPanel.Location = new System.Drawing.Point(0, 0);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(1121, 701);
            this.signInPanel.TabIndex = 0;
            // 
            // usernameSignInLabel
            // 
            this.usernameSignInLabel.BackColor = System.Drawing.Color.Transparent;
            this.usernameSignInLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameSignInLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.usernameSignInLabel.Location = new System.Drawing.Point(28, 32);
            this.usernameSignInLabel.Name = "usernameSignInLabel";
            this.usernameSignInLabel.Size = new System.Drawing.Size(100, 23);
            this.usernameSignInLabel.TabIndex = 11;
            this.usernameSignInLabel.Text = "Email:";
            // 
            // usernameSignInTextBox
            // 
            this.usernameSignInTextBox.Location = new System.Drawing.Point(128, 32);
            this.usernameSignInTextBox.Name = "usernameSignInTextBox";
            this.usernameSignInTextBox.Size = new System.Drawing.Size(312, 23);
            this.usernameSignInTextBox.TabIndex = 12;
            // 
            // passwordSignInLabel
            // 
            this.passwordSignInLabel.BackColor = System.Drawing.Color.Transparent;
            this.passwordSignInLabel.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordSignInLabel.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.passwordSignInLabel.Location = new System.Drawing.Point(28, 74);
            this.passwordSignInLabel.Name = "passwordSignInLabel";
            this.passwordSignInLabel.Size = new System.Drawing.Size(100, 23);
            this.passwordSignInLabel.TabIndex = 13;
            this.passwordSignInLabel.Text = "Password:";
            // 
            // passwordSignInTextBox
            // 
            this.passwordSignInTextBox.Location = new System.Drawing.Point(128, 74);
            this.passwordSignInTextBox.Name = "passwordSignInTextBox";
            this.passwordSignInTextBox.PasswordChar = '*';
            this.passwordSignInTextBox.Size = new System.Drawing.Size(312, 23);
            this.passwordSignInTextBox.TabIndex = 14;
            // 
            // signInPanelButton
            // 
            this.signInPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.signInPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInPanelButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.signInPanelButton.ForeColor = System.Drawing.Color.White;
            this.signInPanelButton.Location = new System.Drawing.Point(128, 122);
            this.signInPanelButton.Name = "signInPanelButton";
            this.signInPanelButton.Size = new System.Drawing.Size(100, 30);
            this.signInPanelButton.TabIndex = 15;
            this.signInPanelButton.Text = "Sign In";
            this.signInPanelButton.UseVisualStyleBackColor = false;
            this.signInPanelButton.Click += new System.EventHandler(this.signInPanelButton_Click);
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.IsSplitterFixed = true;
            this.contentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contentSplitContainer.Panel1.Controls.Add(this.helpButton);
            this.contentSplitContainer.Panel1.Controls.Add(this.exploreFlightsButton);
            this.contentSplitContainer.Panel1.Controls.Add(this.signInButton);
            this.contentSplitContainer.Panel1.Controls.Add(this.signUpButton);
            this.contentSplitContainer.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // contentSplitContainer.Panel2
            // 
            
            this.contentSplitContainer.Size = new System.Drawing.Size(1401, 701);
            this.contentSplitContainer.SplitterDistance = 276;
            this.contentSplitContainer.TabIndex = 0;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.helpButton.Location = new System.Drawing.Point(0, 638);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(276, 63);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // exploreFlightsButton
            // 
            this.exploreFlightsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exploreFlightsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exploreFlightsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exploreFlightsButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exploreFlightsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exploreFlightsButton.Location = new System.Drawing.Point(0, 177);
            this.exploreFlightsButton.Name = "exploreFlightsButton";
            this.exploreFlightsButton.Size = new System.Drawing.Size(276, 57);
            this.exploreFlightsButton.TabIndex = 2;
            this.exploreFlightsButton.Text = "Explore Flights";
            this.exploreFlightsButton.UseVisualStyleBackColor = false;
            this.exploreFlightsButton.Click += new System.EventHandler(this.exploreFlightsButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signInButton.Location = new System.Drawing.Point(0, 120);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(276, 57);
            this.signInButton.TabIndex = 1;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signUpButton.Location = new System.Drawing.Point(0, 63);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(276, 57);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookFlightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookFlightButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookFlightButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookFlightButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bookFlightButton.Location = new System.Drawing.Point(0, 0);
            this.bookFlightButton.Name = "bookFlightButton";
            this.bookFlightButton.Size = new System.Drawing.Size(276, 63);
            this.bookFlightButton.TabIndex = 4;
            this.bookFlightButton.Text = "Book Flight";
            this.bookFlightButton.UseVisualStyleBackColor = false;
            this.bookFlightButton.Click += new System.EventHandler(this.bookFlightButton_Click);
            // 
            // bookFlightPanel
            // 
            this.bookFlightPanel.Controls.Add(this.arrivalCountryLabel);
            this.bookFlightPanel.Controls.Add(this.arrivalCountriesComboBox);
            this.bookFlightPanel.Controls.Add(this.deptCountryLabel);
            this.bookFlightPanel.Controls.Add(this.deptCountriesComboBox);
            this.bookFlightPanel.Controls.Add(this.deptDateLabel);
            this.bookFlightPanel.Controls.Add(this.deptDateTimePicker);
            this.bookFlightPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bookFlightPanel.Location = new System.Drawing.Point(0, 0);
            this.bookFlightPanel.Name = "bookFlightPanel";
            this.bookFlightPanel.Size = new System.Drawing.Size(1121, 701);
            this.bookFlightPanel.TabIndex = 0;
            // 
            // label3
            // 
            this.arrivalCountryLabel.AutoSize = true;
            this.arrivalCountryLabel.Location = new System.Drawing.Point(578, 25);
            this.arrivalCountryLabel.Name = "label3";
            this.arrivalCountryLabel.Size = new System.Drawing.Size(38, 15);
            this.arrivalCountryLabel.TabIndex = 11;
            this.arrivalCountryLabel.Text = "Arrival Country";
            // 
            // arrivalCountriesComboBox
            // 
            this.arrivalCountriesComboBox.FormattingEnabled = true;
            this.arrivalCountriesComboBox.Location = new System.Drawing.Point(537, 43);
            this.arrivalCountriesComboBox.Name = "arrivalCountriesComboBox";
            this.arrivalCountriesComboBox.Size = new System.Drawing.Size(121, 23);
            this.arrivalCountriesComboBox.TabIndex = 10;
            this.deptCountriesComboBox.BindingContextChanged += new System.EventHandler(this.ArrivalCountriesComboBox_BindingContextChanged);
            // 
            // label2
            // 
            this.deptCountryLabel.AutoSize = true;
            this.deptCountryLabel.Location = new System.Drawing.Point(430, 25);
            this.deptCountryLabel.Name = "label2";
            this.deptCountryLabel.Size = new System.Drawing.Size(38, 15);
            this.deptCountryLabel.TabIndex = 9;
            this.deptCountryLabel.Text = "Department Country";
            // 
            // deptCountriesComboBox
            // 
            this.deptCountriesComboBox.FormattingEnabled = true;
            this.deptCountriesComboBox.Location = new System.Drawing.Point(398, 43);
            this.deptCountriesComboBox.Name = "deptCountriesComboBox";
            this.deptCountriesComboBox.Size = new System.Drawing.Size(121, 23);
            this.deptCountriesComboBox.TabIndex = 8;
            this.deptCountriesComboBox.BindingContextChanged += new System.EventHandler(this.deptCountriesComboBox_BindingContextChanged);
            // 
            // deptDateLabel
            // 
            this.deptDateLabel.AutoSize = true;
            this.deptDateLabel.Location = new System.Drawing.Point(386, 100);
            this.deptDateLabel.Name = "deptDateLabel";
            this.deptDateLabel.Size = new System.Drawing.Size(38, 15);
            this.deptDateLabel.TabIndex = 7;
            this.deptDateLabel.Text = "Department Date";
            // 
            // deptDateTimePicker
            // 
            this.deptDateTimePicker.Location = new System.Drawing.Point(430, 94);
            this.deptDateTimePicker.Name = "deptDateTimePicker";
            this.deptDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.deptDateTimePicker.TabIndex = 6;
            // 
            // flightDataGrid
            // 
            this.flightDataGrid.AllowUserToAddRows = false;
            this.flightDataGrid.AllowUserToDeleteRows = false;
            this.flightDataGrid.AllowUserToResizeColumns = false;
            this.flightDataGrid.AllowUserToResizeRows = false;
            this.flightDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.flightDataGrid.BackgroundColor = System.Drawing.SystemColors.Control;
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
            // signUpPanel
            // 
            this.signUpPanel.BackColor = System.Drawing.Color.White;
            this.signUpPanel.BackgroundImage = global::FlightReservationSystem.Properties.Resources.background2;
            this.signUpPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signUpPanel.Controls.Add(this.labelEmail);
            this.signUpPanel.Controls.Add(this.textBoxEmail);
            this.signUpPanel.Controls.Add(this.labelFirstName);
            this.signUpPanel.Controls.Add(this.textBoxFirstName);
            this.signUpPanel.Controls.Add(this.labelLastName);
            this.signUpPanel.Controls.Add(this.textBoxLastName);
            this.signUpPanel.Controls.Add(this.labelPassword);
            this.signUpPanel.Controls.Add(this.textBoxPassword);
            this.signUpPanel.Controls.Add(this.labelPhone);
            this.signUpPanel.Controls.Add(this.textBoxPhone);
            this.signUpPanel.Controls.Add(this.submitButton);
            this.signUpPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signUpPanel.Location = new System.Drawing.Point(0, 0);
            this.signUpPanel.Name = "signUpPanel";
            this.signUpPanel.Size = new System.Drawing.Size(1121, 701);
            this.signUpPanel.TabIndex = 0;
            // 
            // labelEmail
            // 
            this.labelEmail.BackColor = System.Drawing.Color.Transparent;
            this.labelEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelEmail.Location = new System.Drawing.Point(23, 34);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 23);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(123, 34);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(312, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(23, 74);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(100, 23);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(123, 74);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(312, 23);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(23, 114);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(100, 23);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(123, 114);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(312, 23);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(23, 154);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 23);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(123, 154);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(312, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(23, 194);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(100, 23);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(123, 194);
            this.textBoxPhone.Name = "textBoxPhone";
            this.textBoxPhone.Size = new System.Drawing.Size(312, 23);
            this.textBoxPhone.TabIndex = 9;
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(123)))), ((int)(((byte)(255)))));
            this.submitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.submitButton.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.submitButton.ForeColor = System.Drawing.Color.White;
            this.submitButton.Location = new System.Drawing.Point(123, 254);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 30);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Sign Up";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 701);
            this.Controls.Add(this.contentSplitContainer);
            this.Name = "MainForm";
            this.Text = "Flight Reservation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.bookFlightPanel.ResumeLayout(false);
            this.bookFlightPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private SplitContainer contentSplitContainer;
        private Button signInButton;
        private Button signUpButton;
        private Button helpButton;
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


        private Panel signInPanel;
        private Label usernameSignInLabel;
        private TextBox usernameSignInTextBox;
        private Label passwordSignInLabel;
        private TextBox passwordSignInTextBox;
        private Button signInPanelButton;
        private Button bookFlightButton;
        private Panel bookFlightPanel;
        private Label arrivalCountryLabel;
        private ComboBox arrivalCountriesComboBox;
        private Label deptCountryLabel;
        private ComboBox deptCountriesComboBox;
        private Label deptDateLabel;
        private DateTimePicker deptDateTimePicker;
    }
}