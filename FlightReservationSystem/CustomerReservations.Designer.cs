namespace FlightReservationSystem
{
    partial class CustomerReservations
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CustomerReservations));
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
            reservationsDataGrid = new Guna.UI2.WinForms.Guna2DataGridView();
            BookingID = new DataGridViewTextBoxColumn();
            deptCounty = new DataGridViewTextBoxColumn();
            ArrivalCountry = new DataGridViewTextBoxColumn();
            BookingDate = new DataGridViewTextBoxColumn();
            SeatAssignment = new DataGridViewTextBoxColumn();
            TicketPrice = new DataGridViewTextBoxColumn();
            Rank = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).BeginInit();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(reservationsDataGrid);
           
            // 
            // reservationsDataGrid
            // 
            reservationsDataGrid.AllowUserToAddRows = false;
            reservationsDataGrid.AllowUserToDeleteRows = false;
            reservationsDataGrid.AllowUserToResizeColumns = false;
            reservationsDataGrid.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(189, 223, 251);
            reservationsDataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            reservationsDataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(33, 150, 242);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            reservationsDataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            reservationsDataGrid.ColumnHeadersHeight = 40;
            reservationsDataGrid.Columns.AddRange(new DataGridViewColumn[] { BookingID, deptCounty, ArrivalCountry, BookingDate, SeatAssignment, TicketPrice, Rank, Status });
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(211, 233, 252);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.ForeColor = Color.Black;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(107, 185, 246);
            dataGridViewCellStyle3.SelectionForeColor = Color.Black;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            reservationsDataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            reservationsDataGrid.Dock = DockStyle.Fill;
            reservationsDataGrid.GridColor = Color.FromArgb(187, 222, 251);
            reservationsDataGrid.Location = new Point(0, 0);
            reservationsDataGrid.Margin = new Padding(0);
            reservationsDataGrid.MultiSelect = false;
            reservationsDataGrid.Name = "reservationsDataGrid";
            reservationsDataGrid.ReadOnly = true;
            reservationsDataGrid.RowHeadersVisible = false;
            reservationsDataGrid.RowHeadersWidth = 50;
            reservationsDataGrid.RowTemplate.Height = 25;
            reservationsDataGrid.Size = new Size(1089, 726);
            reservationsDataGrid.TabIndex = 3;
            reservationsDataGrid.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Blue;
            reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.BackColor = Color.FromArgb(189, 223, 251);
            reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.Font = null;
            reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.ForeColor = Color.Empty;
            reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = Color.Empty;
            reservationsDataGrid.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = Color.Empty;
            reservationsDataGrid.ThemeStyle.BackColor = Color.White;
            reservationsDataGrid.ThemeStyle.GridColor = Color.FromArgb(187, 222, 251);
            reservationsDataGrid.ThemeStyle.HeaderStyle.BackColor = Color.FromArgb(33, 150, 242);
            reservationsDataGrid.ThemeStyle.HeaderStyle.BorderStyle = DataGridViewHeaderBorderStyle.Single;
            reservationsDataGrid.ThemeStyle.HeaderStyle.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            reservationsDataGrid.ThemeStyle.HeaderStyle.ForeColor = Color.White;
            reservationsDataGrid.ThemeStyle.HeaderStyle.HeaightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            reservationsDataGrid.ThemeStyle.HeaderStyle.Height = 40;
            reservationsDataGrid.ThemeStyle.ReadOnly = true;
            reservationsDataGrid.ThemeStyle.RowsStyle.BackColor = Color.FromArgb(211, 233, 252);
            reservationsDataGrid.ThemeStyle.RowsStyle.BorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            reservationsDataGrid.ThemeStyle.RowsStyle.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            reservationsDataGrid.ThemeStyle.RowsStyle.ForeColor = Color.Black;
            reservationsDataGrid.ThemeStyle.RowsStyle.Height = 25;
            reservationsDataGrid.ThemeStyle.RowsStyle.SelectionBackColor = Color.FromArgb(107, 185, 246);
            reservationsDataGrid.ThemeStyle.RowsStyle.SelectionForeColor = Color.Black;
            // 
            // BookingID
            // 
            BookingID.HeaderText = "Booking ID";
            BookingID.Name = "BookingID";
            BookingID.ReadOnly = true;
            // 
            // deptCounty
            // 
            deptCounty.HeaderText = "Departure Country";
            deptCounty.Name = "deptCounty";
            deptCounty.ReadOnly = true;
            // 
            // ArrivalCountry
            // 
            ArrivalCountry.HeaderText = "Arrival Country";
            ArrivalCountry.Name = "ArrivalCountry";
            ArrivalCountry.ReadOnly = true;
            // 
            // BookingDate
            // 
            BookingDate.HeaderText = "Booking Date";
            BookingDate.Name = "BookingDate";
            BookingDate.ReadOnly = true;
            // 
            // SeatAssignment
            // 
            SeatAssignment.HeaderText = "Seat Assignment";
            SeatAssignment.Name = "SeatAssignment";
            SeatAssignment.ReadOnly = true;
            // 
            // TicketPrice
            // 
            TicketPrice.HeaderText = "Ticket Price";
            TicketPrice.Name = "TicketPrice";
            TicketPrice.ReadOnly = true;
            // 
            // Rank
            // 
            Rank.HeaderText = "Rank";
            Rank.Name = "Rank";
            Rank.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // CustomerReservations
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1354, 726);
            Name = "CustomerReservations";
            Text = "Customer Reservations";
            Load += CustomerReservations_Load;
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)reservationsDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Guna.UI2.WinForms.Guna2DataGridView reservationsDataGrid;
        private DataGridViewTextBoxColumn BookingID;
        private DataGridViewTextBoxColumn deptCounty;
        private DataGridViewTextBoxColumn ArrivalCountry;
        private DataGridViewTextBoxColumn BookingDate;
        private DataGridViewTextBoxColumn SeatAssignment;
        private DataGridViewTextBoxColumn TicketPrice;
        private DataGridViewTextBoxColumn Rank;
        private DataGridViewTextBoxColumn Status;
    }
}