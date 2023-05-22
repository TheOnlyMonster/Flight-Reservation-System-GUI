namespace FlightReservationSystem
{
    partial class UpdateFlight
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateFlight));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            panel3 = new Panel();
            DeleteButton = new Button();
            label8 = new Label();
            AirCraftIdTextBox = new TextBox();
            ArrivaldateTimePicker = new DateTimePicker();
            label4 = new Label();
            DeparturedateTimePicker = new DateTimePicker();
            textBox10 = new TextBox();
            RankCTextBox = new TextBox();
            RankBTextBox = new TextBox();
            textBox7 = new TextBox();
            RankATextBox = new TextBox();
            SeatsAvailabilityTextBox = new TextBox();
            ArrivalCountryTextBox = new TextBox();
            FlightNumberTextBox = new TextBox();
            DepartureTextBox = new TextBox();
            label14 = new Label();
            ClassPriceTextBox = new TextBox();
            label13 = new Label();
            confirmButton = new Button();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            deptDateLabel = new Label();
            arrivalCountryLabel = new Label();
            deptCountryLabel = new Label();
            deptDateTimePicker = new DateTimePicker();
            comboBox1 = new ComboBox();
            deptCountriesComboBox = new ComboBox();
            AdminFlightDataGrid = new DataGridView();
            FlightNo = new DataGridViewTextBoxColumn();
            AirCraftID = new DataGridViewTextBoxColumn();
            deptDate = new DataGridViewTextBoxColumn();
            expectedArrivalDate = new DataGridViewTextBoxColumn();
            arrivalCountry = new DataGridViewTextBoxColumn();
            deptCountry = new DataGridViewTextBoxColumn();
            AvailableSeats = new DataGridViewTextBoxColumn();
            Rank1Price = new DataGridViewTextBoxColumn();
            Rank2Price = new DataGridViewTextBoxColumn();
            Rank3Price = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            panel3.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AdminFlightDataGrid).BeginInit();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            contentSplitContainer.Margin = new Padding(3, 3, 3, 3);
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.Panel2.Controls.Add(panel3);
            contentSplitContainer.Size = new Size(1688, 1008);
            contentSplitContainer.SplitterDistance = 325;
            contentSplitContainer.SplitterWidth = 6;
            // 
            // signInButton
            // 
            signInButton.DialogResult = DialogResult.None;
            signInButton.DisabledState.BorderColor = Color.DarkGray;
            signInButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signInButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signInButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signInButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            signInButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            signInButton.HoverState.Image = (Image)resources.GetObject("resource.Image");
            signInButton.Location = new Point(0, 57);
            signInButton.ShadowDecoration.BorderRadius = 20;
            signInButton.ShadowDecoration.Color = Color.Transparent;
            signInButton.ShadowDecoration.CustomizableEdges = customizableEdges16;
            signInButton.Size = new Size(325, 57);
            // 
            // signUpButton
            // 
            signUpButton.DialogResult = DialogResult.None;
            signUpButton.DisabledState.BorderColor = Color.DarkGray;
            signUpButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signUpButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signUpButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signUpButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            signUpButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            signUpButton.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            signUpButton.ShadowDecoration.BorderRadius = 20;
            signUpButton.ShadowDecoration.Color = Color.Transparent;
            signUpButton.ShadowDecoration.CustomizableEdges = customizableEdges17;
            signUpButton.Size = new Size(325, 57);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.DialogResult = DialogResult.None;
            exploreFlightsButton.DisabledState.BorderColor = Color.DarkGray;
            exploreFlightsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            exploreFlightsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exploreFlightsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exploreFlightsButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            exploreFlightsButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            exploreFlightsButton.HoverState.Image = (Image)resources.GetObject("resource.Image2");
            exploreFlightsButton.Location = new Point(0, 114);
            exploreFlightsButton.Margin = new Padding(3, 3, 3, 3);
            exploreFlightsButton.ShadowDecoration.BorderRadius = 20;
            exploreFlightsButton.ShadowDecoration.Color = Color.Transparent;
            exploreFlightsButton.ShadowDecoration.CustomizableEdges = customizableEdges18;
            exploreFlightsButton.Size = new Size(325, 76);
            // 
            // helpButton
            // 
            helpButton.DialogResult = DialogResult.None;
            helpButton.DisabledState.BorderColor = Color.DarkGray;
            helpButton.DisabledState.CustomBorderColor = Color.DarkGray;
            helpButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            helpButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            helpButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            helpButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            helpButton.HoverState.Image = (Image)resources.GetObject("resource.Image3");
            helpButton.Location = new Point(0, 924);
            helpButton.Margin = new Padding(3, 3, 3, 3);
            helpButton.ShadowDecoration.BorderRadius = 20;
            helpButton.ShadowDecoration.Color = Color.Transparent;
            helpButton.ShadowDecoration.CustomizableEdges = customizableEdges19;
            helpButton.Size = new Size(325, 84);
            // 
            // SignOutButton
            // 
            SignOutButton.DialogResult = DialogResult.None;
            SignOutButton.DisabledState.BorderColor = Color.DarkGray;
            SignOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SignOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SignOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SignOutButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            SignOutButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            SignOutButton.HoverState.Image = (Image)resources.GetObject("resource.Image4");
            SignOutButton.ShadowDecoration.BorderRadius = 20;
            SignOutButton.ShadowDecoration.Color = Color.Transparent;
            SignOutButton.ShadowDecoration.CustomizableEdges = customizableEdges20;
            // 
            // panel3
            // 
            panel3.Controls.Add(DeleteButton);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(AirCraftIdTextBox);
            panel3.Controls.Add(ArrivaldateTimePicker);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(DeparturedateTimePicker);
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(RankCTextBox);
            panel3.Controls.Add(RankBTextBox);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(RankATextBox);
            panel3.Controls.Add(SeatsAvailabilityTextBox);
            panel3.Controls.Add(ArrivalCountryTextBox);
            panel3.Controls.Add(FlightNumberTextBox);
            panel3.Controls.Add(DepartureTextBox);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(ClassPriceTextBox);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(confirmButton);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(952, 4);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(402, 1000);
            panel3.TabIndex = 2;
            // 
            // DeleteButton
            // 
            DeleteButton.Location = new Point(249, 796);
            DeleteButton.Margin = new Padding(3, 4, 3, 4);
            DeleteButton.Name = "DeleteButton";
            DeleteButton.Size = new Size(109, 31);
            DeleteButton.TabIndex = 63;
            DeleteButton.Text = "Delete";
            DeleteButton.UseVisualStyleBackColor = true;
            DeleteButton.Click += DeleteButton_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(69, 445);
            label8.Name = "label8";
            label8.Size = new Size(77, 20);
            label8.TabIndex = 62;
            label8.Text = "Aircraft ID";
            // 
            // AirCraftIdTextBox
            // 
            AirCraftIdTextBox.Location = new Point(24, 469);
            AirCraftIdTextBox.Margin = new Padding(3, 4, 3, 4);
            AirCraftIdTextBox.Name = "AirCraftIdTextBox";
            AirCraftIdTextBox.Size = new Size(154, 27);
            AirCraftIdTextBox.TabIndex = 61;
            // 
            // ArrivaldateTimePicker
            // 
            ArrivaldateTimePicker.Location = new Point(231, 313);
            ArrivaldateTimePicker.Name = "ArrivaldateTimePicker";
            ArrivaldateTimePicker.Size = new Size(154, 27);
            ArrivaldateTimePicker.TabIndex = 60;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(250, 367);
            label4.Name = "label4";
            label4.Size = new Size(112, 20);
            label4.TabIndex = 59;
            label4.Text = "Departure Date";
            // 
            // DeparturedateTimePicker
            // 
            DeparturedateTimePicker.Location = new Point(231, 389);
            DeparturedateTimePicker.Name = "DeparturedateTimePicker";
            DeparturedateTimePicker.Size = new Size(154, 27);
            DeparturedateTimePicker.TabIndex = 56;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(51, 707);
            textBox10.Margin = new Padding(3, 4, 3, 4);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(129, 27);
            textBox10.TabIndex = 55;
            textBox10.Text = "Rank C";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // RankCTextBox
            // 
            RankCTextBox.Location = new Point(235, 707);
            RankCTextBox.Margin = new Padding(3, 4, 3, 4);
            RankCTextBox.Name = "RankCTextBox";
            RankCTextBox.Size = new Size(131, 27);
            RankCTextBox.TabIndex = 54;
            // 
            // RankBTextBox
            // 
            RankBTextBox.Location = new Point(235, 649);
            RankBTextBox.Margin = new Padding(3, 4, 3, 4);
            RankBTextBox.Name = "RankBTextBox";
            RankBTextBox.Size = new Size(131, 27);
            RankBTextBox.TabIndex = 53;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(51, 649);
            textBox7.Margin = new Padding(3, 4, 3, 4);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(129, 27);
            textBox7.TabIndex = 52;
            textBox7.Text = "Rank B";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // RankATextBox
            // 
            RankATextBox.Location = new Point(235, 593);
            RankATextBox.Margin = new Padding(3, 4, 3, 4);
            RankATextBox.Name = "RankATextBox";
            RankATextBox.Size = new Size(131, 27);
            RankATextBox.TabIndex = 51;
            // 
            // SeatsAvailabilityTextBox
            // 
            SeatsAvailabilityTextBox.Location = new Point(24, 391);
            SeatsAvailabilityTextBox.Margin = new Padding(3, 4, 3, 4);
            SeatsAvailabilityTextBox.Name = "SeatsAvailabilityTextBox";
            SeatsAvailabilityTextBox.Size = new Size(154, 27);
            SeatsAvailabilityTextBox.TabIndex = 50;
            // 
            // ArrivalCountryTextBox
            // 
            ArrivalCountryTextBox.Location = new Point(24, 313);
            ArrivalCountryTextBox.Margin = new Padding(3, 4, 3, 4);
            ArrivalCountryTextBox.Name = "ArrivalCountryTextBox";
            ArrivalCountryTextBox.ReadOnly = true;
            ArrivalCountryTextBox.Size = new Size(154, 27);
            ArrivalCountryTextBox.TabIndex = 48;
            // 
            // FlightNumberTextBox
            // 
            FlightNumberTextBox.Location = new Point(231, 239);
            FlightNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            FlightNumberTextBox.Name = "FlightNumberTextBox";
            FlightNumberTextBox.ReadOnly = true;
            FlightNumberTextBox.Size = new Size(154, 27);
            FlightNumberTextBox.TabIndex = 47;
            // 
            // DepartureTextBox
            // 
            DepartureTextBox.Location = new Point(24, 239);
            DepartureTextBox.Margin = new Padding(3, 4, 3, 4);
            DepartureTextBox.Name = "DepartureTextBox";
            DepartureTextBox.ReadOnly = true;
            DepartureTextBox.Size = new Size(157, 27);
            DepartureTextBox.TabIndex = 46;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(249, 557);
            label14.Name = "label14";
            label14.Size = new Size(78, 20);
            label14.TabIndex = 43;
            label14.Text = "Class Price";
            // 
            // ClassPriceTextBox
            // 
            ClassPriceTextBox.Location = new Point(51, 593);
            ClassPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            ClassPriceTextBox.Name = "ClassPriceTextBox";
            ClassPriceTextBox.ReadOnly = true;
            ClassPriceTextBox.Size = new Size(129, 27);
            ClassPriceTextBox.TabIndex = 42;
            ClassPriceTextBox.Text = "Rank A";
            ClassPriceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(86, 557);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 41;
            label13.Text = "Class";
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(71, 796);
            confirmButton.Margin = new Padding(3, 4, 3, 4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(109, 31);
            confirmButton.TabIndex = 38;
            confirmButton.Text = "Confirm";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(51, 367);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 34;
            label11.Text = "Seats Available";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(253, 289);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 11;
            label7.Text = "Arrival Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(51, 289);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 9;
            label6.Text = "Arrival Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(42, 205);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 7;
            label5.Text = "Departure Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(253, 205);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Flight Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(133, 53);
            label1.Name = "label1";
            label1.Size = new Size(162, 32);
            label1.TabIndex = 0;
            label1.Text = "Update Flight";
            // 
            // panel1
            // 
            panel1.Controls.Add(deptDateLabel);
            panel1.Controls.Add(arrivalCountryLabel);
            panel1.Controls.Add(deptCountryLabel);
            panel1.Controls.Add(deptDateTimePicker);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(deptCountriesComboBox);
            panel1.Controls.Add(AdminFlightDataGrid);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(950, 996);
            panel1.TabIndex = 3;
            // 
            // deptDateLabel
            // 
            deptDateLabel.AutoSize = true;
            deptDateLabel.Location = new Point(515, 33);
            deptDateLabel.Name = "deptDateLabel";
            deptDateLabel.Size = new Size(112, 20);
            deptDateLabel.TabIndex = 39;
            deptDateLabel.Text = "Departure Date";
            // 
            // arrivalCountryLabel
            // 
            arrivalCountryLabel.AutoSize = true;
            arrivalCountryLabel.Location = new Point(349, 33);
            arrivalCountryLabel.Name = "arrivalCountryLabel";
            arrivalCountryLabel.Size = new Size(107, 20);
            arrivalCountryLabel.TabIndex = 38;
            arrivalCountryLabel.Text = "Arrival Country";
            // 
            // deptCountryLabel
            // 
            deptCountryLabel.AutoSize = true;
            deptCountryLabel.Location = new Point(175, 29);
            deptCountryLabel.Name = "deptCountryLabel";
            deptCountryLabel.Size = new Size(131, 20);
            deptCountryLabel.TabIndex = 37;
            deptCountryLabel.Text = "Departure Country";
            // 
            // deptDateTimePicker
            // 
            deptDateTimePicker.Location = new Point(515, 53);
            deptDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            deptDateTimePicker.Name = "deptDateTimePicker";
            deptDateTimePicker.Size = new Size(228, 27);
            deptDateTimePicker.TabIndex = 36;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(349, 53);
            comboBox1.Margin = new Padding(3, 4, 3, 4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 28);
            comboBox1.TabIndex = 35;
            comboBox1.DropDown += AdminArrivalCountriesComboBox_OnDropDown;
            // 
            // deptCountriesComboBox
            // 
            deptCountriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deptCountriesComboBox.FormattingEnabled = true;
            deptCountriesComboBox.Location = new Point(175, 53);
            deptCountriesComboBox.Margin = new Padding(3, 4, 3, 4);
            deptCountriesComboBox.Name = "deptCountriesComboBox";
            deptCountriesComboBox.Size = new Size(138, 28);
            deptCountriesComboBox.TabIndex = 34;
            deptCountriesComboBox.DropDown += AdminDeptCountriesComboBox_OnDropDown;
            // 
            // AdminFlightDataGrid
            // 
            AdminFlightDataGrid.AllowUserToAddRows = false;
            AdminFlightDataGrid.AllowUserToDeleteRows = false;
            AdminFlightDataGrid.AllowUserToResizeColumns = false;
            AdminFlightDataGrid.AllowUserToResizeRows = false;
            AdminFlightDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AdminFlightDataGrid.BackgroundColor = SystemColors.Control;
            AdminFlightDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AdminFlightDataGrid.Columns.AddRange(new DataGridViewColumn[] { FlightNo, AirCraftID, deptDate, expectedArrivalDate, arrivalCountry, deptCountry, AvailableSeats, Rank1Price, Rank2Price, Rank3Price });
            AdminFlightDataGrid.Dock = DockStyle.Bottom;
            AdminFlightDataGrid.Location = new Point(0, 111);
            AdminFlightDataGrid.Name = "AdminFlightDataGrid";
            AdminFlightDataGrid.ReadOnly = true;
            AdminFlightDataGrid.RowHeadersWidth = 51;
            AdminFlightDataGrid.RowTemplate.Height = 25;
            AdminFlightDataGrid.Size = new Size(950, 885);
            AdminFlightDataGrid.TabIndex = 33;
            AdminFlightDataGrid.CellClick += AdminFlightDataGrid_CellClick;
            // 
            // FlightNo
            // 
            FlightNo.HeaderText = "Flight Number";
            FlightNo.MinimumWidth = 6;
            FlightNo.Name = "FlightNo";
            FlightNo.ReadOnly = true;
            // 
            // AirCraftID
            // 
            AirCraftID.HeaderText = "Aircraft ID";
            AirCraftID.MinimumWidth = 6;
            AirCraftID.Name = "AirCraftID";
            AirCraftID.ReadOnly = true;
            // 
            // deptDate
            // 
            deptDate.HeaderText = "Departure Date";
            deptDate.MinimumWidth = 6;
            deptDate.Name = "deptDate";
            deptDate.ReadOnly = true;
            // 
            // expectedArrivalDate
            // 
            expectedArrivalDate.HeaderText = "Expected Arrival Date";
            expectedArrivalDate.MinimumWidth = 6;
            expectedArrivalDate.Name = "expectedArrivalDate";
            expectedArrivalDate.ReadOnly = true;
            // 
            // arrivalCountry
            // 
            arrivalCountry.HeaderText = "Arrival Country";
            arrivalCountry.MinimumWidth = 6;
            arrivalCountry.Name = "arrivalCountry";
            arrivalCountry.ReadOnly = true;
            // 
            // deptCountry
            // 
            deptCountry.HeaderText = "Departure Country";
            deptCountry.MinimumWidth = 6;
            deptCountry.Name = "deptCountry";
            deptCountry.ReadOnly = true;
            // 
            // AvailableSeats
            // 
            AvailableSeats.HeaderText = "Available Seats";
            AvailableSeats.MinimumWidth = 6;
            AvailableSeats.Name = "AvailableSeats";
            AvailableSeats.ReadOnly = true;
            // 
            // Rank1Price
            // 
            Rank1Price.HeaderText = "Rank A Price";
            Rank1Price.MinimumWidth = 6;
            Rank1Price.Name = "Rank1Price";
            Rank1Price.ReadOnly = true;
            // 
            // Rank2Price
            // 
            Rank2Price.HeaderText = "Rank B Price";
            Rank2Price.MinimumWidth = 6;
            Rank2Price.Name = "Rank2Price";
            Rank2Price.ReadOnly = true;
            // 
            // Rank3Price
            // 
            Rank3Price.HeaderText = "Rank C Price";
            Rank3Price.MinimumWidth = 6;
            Rank3Price.Name = "Rank3Price";
            Rank3Price.ReadOnly = true;
            // 
            // UpdateFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1688, 1008);
            Margin = new Padding(3, 3, 3, 3);
            Name = "UpdateFlight";
            Text = "UpdateFlight";
            Load += UpdateFlight_Load;
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AdminFlightDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel3;
        private Label label14;
        private TextBox ClassPriceTextBox;
        private Label label13;
        private Label label11;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label2;
        private Label label1;
        private Panel panel1;
        private DataGridView AdminFlightDataGrid;
        private TextBox SeatsAvailabilityTextBox;
        private TextBox ArrivalCountryTextBox;
        private TextBox FlightNumberTextBox;
        private TextBox DepartureTextBox;
        private TextBox textBox10;
        private TextBox RankCTextBox;
        private TextBox RankBTextBox;
        private TextBox textBox7;
        private TextBox RankATextBox;
        private Button confirmButton;
        private ComboBox deptCountriesComboBox;
        private ComboBox comboBox1;
        private DateTimePicker deptDateTimePicker;
        private Label deptCountryLabel;
        private Label arrivalCountryLabel;
        private Label deptDateLabel;
        private DateTimePicker ArrivaldateTimePicker;
        private Label label4;
        private DateTimePicker DeparturedateTimePicker;
        private Label label8;
        private TextBox AirCraftIdTextBox;
        private DataGridViewTextBoxColumn FlightNo;
        private DataGridViewTextBoxColumn AirCraftID;
        private DataGridViewTextBoxColumn deptDate;
        private DataGridViewTextBoxColumn expectedArrivalDate;
        private DataGridViewTextBoxColumn arrivalCountry;
        private DataGridViewTextBoxColumn deptCountry;
        private DataGridViewTextBoxColumn AvailableSeats;
        private DataGridViewTextBoxColumn Rank1Price;
        private DataGridViewTextBoxColumn Rank2Price;
        private DataGridViewTextBoxColumn Rank3Price;
        private Button DeleteButton;
    }
}