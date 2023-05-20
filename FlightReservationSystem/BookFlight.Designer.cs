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
            contentSplitContainer.Margin = new Padding(3, 5, 3, 5);
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.SplitterDistance = 230;
            contentSplitContainer.SplitterWidth = 6;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(0, 76);
            signInButton.Margin = new Padding(3, 4, 3, 4);
            signInButton.Size = new Size(230, 76);
            // 
            // signUpButton
            // 
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Size = new Size(230, 76);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 681);
            helpButton.Margin = new Padding(3, 7, 3, 7);
            helpButton.Size = new Size(230, 112);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Location = new Point(0, 152);
            exploreFlightsButton.Margin = new Padding(3, 5, 3, 5);
            exploreFlightsButton.Size = new Size(230, 76);
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
            panel1.Size = new Size(1115, 793);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
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
            // confirmButton
            // 
            confirmButton.Location = new Point(210, 624);
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
            cvvCreditCardTextBox.Location = new Point(155, 569);
            cvvCreditCardTextBox.Margin = new Padding(3, 4, 3, 4);
            cvvCreditCardTextBox.Name = "cvvCreditCardTextBox";
            cvvCreditCardTextBox.Size = new Size(236, 27);
            cvvCreditCardTextBox.TabIndex = 33;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(109, 573);
            label10.Name = "label10";
            label10.Size = new Size(36, 20);
            label10.TabIndex = 32;
            label10.Text = "CVV";
            // 
            // creditCardExpiryDateTextBox
            // 
            creditCardExpiryDateTextBox.Location = new Point(155, 531);
            creditCardExpiryDateTextBox.Margin = new Padding(3, 4, 3, 4);
            creditCardExpiryDateTextBox.Name = "creditCardExpiryDateTextBox";
            creditCardExpiryDateTextBox.Size = new Size(236, 27);
            creditCardExpiryDateTextBox.TabIndex = 31;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(66, 535);
            label9.Name = "label9";
            label9.Size = new Size(85, 20);
            label9.TabIndex = 30;
            label9.Text = "Expiry Date";
            // 
            // creditCardTextBox
            // 
            creditCardTextBox.Location = new Point(154, 492);
            creditCardTextBox.Margin = new Padding(3, 4, 3, 4);
            creditCardTextBox.Name = "creditCardTextBox";
            creditCardTextBox.Size = new Size(236, 27);
            creditCardTextBox.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(9, 499);
            label8.Name = "label8";
            label8.Size = new Size(142, 20);
            label8.TabIndex = 28;
            label8.Text = "Credit Card Number";
            // 
            // passportDateTimePicker
            // 
            passportDateTimePicker.Location = new Point(154, 439);
            passportDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            passportDateTimePicker.Name = "passportDateTimePicker";
            passportDateTimePicker.Size = new Size(236, 27);
            passportDateTimePicker.TabIndex = 27;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 444);
            label4.Name = "label4";
            label4.Size = new Size(144, 20);
            label4.TabIndex = 15;
            label4.Text = "Passport Expiry Date";
            // 
            // passportNumberTextBox
            // 
            passportNumberTextBox.Location = new Point(154, 400);
            passportNumberTextBox.Margin = new Padding(3, 4, 3, 4);
            passportNumberTextBox.Name = "passportNumberTextBox";
            passportNumberTextBox.Size = new Size(236, 27);
            passportNumberTextBox.TabIndex = 14;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 404);
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
            panel2.Location = new Point(3, 16);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(637, 773);
            panel2.TabIndex = 0;
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
            this.flightDataGrid.Name = "flightDataGrid";
            this.flightDataGrid.ReadOnly = true;
            this.flightDataGrid.RowTemplate.Height = 25;
            this.flightDataGrid.Size = new System.Drawing.Size(557, 481);
            this.flightDataGrid.TabIndex = 32;
            this.flightDataGrid.CellClick += flightDataGrid_CellClick;
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
            // Rank1Price
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
    }
}