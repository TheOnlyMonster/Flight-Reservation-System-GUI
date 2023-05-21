namespace FlightReservationSystem
{
    partial class UpdateAirCraft
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
            label11 = new Label();
            StatusComboBoxPanel1 = new ComboBox();
            label10 = new Label();
            ModelTextBoxPnanel1 = new TextBox();
            label4 = new Label();
            AirCraftIdTextBoxPanel1 = new TextBox();
            AirCraftdataGridView = new DataGridView();
            panel2 = new Panel();
            label2 = new Label();
            button2 = new Button();
            StatusComboBox = new ComboBox();
            label9 = new Label();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label1 = new Label();
            ModelTextBox = new TextBox();
            ManufactureTextBox = new TextBox();
            AirCraftTextBox = new TextBox();
            ManufacturerTextBox = new TextBox();
            CapacityTextBox = new TextBox();
            AircraftIdTextBox = new TextBox();
            label3 = new Label();
            AirCraftID = new DataGridViewTextBoxColumn();
            Model = new DataGridViewTextBoxColumn();
            Manufacturer = new DataGridViewTextBoxColumn();
            AirCraftType = new DataGridViewTextBoxColumn();
            ManufactureYear = new DataGridViewTextBoxColumn();
            Capacity = new DataGridViewTextBoxColumn();
            Status = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)AirCraftdataGridView).BeginInit();
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
            contentSplitContainer.Size = new Size(1307, 679);
            contentSplitContainer.SplitterDistance = 253;
            contentSplitContainer.SplitterWidth = 6;
            // 
            // signInButton
            // 
            signInButton.Location = new Point(0, 76);
            signInButton.Margin = new Padding(3, 4, 3, 4);
            signInButton.Size = new Size(253, 76);
            // 
            // signUpButton
            // 
            signUpButton.Margin = new Padding(3, 4, 3, 4);
            signUpButton.Size = new Size(253, 76);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 595);
            helpButton.Margin = new Padding(3, 5, 3, 5);
            helpButton.Size = new Size(253, 84);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Location = new Point(0, 152);
            exploreFlightsButton.Margin = new Padding(3, 5, 3, 5);
            exploreFlightsButton.Size = new Size(253, 76);
            // 
            // panel1
            // 
            panel1.Controls.Add(label11);
            panel1.Controls.Add(StatusComboBoxPanel1);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(ModelTextBoxPnanel1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(AirCraftIdTextBoxPanel1);
            panel1.Controls.Add(AirCraftdataGridView);
            panel1.Location = new Point(3, 4);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(676, 828);
            panel1.TabIndex = 0;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(479, 47);
            label11.Name = "label11";
            label11.Size = new Size(49, 20);
            label11.TabIndex = 21;
            label11.Text = "Status";
            // 
            // StatusComboBoxPanel1
            // 
            StatusComboBoxPanel1.DropDownStyle = ComboBoxStyle.DropDownList;
            StatusComboBoxPanel1.FormattingEnabled = true;
            StatusComboBoxPanel1.Items.AddRange(new object[] { "Active", "Inactive", "Maintainance" });
            StatusComboBoxPanel1.Location = new Point(534, 42);
            StatusComboBoxPanel1.Name = "StatusComboBoxPanel1";
            StatusComboBoxPanel1.Size = new Size(125, 28);
            StatusComboBoxPanel1.TabIndex = 20;
            StatusComboBoxPanel1.SelectedIndexChanged += StatusComboBoxPanel1_SelectedIndexChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(270, 47);
            label10.Name = "label10";
            label10.Size = new Size(52, 20);
            label10.TabIndex = 19;
            label10.Text = "Model";
            // 
            // ModelTextBoxPnanel1
            // 
            ModelTextBoxPnanel1.Location = new Point(328, 40);
            ModelTextBoxPnanel1.Name = "ModelTextBoxPnanel1";
            ModelTextBoxPnanel1.Size = new Size(125, 27);
            ModelTextBoxPnanel1.TabIndex = 18;
            ModelTextBoxPnanel1.TextChanged += ModelTextBoxPnanel1_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(23, 47);
            label4.Name = "label4";
            label4.Size = new Size(79, 20);
            label4.TabIndex = 17;
            label4.Text = "AirCraft ID";
            // 
            // AirCraftIdTextBoxPanel1
            // 
            AirCraftIdTextBoxPanel1.Location = new Point(108, 40);
            AirCraftIdTextBoxPanel1.Name = "AirCraftIdTextBoxPanel1";
            AirCraftIdTextBoxPanel1.Size = new Size(125, 27);
            AirCraftIdTextBoxPanel1.TabIndex = 4;
            AirCraftIdTextBoxPanel1.TextChanged += AirCraftIdTextBoxPanel1_TextChanged;
            // 
            // AirCraftdataGridView
            // 
            AirCraftdataGridView.AllowUserToAddRows = false;
            AirCraftdataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            AirCraftdataGridView.BackgroundColor = SystemColors.Control;
            AirCraftdataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            AirCraftdataGridView.Columns.AddRange(new DataGridViewColumn[] { AirCraftID, Model, Manufacturer, AirCraftType, ManufactureYear, Capacity, Status });
            AirCraftdataGridView.Location = new Point(3, 88);
            AirCraftdataGridView.Name = "AirCraftdataGridView";
            AirCraftdataGridView.RowHeadersWidth = 51;
            AirCraftdataGridView.RowTemplate.Height = 29;
            AirCraftdataGridView.Size = new Size(670, 737);
            AirCraftdataGridView.TabIndex = 0;
            // 
            // panel2
            // 
            panel2.Controls.Add(label2);
            panel2.Controls.Add(button2);
            panel2.Controls.Add(StatusComboBox);
            panel2.Controls.Add(label9);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label1);
            panel2.Controls.Add(ModelTextBox);
            panel2.Controls.Add(ManufactureTextBox);
            panel2.Controls.Add(AirCraftTextBox);
            panel2.Controls.Add(ManufacturerTextBox);
            panel2.Controls.Add(CapacityTextBox);
            panel2.Controls.Add(AircraftIdTextBox);
            panel2.Controls.Add(label3);
            panel2.Location = new Point(685, 6);
            panel2.Name = "panel2";
            panel2.Size = new Size(360, 826);
            panel2.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(206, 182);
            label2.Name = "label2";
            label2.Size = new Size(95, 20);
            label2.TabIndex = 20;
            label2.Text = "AirCraft Type";
            // 
            // button2
            // 
            button2.Location = new Point(131, 550);
            button2.Name = "button2";
            button2.Size = new Size(125, 29);
            button2.TabIndex = 19;
            button2.Text = "Confirm";
            button2.UseVisualStyleBackColor = true;
            // 
            // StatusComboBox
            // 
            StatusComboBox.FormattingEnabled = true;
            StatusComboBox.Location = new Point(41, 372);
            StatusComboBox.Name = "StatusComboBox";
            StatusComboBox.Size = new Size(125, 28);
            StatusComboBox.TabIndex = 17;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(41, 96);
            label9.Name = "label9";
            label9.Size = new Size(79, 20);
            label9.TabIndex = 16;
            label9.Text = "AirCraft ID";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(204, 96);
            label8.Name = "label8";
            label8.Size = new Size(52, 20);
            label8.TabIndex = 15;
            label8.Text = "Model";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(41, 182);
            label7.Name = "label7";
            label7.Size = new Size(124, 20);
            label7.TabIndex = 14;
            label7.Text = "Manufacture Year";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(204, 263);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 13;
            label6.Text = "Capacity";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(41, 349);
            label5.Name = "label5";
            label5.Size = new Size(49, 20);
            label5.TabIndex = 12;
            label5.Text = "Status";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 263);
            label1.Name = "label1";
            label1.Size = new Size(97, 20);
            label1.TabIndex = 9;
            label1.Text = "Manufacturer";
            // 
            // ModelTextBox
            // 
            ModelTextBox.Location = new Point(204, 119);
            ModelTextBox.Name = "ModelTextBox";
            ModelTextBox.Size = new Size(125, 27);
            ModelTextBox.TabIndex = 8;
            // 
            // ManufactureTextBox
            // 
            ManufactureTextBox.Location = new Point(41, 205);
            ManufactureTextBox.Name = "ManufactureTextBox";
            ManufactureTextBox.Size = new Size(125, 27);
            ManufactureTextBox.TabIndex = 7;
            // 
            // AirCraftTextBox
            // 
            AirCraftTextBox.Location = new Point(204, 205);
            AirCraftTextBox.Name = "AirCraftTextBox";
            AirCraftTextBox.Size = new Size(125, 27);
            AirCraftTextBox.TabIndex = 6;
            // 
            // ManufacturerTextBox
            // 
            ManufacturerTextBox.Location = new Point(41, 286);
            ManufacturerTextBox.Name = "ManufacturerTextBox";
            ManufacturerTextBox.Size = new Size(125, 27);
            ManufacturerTextBox.TabIndex = 5;
            // 
            // CapacityTextBox
            // 
            CapacityTextBox.Location = new Point(204, 286);
            CapacityTextBox.Name = "CapacityTextBox";
            CapacityTextBox.Size = new Size(125, 27);
            CapacityTextBox.TabIndex = 4;
            // 
            // AircraftIdTextBox
            // 
            AircraftIdTextBox.Location = new Point(41, 119);
            AircraftIdTextBox.Name = "AircraftIdTextBox";
            AircraftIdTextBox.ReadOnly = true;
            AircraftIdTextBox.Size = new Size(125, 27);
            AircraftIdTextBox.TabIndex = 3;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 14.25F, FontStyle.Bold, GraphicsUnit.Point);
            label3.Location = new Point(95, 38);
            label3.Name = "label3";
            label3.Size = new Size(186, 32);
            label3.TabIndex = 2;
            label3.Text = "Update AirCraft";
            // 
            // AirCraftID
            // 
            AirCraftID.HeaderText = "Aircraft ID";
            AirCraftID.MinimumWidth = 6;
            AirCraftID.Name = "AirCraftID";
            // 
            // Model
            // 
            Model.HeaderText = "Model";
            Model.MinimumWidth = 6;
            Model.Name = "Model";
            // 
            // Manufacturer
            // 
            Manufacturer.HeaderText = "Manufacturer";
            Manufacturer.MinimumWidth = 6;
            Manufacturer.Name = "Manufacturer";
            // 
            // AirCraftType
            // 
            AirCraftType.HeaderText = "AirCraft Type";
            AirCraftType.MinimumWidth = 6;
            AirCraftType.Name = "AirCraftType";
            // 
            // ManufactureYear
            // 
            ManufactureYear.HeaderText = "Manufacture Year";
            ManufactureYear.MinimumWidth = 6;
            ManufactureYear.Name = "ManufactureYear";
            // 
            // Capacity
            // 
            Capacity.HeaderText = "Capacity";
            Capacity.MinimumWidth = 6;
            Capacity.Name = "Capacity";
            // 
            // Status
            // 
            Status.HeaderText = "Status";
            Status.MinimumWidth = 6;
            Status.Name = "Status";
            // 
            // UpdateAirCraft
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1307, 679);
            Margin = new Padding(3, 5, 3, 5);
            Name = "UpdateAirCraft";
            Text = "UpdateAircCraft";
            Load += UpdateAirCraft_Load;
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)AirCraftdataGridView).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private DataGridView AirCraftdataGridView;
        private Button button2;
        private ComboBox StatusComboBox;
        private Label label9;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label1;
        private TextBox ModelTextBox;
        private TextBox ManufactureTextBox;
        private TextBox AirCraftTextBox;
        private TextBox ManufacturerTextBox;
        private TextBox CapacityTextBox;
        private TextBox AircraftIdTextBox;
        private Label label3;
        private Label label2;
        private Label label11;
        private ComboBox StatusComboBoxPanel1;
        private Label label10;
        private TextBox ModelTextBoxPnanel1;
        private Label label4;
        private TextBox AirCraftIdTextBoxPanel1;
        private DataGridViewTextBoxColumn AirCraftID;
        private DataGridViewTextBoxColumn Model;
        private DataGridViewTextBoxColumn Manufacturer;
        private DataGridViewTextBoxColumn AirCraftType;
        private DataGridViewTextBoxColumn ManufactureYear;
        private DataGridViewTextBoxColumn Capacity;
        private DataGridViewTextBoxColumn Status;
    }
}