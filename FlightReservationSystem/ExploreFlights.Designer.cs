namespace FlightReservationSystem
{
    partial class ExploreFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExploreFlights));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Rank3Price = new DataGridViewTextBoxColumn();
            Rank2Price = new DataGridViewTextBoxColumn();
            Rank1Price = new DataGridViewTextBoxColumn();
            AvailableSeats = new DataGridViewTextBoxColumn();
            expectedArrivalDate = new DataGridViewTextBoxColumn();
            arrivalCountry = new DataGridViewTextBoxColumn();
            deptCountry = new DataGridViewTextBoxColumn();
            deptDate = new DataGridViewTextBoxColumn();
            FlightNo = new DataGridViewTextBoxColumn();
            flightDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)flightDataGrid).BeginInit();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(flightDataGrid);
           
            // 
            // Rank3Price
            // 
            Rank3Price.HeaderText = "Rank C Price";
            Rank3Price.MinimumWidth = 6;
            Rank3Price.Name = "Rank3Price";
            Rank3Price.ReadOnly = true;
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
            Rank1Price.HeaderText = "Rank A Price";
            Rank1Price.MinimumWidth = 6;
            Rank1Price.Name = "Rank1Price";
            Rank1Price.ReadOnly = true;
            // 
            // AvailableSeats
            // 
            AvailableSeats.HeaderText = "Available Seats";
            AvailableSeats.Name = "AvailableSeats";
            AvailableSeats.ReadOnly = true;
            // 
            // expectedArrivalDate
            // 
            expectedArrivalDate.HeaderText = "Expected Arrival Date";
            expectedArrivalDate.Name = "expectedArrivalDate";
            expectedArrivalDate.ReadOnly = true;
            // 
            // arrivalCountry
            // 
            arrivalCountry.HeaderText = "Arrival Country";
            arrivalCountry.Name = "arrivalCountry";
            arrivalCountry.ReadOnly = true;
            // 
            // deptCountry
            // 
            deptCountry.HeaderText = "Departure Country";
            deptCountry.Name = "deptCountry";
            deptCountry.ReadOnly = true;
            // 
            // deptDate
            // 
            deptDate.HeaderText = "Departure Date";
            deptDate.Name = "deptDate";
            deptDate.ReadOnly = true;
            // 
            // FlightNo
            // 
            FlightNo.HeaderText = "Flight Number";
            FlightNo.Name = "FlightNo";
            FlightNo.ReadOnly = true;
            // 
            // flightDataGrid
            // 
            flightDataGrid.AllowUserToAddRows = false;
            flightDataGrid.AllowUserToDeleteRows = false;
            flightDataGrid.AllowUserToResizeColumns = false;
            flightDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(189, 223, 251);
            flightDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            flightDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            flightDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            flightDataGrid.ColumnHeadersHeight = 40;
            flightDataGrid.Columns.AddRange(new DataGridViewColumn[] { FlightNo, deptDate, deptCountry, arrivalCountry, expectedArrivalDate, AvailableSeats, Rank1Price, Rank2Price, Rank3Price });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            flightDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            flightDataGrid.Dock = DockStyle.Fill;
            flightDataGrid.GridColor = Color.FromArgb(187, 222, 251);
            flightDataGrid.Location = new Point(0, 0);
            flightDataGrid.Margin = new Padding(0);
            flightDataGrid.MultiSelect = false;
            flightDataGrid.Name = "flightDataGrid";
            flightDataGrid.ReadOnly = true;
            flightDataGrid.RowHeadersVisible = false;
            flightDataGrid.RowHeadersWidth = 50;
            flightDataGrid.RowTemplate.Height = 25;
            flightDataGrid.Size = new Size(1188, 756);
            flightDataGrid.TabIndex = 2;
            flightDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            flightDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            flightDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            flightDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            flightDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            flightDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            flightDataGrid.ThemeStyle.BackColor = Color.White;
            flightDataGrid.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            flightDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            flightDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            flightDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            flightDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            flightDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            flightDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            flightDataGrid.ThemeStyle.ReadOnly = true;
            flightDataGrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            flightDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            flightDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            flightDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            flightDataGrid.ThemeStyle.RowsStyle.Height = 25;
            flightDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            flightDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // ExploreFlights
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1477, 756);
            Name = "ExploreFlights";
            Text = "Explore Flights";
            Load += ExploreFlights_Load;
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)flightDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion


        private Guna.UI2.WinForms.Guna2DataGridView flightDataGrid;
        private DataGridViewTextBoxColumn FlightNo;
        private DataGridViewTextBoxColumn deptDate;
        private DataGridViewTextBoxColumn deptCountry;
        private DataGridViewTextBoxColumn arrivalCountry;
        private DataGridViewTextBoxColumn expectedArrivalDate;
        private DataGridViewTextBoxColumn AvailableSeats;
        private DataGridViewTextBoxColumn Rank1Price;
        private DataGridViewTextBoxColumn Rank2Price;
        private DataGridViewTextBoxColumn Rank3Price;
    }
}