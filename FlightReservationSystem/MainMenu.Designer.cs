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
            helpButton = new Button();
            exploreFlightsButton = new Button();
            UpdateReservation = new Button();
            UpdateAircraft = new Button();
            AddAircraft = new Button();
            AddFlight = new Button();
            UpdateFlight = new Button();
            UpdateInfo = new Button();
            signInButton = new Button();
            signUpButton = new Button();
            bookFlightButton = new Button();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            contentSplitContainer.Dock = DockStyle.Fill;
            contentSplitContainer.IsSplitterFixed = true;
            contentSplitContainer.Location = new Point(0, 0);
            contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            contentSplitContainer.Panel1.BackColor = SystemColors.InactiveCaption;
            contentSplitContainer.Panel1.Controls.Add(helpButton);
            contentSplitContainer.Panel1.Controls.Add(exploreFlightsButton);
            contentSplitContainer.Panel1.ImeMode = ImeMode.NoControl;
            // 
            // contentSplitContainer.Panel2
            // 
            
            contentSplitContainer.Size = new Size(1182, 595);
            contentSplitContainer.SplitterDistance = 230;
            contentSplitContainer.TabIndex = 0;
            // 
            // helpButton
            // 
            helpButton.BackColor = SystemColors.ButtonHighlight;
            helpButton.Cursor = Cursors.Hand;
            helpButton.Dock = DockStyle.Bottom;
            helpButton.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            helpButton.ForeColor = SystemColors.HotTrack;
            helpButton.Location = new Point(0, 532);
            helpButton.Name = "helpButton";
            helpButton.Size = new Size(230, 63);
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
            exploreFlightsButton.Name = "exploreFlightsButton";
            exploreFlightsButton.Size = new Size(230, 57);
            exploreFlightsButton.TabIndex = 2;
            exploreFlightsButton.Text = "Explore Flights";
            exploreFlightsButton.UseVisualStyleBackColor = false;
            exploreFlightsButton.Click += exploreFlightsButton_Click;
            //

            // UpdateReservation
            // 
            UpdateReservation.BackColor = SystemColors.ButtonHighlight;
            UpdateReservation.Cursor = Cursors.Hand;
            UpdateReservation.Dock = DockStyle.Top;
            UpdateReservation.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateReservation.ForeColor = SystemColors.HotTrack;
            UpdateReservation.Location = new Point(0, 285);
            UpdateReservation.Name = "UpdateReservation";
            UpdateReservation.Size = new Size(231, 57);
            UpdateReservation.TabIndex = 8;
            UpdateReservation.Text = "Update Reservation";
            UpdateReservation.UseVisualStyleBackColor = false;
            UpdateReservation.Click += UpdateReservation_Click;
            // 
            // UpdateAircraft
            // 
            UpdateAircraft.BackColor = SystemColors.ButtonHighlight;
            UpdateAircraft.Cursor = Cursors.Hand;
            UpdateAircraft.Dock = DockStyle.Top;
            UpdateAircraft.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateAircraft.ForeColor = SystemColors.HotTrack;
            UpdateAircraft.Location = new Point(0, 228);
            UpdateAircraft.Name = "UpdateAircraft";
            UpdateAircraft.Size = new Size(231, 57);
            UpdateAircraft.TabIndex = 7;
            UpdateAircraft.Text = "Update Aircarft";
            UpdateAircraft.UseVisualStyleBackColor = false;
            UpdateAircraft.Click += UpdateAircraft_Click;
            // 
            // AddAircraft
            // 
            AddAircraft.BackColor = SystemColors.ButtonHighlight;
            AddAircraft.Cursor = Cursors.Hand;
            AddAircraft.Dock = DockStyle.Top;
            AddAircraft.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AddAircraft.ForeColor = SystemColors.HotTrack;
            AddAircraft.Location = new Point(0, 171);
            AddAircraft.Name = "AddAircraft";
            AddAircraft.Size = new Size(231, 57);
            AddAircraft.TabIndex = 6;
            AddAircraft.Text = "Add Aircraft";
            AddAircraft.UseVisualStyleBackColor = false;
            AddAircraft.Click += AddAircraft_Click;
            // 
            // AddFlight
            // 
            AddFlight.BackColor = SystemColors.ButtonHighlight;
            AddFlight.Cursor = Cursors.Hand;
            AddFlight.Dock = DockStyle.Top;
            AddFlight.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            AddFlight.ForeColor = SystemColors.HotTrack;
            AddFlight.Location = new Point(0, 114);
            AddFlight.Name = "AddFlight";
            AddFlight.Size = new Size(231, 57);
            AddFlight.TabIndex = 5;
            AddFlight.Text = "Add Flight";
            AddFlight.UseVisualStyleBackColor = false;
            // 
            // UpdateFlight
            // 
            UpdateFlight.BackColor = SystemColors.ButtonHighlight;
            UpdateFlight.Cursor = Cursors.Hand;
            UpdateFlight.Dock = DockStyle.Top;
            UpdateFlight.Font = new Font("Segoe UI", 13F, FontStyle.Regular, GraphicsUnit.Point);
            UpdateFlight.ForeColor = SystemColors.HotTrack;
            UpdateFlight.Location = new Point(0, 57);
            UpdateFlight.Name = "UpdateFlight";
            UpdateFlight.Size = new Size(231, 57);
            UpdateFlight.TabIndex = 4;
            UpdateFlight.Text = "Update Flight";
            UpdateFlight.UseVisualStyleBackColor = false;
            // 
            // UpdateInfo
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
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1182, 595);
            Controls.Add(contentSplitContainer);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            Name = "MainMenu";
            Text = "MainMenu";
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
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
        protected Button UpdateAircraft;
        protected Button AddAircraft;
        protected Button AddFlight;
        protected Button UpdateFlight;
        protected Button UpdateReservation;
       
    }
}