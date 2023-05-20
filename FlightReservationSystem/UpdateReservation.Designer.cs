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
            dataGridView1 = new DataGridView();
            BookingID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            FlightNo = new DataGridViewTextBoxColumn();
            BookingDate = new DataGridViewTextBoxColumn();
            SeatAssignment = new DataGridViewTextBoxColumn();
            TicketPrice = new DataGridViewTextBoxColumn();
            Ranl = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel2);
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.Size = new Size(1219, 635);
            contentSplitContainer.SplitterDistance = 236;
            // 
            // signInButton
            // 
            signInButton.Size = new Size(236, 57);
            // 
            // signUpButton
            // 
            signUpButton.Size = new Size(236, 57);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 572);
            helpButton.Size = new Size(236, 63);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Size = new Size(236, 57);
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(textBox2);
            panel1.Controls.Add(textBox1);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 632);
            panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridView1.BackgroundColor = SystemColors.ButtonFace;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { BookingID, CustomerID, FlightNo, BookingDate, SeatAssignment, TicketPrice, Ranl, Status });
            dataGridView1.EditMode = DataGridViewEditMode.EditOnEnter;
            dataGridView1.GridColor = SystemColors.ControlDarkDark;
            dataGridView1.Location = new Point(3, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(632, 603);
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
            SeatAssignment.HeaderText = "SeatAssignment";
            SeatAssignment.Name = "SeatAssignment";
            SeatAssignment.ReadOnly = true;
            // 
            // TicketPrice
            // 
            TicketPrice.HeaderText = "TicketPrice";
            TicketPrice.Name = "TicketPrice";
            TicketPrice.ReadOnly = true;
            // 
            // Ranl
            // 
            Ranl.HeaderText = "Rank";
            Ranl.Name = "Ranl";
            Ranl.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.Name = "Status";
            Status.ReadOnly = true;
            // 
            // panel2
            // 
            panel2.Controls.Add(label3);
            panel2.Location = new Point(644, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 632);
            panel2.TabIndex = 1;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(112, 21);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(110, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(359, 21);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(68, 29);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 3;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(315, 29);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "label2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(87, 29);
            label3.Name = "label3";
            label3.Size = new Size(180, 25);
            label3.TabIndex = 1;
            label3.Text = "Update Reservation";
            // 
            // UpdateReservation
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1219, 635);
            Name = "UpdateReservation";
            Text = "Form1";
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
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
        private DataGridViewTextBoxColumn TicketPrice;
        private DataGridViewTextBoxColumn Ranl;
        private DataGridViewTextBoxColumn Status;
        private Label label2;
        private Label label1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label3;
    }
}