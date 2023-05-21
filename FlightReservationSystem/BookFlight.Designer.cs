﻿using System.Windows.Forms;

namespace FlightReservationSystem
{
    partial class BookFlight
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
        private new void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            label15 = new Label();
            TotalPriceTextBox = new TextBox();
            label14 = new Label();
            ClassPriceTextBox = new TextBox();
            label13 = new Label();
            ClassComboBox = new ComboBox();
            confirmButton = new Button();
            seatsNumericUpDown = new NumericUpDown();
            label12 = new Label();
            seatsAvailableTextBox = new TextBox();
            label11 = new Label();
            cvvCreditCardTextBox = new TextBox();
            label10 = new Label();
            creditCardExpiryDateTextBox = new TextBox();
            label9 = new Label();
            creditCardTextBox = new TextBox();
            label8 = new Label();
            passportDateTimePicker = new TextBox();
            label4 = new Label();
            passportNumberTextBox = new TextBox();
            label3 = new Label();
            arrivalDateTextBox = new TextBox();
            label7 = new Label();
            arrivalCountryTextBox = new TextBox();
            label6 = new Label();
            deptCountryTextBox = new TextBox();
            label5 = new Label();
            flightNoTextBox = new TextBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            flightDataGrid = new DataGridView();
            FlightNo = new DataGridViewTextBoxColumn();
            deptDate = new DataGridViewTextBoxColumn();
            deptCountry = new DataGridViewTextBoxColumn();
            arrivalCountry = new DataGridViewTextBoxColumn();
            expectedArrivalDate = new DataGridViewTextBoxColumn();
            AvailableSeats = new DataGridViewTextBoxColumn();
            Rank1Price = new DataGridViewTextBoxColumn();
            Rank2Price = new DataGridViewTextBoxColumn();
            Rank3Price = new DataGridViewTextBoxColumn();
            arrivalCountryLabel = new Label();
            arrivalCountriesComboBox = new ComboBox();
            deptCountryLabel = new Label();
            deptCountriesComboBox = new ComboBox();
            deptDateLabel = new Label();
            deptDateTimePicker = new DateTimePicker();
            textBox1 = new TextBox();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)seatsNumericUpDown).BeginInit();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flightDataGrid).BeginInit();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            contentSplitContainer.Margin = new Padding(3, 5, 3, 5);
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.SplitterDistance = 262;
            contentSplitContainer.SplitterWidth = 6;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(0, 76);
            signInButton.Margin = new Padding(3, 4, 3, 4);
            signInButton.Size = new Size(262, 76);
            // 
            // signUpButton
            // 
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Size = new Size(262, 76);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 681);
            helpButton.Margin = new Padding(3, 7, 3, 7);
            helpButton.Size = new Size(262, 112);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Location = new Point(0, 152);
            // 
            // bookFlightButton
            // 
            bookFlightButton.Size = new Size(230, 63);
            bookFlightButton.TabIndex = 4;
            // 
            // panel1
            // 
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1083, 793);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.Controls.Add(label15);
            panel3.Controls.Add(TotalPriceTextBox);
            panel3.Controls.Add(label14);
            panel3.Controls.Add(ClassPriceTextBox);
            panel3.Controls.Add(label13);
            panel3.Controls.Add(ClassComboBox);
            panel3.Controls.Add(confirmButton);
            panel3.Controls.Add(seatsNumericUpDown);
            panel3.Controls.Add(label12);
            panel3.Controls.Add(seatsAvailableTextBox);
            panel3.Controls.Add(label11);
            panel3.Controls.Add(cvvCreditCardTextBox);
            panel3.Controls.Add(label10);
            panel3.Controls.Add(creditCardExpiryDateTextBox);
            panel3.Controls.Add(label9);
            panel3.Controls.Add(creditCardTextBox);
            panel3.Controls.Add(label8);
            panel3.Controls.Add(passportDateTimePicker);
            panel3.Controls.Add(label4);
            panel3.Controls.Add(passportNumberTextBox);
            panel3.Controls.Add(label3);
            panel3.Controls.Add(arrivalDateTextBox);
            panel3.Controls.Add(label7);
            panel3.Controls.Add(arrivalCountryTextBox);
            panel3.Controls.Add(label6);
            panel3.Controls.Add(deptCountryTextBox);
            panel3.Controls.Add(label5);
            panel3.Controls.Add(flightNoTextBox);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(647, 16);
            panel3.Margin = new Padding(3, 4, 3, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(433, 773);
            panel3.TabIndex = 1;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(81, 439);
            label15.Name = "label15";
            label15.Size = new Size(78, 20);
            label15.TabIndex = 45;
            label15.Text = "Total Price";
            // 
            // TotalPriceTextBox
            // 
            TotalPriceTextBox.Location = new Point(158, 428);
            TotalPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            TotalPriceTextBox.Name = "TotalPriceTextBox";
            TotalPriceTextBox.ReadOnly = true;
            TotalPriceTextBox.Size = new Size(149, 27);
            TotalPriceTextBox.TabIndex = 44;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(299, 345);
            label14.Name = "label14";
            label14.Size = new Size(78, 20);
            label14.TabIndex = 43;
            label14.Text = "Class Price";
            // 
            // ClassPriceTextBox
            // 
            ClassPriceTextBox.Location = new Point(255, 369);
            ClassPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            ClassPriceTextBox.Name = "ClassPriceTextBox";
            ClassPriceTextBox.ReadOnly = true;
            ClassPriceTextBox.Size = new Size(145, 27);
            ClassPriceTextBox.TabIndex = 42;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(93, 345);
            label13.Name = "label13";
            label13.Size = new Size(42, 20);
            label13.TabIndex = 41;
            label13.Text = "Class";
            // 
            // ClassComboBox
            // 
            ClassComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ClassComboBox.FormattingEnabled = true;
            ClassComboBox.Location = new Point(40, 369);
            ClassComboBox.Margin = new Padding(3, 4, 3, 4);
            ClassComboBox.Name = "ClassComboBox";
            ClassComboBox.Size = new Size(157, 28);
            ClassComboBox.TabIndex = 40;
            ClassComboBox.SelectedValueChanged += ClassComboBox_SelectedValueChanged;
            // 
            // confirmButton
            // 
            confirmButton.Location = new Point(211, 712);
            confirmButton.Margin = new Padding(3, 4, 3, 4);
            confirmButton.Name = "confirmButton";
            confirmButton.Size = new Size(115, 31);
            confirmButton.TabIndex = 38;
            confirmButton.Text = "Confirm Booking";
            confirmButton.UseVisualStyleBackColor = true;
            confirmButton.Click += confirmButton_Click;
            // 
            // seatsNumericUpDown
            // 
            seatsNumericUpDown.Location = new Point(255, 295);
            seatsNumericUpDown.Margin = new Padding(3, 4, 3, 4);
            seatsNumericUpDown.Name = "seatsNumericUpDown";
            seatsNumericUpDown.Size = new Size(137, 27);
            seatsNumericUpDown.TabIndex = 37;
            seatsNumericUpDown.ValueChanged += seatsNumericUpDown_UpButton;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(279, 269);
            label12.Name = "label12";
            label12.Size = new Size(102, 20);
            label12.TabIndex = 36;
            label12.Text = "Seats To Book";
            // 
            // seatsAvailableTextBox
            // 
            seatsAvailableTextBox.Location = new Point(37, 293);
            seatsAvailableTextBox.Margin = new Padding(3, 4, 3, 4);
            seatsAvailableTextBox.Name = "seatsAvailableTextBox";
            seatsAvailableTextBox.ReadOnly = true;
            seatsAvailableTextBox.Size = new Size(161, 27);
            seatsAvailableTextBox.TabIndex = 35;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(67, 269);
            label11.Name = "label11";
            label11.Size = new Size(110, 20);
            label11.TabIndex = 34;
            label11.Text = "Seats Available";
            // 
            // cvvCreditCardTextBox
            // 
            cvvCreditCardTextBox.Location = new Point(157, 657);
            cvvCreditCardTextBox.Margin = new Padding(3, 4, 3, 4);
            cvvCreditCardTextBox.Name = "cvvCreditCardTextBox";
            cvvCreditCardTextBox.Size = new Size(236, 27);
            cvvCreditCardTextBox.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(110, 661);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 32;
            label10.Text = "CVV";
            // 
            // creditCardExpiryDateTextBox
            // 
            creditCardExpiryDateTextBox.Location = new Point(157, 619);
            creditCardExpiryDateTextBox.Margin = new Padding(3, 4, 3, 4);
            creditCardExpiryDateTextBox.Name = "creditCardExpiryDateTextBox";
            creditCardExpiryDateTextBox.Size = new Size(236, 27);
            creditCardExpiryDateTextBox.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(67, 623);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 30;
            label9.Text = "Expiry Date";
            // 
            // creditCardTextBox
            // 
            creditCardTextBox.Location = new Point(155, 580);
            creditCardTextBox.Margin = new Padding(3, 4, 3, 4);
            creditCardTextBox.Name = "creditCardTextBox";
            creditCardTextBox.Size = new Size(236, 27);
            creditCardTextBox.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(10, 587);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 28;
            label8.Text = "Credit Card Number";
            // 
            // passportDateTimePicker
            // 
            passportDateTimePicker.Location = new Point(155, 527);
            passportDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            passportDateTimePicker.Name = "passportDateTimePicker";
            passportDateTimePicker.Size = new Size(236, 27);
            passportDateTimePicker.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 532);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 15;
            label4.Text = "Passport Expiry Date";
            // 
            // passportNumberTextBox
            // 
            passportNumberTextBox.Location = new Point(155, 488);
            passportNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            passportNumberTextBox.Name = "passportNumberTextBox";
            passportNumberTextBox.Size = new Size(236, 27);
            passportNumberTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(35, 492);
            label3.Name = "label3";
            label3.Size = new Size(122, 20);
            label3.TabIndex = 13;
            label3.Text = "Passport Number";
            // 
            // arrivalDateTextBox
            // 
            arrivalDateTextBox.Location = new Point(248, 216);
            arrivalDateTextBox.Margin = new Padding(3, 4, 3, 4);
            arrivalDateTextBox.Name = "arrivalDateTextBox";
            arrivalDateTextBox.ReadOnly = true;
            arrivalDateTextBox.Size = new Size(161, 27);
            arrivalDateTextBox.TabIndex = 12;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(287, 192);
            label7.Name = "label7";
            label7.Size = new Size(88, 20);
            label7.TabIndex = 11;
            label7.Text = "Arrival Date";
            // 
            // arrivalCountryTextBox
            // 
            arrivalCountryTextBox.Location = new Point(37, 216);
            arrivalCountryTextBox.Margin = new Padding(3, 4, 3, 4);
            arrivalCountryTextBox.Name = "arrivalCountryTextBox";
            arrivalCountryTextBox.ReadOnly = true;
            arrivalCountryTextBox.Size = new Size(161, 27);
            arrivalCountryTextBox.TabIndex = 10;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(67, 192);
            label6.Name = "label6";
            label6.Size = new Size(107, 20);
            label6.TabIndex = 9;
            label6.Text = "Arrival Country";
            // 
            // deptCountryTextBox
            // 
            deptCountryTextBox.Location = new Point(37, 132);
            deptCountryTextBox.Margin = new Padding(3, 4, 3, 4);
            deptCountryTextBox.Name = "deptCountryTextBox";
            deptCountryTextBox.ReadOnly = true;
            deptCountryTextBox.Size = new Size(161, 27);
            deptCountryTextBox.TabIndex = 8;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(58, 108);
            label5.Name = "label5";
            label5.Size = new Size(131, 20);
            label5.TabIndex = 7;
            label5.Text = "Departure Country";
            // 
            // flightNoTextBox
            // 
            flightNoTextBox.Location = new Point(248, 132);
            flightNoTextBox.Margin = new Padding(3, 4, 3, 4);
            flightNoTextBox.Name = "flightNoTextBox";
            flightNoTextBox.ReadOnly = true;
            flightNoTextBox.Size = new Size(161, 27);
            flightNoTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(275, 108);
            label2.Name = "label2";
            label2.Size = new Size(104, 20);
            label2.TabIndex = 1;
            label2.Text = "Flight Number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(137, 23);
            label1.Name = "label1";
            label1.Size = new Size(172, 32);
            label1.TabIndex = 0;
            label1.Text = "Booking Flight";
            // 
            // panel2
            // 
            panel2.Controls.Add(flightDataGrid);
            panel2.Controls.Add(arrivalCountryLabel);
            panel2.Controls.Add(arrivalCountriesComboBox);
            panel2.Controls.Add(deptCountryLabel);
            panel2.Controls.Add(deptCountriesComboBox);
            panel2.Controls.Add(deptDateLabel);
            panel2.Controls.Add(deptDateTimePicker);
            panel2.Location = new Point(9, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 773);
            panel2.TabIndex = 0;
            // 
            // flightDataGrid
            // 
            flightDataGrid.AllowUserToAddRows = false;
            flightDataGrid.AllowUserToDeleteRows = false;
            flightDataGrid.AllowUserToResizeColumns = false;
            flightDataGrid.AllowUserToResizeRows = false;
            flightDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            flightDataGrid.BackgroundColor = SystemColors.Control;
            flightDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            flightDataGrid.Columns.AddRange(new DataGridViewColumn[] { FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrivalDate, AvailableSeats, Rank1Price, Rank2Price, Rank3Price });
            flightDataGrid.Dock = DockStyle.Bottom;
            flightDataGrid.Location = new Point(0, 132);
            flightDataGrid.Name = "flightDataGrid";
            flightDataGrid.ReadOnly = true;
            flightDataGrid.RowHeadersWidth = 51;
            flightDataGrid.RowTemplate.Height = 25;
            flightDataGrid.Size = new Size(637, 641);
            flightDataGrid.TabIndex = 32;
            flightDataGrid.CellClick += flightDataGrid_CellClick;
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
            // arrivalCountryLabel
            // 
            arrivalCountryLabel.AutoSize = true;
            arrivalCountryLabel.Location = new Point(197, 21);
            arrivalCountryLabel.Name = "arrivalCountryLabel";
            arrivalCountryLabel.Size = new Size(107, 20);
            arrivalCountryLabel.TabIndex = 31;
            arrivalCountryLabel.Text = "Arrival Country";
            // 
            // arrivalCountriesComboBox
            // 
            arrivalCountriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            arrivalCountriesComboBox.FormattingEnabled = true;
            arrivalCountriesComboBox.Location = new Point(178, 45);
            arrivalCountriesComboBox.Margin = new Padding(3, 4, 3, 4);
            arrivalCountriesComboBox.Name = "arrivalCountriesComboBox";
            arrivalCountriesComboBox.Size = new Size(138, 28);
            arrivalCountriesComboBox.TabIndex = 30;
            arrivalCountriesComboBox.DropDown += arrivalCountriesComboBox_OnDropDown;
            arrivalCountriesComboBox.TextChanged += bookFlightComboBox_Changed;
            // 
            // deptCountryLabel
            // 
            deptCountryLabel.AutoSize = true;
            deptCountryLabel.Location = new Point(27, 21);
            deptCountryLabel.Name = "deptCountryLabel";
            deptCountryLabel.Size = new Size(131, 20);
            deptCountryLabel.TabIndex = 29;
            deptCountryLabel.Text = "Departure Country";
            // 
            // deptCountriesComboBox
            // 
            deptCountriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deptCountriesComboBox.FormattingEnabled = true;
            deptCountriesComboBox.Location = new Point(19, 45);
            deptCountriesComboBox.Margin = new Padding(3, 4, 3, 4);
            deptCountriesComboBox.Name = "deptCountriesComboBox";
            deptCountriesComboBox.Size = new Size(138, 28);
            deptCountriesComboBox.TabIndex = 28;
            deptCountriesComboBox.DropDown += deptCountriesComboBox_OnDropDown;
            deptCountriesComboBox.TextChanged += bookFlightComboBox_Changed;
            // 
            // deptDateLabel
            // 
            deptDateLabel.AutoSize = true;
            deptDateLabel.Location = new Point(408, 21);
            deptDateLabel.Name = "deptDateLabel";
            deptDateLabel.Size = new Size(112, 20);
            deptDateLabel.TabIndex = 27;
            deptDateLabel.Text = "Departure Date";
            // 
            // deptDateTimePicker
            // 
            deptDateTimePicker.Location = new Point(352, 45);
            deptDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            deptDateTimePicker.Name = "deptDateTimePicker";
            deptDateTimePicker.Size = new Size(228, 27);
            deptDateTimePicker.TabIndex = 26;
            deptDateTimePicker.ValueChanged += bookFlightComboBox_Changed;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(138, 321);
            textBox1.Name = "textBox1";
            textBox1.ReadOnly = true;
            textBox1.Size = new Size(131, 27);
            textBox1.TabIndex = 44;
            // 
            // BookFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 793);
            Margin = new Padding(3, 5, 3, 5);
            Name = "BookFlight";
            Text = "BookFlight";
            Load += BookFlight_Load;
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)seatsNumericUpDown).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flightDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private DataGridView flightDataGrid;
        private DataGridViewTextBoxColumn FlightNo;
        private DataGridViewTextBoxColumn deptDate;
        private DataGridViewTextBoxColumn deptCountry;
        private DataGridViewTextBoxColumn arrivalCountry;
        private DataGridViewTextBoxColumn expectedArrivalDate;
        private DataGridViewTextBoxColumn AvailableSeats;
        private DataGridViewTextBoxColumn Rank1Price;
        private DataGridViewTextBoxColumn Rank2Price;
        private DataGridViewTextBoxColumn Rank3Price;
        private Label arrivalCountryLabel;
        private ComboBox arrivalCountriesComboBox;
        private Label deptCountryLabel;
        private ComboBox deptCountriesComboBox;
        private Label deptDateLabel;
        private DateTimePicker deptDateTimePicker;
        private Label label1;
        private TextBox arrivalDateTextBox;
        private Label label7;
        private TextBox arrivalCountryTextBox;
        private TextBox textBox1;
        private Label label6;
        private TextBox deptCountryTextBox;
        private Label label5;
        private TextBox flightNoTextBox;
        private Label label2;
        private Button confirmButton;
        private NumericUpDown seatsNumericUpDown;
        private Label label12;
        private TextBox seatsAvailableTextBox;
        private Label label11;
        private TextBox cvvCreditCardTextBox;
        private Label label10;
        private TextBox creditCardExpiryDateTextBox;
        private Label label9;
        private TextBox creditCardTextBox;
        private Label label8;
        private TextBox passportDateTimePicker;
        private Label label4;
        private TextBox passportNumberTextBox;
        private Label label3;
        private Label label13;
        private ComboBox ClassComboBox;
        private Label label14;
        private TextBox ClassPriceTextBox;
        private Label label15;
        private TextBox TotalPriceTextBox;
    }
}