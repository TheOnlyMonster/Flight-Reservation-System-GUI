using System.Windows.Forms;

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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.TotalPriceTextBox = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.ClassPriceTextBox = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.ClassComboBox = new System.Windows.Forms.ComboBox();
            this.confirmButton = new System.Windows.Forms.Button();
            this.seatsNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.seatsAvailableTextBox = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cvvCreditCardTextBox = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.creditCardExpiryDateTextBox = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.creditCardTextBox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.passportDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.passportNumberTextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.arrivalDateTextBox = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.arrivalCountryTextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.deptCountryTextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.flightNoTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.flightDataGrid = new System.Windows.Forms.DataGridView();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank1Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank2Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank3Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountryLabel = new System.Windows.Forms.Label();
            this.arrivalCountriesComboBox = new System.Windows.Forms.ComboBox();
            this.deptCountryLabel = new System.Windows.Forms.Label();
            this.deptCountriesComboBox = new System.Windows.Forms.ComboBox();
            this.deptDateLabel = new System.Windows.Forms.Label();
            this.deptDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.panel1);
            this.contentSplitContainer.SplitterDistance = 262;
            this.contentSplitContainer.SplitterWidth = 5;
            // 
            // signInButton
            // 
            this.signInButton.Size = new System.Drawing.Size(262, 57);
            // 
            // signUpButton
            // 
            this.signUpButton.Size = new System.Drawing.Size(262, 57);
            // 
            // helpButton
            // 
            this.helpButton.Location = new System.Drawing.Point(0, 511);
            this.helpButton.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.helpButton.Size = new System.Drawing.Size(262, 84);
            // 
            // exploreFlightsButton
            // 
            this.exploreFlightsButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.exploreFlightsButton.Size = new System.Drawing.Size(262, 57);
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.Size = new System.Drawing.Size(230, 63);
            this.bookFlightButton.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 595);
            this.panel1.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.TotalPriceTextBox);
            this.panel3.Controls.Add(this.label14);
            this.panel3.Controls.Add(this.ClassPriceTextBox);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.ClassComboBox);
            this.panel3.Controls.Add(this.confirmButton);
            this.panel3.Controls.Add(this.seatsNumericUpDown);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.seatsAvailableTextBox);
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.cvvCreditCardTextBox);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.creditCardExpiryDateTextBox);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.creditCardTextBox);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.passportDateTimePicker);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.passportNumberTextBox);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.arrivalDateTextBox);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.arrivalCountryTextBox);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.deptCountryTextBox);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Controls.Add(this.flightNoTextBox);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Location = new System.Drawing.Point(566, 12);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(379, 580);
            this.panel3.TabIndex = 1;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(71, 329);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(61, 15);
            this.label15.TabIndex = 45;
            this.label15.Text = "Total Price";
            // 
            // TotalPriceTextBox
            // 
            this.TotalPriceTextBox.Location = new System.Drawing.Point(138, 321);
            this.TotalPriceTextBox.Name = "TotalPriceTextBox";
            this.TotalPriceTextBox.ReadOnly = true;
            this.TotalPriceTextBox.Size = new System.Drawing.Size(131, 23);
            this.TotalPriceTextBox.TabIndex = 44;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(262, 259);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 15);
            this.label14.TabIndex = 43;
            this.label14.Text = "Class Price";
            // 
            // ClassPriceTextBox
            // 
            this.ClassPriceTextBox.Location = new System.Drawing.Point(223, 277);
            this.ClassPriceTextBox.Name = "ClassPriceTextBox";
            this.ClassPriceTextBox.ReadOnly = true;
            this.ClassPriceTextBox.Size = new System.Drawing.Size(127, 23);
            this.ClassPriceTextBox.TabIndex = 42;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(81, 259);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(34, 15);
            this.label13.TabIndex = 41;
            this.label13.Text = "Class";
            // 
            // ClassComboBox
            // 
            this.ClassComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ClassComboBox.FormattingEnabled = true;
            this.ClassComboBox.Location = new System.Drawing.Point(35, 277);
            this.ClassComboBox.Name = "ClassComboBox";
            this.ClassComboBox.Size = new System.Drawing.Size(138, 23);
            this.ClassComboBox.TabIndex = 40;
            // 
            // confirmButton
            // 
            this.confirmButton.Location = new System.Drawing.Point(185, 534);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(101, 23);
            this.confirmButton.TabIndex = 38;
            this.confirmButton.Text = "Confirm Booking";
            this.confirmButton.UseVisualStyleBackColor = true;
            // 
            // seatsNumericUpDown
            // 
            this.seatsNumericUpDown.Location = new System.Drawing.Point(223, 221);
            this.seatsNumericUpDown.Name = "seatsNumericUpDown";
            this.seatsNumericUpDown.Size = new System.Drawing.Size(120, 23);
            this.seatsNumericUpDown.TabIndex = 37;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(244, 202);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(79, 15);
            this.label12.TabIndex = 36;
            this.label12.Text = "Seats To Book";
            // 
            // seatsAvailableTextBox
            // 
            this.seatsAvailableTextBox.Location = new System.Drawing.Point(32, 220);
            this.seatsAvailableTextBox.Name = "seatsAvailableTextBox";
            this.seatsAvailableTextBox.ReadOnly = true;
            this.seatsAvailableTextBox.Size = new System.Drawing.Size(141, 23);
            this.seatsAvailableTextBox.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(59, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(85, 15);
            this.label11.TabIndex = 34;
            this.label11.Text = "Seats Available";
            // 
            // cvvCreditCardTextBox
            // 
            this.cvvCreditCardTextBox.Location = new System.Drawing.Point(137, 493);
            this.cvvCreditCardTextBox.Name = "cvvCreditCardTextBox";
            this.cvvCreditCardTextBox.Size = new System.Drawing.Size(207, 23);
            this.cvvCreditCardTextBox.TabIndex = 33;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(96, 496);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(29, 15);
            this.label10.TabIndex = 32;
            this.label10.Text = "CVV";
            // 
            // creditCardExpiryDateTextBox
            // 
            this.creditCardExpiryDateTextBox.Location = new System.Drawing.Point(137, 464);
            this.creditCardExpiryDateTextBox.Name = "creditCardExpiryDateTextBox";
            this.creditCardExpiryDateTextBox.Size = new System.Drawing.Size(207, 23);
            this.creditCardExpiryDateTextBox.TabIndex = 31;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(59, 467);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(66, 15);
            this.label9.TabIndex = 30;
            this.label9.Text = "Expiry Date";
            // 
            // creditCardTextBox
            // 
            this.creditCardTextBox.Location = new System.Drawing.Point(136, 435);
            this.creditCardTextBox.Name = "creditCardTextBox";
            this.creditCardTextBox.Size = new System.Drawing.Size(207, 23);
            this.creditCardTextBox.TabIndex = 29;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 440);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(114, 15);
            this.label8.TabIndex = 28;
            this.label8.Text = "Credit Card Number";
            // 
            // passportDateTimePicker
            // 
            this.passportDateTimePicker.Location = new System.Drawing.Point(136, 395);
            this.passportDateTimePicker.Name = "passportDateTimePicker";
            this.passportDateTimePicker.Size = new System.Drawing.Size(207, 23);
            this.passportDateTimePicker.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 399);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 15);
            this.label4.TabIndex = 15;
            this.label4.Text = "Passport Expiry Date";
            // 
            // passportNumberTextBox
            // 
            this.passportNumberTextBox.Location = new System.Drawing.Point(136, 366);
            this.passportNumberTextBox.Name = "passportNumberTextBox";
            this.passportNumberTextBox.Size = new System.Drawing.Size(207, 23);
            this.passportNumberTextBox.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 369);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 15);
            this.label3.TabIndex = 13;
            this.label3.Text = "Passport Number";
            // 
            // arrivalDateTextBox
            // 
            this.arrivalDateTextBox.Location = new System.Drawing.Point(217, 162);
            this.arrivalDateTextBox.Name = "arrivalDateTextBox";
            this.arrivalDateTextBox.ReadOnly = true;
            this.arrivalDateTextBox.Size = new System.Drawing.Size(141, 23);
            this.arrivalDateTextBox.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(251, 144);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(68, 15);
            this.label7.TabIndex = 11;
            this.label7.Text = "Arrival Date";
            // 
            // arrivalCountryTextBox
            // 
            this.arrivalCountryTextBox.Location = new System.Drawing.Point(32, 162);
            this.arrivalCountryTextBox.Name = "arrivalCountryTextBox";
            this.arrivalCountryTextBox.ReadOnly = true;
            this.arrivalCountryTextBox.Size = new System.Drawing.Size(141, 23);
            this.arrivalCountryTextBox.TabIndex = 10;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 144);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 15);
            this.label6.TabIndex = 9;
            this.label6.Text = "Arrival Country";
            // 
            // deptCountryTextBox
            // 
            this.deptCountryTextBox.Location = new System.Drawing.Point(32, 99);
            this.deptCountryTextBox.Name = "deptCountryTextBox";
            this.deptCountryTextBox.ReadOnly = true;
            this.deptCountryTextBox.Size = new System.Drawing.Size(141, 23);
            this.deptCountryTextBox.TabIndex = 8;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 81);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 15);
            this.label5.TabIndex = 7;
            this.label5.Text = "Departure Country";
            // 
            // flightNoTextBox
            // 
            this.flightNoTextBox.Location = new System.Drawing.Point(217, 99);
            this.flightNoTextBox.Name = "flightNoTextBox";
            this.flightNoTextBox.ReadOnly = true;
            this.flightNoTextBox.Size = new System.Drawing.Size(141, 23);
            this.flightNoTextBox.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(241, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Flight Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(120, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(136, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Booking Flight";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.flightDataGrid);
            this.panel2.Controls.Add(this.arrivalCountryLabel);
            this.panel2.Controls.Add(this.arrivalCountriesComboBox);
            this.panel2.Controls.Add(this.deptCountryLabel);
            this.panel2.Controls.Add(this.deptCountriesComboBox);
            this.panel2.Controls.Add(this.deptDateLabel);
            this.panel2.Controls.Add(this.deptDateTimePicker);
            this.panel2.Location = new System.Drawing.Point(8, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(557, 580);
            this.panel2.TabIndex = 0;
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
            this.expectedArrivalDate,
            this.AvailableSeats,
            this.Rank1Price,
            this.Rank2Price,
            this.Rank3Price});
            this.flightDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flightDataGrid.Location = new System.Drawing.Point(0, 99);
            this.flightDataGrid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.flightDataGrid.Name = "flightDataGrid";
            this.flightDataGrid.ReadOnly = true;
            this.flightDataGrid.RowHeadersWidth = 51;
            this.flightDataGrid.RowTemplate.Height = 25;
            this.flightDataGrid.Size = new System.Drawing.Size(557, 481);
            this.flightDataGrid.TabIndex = 32;
            // 
            // FlightNo
            // 
            this.FlightNo.HeaderText = "Flight Number";
            this.FlightNo.MinimumWidth = 6;
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            // 
            // deptDate
            // 
            this.deptDate.HeaderText = "Departure Date";
            this.deptDate.MinimumWidth = 6;
            this.deptDate.Name = "deptDate";
            this.deptDate.ReadOnly = true;
            // 
            // deptCountry
            // 
            this.deptCountry.HeaderText = "Departure Country";
            this.deptCountry.MinimumWidth = 6;
            this.deptCountry.Name = "deptCountry";
            this.deptCountry.ReadOnly = true;
            // 
            // arrivalCountry
            // 
            this.arrivalCountry.HeaderText = "Arrival Country";
            this.arrivalCountry.MinimumWidth = 6;
            this.arrivalCountry.Name = "arrivalCountry";
            this.arrivalCountry.ReadOnly = true;
            // 
            // expectedArrivalDate
            // 
            this.expectedArrivalDate.HeaderText = "Expected Arrival Date";
            this.expectedArrivalDate.MinimumWidth = 6;
            this.expectedArrivalDate.Name = "expectedArrivalDate";
            this.expectedArrivalDate.ReadOnly = true;
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.HeaderText = "Available Seats";
            this.AvailableSeats.MinimumWidth = 6;
            this.AvailableSeats.Name = "AvailableSeats";
            this.AvailableSeats.ReadOnly = true;
            // 
            // Rank1Price
            // 
            this.Rank1Price.HeaderText = "Rank A Price";
            this.Rank1Price.MinimumWidth = 6;
            this.Rank1Price.Name = "Rank1Price";
            this.Rank1Price.ReadOnly = true;
            // 
            // Rank2Price
            // 
            this.Rank2Price.HeaderText = "Rank B Price";
            this.Rank2Price.MinimumWidth = 6;
            this.Rank2Price.Name = "Rank2Price";
            this.Rank2Price.ReadOnly = true;
            // 
            // Rank3Price
            // 
            this.Rank3Price.HeaderText = "Rank C Price";
            this.Rank3Price.MinimumWidth = 6;
            this.Rank3Price.Name = "Rank3Price";
            this.Rank3Price.ReadOnly = true;
            // 
            // arrivalCountryLabel
            // 
            this.arrivalCountryLabel.AutoSize = true;
            this.arrivalCountryLabel.Location = new System.Drawing.Point(172, 16);
            this.arrivalCountryLabel.Name = "arrivalCountryLabel";
            this.arrivalCountryLabel.Size = new System.Drawing.Size(87, 15);
            this.arrivalCountryLabel.TabIndex = 31;
            this.arrivalCountryLabel.Text = "Arrival Country";
            // 
            // arrivalCountriesComboBox
            // 
            this.arrivalCountriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrivalCountriesComboBox.FormattingEnabled = true;
            this.arrivalCountriesComboBox.Location = new System.Drawing.Point(156, 34);
            this.arrivalCountriesComboBox.Name = "arrivalCountriesComboBox";
            this.arrivalCountriesComboBox.Size = new System.Drawing.Size(121, 23);
            this.arrivalCountriesComboBox.TabIndex = 30;
            // 
            // deptCountryLabel
            // 
            this.deptCountryLabel.AutoSize = true;
            this.deptCountryLabel.Location = new System.Drawing.Point(24, 16);
            this.deptCountryLabel.Name = "deptCountryLabel";
            this.deptCountryLabel.Size = new System.Drawing.Size(105, 15);
            this.deptCountryLabel.TabIndex = 29;
            this.deptCountryLabel.Text = "Departure Country";
            // 
            // deptCountriesComboBox
            // 
            this.deptCountriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptCountriesComboBox.FormattingEnabled = true;
            this.deptCountriesComboBox.Location = new System.Drawing.Point(17, 34);
            this.deptCountriesComboBox.Name = "deptCountriesComboBox";
            this.deptCountriesComboBox.Size = new System.Drawing.Size(121, 23);
            this.deptCountriesComboBox.TabIndex = 28;
            // 
            // deptDateLabel
            // 
            this.deptDateLabel.AutoSize = true;
            this.deptDateLabel.Location = new System.Drawing.Point(357, 16);
            this.deptDateLabel.Name = "deptDateLabel";
            this.deptDateLabel.Size = new System.Drawing.Size(86, 15);
            this.deptDateLabel.TabIndex = 27;
            this.deptDateLabel.Text = "Departure Date";
            // 
            // deptDateTimePicker
            // 
            this.deptDateTimePicker.Location = new System.Drawing.Point(308, 34);
            this.deptDateTimePicker.Name = "deptDateTimePicker";
            this.deptDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.deptDateTimePicker.TabIndex = 26;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(138, 321);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(131, 23);
            this.textBox1.TabIndex = 44;
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 595);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "BookFlight";
            this.Text = "BookFlight";
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.seatsNumericUpDown)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            this.ResumeLayout(false);

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
        private DateTimePicker passportDateTimePicker;
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