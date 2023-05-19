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
            this.contentSplitContainer = new System.Windows.Forms.SplitContainer();
            this.helpButton = new System.Windows.Forms.Button();
            this.exploreFlightsButton = new System.Windows.Forms.Button();
            this.signInButton = new System.Windows.Forms.Button();
            this.signUpButton = new System.Windows.Forms.Button();
            this.bookFlightButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentSplitContainer
            // 
            this.contentSplitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.contentSplitContainer.IsSplitterFixed = true;
            this.contentSplitContainer.Location = new System.Drawing.Point(0, 0);
            this.contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            this.contentSplitContainer.Panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.contentSplitContainer.Panel1.Controls.Add(this.helpButton);
            this.contentSplitContainer.Panel1.Controls.Add(this.exploreFlightsButton);
            
            this.contentSplitContainer.Panel1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.contentSplitContainer.Size = new System.Drawing.Size(1182, 595);
            this.contentSplitContainer.SplitterDistance = 232;
            this.contentSplitContainer.TabIndex = 0;
            // 
            // helpButton
            // 
            this.helpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.helpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.helpButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.helpButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.helpButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.helpButton.Location = new System.Drawing.Point(0, 532);
            this.helpButton.Name = "helpButton";
            this.helpButton.Size = new System.Drawing.Size(232, 63);
            this.helpButton.TabIndex = 3;
            this.helpButton.Text = "Help";
            this.helpButton.UseVisualStyleBackColor = false;
            // 
            // exploreFlightsButton
            // 
            this.exploreFlightsButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.exploreFlightsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exploreFlightsButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.exploreFlightsButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.exploreFlightsButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.exploreFlightsButton.Location = new System.Drawing.Point(0, 177);
            this.exploreFlightsButton.Name = "exploreFlightsButton";
            this.exploreFlightsButton.Size = new System.Drawing.Size(232, 57);
            this.exploreFlightsButton.TabIndex = 2;
            this.exploreFlightsButton.Text = "Explore Flights";
            this.exploreFlightsButton.UseVisualStyleBackColor = false;
            this.exploreFlightsButton.Click += new System.EventHandler(this.exploreFlightsButton_Click);
            // 
            // signInButton
            // 
            this.signInButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signInButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signInButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signInButton.Location = new System.Drawing.Point(0, 120);
            this.signInButton.Name = "signInButton";
            this.signInButton.Size = new System.Drawing.Size(232, 57);
            this.signInButton.TabIndex = 1;
            this.signInButton.Text = "Sign In";
            this.signInButton.UseVisualStyleBackColor = false;
            this.signInButton.Click += new System.EventHandler(this.signInButton_Click);
            // 
            // signUpButton
            // 
            this.signUpButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signUpButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signUpButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.signUpButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signUpButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.signUpButton.Location = new System.Drawing.Point(0, 63);
            this.signUpButton.Name = "signUpButton";
            this.signUpButton.Size = new System.Drawing.Size(232, 57);
            this.signUpButton.TabIndex = 0;
            this.signUpButton.Text = "Sign Up";
            this.signUpButton.UseVisualStyleBackColor = false;
            this.signUpButton.Click += new System.EventHandler(this.signUpButton_Click);
            // 
            // bookFlightButton
            // 
            this.bookFlightButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.bookFlightButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bookFlightButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.bookFlightButton.Font = new System.Drawing.Font("Segoe UI", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.bookFlightButton.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.bookFlightButton.Location = new System.Drawing.Point(0, 0);
            this.bookFlightButton.Name = "bookFlightButton";
            this.bookFlightButton.Size = new System.Drawing.Size(232, 63);
            this.bookFlightButton.TabIndex = 3;
            this.bookFlightButton.Text = "Book Flight";
            this.bookFlightButton.UseVisualStyleBackColor = false;
            this.bookFlightButton.Click += new System.EventHandler(this.bookFlightButton_Click);
            // 
            // MainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 595);
            this.Controls.Add(this.contentSplitContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "MainMenu";
            this.Text = "MainMenu";
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        
        protected SplitContainer contentSplitContainer;
        protected Button signInButton;
        protected Button signUpButton;
        protected Button helpButton;
        protected Button exploreFlightsButton;
        protected Button bookFlightButton;
        #endregion
    }
}