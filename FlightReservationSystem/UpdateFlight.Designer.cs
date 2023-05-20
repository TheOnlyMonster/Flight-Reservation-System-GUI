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
            panel3 = new Panel();
            label14 = new Label();
            ClassPriceTextBox = new TextBox();
            label13 = new Label();
            label11 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            AdminFlightDataGrid = new DataGridView();
            FlightNo = new DataGridViewTextBoxColumn();
            deptDate = new DataGridViewTextBoxColumn();
            deptCountry = new DataGridViewTextBoxColumn();
            arrivalCountry = new DataGridViewTextBoxColumn();
            expectedArrivalDate = new DataGridViewTextBoxColumn();
            AvailableSeats = new DataGridViewTextBoxColumn();
            Rank1Price = new DataGridViewTextBoxColumn();
            Rank2Price = new DataGridViewTextBoxColumn();
            Rank3Price = new DataGridViewTextBoxColumn();
            DepartureTextBox = new TextBox();
            FlightNumberTextBox = new TextBox();
            ArrivalCountryTextBox = new TextBox();
            ArrivalDateTextBox = new TextBox();
            SeatsAvailabilityTextBox = new TextBox();
            confirmButton = new Button();
            RankATextBox = new TextBox();
            textBox7 = new TextBox();
            RankBTextBox = new TextBox();
            RankCTextBox = new TextBox();
            textBox10 = new TextBox();
            deptCountriesComboBox = new ComboBox();
            comboBox1 = new ComboBox();
            deptDateTimePicker = new DateTimePicker();
            deptCountryLabel = new Label();
            arrivalCountryLabel = new Label();
            deptDateLabel = new Label();
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
            contentSplitContainer.Margin = new Padding(3, 2, 3, 2);
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.Panel2.Controls.Add(panel3);
            contentSplitContainer.Size = new Size(1109, 551);
            contentSplitContainer.SplitterDistance = 214;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(0, 43);
            signInButton.Margin = new Padding(3, 2, 3, 2);
            signInButton.Size = new Size(214, 43);
            // 
            // signUpButton
            // 
            signUpButton.Margin = new Padding(3, 2, 3, 2);
            signUpButton.Size = new Size(214, 43);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 488);
            helpButton.Margin = new Padding(3, 2, 3, 2);
            helpButton.Size = new Size(214, 63);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Location = new Point(0, 86);
            exploreFlightsButton.Margin = new Padding(3, 2, 3, 2);
            exploreFlightsButton.Size = new Size(214, 57);
            // 
            // panel3
            // 
            panel3.Controls.Add(textBox10);
            panel3.Controls.Add(RankCTextBox);
            panel3.Controls.Add(RankBTextBox);
            panel3.Controls.Add(textBox7);
            panel3.Controls.Add(RankATextBox);
            panel3.Controls.Add(SeatsAvailabilityTextBox);
            panel3.Controls.Add(ArrivalDateTextBox);
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
            panel3.Location = new Point(539, 0);
            panel3.Name = "panel3";
            panel3.Size = new Size(352, 551);
            panel3.TabIndex = 2;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(201, 248);
            label14.Name = "label14";
            label14.Size = new Size(63, 15);
            label14.TabIndex = 43;
            label14.Text = "Class Price";
            // 
            // ClassPriceTextBox
            // 
            ClassPriceTextBox.Location = new Point(28, 275);
            ClassPriceTextBox.Name = "ClassPriceTextBox";
            ClassPriceTextBox.ReadOnly = true;
            ClassPriceTextBox.Size = new Size(113, 23);
            ClassPriceTextBox.TabIndex = 42;
            ClassPriceTextBox.Text = "Rank A";
            ClassPriceTextBox.TextAlign = HorizontalAlignment.Center;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(58, 248);
            label13.Name = "label13";
            label13.Size = new Size(34, 15);
            label13.TabIndex = 41;
            label13.Text = "Class";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(44, 191);
            label11.Name = "label11";
            label11.Size = new Size(85, 15);
            label11.TabIndex = 34;
            label11.Text = "Seats Available";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(236, 133);
            label7.Name = "label7";
            label7.Size = new Size(68, 15);
            label7.TabIndex = 11;
            label7.Text = "Arrival Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(44, 133);
            label6.Name = "label6";
            label6.Size = new Size(87, 15);
            label6.TabIndex = 9;
            label6.Text = "Arrival Country";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(36, 70);
            label5.Name = "label5";
            label5.Size = new Size(105, 15);
            label5.TabIndex = 7;
            label5.Text = "Departure Country";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(220, 70);
            label2.Name = "label2";
            label2.Size = new Size(84, 15);
            label2.TabIndex = 1;
            label2.Text = "Flight Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(116, 17);
            label1.Name = "label1";
            label1.Size = new Size(128, 25);
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
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(530, 548);
            panel1.TabIndex = 3;
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
            AdminFlightDataGrid.Columns.AddRange(new DataGridViewColumn[] { FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrivalDate, AvailableSeats, Rank1Price, Rank2Price, Rank3Price });
            AdminFlightDataGrid.Dock = DockStyle.Bottom;
            AdminFlightDataGrid.Location = new Point(0, 83);
            AdminFlightDataGrid.Margin = new Padding(3, 2, 3, 2);
            AdminFlightDataGrid.Name = "AdminFlightDataGrid";
            AdminFlightDataGrid.ReadOnly = true;
            AdminFlightDataGrid.RowTemplate.Height = 25;
            AdminFlightDataGrid.Size = new Size(530, 465);
            AdminFlightDataGrid.TabIndex = 33;
            AdminFlightDataGrid.CellContentClick += AdminFlightDataGrid_CellContentClick;
            // 
            // FlightNo
            // 
            FlightNo.HeaderText = "Flight Number";
            FlightNo.MinimumWidth = 6;
            FlightNo.Name = "FlightNo";
            FlightNo.ReadOnly = true;
            // 
            // deptDate
            // 
            deptDate.HeaderText = "Departure Date";
            deptDate.MinimumWidth = 6;
            deptDate.Name = "deptDate";
            deptDate.ReadOnly = true;
            // 
            // deptCountry
            // 
            deptCountry.HeaderText = "Departure Country";
            deptCountry.MinimumWidth = 6;
            deptCountry.Name = "deptCountry";
            deptCountry.ReadOnly = true;
            // 
            // arrivalCountry
            // 
            arrivalCountry.HeaderText = "Arrival Country";
            arrivalCountry.MinimumWidth = 6;
            arrivalCountry.Name = "arrivalCountry";
            arrivalCountry.ReadOnly = true;
            // 
            // expectedArrivalDate
            // 
            expectedArrivalDate.HeaderText = "Expected Arrival Date";
            expectedArrivalDate.MinimumWidth = 6;
            expectedArrivalDate.Name = "expectedArrivalDate";
            expectedArrivalDate.ReadOnly = true;
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
            // DepartureTextBox
            // 
            DepartureTextBox.Location = new Point(20, 95);
            DepartureTextBox.Name = "DepartureTextBox";
            DepartureTextBox.Size = new Size(138, 23);
            DepartureTextBox.TabIndex = 46;
            DepartureTextBox.TextChanged += DepartureTextBox_TextChanged;
            // 
            // FlightNumberTextBox
            // 
            FlightNumberTextBox.Location = new Point(201, 95);
            FlightNumberTextBox.Name = "FlightNumberTextBox";
            FlightNumberTextBox.Size = new Size(135, 23);
            FlightNumberTextBox.TabIndex = 47;
            FlightNumberTextBox.TextChanged += FlightNumberTextBox_TextChanged;
            // 
            // ArrivalCountryTextBox
            // 
            ArrivalCountryTextBox.Location = new Point(20, 151);
            ArrivalCountryTextBox.Name = "ArrivalCountryTextBox";
            ArrivalCountryTextBox.Size = new Size(135, 23);
            ArrivalCountryTextBox.TabIndex = 48;
            ArrivalCountryTextBox.TextChanged += ArrivalCountryTextBox_TextChanged;
            // 
            // ArrivalDateTextBox
            // 
            ArrivalDateTextBox.Location = new Point(201, 151);
            ArrivalDateTextBox.Name = "ArrivalDateTextBox";
            ArrivalDateTextBox.Size = new Size(135, 23);
            ArrivalDateTextBox.TabIndex = 49;
            ArrivalDateTextBox.TextChanged += ArrivalDateTextBox_TextChanged;
            // 
            // SeatsAvailabilityTextBox
            // 
            SeatsAvailabilityTextBox.Location = new Point(20, 209);
            SeatsAvailabilityTextBox.Name = "SeatsAvailabilityTextBox";
            SeatsAvailabilityTextBox.Size = new Size(135, 23);
            SeatsAvailabilityTextBox.TabIndex = 50;
            SeatsAvailabilityTextBox.TextChanged += SeatsAvailabilityTextBox_TextChanged;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(116, 471);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(101, 23);
            confirmButton.TabIndex = 38;
            confirmButton.Text = "Confirm Update";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // RankATextBox
            // 
            RankATextBox.Location = new Point(189, 275);
            RankATextBox.Name = "RankATextBox";
            RankATextBox.Size = new Size(115, 23);
            RankATextBox.TabIndex = 51;
            RankATextBox.TextChanged += RankATextBox_TextChanged;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(28, 317);
            textBox7.Name = "textBox7";
            textBox7.ReadOnly = true;
            textBox7.Size = new Size(113, 23);
            textBox7.TabIndex = 52;
            textBox7.Text = "Rank B";
            textBox7.TextAlign = HorizontalAlignment.Center;
            // 
            // RankBTextBox
            // 
            RankBTextBox.Location = new Point(189, 317);
            RankBTextBox.Name = "RankBTextBox";
            RankBTextBox.Size = new Size(115, 23);
            RankBTextBox.TabIndex = 53;
            RankBTextBox.TextChanged += RankBTextBox_TextChanged;
            // 
            // RankCTextBox
            // 
            RankCTextBox.Location = new Point(189, 360);
            RankCTextBox.Name = "RankCTextBox";
            RankCTextBox.Size = new Size(115, 23);
            RankCTextBox.TabIndex = 54;
            RankCTextBox.TextChanged += RankCTextBox_TextChanged;
            // 
            // textBox10
            // 
            textBox10.Location = new Point(28, 360);
            textBox10.Name = "textBox10";
            textBox10.ReadOnly = true;
            textBox10.Size = new Size(113, 23);
            textBox10.TabIndex = 55;
            textBox10.Text = "Rank C";
            textBox10.TextAlign = HorizontalAlignment.Center;
            // 
            // deptCountriesComboBox
            // 
            deptCountriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deptCountriesComboBox.FormattingEnabled = true;
            deptCountriesComboBox.Location = new Point(19, 40);
            deptCountriesComboBox.Name = "deptCountriesComboBox";
            deptCountriesComboBox.Size = new Size(121, 23);
            deptCountriesComboBox.TabIndex = 34;
            deptCountriesComboBox.SelectedIndexChanged += deptCountriesComboBox_SelectedIndexChanged;
            // 
            // comboBox1
            // 
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(171, 40);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 35;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // deptDateTimePicker
            // 
            deptDateTimePicker.Location = new Point(317, 40);
            deptDateTimePicker.Name = "deptDateTimePicker";
            deptDateTimePicker.Size = new Size(200, 23);
            deptDateTimePicker.TabIndex = 36;
            deptDateTimePicker.ValueChanged += deptDateTimePicker_ValueChanged;
            // 
            // deptCountryLabel
            // 
            deptCountryLabel.AutoSize = true;
            deptCountryLabel.Location = new Point(19, 22);
            deptCountryLabel.Name = "deptCountryLabel";
            deptCountryLabel.Size = new Size(105, 15);
            deptCountryLabel.TabIndex = 37;
            deptCountryLabel.Text = "Departure Country";
            // 
            // arrivalCountryLabel
            // 
            arrivalCountryLabel.AutoSize = true;
            arrivalCountryLabel.Location = new Point(171, 25);
            arrivalCountryLabel.Name = "arrivalCountryLabel";
            arrivalCountryLabel.Size = new Size(87, 15);
            arrivalCountryLabel.TabIndex = 38;
            arrivalCountryLabel.Text = "Arrival Country";
            // 
            // deptDateLabel
            // 
            deptDateLabel.AutoSize = true;
            deptDateLabel.Location = new Point(317, 25);
            deptDateLabel.Name = "deptDateLabel";
            deptDateLabel.Size = new Size(86, 15);
            deptDateLabel.TabIndex = 39;
            deptDateLabel.Text = "Departure Date";
            // 
            // UpdateFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1109, 551);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UpdateFlight";
            Text = "UpdateFlight";
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
        private DataGridViewTextBoxColumn FlightNo;
        private DataGridViewTextBoxColumn deptDate;
        private DataGridViewTextBoxColumn deptCountry;
        private DataGridViewTextBoxColumn arrivalCountry;
        private DataGridViewTextBoxColumn expectedArrivalDate;
        private DataGridViewTextBoxColumn AvailableSeats;
        private DataGridViewTextBoxColumn Rank1Price;
        private DataGridViewTextBoxColumn Rank2Price;
        private DataGridViewTextBoxColumn Rank3Price;
        private TextBox SeatsAvailabilityTextBox;
        private TextBox ArrivalDateTextBox;
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
    }
}