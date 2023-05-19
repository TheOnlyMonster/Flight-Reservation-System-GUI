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
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.flightDataGrid = new System.Windows.Forms.DataGridView();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.Controls.Add(this.bookFlightButton);
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.panel1);
            this.contentSplitContainer.SplitterDistance = 230;
            // 
            // signInButton
            // 
            this.signInButton.Location = new System.Drawing.Point(0, 120);
            this.signInButton.Size = new System.Drawing.Size(230, 57);
            // 
            // signUpButton
            // 
            this.signUpButton.Location = new System.Drawing.Point(0, 63);
            this.signUpButton.Size = new System.Drawing.Size(230, 57);
            // 
            // helpButton
            // 
            this.helpButton.Size = new System.Drawing.Size(230, 63);
            // 
            // exploreFlightsButton
            // 
            this.exploreFlightsButton.Location = new System.Drawing.Point(0, 177);
            this.exploreFlightsButton.Size = new System.Drawing.Size(230, 57);
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.Size = new System.Drawing.Size(230, 63);
            this.bookFlightButton.TabIndex = 4;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.flightDataGrid);
            this.panel1.Controls.Add(this.arrivalCountryLabel);
            this.panel1.Controls.Add(this.arrivalCountriesComboBox);
            this.panel1.Controls.Add(this.deptCountryLabel);
            this.panel1.Controls.Add(this.deptCountriesComboBox);
            this.panel1.Controls.Add(this.deptDateLabel);
            this.panel1.Controls.Add(this.deptDateTimePicker);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(948, 595);
            this.panel1.TabIndex = 0;
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
            this.flightDataGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.flightDataGrid.Location = new System.Drawing.Point(0, 114);
            this.flightDataGrid.Name = "flightDataGrid";
            this.flightDataGrid.ReadOnly = true;
            this.flightDataGrid.RowTemplate.Height = 25;
            this.flightDataGrid.Size = new System.Drawing.Size(948, 481);
            this.flightDataGrid.TabIndex = 18;
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
            // arrivalCountryLabel
            // 
            this.arrivalCountryLabel.AutoSize = true;
            this.arrivalCountryLabel.Location = new System.Drawing.Point(482, 11);
            this.arrivalCountryLabel.Name = "arrivalCountryLabel";
            this.arrivalCountryLabel.Size = new System.Drawing.Size(87, 15);
            this.arrivalCountryLabel.TabIndex = 17;
            this.arrivalCountryLabel.Text = "Arrival Country";
            // 
            // arrivalCountriesComboBox
            // 
            this.arrivalCountriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.arrivalCountriesComboBox.FormattingEnabled = true;
            this.arrivalCountriesComboBox.Location = new System.Drawing.Point(466, 29);
            this.arrivalCountriesComboBox.Name = "arrivalCountriesComboBox";
            this.arrivalCountriesComboBox.Size = new System.Drawing.Size(121, 23);
            this.arrivalCountriesComboBox.TabIndex = 16;
            this.arrivalCountriesComboBox.DropDown += new System.EventHandler(this.arrivalCountriesComboBox_OnDropDown);
            this.arrivalCountriesComboBox.TextChanged += new System.EventHandler(this.bookFlightComboBox_Changed);
            // 
            // deptCountryLabel
            // 
            this.deptCountryLabel.AutoSize = true;
            this.deptCountryLabel.Location = new System.Drawing.Point(327, 11);
            this.deptCountryLabel.Name = "deptCountryLabel";
            this.deptCountryLabel.Size = new System.Drawing.Size(105, 15);
            this.deptCountryLabel.TabIndex = 15;
            this.deptCountryLabel.Text = "Departure Country";
            // 
            // deptCountriesComboBox
            // 
            this.deptCountriesComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.deptCountriesComboBox.FormattingEnabled = true;
            this.deptCountriesComboBox.Location = new System.Drawing.Point(327, 29);
            this.deptCountriesComboBox.Name = "deptCountriesComboBox";
            this.deptCountriesComboBox.Size = new System.Drawing.Size(121, 23);
            this.deptCountriesComboBox.TabIndex = 14;
            this.deptCountriesComboBox.DropDown += new System.EventHandler(this.deptCountriesComboBox_OnDropDown);
            this.deptCountriesComboBox.TextChanged += new System.EventHandler(this.bookFlightComboBox_Changed);
            // 
            // deptDateLabel
            // 
            this.deptDateLabel.AutoSize = true;
            this.deptDateLabel.Location = new System.Drawing.Point(278, 74);
            this.deptDateLabel.Name = "deptDateLabel";
            this.deptDateLabel.Size = new System.Drawing.Size(86, 15);
            this.deptDateLabel.TabIndex = 13;
            this.deptDateLabel.Text = "Departure Date";
            // 
            // deptDateTimePicker
            // 
            this.deptDateTimePicker.Location = new System.Drawing.Point(370, 69);
            this.deptDateTimePicker.Name = "deptDateTimePicker";
            this.deptDateTimePicker.Size = new System.Drawing.Size(200, 23);
            this.deptDateTimePicker.TabIndex = 12;
            this.deptDateTimePicker.ValueChanged += new System.EventHandler(this.bookFlightComboBox_Changed);
            // 
            // BookFlight
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 595);
            this.Name = "BookFlight";
            this.Text = "BookFlight";
            this.Load += new System.EventHandler(this.BookFlight_Load);
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label arrivalCountryLabel;
        private ComboBox arrivalCountriesComboBox;
        private Label deptCountryLabel;
        private ComboBox deptCountriesComboBox;
        private Label deptDateLabel;
        private DateTimePicker deptDateTimePicker;
        private DataGridView flightDataGrid;
        private DataGridViewTextBoxColumn FlightNo;
        private DataGridViewTextBoxColumn deptDate;
        private DataGridViewTextBoxColumn deptCountry;
        private DataGridViewTextBoxColumn arrivalCountry;
        private DataGridViewTextBoxColumn expectedArrivalDate;
    }
}