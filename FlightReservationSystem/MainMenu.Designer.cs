namespace FlightReservationSystem
{
    partial class MainMenu
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
        protected void InitializeComponent()
        {
            contentSplitContainer = new SplitContainer();
            UpdateInfo = new Button();
            helpButton = new Button();
            exploreFlightsButton = new Button();
            signInButton = new Button();
            signUpButton = new Button();
            bookFlightButton = new Button();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            contentSplitContainer.Dock = DockStyle.Fill;
            contentSplitContainer.IsSplitterFixed = true;
            contentSplitContainer.Location = new Point(0, 0);
            contentSplitContainer.Margin = new Padding(3, 4, 3, 4);
            contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            contentSplitContainer.Panel1.BackColor = SystemColors.InactiveCaption;
         
            contentSplitContainer.Panel1.Controls.Add(helpButton);
            contentSplitContainer.Panel1.Controls.Add(exploreFlightsButton);
            contentSplitContainer.Panel1.ImeMode = ImeMode.NoControl;
            contentSplitContainer.Size = new Size(1351, 793);
            contentSplitContainer.SplitterDistance = 265;
            contentSplitContainer.SplitterWidth = 5;
            contentSplitContainer.TabIndex = 0;
            // 
            // button1
            // 
            UpdateInfo.BackColor = SystemColors.ButtonHighlight;
            UpdateInfo.Cursor = Cursors.Hand;
            UpdateInfo.Dock = DockStyle.Top;
            UpdateInfo.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateInfo.ForeColor = SystemColors.HotTrack;
            UpdateInfo.Location = new Point(0, 76);
            UpdateInfo.Margin = new Padding(3, 4, 3, 4);
            UpdateInfo.Name = "UpdateInfo";
            UpdateInfo.Size = new Size(265, 76);
            UpdateInfo.TabIndex = 4;
            UpdateInfo.Text = "Update Info";
            UpdateInfo.UseVisualStyleBackColor = false;
            UpdateInfo.Click += UpdateInfo_Click;
            // 
            // helpButton
            // 
            helpButton.BackColor = SystemColors.ButtonHighlight;
            helpButton.Cursor = Cursors.Hand;
            helpButton.Dock = DockStyle.Bottom;
            helpButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            helpButton.ForeColor = SystemColors.HotTrack;
            helpButton.Location = new Point(0, 709);
            helpButton.Margin = new Padding(3, 4, 3, 4);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(265, 84);
            helpButton.TabIndex = 3;
            helpButton.Text = "Help";
            helpButton.UseVisualStyleBackColor = false;
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.BackColor = SystemColors.ButtonHighlight;
            exploreFlightsButton.Cursor = Cursors.Hand;
            exploreFlightsButton.Dock = DockStyle.Top;
            exploreFlightsButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            exploreFlightsButton.ForeColor = SystemColors.HotTrack;
            exploreFlightsButton.Location = new Point(0, 0);
            exploreFlightsButton.Margin = new Padding(3, 4, 3, 4);
            exploreFlightsButton.Name = "exploreFlightsButton";
            exploreFlightsButton.Size = new Size(265, 76);
            exploreFlightsButton.TabIndex = 2;
            exploreFlightsButton.Text = "Explore Flights";
            exploreFlightsButton.UseVisualStyleBackColor = false;
            exploreFlightsButton.Click += exploreFlightsButton_Click;
            // 
            // signInButton
            // 
            signInButton.BackColor = SystemColors.ButtonHighlight;
            signInButton.Cursor = Cursors.Hand;
            signInButton.Dock = DockStyle.Top;
            signInButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            signInButton.ForeColor = SystemColors.HotTrack;
            signInButton.Location = new Point(0, 120);
            signInButton.Name = "signInButton";
            signInButton.Size = new Size(232, 57);
            signInButton.TabIndex = 1;
            signInButton.Text = "Sign In";
            signInButton.UseVisualStyleBackColor = false;
            signInButton.Click += signInButton_Click;
            // 
            // signUpButton
            // 
            signUpButton.BackColor = SystemColors.ButtonHighlight;
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.Dock = DockStyle.Top;
            signUpButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            signUpButton.ForeColor = SystemColors.HotTrack;
            signUpButton.Location = new Point(0, 63);
            signUpButton.Name = "signUpButton";
            signUpButton.Size = new Size(232, 57);
            signUpButton.TabIndex = 0;
            signUpButton.Text = "Sign Up";
            signUpButton.UseVisualStyleBackColor = false;
            signUpButton.Click += signUpButton_Click;
            // 
            // bookFlightButton
            // 
            bookFlightButton.BackColor = SystemColors.ButtonHighlight;
            bookFlightButton.Cursor = Cursors.Hand;
            bookFlightButton.Dock = DockStyle.Top;
            bookFlightButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            bookFlightButton.ForeColor = SystemColors.HotTrack;
            bookFlightButton.Location = new Point(0, 0);
            bookFlightButton.Name = "bookFlightButton";
            bookFlightButton.Size = new Size(232, 63);
            bookFlightButton.TabIndex = 3;
            bookFlightButton.Text = "Book Flight";
            bookFlightButton.UseVisualStyleBackColor = false;
            bookFlightButton.Click += bookFlightButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1351, 793);
            Controls.Add(contentSplitContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Margin = new Padding(3, 4, 3, 4);
            Name = "MainMenu";
            Text = "MainMenu";
            contentSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        protected SplitContainer contentSplitContainer;
        protected Button signInButton;
        protected Button signUpButton;
        protected Button helpButton;
        protected Button exploreFlightsButton;
        protected Button bookFlightButton;
        protected Button UpdateInfo;
        #endregion


    }
}