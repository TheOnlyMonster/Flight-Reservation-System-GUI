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
            textBox5 = new TextBox();
            textBox6 = new TextBox();
            textBox7 = new TextBox();
            textBox8 = new TextBox();
            textBox9 = new TextBox();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            label9 = new Label();
            comboBox1 = new ComboBox();
            button1 = new Button();
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
            contentSplitContainer.Panel2.Controls.Add(button1);
            contentSplitContainer.Panel2.Controls.Add(comboBox1);
            contentSplitContainer.Panel2.Controls.Add(label9);
            contentSplitContainer.Panel2.Controls.Add(label8);
            contentSplitContainer.Panel2.Controls.Add(label7);
            contentSplitContainer.Panel2.Controls.Add(label6);
            contentSplitContainer.Panel2.Controls.Add(label5);
            contentSplitContainer.Panel2.Controls.Add(label3);
            contentSplitContainer.Panel2.Controls.Add(textBox9);
            contentSplitContainer.Panel2.Controls.Add(textBox8);
            contentSplitContainer.Panel2.Controls.Add(textBox7);
            contentSplitContainer.Panel2.Controls.Add(textBox6);
            contentSplitContainer.Panel2.Controls.Add(textBox5);
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
            // textBox5
            // 
            textBox5.Location = new Point(526, 311);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(161, 27);
            textBox5.TabIndex = 5;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(58, 204);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(165, 27);
            textBox6.TabIndex = 6;
            // 
            // textBox7
            // 
            textBox7.Location = new Point(526, 204);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(161, 27);
            textBox7.TabIndex = 7;
            // 
            // textBox8
            // 
            textBox8.Location = new Point(57, 94);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(164, 27);
            textBox8.TabIndex = 8;
            // 
            // textBox9
            // 
            textBox9.Location = new Point(526, 94);
            textBox9.Name = "textBox9";
            textBox9.Size = new Size(161, 27);
            textBox9.TabIndex = 9;
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
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Active", "Inactive", "Maintainance" });
            comboBox1.Location = new Point(57, 310);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(166, 28);
            comboBox1.TabIndex = 19;
            // 
            // button1
            // 
            button1.Location = new Point(291, 480);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 20;
            button1.Text = "Add";
            button1.UseVisualStyleBackColor = true;
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
        private TextBox textBox9;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private Button button1;
        private ComboBox comboBox1;
    }
}