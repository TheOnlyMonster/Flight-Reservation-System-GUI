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
            label2 = new Label();
            label1 = new Label();
            FlighNoTextBox = new TextBox();
            CustomerIdTextBox = new TextBox();
            UpdateReservationDataGridView = new DataGridView();
            BookingID = new DataGridViewTextBoxColumn();
            CustomerID = new DataGridViewTextBoxColumn();
            FlightNo = new DataGridViewTextBoxColumn();
            BookingDate = new DataGridViewTextBoxColumn();
            SeatAssignment = new DataGridViewTextBoxColumn();
            TicketPrice = new DataGridViewTextBoxColumn();
            Ranl = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            panel2 = new Panel();
            label3 = new Label();
            CustomerIdTextBox2 = new TextBox();
            TicketPriceTextBox = new TextBox();
            SeatAssignmentTextBox = new TextBox();
            BookingDateTextBox = new TextBox();
            FlightNoTextBox2 = new TextBox();
            BookingIdTextBox = new TextBox();
            RankComboBox = new ComboBox();
            ConfirmButton = new Button();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            label10 = new Label();
            label11 = new Label();
            StatusComboBox = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)UpdateReservationDataGridView).BeginInit();
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
            panel1.Controls.Add(FlighNoTextBox);
            panel1.Controls.Add(CustomerIdTextBox);
            panel1.Controls.Add(UpdateReservationDataGridView);
            panel1.Location = new Point(3, 3);
            panel1.Name = "panel1";
            panel1.Size = new Size(635, 632);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(297, 29);
            label2.Name = "label2";
            label2.Size = new Size(56, 15);
            label2.TabIndex = 4;
            label2.Text = "Flight No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(33, 29);
            label1.Name = "label1";
            label1.Size = new Size(73, 15);
            label1.TabIndex = 3;
            label1.Text = "Customer ID";
            // 
            // FlighNoTextBox
            // 
            FlighNoTextBox.Location = new Point(359, 21);
            FlighNoTextBox.Name = "FlighNoTextBox";
            FlighNoTextBox.Size = new Size(100, 23);
            FlighNoTextBox.TabIndex = 2;
            // 
            // CustomerIdTextBox
            // 
            CustomerIdTextBox.Location = new Point(112, 21);
            CustomerIdTextBox.Name = "CustomerIdTextBox";
            CustomerIdTextBox.Size = new Size(110, 23);
            CustomerIdTextBox.TabIndex = 1;
            
            // 
            // UpdateReservationDataGridView
            // 
            UpdateReservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateReservationDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UpdateReservationDataGridView.BackgroundColor = SystemColors.ButtonFace;
            UpdateReservationDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            UpdateReservationDataGridView.Columns.AddRange(new DataGridViewColumn[] { BookingID, CustomerID, FlightNo, BookingDate, SeatAssignment, TicketPrice, Ranl, Status });
            UpdateReservationDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            UpdateReservationDataGridView.GridColor = SystemColors.ControlDarkDark;
            UpdateReservationDataGridView.Location = new Point(3, 54);
            UpdateReservationDataGridView.Name = "UpdateReservationDataGridView";
            UpdateReservationDataGridView.RowTemplate.Height = 25;
            UpdateReservationDataGridView.Size = new Size(632, 603);
            UpdateReservationDataGridView.TabIndex = 0;
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
            panel2.Controls.Add(StatusComboBox);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(ConfirmButton);
            panel2.Controls.Add(RankComboBox);
            panel2.Controls.Add(BookingIdTextBox);
            panel2.Controls.Add(FlightNoTextBox2);
            panel2.Controls.Add(BookingDateTextBox);
            panel2.Controls.Add(SeatAssignmentTextBox);
            panel2.Controls.Add(TicketPriceTextBox);
            panel2.Controls.Add(CustomerIdTextBox2);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(644, 3);
            panel2.Name = "panel2";
            panel2.Size = new Size(332, 632);
            panel2.TabIndex = 1;
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
            // CustomerIdTextBox2
            // 
            CustomerIdTextBox2.Location = new Point(41, 111);
            CustomerIdTextBox2.Name = "CustomerIdTextBox2";
            CustomerIdTextBox2.ReadOnly = true;
            CustomerIdTextBox2.Size = new Size(100, 23);
            CustomerIdTextBox2.TabIndex = 2;
            // 
            // TicketPriceTextBox
            // 
            TicketPriceTextBox.Location = new Point(198, 256);
            TicketPriceTextBox.Name = "TicketPriceTextBox";
            TicketPriceTextBox.Size = new Size(100, 23);
            TicketPriceTextBox.TabIndex = 3;
            // 
            // SeatAssignmentTextBox
            // 
            SeatAssignmentTextBox.Location = new Point(41, 256);
            SeatAssignmentTextBox.Name = "SeatAssignmentTextBox";
            SeatAssignmentTextBox.Size = new Size(100, 23);
            SeatAssignmentTextBox.TabIndex = 4;
            // 
            // BookingDateTextBox
            // 
            BookingDateTextBox.Location = new Point(198, 181);
            BookingDateTextBox.Name = "BookingDateTextBox";
            BookingDateTextBox.ReadOnly = true;
            BookingDateTextBox.Size = new Size(100, 23);
            BookingDateTextBox.TabIndex = 5;
            // 
            // FlightNoTextBox2
            // 
            FlightNoTextBox2.Location = new Point(198, 111);
            FlightNoTextBox2.Name = "FlightNoTextBox2";
            FlightNoTextBox2.ReadOnly = true;
            FlightNoTextBox2.Size = new Size(100, 23);
            FlightNoTextBox2.TabIndex = 6;
            // 
            // BookingIdTextBox
            // 
            BookingIdTextBox.Location = new Point(41, 181);
            BookingIdTextBox.Name = "BookingIdTextBox";
            BookingIdTextBox.ReadOnly = true;
            BookingIdTextBox.Size = new Size(100, 23);
            BookingIdTextBox.TabIndex = 7;
            // 
            // RankComboBox
            // 
            RankComboBox.FormattingEnabled = true;
            RankComboBox.Items.AddRange(new object[] { "sd", "a", "a" });
            RankComboBox.Location = new Point(198, 321);
            RankComboBox.Name = "RankComboBox";
            RankComboBox.Size = new Size(100, 23);
            RankComboBox.TabIndex = 8;
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(118, 474);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(113, 23);
            ConfirmButton.TabIndex = 10;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(41, 96);
            label4.Name = "label4";
            label4.Size = new Size(73, 15);
            label4.TabIndex = 12;
            label4.Text = "Customer ID";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(198, 163);
            label5.Name = "label5";
            label5.Size = new Size(78, 15);
            label5.TabIndex = 13;
            label5.Text = "Booking Date";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(41, 303);
            label6.Name = "label6";
            label6.Size = new Size(39, 15);
            label6.TabIndex = 14;
            label6.Text = "Status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 238);
            label7.Name = "label7";
            label7.Size = new Size(95, 15);
            label7.TabIndex = 15;
            label7.Text = "Seat Assignment";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(198, 303);
            label8.Name = "label8";
            label8.Size = new Size(33, 15);
            label8.TabIndex = 16;
            label8.Text = "Rank";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(198, 238);
            label9.Name = "label9";
            label9.Size = new Size(67, 15);
            label9.TabIndex = 17;
            label9.Text = "Ticket Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(41, 163);
            label10.Name = "label10";
            label10.Size = new Size(65, 15);
            label10.TabIndex = 18;
            label10.Text = "Booking ID";
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(198, 93);
            label11.Name = "label11";
            label11.Size = new Size(56, 15);
            label11.TabIndex = 19;
            label11.Text = "Flight No";
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] { "sd", "a", "a" });
            StatusComboBox.Location = new Point(41, 321);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(100, 23);
            StatusComboBox.TabIndex = 20;
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
            ((System.ComponentModel.ISupportInitialize)UpdateReservationDataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private Panel panel1;
        private DataGridView UpdateReservationDataGridView;
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
        private TextBox FlighNoTextBox;
        private TextBox CustomerIdTextBox;
        private Label label3;
        private ComboBox RankComboBox;
        private TextBox BookingIdTextBox;
        private TextBox FlightNoTextBox2;
        private TextBox BookingDateTextBox;
        private TextBox SeatAssignmentTextBox;
        private TextBox TicketPriceTextBox;
        private TextBox CustomerIdTextBox2;
        private Label label11;
        private Label label10;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Button ConfirmButton;
        private ComboBox StatusComboBox;
    }
}