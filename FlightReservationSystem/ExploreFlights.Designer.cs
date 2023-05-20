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
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.flightDataGrid);
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
            this.flightDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightDataGrid.Location = new System.Drawing.Point(0, 0);
            this.flightDataGrid.Name = "flightDataGrid";
            this.flightDataGrid.ReadOnly = true;
            this.flightDataGrid.RowTemplate.Height = 25;
            this.flightDataGrid.Size = new System.Drawing.Size(946, 595);
            this.flightDataGrid.TabIndex = 1;
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
            // AvailableSeats
            // 
            this.AvailableSeats.HeaderText = "Available Seats";
            this.AvailableSeats.Name = "Available Seats";
            this.AvailableSeats.ReadOnly = true;
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
            // ExploreFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 595);
            this.Name = "ExploreFlights";
            this.Text = "ExploreFlights";
            this.Load += new System.EventHandler(this.ExploreFlights_Load);
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.flightDataGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

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
    }
}