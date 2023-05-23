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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.Rank3Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank2Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Rank1Price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AvailableSeats = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.expectedArrivalDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.arrivalCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptCountry = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deptDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FlightNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.flightDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
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
            // Rank3Price
            // 
            this.Rank3Price.HeaderText = "Rank C Price";
            this.Rank3Price.MinimumWidth = 6;
            this.Rank3Price.Name = "Rank3Price";
            this.Rank3Price.ReadOnly = true;
            // 
            // Rank2Price
            // 
            this.Rank2Price.HeaderText = "Rank B Price";
            this.Rank2Price.MinimumWidth = 6;
            this.Rank2Price.Name = "Rank2Price";
            this.Rank2Price.ReadOnly = true;
            // 
            // Rank1Price
            // 
            this.Rank1Price.HeaderText = "Rank A Price";
            this.Rank1Price.MinimumWidth = 6;
            this.Rank1Price.Name = "Rank1Price";
            this.Rank1Price.ReadOnly = true;
            // 
            // AvailableSeats
            // 
            this.AvailableSeats.HeaderText = "Available Seats";
            this.AvailableSeats.Name = "AvailableSeats";
            this.AvailableSeats.ReadOnly = true;
            // 
            // expectedArrivalDate
            // 
            this.expectedArrivalDate.HeaderText = "Expected Arrival Date";
            this.expectedArrivalDate.Name = "expectedArrivalDate";
            this.expectedArrivalDate.ReadOnly = true;
            // 
            // arrivalCountry
            // 
            this.arrivalCountry.HeaderText = "Arrival Country";
            this.arrivalCountry.Name = "arrivalCountry";
            this.arrivalCountry.ReadOnly = true;
            // 
            // deptCountry
            // 
            this.deptCountry.HeaderText = "Departure Country";
            this.deptCountry.Name = "deptCountry";
            this.deptCountry.ReadOnly = true;
            // 
            // deptDate
            // 
            this.deptDate.HeaderText = "Departure Date";
            this.deptDate.Name = "deptDate";
            this.deptDate.ReadOnly = true;
            // 
            // FlightNo
            // 
            this.FlightNo.HeaderText = "Flight Number";
            this.FlightNo.Name = "FlightNo";
            this.FlightNo.ReadOnly = true;
            // 
            // AdminFlightDataGrid
            // 
            this.flightDataGrid.AllowUserToAddRows = false;
            this.flightDataGrid.AllowUserToDeleteRows = false;
            this.flightDataGrid.AllowUserToResizeColumns = false;
            this.flightDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.flightDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.flightDataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.flightDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.flightDataGrid.ColumnHeadersHeight = 40;
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
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.flightDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.flightDataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flightDataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.flightDataGrid.Location = new System.Drawing.Point(0, 0);
            this.flightDataGrid.Margin = new System.Windows.Forms.Padding(0);
            this.flightDataGrid.MultiSelect = false;
            this.flightDataGrid.Name = "AdminFlightDataGrid";
            this.flightDataGrid.ReadOnly = true;
            this.flightDataGrid.RowHeadersVisible = false;
            this.flightDataGrid.RowHeadersWidth = 50;
            this.flightDataGrid.RowTemplate.Height = 25;
            this.flightDataGrid.Size = new System.Drawing.Size(1188, 756);
            this.flightDataGrid.TabIndex = 2;
            this.flightDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            this.flightDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(223)))), ((int)(((byte)(251)))));
            this.flightDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.flightDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.flightDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.flightDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.flightDataGrid.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.flightDataGrid.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(187)))), ((int)(((byte)(222)))), ((int)(((byte)(251)))));
            this.flightDataGrid.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(242)))));
            this.flightDataGrid.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.flightDataGrid.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.flightDataGrid.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.flightDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.flightDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            this.flightDataGrid.ThemeStyle.ReadOnly = true;
            this.flightDataGrid.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(233)))), ((int)(((byte)(252)))));
            this.flightDataGrid.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.flightDataGrid.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.flightDataGrid.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.Black;
            this.flightDataGrid.ThemeStyle.RowsStyle.Height = 25;
            this.flightDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(107)))), ((int)(((byte)(185)))), ((int)(((byte)(246)))));
            this.flightDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.Black;
            // 
            // ExploreFlights
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 756);
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