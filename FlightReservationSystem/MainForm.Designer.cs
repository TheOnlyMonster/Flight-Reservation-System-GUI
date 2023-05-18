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
            this.signUpButton = new System.Windows.Forms.Button();
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
            this.flightDataGrid = new System.Windows.Forms.DataGridView();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.signUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            this.SuspendLayout();
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
            this.contentSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.contentSplitContainer.Panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("contentSplitContainer.Panel1.BackgroundImage")));
            this.contentSplitContainer.Panel1.Controls.Add(this.button4);
            this.contentSplitContainer.Panel1.Controls.Add(this.exploreFlightsButton);
            this.contentSplitContainer.Panel1.Controls.Add(this.button2);
            this.contentSplitContainer.Panel1.Controls.Add(this.signUpButton);
            this.contentSplitContainer.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            // 
            // contentSplitContainer.Panel2
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
            this.exploreFlightsButton.Name = "exploreFlightsButton";
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
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(276, 57);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
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
            this.labelEmail.Location = new System.Drawing.Point(313, 34);
            this.labelEmail.Name = "labelEmail";
            this.labelEmail.Size = new System.Drawing.Size(100, 23);
            this.labelEmail.TabIndex = 0;
            this.labelEmail.Text = "Email:";
            // 
            // textBoxEmail
            // 
            this.textBoxEmail.Location = new System.Drawing.Point(413, 34);
            this.textBoxEmail.Name = "textBoxEmail";
            this.textBoxEmail.Size = new System.Drawing.Size(312, 23);
            this.textBoxEmail.TabIndex = 1;
            // 
            // labelFirstName
            // 
            this.labelFirstName.BackColor = System.Drawing.Color.Transparent;
            this.labelFirstName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelFirstName.Location = new System.Drawing.Point(313, 74);
            this.labelFirstName.Name = "labelFirstName";
            this.labelFirstName.Size = new System.Drawing.Size(100, 23);
            this.labelFirstName.TabIndex = 2;
            this.labelFirstName.Text = "First Name:";
            // 
            // textBoxFirstName
            // 
            this.textBoxFirstName.Location = new System.Drawing.Point(413, 74);
            this.textBoxFirstName.Name = "textBoxFirstName";
            this.textBoxFirstName.Size = new System.Drawing.Size(312, 23);
            this.textBoxFirstName.TabIndex = 3;
            // 
            // labelLastName
            // 
            this.labelLastName.BackColor = System.Drawing.Color.Transparent;
            this.labelLastName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelLastName.Location = new System.Drawing.Point(313, 114);
            this.labelLastName.Name = "labelLastName";
            this.labelLastName.Size = new System.Drawing.Size(100, 23);
            this.labelLastName.TabIndex = 4;
            this.labelLastName.Text = "Last Name:";
            // 
            // textBoxLastName
            // 
            this.textBoxLastName.Location = new System.Drawing.Point(413, 114);
            this.textBoxLastName.Name = "textBoxLastName";
            this.textBoxLastName.Size = new System.Drawing.Size(312, 23);
            this.textBoxLastName.TabIndex = 5;
            // 
            // labelPassword
            // 
            this.labelPassword.BackColor = System.Drawing.Color.Transparent;
            this.labelPassword.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPassword.Location = new System.Drawing.Point(313, 154);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(100, 23);
            this.labelPassword.TabIndex = 6;
            this.labelPassword.Text = "Password:";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(413, 154);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(312, 23);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelPhone
            // 
            this.labelPhone.BackColor = System.Drawing.Color.Transparent;
            this.labelPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelPhone.Location = new System.Drawing.Point(313, 194);
            this.labelPhone.Name = "labelPhone";
            this.labelPhone.Size = new System.Drawing.Size(100, 23);
            this.labelPhone.TabIndex = 8;
            this.labelPhone.Text = "Phone:";
            // 
            // textBoxPhone
            // 
            this.textBoxPhone.Location = new System.Drawing.Point(413, 194);
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
            this.submitButton.Location = new System.Drawing.Point(413, 254);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(100, 30);
            this.submitButton.TabIndex = 10;
            this.submitButton.Text = "Sign Up";
            this.submitButton.UseVisualStyleBackColor = false;
            // 
            // flightDataGrid
            // 
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
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1401, 701);
            this.Controls.Add(this.contentSplitContainer);
            this.Name = "MainForm";
            this.Text = "Flight Reservation System";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.signUpPanel.ResumeLayout(false);
            this.signUpPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            this.ResumeLayout(false);

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