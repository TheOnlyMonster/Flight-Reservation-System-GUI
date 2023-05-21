namespace FlightReservationSystem
{
    partial class AddFlight
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
            AddButton = new Button();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label3 = new Label();
            AirCraftIdTextBox = new TextBox();
            ArrivalTextBox = new TextBox();
            SeatsTextBox = new TextBox();
            label1 = new Label();
            RankATextBox = new TextBox();
            RankBTextBox = new TextBox();
            RankCTextBox = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label10 = new Label();
            DepatureTextBox = new TextBox();
            DepartureDateTimePicker3 = new DateTimePicker();
            ExpectedDateTimePicker4 = new DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            contentSplitContainer.Margin = new Padding(3, 5, 3, 5);
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(ExpectedDateTimePicker4);
            contentSplitContainer.Panel2.Controls.Add(DepartureDateTimePicker3);
            contentSplitContainer.Panel2.Controls.Add(DepatureTextBox);
            contentSplitContainer.Panel2.Controls.Add(label10);
            contentSplitContainer.Panel2.Controls.Add(label4);
            contentSplitContainer.Panel2.Controls.Add(label2);
            contentSplitContainer.Panel2.Controls.Add(RankCTextBox);
            contentSplitContainer.Panel2.Controls.Add(RankBTextBox);
            contentSplitContainer.Panel2.Controls.Add(RankATextBox);
            contentSplitContainer.Panel2.Controls.Add(AddButton);
            contentSplitContainer.Panel2.Controls.Add(label9);
            contentSplitContainer.Panel2.Controls.Add(label8);
            contentSplitContainer.Panel2.Controls.Add(label7);
            contentSplitContainer.Panel2.Controls.Add(label6);
            contentSplitContainer.Panel2.Controls.Add(label5);
            contentSplitContainer.Panel2.Controls.Add(label3);
            contentSplitContainer.Panel2.Controls.Add(AirCraftIdTextBox);
            contentSplitContainer.Panel2.Controls.Add(ArrivalTextBox);
            contentSplitContainer.Panel2.Controls.Add(SeatsTextBox);
            contentSplitContainer.Panel2.Controls.Add(label1);
            contentSplitContainer.Size = new Size(914, 600);
            contentSplitContainer.SplitterDistance = 178;
            contentSplitContainer.SplitterWidth = 6;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(0, 76);
            signInButton.Margin = new Padding(3, 4, 3, 4);
            signInButton.Size = new Size(178, 76);
            // 
            // signUpButton
            // 
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Size = new Size(178, 76);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 516);
            helpButton.Margin = new Padding(3, 5, 3, 5);
            helpButton.Size = new Size(178, 84);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Location = new Point(0, 152);
            exploreFlightsButton.Margin = new Padding(3, 5, 3, 5);
            exploreFlightsButton.Size = new Size(178, 76);
            // 
            // AddButton
            // 
            AddButton.Location = new Point(300, 532);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(146, 29);
            AddButton.TabIndex = 34;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += AddButton_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(523, 91);
            label9.Name = "label9";
            label9.Size = new Size(112, 20);
            label9.TabIndex = 32;
            label9.Text = "Departure Date";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(523, 178);
            label8.Name = "label8";
            label8.Size = new Size(107, 20);
            label8.TabIndex = 31;
            label8.Text = "Arrival Country";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(60, 91);
            label7.Name = "label7";
            label7.Size = new Size(79, 20);
            label7.TabIndex = 30;
            label7.Text = "AirCraft ID";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(58, 178);
            label6.Name = "label6";
            label6.Size = new Size(117, 20);
            label6.TabIndex = 29;
            label6.Text = "Expected Arrival";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(525, 267);
            label5.Name = "label5";
            label5.Size = new Size(110, 20);
            label5.TabIndex = 28;
            label5.Text = "Available Seats";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(61, 267);
            label3.Name = "label3";
            label3.Size = new Size(131, 20);
            label3.TabIndex = 27;
            label3.Text = "Departure Country";
            // 
            // AirCraftIdTextBox
            // 
            AirCraftIdTextBox.Location = new Point(59, 114);
            AirCraftIdTextBox.Name = "AirCraftIdTextBox";
            AirCraftIdTextBox.Size = new Size(164, 27);
            AirCraftIdTextBox.TabIndex = 25;
            // 
            // ArrivalTextBox
            // 
            ArrivalTextBox.Location = new Point(523, 201);
            ArrivalTextBox.Name = "ArrivalTextBox";
            ArrivalTextBox.Size = new Size(161, 27);
            ArrivalTextBox.TabIndex = 24;
            // 
            // SeatsTextBox
            // 
            SeatsTextBox.Location = new Point(523, 290);
            SeatsTextBox.Name = "SeatsTextBox";
            SeatsTextBox.Size = new Size(161, 27);
            SeatsTextBox.TabIndex = 22;
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(271, 19);
            label1.Name = "label1";
            label1.Size = new Size(175, 43);
            label1.TabIndex = 21;
            label1.Text = "Add Flight\r\n";
            // 
            // RankATextBox
            // 
            RankATextBox.Location = new Point(61, 376);
            RankATextBox.Name = "RankATextBox";
            RankATextBox.Size = new Size(166, 27);
            RankATextBox.TabIndex = 35;
            // 
            // RankBTextBox
            // 
            RankBTextBox.Location = new Point(523, 376);
            RankBTextBox.Name = "RankBTextBox";
            RankBTextBox.Size = new Size(161, 27);
            RankBTextBox.TabIndex = 36;
            // 
            // RankCTextBox
            // 
            RankCTextBox.Location = new Point(61, 463);
            RankCTextBox.Name = "RankCTextBox";
            RankCTextBox.Size = new Size(165, 27);
            RankCTextBox.TabIndex = 37;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(61, 440);
            label2.Name = "label2";
            label2.Size = new Size(90, 20);
            label2.TabIndex = 38;
            label2.Text = "Rank C Price";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(523, 353);
            label4.Name = "label4";
            label4.Size = new Size(90, 20);
            label4.TabIndex = 39;
            label4.Text = "Rank B Price";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(60, 353);
            label10.Name = "label10";
            label10.Size = new Size(91, 20);
            label10.TabIndex = 40;
            label10.Text = "Rank A Price";
            // 
            // DepatureTextBox
            // 
            DepatureTextBox.Location = new Point(60, 290);
            DepatureTextBox.Name = "DepatureTextBox";
            DepatureTextBox.Size = new Size(166, 27);
            DepatureTextBox.TabIndex = 41;
            // 
            // DepartureDateTimePicker3
            // 
            DepartureDateTimePicker3.Location = new Point(523, 114);
            DepartureDateTimePicker3.Name = "DepartureDateTimePicker3";
            DepartureDateTimePicker3.Size = new Size(161, 27);
            DepartureDateTimePicker3.TabIndex = 44;
            // 
            // ExpectedDateTimePicker4
            // 
            ExpectedDateTimePicker4.Location = new Point(61, 199);
            ExpectedDateTimePicker4.Name = "ExpectedDateTimePicker4";
            ExpectedDateTimePicker4.Size = new Size(166, 27);
            ExpectedDateTimePicker4.TabIndex = 45;
            // 
            // AddFlight
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Margin = new Padding(3, 5, 3, 5);
            Name = "AddFlight";
            Text = "AddFlight";
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            contentSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button AddButton;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox AirCraftIdTextBox;
        private TextBox ArrivalTextBox;
        private TextBox SeatsTextBox;
        private Label label1;
        private Label label10;
        private Label label4;
        private Label label2;
        private TextBox RankCTextBox;
        private TextBox RankBTextBox;
        private TextBox RankATextBox;
        private DateTimePicker DepartureDateTimePicker3;
        private TextBox DepatureTextBox;
        private DateTimePicker ExpectedDateTimePicker4;
    }
}