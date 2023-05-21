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
            StatusComboBox = new ComboBox();
            label11 = new Label();
            label10 = new Label();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            ConfirmButton = new Button();
            RankComboBox = new ComboBox();
            BookingIdTextBox = new TextBox();
            FlightNoTextBox2 = new TextBox();
            BookingDateTextBox = new TextBox();
            SeatAssignmentTextBox = new TextBox();
            TicketPriceTextBox = new TextBox();
            CustomerIdTextBox2 = new TextBox();
            label3 = new Label();
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
            contentSplitContainer.Margin = new Padding(3, 5, 3, 5);
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(panel2);
            contentSplitContainer.Panel2.Controls.Add(panel1);
            contentSplitContainer.Size = new Size(1393, 847);
            contentSplitContainer.SplitterDistance = 269;
            contentSplitContainer.SplitterWidth = 6;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(0, 76);
            signInButton.Margin = new Padding(3, 4, 3, 4);
            signInButton.Size = new Size(269, 76);
            // 
            // signUpButton
            // 
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Size = new Size(269, 76);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 763);
            helpButton.Margin = new Padding(3, 5, 3, 5);
            helpButton.Size = new Size(269, 84);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Location = new Point(0, 152);
            exploreFlightsButton.Margin = new Padding(3, 5, 3, 5);
            exploreFlightsButton.Size = new Size(269, 76);
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(FlighNoTextBox);
            panel1.Controls.Add(CustomerIdTextBox);
            panel1.Controls.Add(UpdateReservationDataGridView);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(726, 843);
            panel1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(334, 35);
            label2.Name = "label2";
            label2.Size = new Size(70, 20);
            label2.TabIndex = 4;
            label2.Text = "Flight No";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(31, 35);
            label1.Name = "label1";
            label1.Size = new Size(91, 20);
            label1.TabIndex = 3;
            label1.Text = "Customer ID";
            // 
            // FlighNoTextBox
            // 
            FlighNoTextBox.Location = new Point(410, 28);
            FlighNoTextBox.Margin = new Padding(3, 4, 3, 4);
            FlighNoTextBox.Name = "FlighNoTextBox";
            FlighNoTextBox.Size = new Size(114, 27);
            FlighNoTextBox.TabIndex = 2;
            FlighNoTextBox.TextChanged += FlighNoTextBox_TextChanged;
            // 
            // CustomerIdTextBox
            // 
            CustomerIdTextBox.Location = new Point(128, 28);
            CustomerIdTextBox.Margin = new Padding(3, 4, 3, 4);
            CustomerIdTextBox.Name = "CustomerIdTextBox";
            CustomerIdTextBox.Size = new Size(125, 27);
            CustomerIdTextBox.TabIndex = 1;
            CustomerIdTextBox.TextChanged += CustomerIdTextBox_TextChanged;
            // 
            // UpdateReservationDataGridView
            // 
            UpdateReservationDataGridView.AllowUserToAddRows = false;
            UpdateReservationDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            UpdateReservationDataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            UpdateReservationDataGridView.BackgroundColor = SystemColors.ButtonFace;
            UpdateReservationDataGridView.ColumnHeadersHeight = 29;
            UpdateReservationDataGridView.Columns.AddRange(new DataGridViewColumn[] { BookingID, CustomerID, FlightNo, BookingDate, SeatAssignment, TicketPrice, Ranl, Status });
            UpdateReservationDataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
            UpdateReservationDataGridView.GridColor = SystemColors.ControlDarkDark;
            UpdateReservationDataGridView.Location = new Point(3, 72);
            UpdateReservationDataGridView.Margin = new Padding(3, 4, 3, 4);
            UpdateReservationDataGridView.Name = "UpdateReservationDataGridView";
            UpdateReservationDataGridView.RowHeadersWidth = 51;
            UpdateReservationDataGridView.RowTemplate.Height = 25;
            UpdateReservationDataGridView.Size = new Size(722, 804);
            UpdateReservationDataGridView.TabIndex = 0;
            UpdateReservationDataGridView.CellClick += UpdateReservationDataGridView_CellClick;
            // 
            // BookingID
            // 
            BookingID.HeaderText = "BookingID";
            BookingID.MinimumWidth = 6;
            BookingID.Name = "BookingID";
            BookingID.ReadOnly = true;
            // 
            // CustomerID
            // 
            CustomerID.HeaderText = "CustomerID";
            CustomerID.MinimumWidth = 6;
            CustomerID.Name = "CustomerID";
            CustomerID.ReadOnly = true;
            // 
            // FlightNo
            // 
            FlightNo.HeaderText = "FlightNo";
            FlightNo.MinimumWidth = 6;
            FlightNo.Name = "FlightNo";
            FlightNo.ReadOnly = true;
            // 
            // BookingDate
            // 
            BookingDate.HeaderText = "BookingDate";
            BookingDate.MinimumWidth = 6;
            BookingDate.Name = "BookingDate";
            BookingDate.ReadOnly = true;
            // 
            // SeatAssignment
            // 
            SeatAssignment.HeaderText = "SeatAssignment";
            SeatAssignment.MinimumWidth = 6;
            SeatAssignment.Name = "SeatAssignment";
            SeatAssignment.ReadOnly = true;
            // 
            // TicketPrice
            // 
            TicketPrice.HeaderText = "TicketPrice";
            TicketPrice.MinimumWidth = 6;
            TicketPrice.Name = "TicketPrice";
            TicketPrice.ReadOnly = true;
            // 
            // Ranl
            // 
            Ranl.HeaderText = "Rank";
            Ranl.MinimumWidth = 6;
            Ranl.Name = "Ranl";
            Ranl.ReadOnly = true;
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
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
            panel2.Location = new Point(736, 4);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(379, 843);
            panel2.TabIndex = 1;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Items.AddRange(new object[] {"Confirmed","Canceled"});
            StatusComboBox.Location = new Point(47, 428);
            StatusComboBox.Margin = new Padding(3, 4, 3, 4);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(114, 28);
            StatusComboBox.TabIndex = 20;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(226, 124);
            label11.Name = "label11";
            label11.Size = new Size(70, 20);
            label11.TabIndex = 19;
            label11.Text = "Flight No";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(47, 217);
            label10.Name = "label10";
            label10.Size = new Size(83, 20);
            label10.TabIndex = 18;
            label10.Text = "Booking ID";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(226, 317);
            label9.Name = "label9";
            label9.Size = new Size(84, 20);
            label9.TabIndex = 17;
            label9.Text = "Ticket Price";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(226, 404);
            label8.Name = "label8";
            label8.Size = new Size(41, 20);
            label8.TabIndex = 16;
            label8.Text = "Rank";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(47, 317);
            label7.Name = "label7";
            label7.Size = new Size(119, 20);
            label7.TabIndex = 15;
            label7.Text = "Seat Assignment";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(47, 404);
            label6.Name = "label6";
            label6.Size = new Size(49, 20);
            label6.TabIndex = 14;
            label6.Text = "Status";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(226, 217);
            label5.Name = "label5";
            label5.Size = new Size(100, 20);
            label5.TabIndex = 13;
            label5.Text = "Booking Date";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(47, 128);
            label4.Name = "label4";
            label4.Size = new Size(91, 20);
            label4.TabIndex = 12;
            label4.Text = "Customer ID";
            // 
            // ConfirmButton
            // 
            ConfirmButton.Location = new Point(135, 632);
            ConfirmButton.Margin = new Padding(3, 4, 3, 4);
            ConfirmButton.Name = "ConfirmButton";
            ConfirmButton.Size = new Size(132, 31);
            ConfirmButton.TabIndex = 10;
            ConfirmButton.Text = "Confirm";
            ConfirmButton.UseVisualStyleBackColor = true;
            ConfirmButton.Click += ConfirmButton_Click;
            // 
            // RankComboBox
            // 
            RankComboBox.FormattingEnabled = true;
            RankComboBox.Items.AddRange(new object[] { "sd", "a", "a" });
            RankComboBox.Location = new Point(226, 428);
            RankComboBox.Margin = new Padding(3, 4, 3, 4);
            RankComboBox.Name = "RankComboBox";
            RankComboBox.Size = new Size(114, 28);
            RankComboBox.TabIndex = 8;
            // 
            // BookingIdTextBox
            // 
            BookingIdTextBox.Location = new Point(47, 241);
            BookingIdTextBox.Margin = new Padding(3, 4, 3, 4);
            BookingIdTextBox.Name = "BookingIdTextBox";
            BookingIdTextBox.ReadOnly = true;
            BookingIdTextBox.Size = new Size(114, 27);
            BookingIdTextBox.TabIndex = 7;
            // 
            // FlightNoTextBox2
            // 
            FlightNoTextBox2.Location = new Point(226, 148);
            FlightNoTextBox2.Margin = new Padding(3, 4, 3, 4);
            FlightNoTextBox2.Name = "FlightNoTextBox2";
            FlightNoTextBox2.ReadOnly = true;
            FlightNoTextBox2.Size = new Size(114, 27);
            FlightNoTextBox2.TabIndex = 6;
            // 
            // BookingDateTextBox
            // 
            BookingDateTextBox.Location = new Point(226, 241);
            BookingDateTextBox.Margin = new Padding(3, 4, 3, 4);
            BookingDateTextBox.Name = "BookingDateTextBox";
            BookingDateTextBox.ReadOnly = true;
            BookingDateTextBox.Size = new Size(114, 27);
            BookingDateTextBox.TabIndex = 5;
            // 
            // SeatAssignmentTextBox
            // 
            SeatAssignmentTextBox.Location = new Point(47, 341);
            SeatAssignmentTextBox.Margin = new Padding(3, 4, 3, 4);
            SeatAssignmentTextBox.Name = "SeatAssignmentTextBox";
            SeatAssignmentTextBox.Size = new Size(114, 27);
            SeatAssignmentTextBox.TabIndex = 4;
            // 
            // TicketPriceTextBox
            // 
            TicketPriceTextBox.Location = new Point(226, 341);
            TicketPriceTextBox.Margin = new Padding(3, 4, 3, 4);
            TicketPriceTextBox.Name = "TicketPriceTextBox";
            TicketPriceTextBox.Size = new Size(114, 27);
            TicketPriceTextBox.TabIndex = 3;
            // 
            // CustomerIdTextBox2
            // 
            CustomerIdTextBox2.Location = new Point(47, 148);
            CustomerIdTextBox2.Margin = new Padding(3, 4, 3, 4);
            CustomerIdTextBox2.Name = "CustomerIdTextBox2";
            CustomerIdTextBox2.ReadOnly = true;
            CustomerIdTextBox2.Size = new Size(114, 27);
            CustomerIdTextBox2.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(99, 39);
            label3.Name = "label3";
            label3.Size = new Size(229, 32);
            label3.TabIndex = 1;
            label3.Text = "Update Reservation";
            // 
            // UpdateReservation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 847);
            Margin = new Padding(3, 5, 3, 5);
            Name = "UpdateReservation";
            Text = "Form1";
            Load += UpdateReservation_Load;
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