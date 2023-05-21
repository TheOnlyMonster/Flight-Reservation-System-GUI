namespace FlightReservationSystem
{
    partial class AddAirCraft
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
            label1 = new Label();
            CapacityTextBox = new TextBox();
            ManufactureYearTextBox = new TextBox();
            AirCraftYearTextBox = new TextBox();
            ModelTextBox = new TextBox();
            ManfucaturerTextBox = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            AirCraftComboBox = new ComboBox();
            AddButton = new Button();
            AirCraftTextBox = new TextBox();
            label2 = new Label();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(label2);
            contentSplitContainer.Panel2.Controls.Add(AirCraftTextBox);
            contentSplitContainer.Panel2.Controls.Add(AddButton);
            contentSplitContainer.Panel2.Controls.Add(AirCraftComboBox);
            contentSplitContainer.Panel2.Controls.Add(label9);
            contentSplitContainer.Panel2.Controls.Add(label8);
            contentSplitContainer.Panel2.Controls.Add(label7);
            contentSplitContainer.Panel2.Controls.Add(label6);
            contentSplitContainer.Panel2.Controls.Add(label5);
            contentSplitContainer.Panel2.Controls.Add(label3);
            contentSplitContainer.Panel2.Controls.Add(ManfucaturerTextBox);
            contentSplitContainer.Panel2.Controls.Add(ModelTextBox);
            contentSplitContainer.Panel2.Controls.Add(AirCraftYearTextBox);
            contentSplitContainer.Panel2.Controls.Add(ManufactureYearTextBox);
            contentSplitContainer.Panel2.Controls.Add(CapacityTextBox);
            contentSplitContainer.Panel2.Controls.Add(label1);
            contentSplitContainer.Size = new Size(946, 620);
            contentSplitContainer.SplitterDistance = 184;
            // 
            // signInButton
            // 
            signInButton.Size = new Size(184, 57);
            // 
            // signUpButton
            // 
            signUpButton.Size = new Size(184, 57);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 536);
            helpButton.Size = new Size(184, 84);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Size = new Size(184, 76);
            // 
            // label1
            // 
            label1.Font = new Font("Arial", 18F, FontStyle.Bold, GraphicsUnit.Point);
            label1.Location = new Point(262, 14);
            label1.Name = "label1";
            label1.Size = new Size(192, 43);
            label1.TabIndex = 0;
            label1.Text = "Add AirCraft";
            // 
            // CapacityTextBox
            // 
            CapacityTextBox.Location = new Point(526, 311);
            CapacityTextBox.Name = "CapacityTextBox";
            CapacityTextBox.Size = new Size(161, 27);
            CapacityTextBox.TabIndex = 5;
            // 
            // ManufactureYearTextBox
            // 
            ManufactureYearTextBox.Location = new Point(58, 204);
            ManufactureYearTextBox.Name = "ManufactureYearTextBox";
            ManufactureYearTextBox.Size = new Size(165, 27);
            ManufactureYearTextBox.TabIndex = 6;
            // 
            // AirCraftYearTextBox
            // 
            AirCraftYearTextBox.Location = new Point(526, 204);
            AirCraftYearTextBox.Name = "AirCraftYearTextBox";
            AirCraftYearTextBox.Size = new Size(161, 27);
            AirCraftYearTextBox.TabIndex = 7;
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(57, 94);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(164, 27);
            ModelTextBox.TabIndex = 8;
            // 
            // ManfucaturerTextBox
            // 
            ManfucaturerTextBox.Location = new Point(526, 94);
            ManfucaturerTextBox.Name = "ManfucaturerTextBox";
            ManfucaturerTextBox.Size = new Size(161, 27);
            ManfucaturerTextBox.TabIndex = 9;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(58, 287);
            label3.Name = "label3";
            label3.Size = new Size(49, 20);
            label3.TabIndex = 11;
            label3.Text = "Status";
            label3.Click += label3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(526, 288);
            label5.Name = "label5";
            label5.Size = new Size(66, 20);
            label5.TabIndex = 13;
            label5.Text = "Capacity";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(57, 181);
            label6.Name = "label6";
            label6.Size = new Size(124, 20);
            label6.TabIndex = 14;
            label6.Text = "Manfucature Year";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(57, 71);
            label7.Name = "label7";
            label7.Size = new Size(52, 20);
            label7.TabIndex = 15;
            label7.Text = "Model";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(526, 181);
            label8.Name = "label8";
            label8.Size = new Size(92, 20);
            label8.TabIndex = 16;
            label8.Text = "AirCraft Year";
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(526, 71);
            label9.Name = "label9";
            label9.Size = new Size(97, 20);
            label9.TabIndex = 17;
            label9.Text = "Manfucaturer";
            // 
            // AirCraftComboBox
            // 
            AirCraftComboBox.FormattingEnabled = true;
            AirCraftComboBox.Items.AddRange(new object[] { "Active", "Inactive", "Maintainance" });
            AirCraftComboBox.Location = new Point(57, 310);
            AirCraftComboBox.Name = "AirCraftComboBox";
            AirCraftComboBox.Size = new Size(166, 28);
            AirCraftComboBox.TabIndex = 19;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(291, 480);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(146, 29);
            AddButton.TabIndex = 20;
            AddButton.Text = "Add";
            AddButton.UseVisualStyleBackColor = true;
            // 
            // AirCraftTextBox
            // 
            AirCraftTextBox.Location = new Point(57, 402);
            AirCraftTextBox.Name = "AirCraftTextBox";
            AirCraftTextBox.Size = new Size(166, 27);
            AirCraftTextBox.TabIndex = 21;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 379);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 22;
            label2.Text = "AirCraft Type";
            // 
            // AddAirCraft
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(946, 620);
            Name = "AddAirCraft";
            Text = "AddAirCraft";
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            contentSplitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label3;
        private TextBox ManfucaturerTextBox;
        private TextBox ModelTextBox;
        private TextBox AirCraftYearTextBox;
        private TextBox ManufactureYearTextBox;
        private TextBox CapacityTextBox;
        private Button AddButton;
        private ComboBox AirCraftComboBox;
        private Label label2;
        private TextBox AirCraftTextBox;
    }
}