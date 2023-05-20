namespace FlightReservationSystem
{
    partial class UpdateReservation
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            BookingID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            FlightNo = new DataGridViewTextBoxColumn();
            BookingDate = new DataGridViewTextBoxColumn();
            SeatAssignment = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel2);
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.Size = new Size(1118, 610);
            contentSplitContainer.SplitterDistance = 217;
            // 
            // signInButton
            // 
            signInButton.Size = new Size(217, 57);
            // 
            // signUpButton
            // 
            signUpButton.Size = new Size(217, 57);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 547);
            helpButton.Size = new Size(217, 63);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Size = new Size(217, 57);
            // 
            // panel1
            // 
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(568, 607);
            panel1.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Location = new Point(577, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(317, 604);
            panel2.TabIndex = 1;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookingID, CustomerID, FlightNo, BookingDate, SeatAssignment, Column1 });
            dataGridView1.Location = new Point(138, 192);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(240, 150);
            dataGridView1.TabIndex = 0;
            // 
            // BookingID
            // 
            BookingID.HeaderText = "BookingID";
            BookingID.Name = "BookingID";
            BookingID.ReadOnly = true;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "CustomerID";
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FlightNo
            // 
            FlightNo.HeaderText = "FlightNo";
            FlightNo.Name = "FlightNo";
            FlightNo.ReadOnly = true;
            // 
            // BookingDate
            // 
            BookingDate.HeaderText = "BookingDate";
            BookingDate.Name = "BookingDate";
            BookingDate.ReadOnly = true;
            // 
            // SeatAssignment
            // 
            SeatAssignment.HeaderText = "Column1";
            SeatAssignment.Name = "SeatAssignment";
            SeatAssignment.ReadOnly = true;
            // 
            // Column1
            // 
            Column1.HeaderText = "Column1";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // UpdateReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1118, 610);
            Name = "UpdateReservation";
            Text = "Form1";
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private DataGridView dataGridView1;
        private DataGridViewTextBoxColumn BookingID;
        private DataGridViewTextBoxColumn CustomerID;
        private DataGridViewTextBoxColumn FlightNo;
        private DataGridViewTextBoxColumn BookingDate;
        private DataGridViewTextBoxColumn SeatAssignment;
        private DataGridViewTextBoxColumn Column1;
    }
}