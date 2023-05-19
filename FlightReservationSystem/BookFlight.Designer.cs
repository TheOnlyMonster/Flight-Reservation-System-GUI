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
            panel1 = new Panel();
            flightDataGrid = new DataGridView();
            FlightNo = new DataGridViewTextBoxColumn();
            deptDate = new DataGridViewTextBoxColumn();
            deptCountry = new DataGridViewTextBoxColumn();
            arrivalCountry = new DataGridViewTextBoxColumn();
            expectedArrivalDate = new DataGridViewTextBoxColumn();
            arrivalCountryLabel = new Label();
            arrivalCountriesComboBox = new ComboBox();
            deptCountryLabel = new Label();
            deptCountriesComboBox = new ComboBox();
            deptDateLabel = new Label();
            deptDateTimePicker = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flightDataGrid).BeginInit();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.SplitterDistance = 230;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(0, 76);
            signInButton.Margin = new Padding(3, 4, 3, 4);
            signInButton.Size = new Size(230, 76);
            signInButton.Click += signInButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Size = new Size(230, 76);
            // 
            // helpButton
            // 
            helpButton.Margin = new Padding(3, 5, 3, 5);
            helpButton.Size = new Size(230, 84);
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
            panel1.Controls.Add(flightDataGrid);
            panel1.Controls.Add(arrivalCountryLabel);
            panel1.Controls.Add(arrivalCountriesComboBox);
            panel1.Controls.Add(deptCountryLabel);
            panel1.Controls.Add(deptCountriesComboBox);
            panel1.Controls.Add(deptDateLabel);
            panel1.Controls.Add(deptDateTimePicker);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1116, 793);
            panel1.TabIndex = 0;
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
            flightDataGrid.Columns.AddRange(new DataGridViewColumn[] { FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrivalDate });
            flightDataGrid.Dock = DockStyle.Bottom;
            flightDataGrid.Location = new Point(0, 152);
            flightDataGrid.Margin = new Padding(3, 4, 3, 4);
            flightDataGrid.Name = "flightDataGrid";
            flightDataGrid.ReadOnly = true;
            flightDataGrid.RowHeadersWidth = 51;
            flightDataGrid.RowTemplate.Height = 25;
            flightDataGrid.Size = new Size(1116, 641);
            flightDataGrid.TabIndex = 18;
            flightDataGrid.CellDoubleClick += flightDataGrid_CellDoubleClick;
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
            // arrivalCountryLabel
            // 
            arrivalCountryLabel.AutoSize = true;
            arrivalCountryLabel.Location = new Point(551, 15);
            arrivalCountryLabel.Name = "arrivalCountryLabel";
            arrivalCountryLabel.Size = new Size(107, 20);
            arrivalCountryLabel.TabIndex = 17;
            arrivalCountryLabel.Text = "Arrival Country";
            // 
            // arrivalCountriesComboBox
            // 
            arrivalCountriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            arrivalCountriesComboBox.FormattingEnabled = true;
            arrivalCountriesComboBox.Location = new Point(533, 39);
            arrivalCountriesComboBox.Margin = new Padding(3, 4, 3, 4);
            arrivalCountriesComboBox.Name = "arrivalCountriesComboBox";
            arrivalCountriesComboBox.Size = new Size(138, 28);
            arrivalCountriesComboBox.TabIndex = 16;
            arrivalCountriesComboBox.DropDown += arrivalCountriesComboBox_OnDropDown;
            arrivalCountriesComboBox.TextChanged += bookFlightComboBox_Changed;
            // 
            // deptCountryLabel
            // 
            deptCountryLabel.AutoSize = true;
            deptCountryLabel.Location = new Point(374, 15);
            deptCountryLabel.Name = "deptCountryLabel";
            deptCountryLabel.Size = new Size(131, 20);
            deptCountryLabel.TabIndex = 15;
            deptCountryLabel.Text = "Departure Country";
            // 
            // deptCountriesComboBox
            // 
            deptCountriesComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            deptCountriesComboBox.FormattingEnabled = true;
            deptCountriesComboBox.Location = new Point(374, 39);
            deptCountriesComboBox.Margin = new Padding(3, 4, 3, 4);
            deptCountriesComboBox.Name = "deptCountriesComboBox";
            deptCountriesComboBox.Size = new Size(138, 28);
            deptCountriesComboBox.TabIndex = 14;
            deptCountriesComboBox.DropDown += deptCountriesComboBox_OnDropDown;
            deptCountriesComboBox.TextChanged += bookFlightComboBox_Changed;
            // 
            // deptDateLabel
            // 
            deptDateLabel.AutoSize = true;
            deptDateLabel.Location = new Point(318, 99);
            deptDateLabel.Name = "deptDateLabel";
            deptDateLabel.Size = new Size(112, 20);
            deptDateLabel.TabIndex = 13;
            deptDateLabel.Text = "Departure Date";
            // 
            // deptDateTimePicker
            // 
            deptDateTimePicker.Location = new Point(423, 92);
            deptDateTimePicker.Margin = new Padding(3, 4, 3, 4);
            deptDateTimePicker.Name = "deptDateTimePicker";
            deptDateTimePicker.Size = new Size(228, 27);
            deptDateTimePicker.TabIndex = 12;
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
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)flightDataGrid).EndInit();
            ResumeLayout(false);
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