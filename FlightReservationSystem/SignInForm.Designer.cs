using FlightReservationSystem.Properties;

namespace FlightReservationSystem
{
    partial class SignInForm
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
        private new void InitializeComponent()
        {
            this.signInPanel = new System.Windows.Forms.Panel();
            this.usernameSignInLabel = new System.Windows.Forms.Label();
            this.usernameSignInTextBox = new System.Windows.Forms.TextBox();
            this.passwordSignInLabel = new System.Windows.Forms.Label();
            this.passwordSignInTextBox = new System.Windows.Forms.TextBox();
            this.signInPanelButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).BeginInit();
            this.contentSplitContainer.Panel1.SuspendLayout();
            this.contentSplitContainer.Panel2.SuspendLayout();
            this.contentSplitContainer.SuspendLayout();
            this.signInPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            this.contentSplitContainer.Panel2.Controls.Add(this.signInPanel);
            this.contentSplitContainer.SplitterDistance = 231;
            // 
            // signInButton
            // 
            this.signInButton.Size = new System.Drawing.Size(231, 57);
            // 
            // signUpButton
            // 
            this.signUpButton.Size = new System.Drawing.Size(231, 57);
            // 
            // helpButton
            // 
            this.helpButton.Size = new System.Drawing.Size(231, 63);
            // 
            // exploreFlightsButton
            // 
            this.exploreFlightsButton.Size = new System.Drawing.Size(231, 57);
            // 
            // signInPanel
            // 
            this.signInPanel.BackgroundImage = global::FlightReservationSystem.Properties.Resources.signInBackground;
            this.signInPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signInPanel.Controls.Add(this.usernameSignInLabel);
            this.signInPanel.Controls.Add(this.usernameSignInTextBox);
            this.signInPanel.Controls.Add(this.passwordSignInLabel);
            this.signInPanel.Controls.Add(this.passwordSignInTextBox);
            this.signInPanel.Controls.Add(this.signInPanelButton);
            this.signInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInPanel.Location = new System.Drawing.Point(0, 0);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(947, 595);
            this.signInPanel.TabIndex = 0;
            // 
            // usernameSignInLabel
            // 
            this.usernameSignInLabel.Location = new System.Drawing.Point(36, 12);
            this.usernameSignInLabel.Name = "usernameSignInLabel";
            this.usernameSignInLabel.Size = new System.Drawing.Size(100, 23);
            this.usernameSignInLabel.TabIndex = 0;
            this.usernameSignInLabel.Text = "Email";
            // 
            // usernameSignInTextBox
            // 
            this.usernameSignInTextBox.Location = new System.Drawing.Point(142, 12);
            this.usernameSignInTextBox.Name = "usernameSignInTextBox";
            this.usernameSignInTextBox.Size = new System.Drawing.Size(218, 23);
            this.usernameSignInTextBox.TabIndex = 1;
            // 
            // passwordSignInLabel
            // 
            this.passwordSignInLabel.Location = new System.Drawing.Point(36, 41);
            this.passwordSignInLabel.Name = "passwordSignInLabel";
            this.passwordSignInLabel.Size = new System.Drawing.Size(100, 23);
            this.passwordSignInLabel.TabIndex = 2;
            this.passwordSignInLabel.Text = "Password";
            // 
            // passwordSignInTextBox
            // 
            this.passwordSignInTextBox.Location = new System.Drawing.Point(142, 41);
            this.passwordSignInTextBox.Name = "passwordSignInTextBox";
            this.passwordSignInTextBox.Size = new System.Drawing.Size(218, 23);
            this.passwordSignInTextBox.TabIndex = 3;
            // 
            // signInPanelButton
            // 
            this.signInPanelButton.Location = new System.Drawing.Point(142, 76);
            this.signInPanelButton.Name = "signInPanelButton";
            this.signInPanelButton.Size = new System.Drawing.Size(95, 23);
            this.signInPanelButton.TabIndex = 4;
            this.signInPanelButton.Text = "Submit";
            this.signInPanelButton.Click += new System.EventHandler(this.signInPanelButton_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1182, 595);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.signInPanel.ResumeLayout(false);
            this.signInPanel.PerformLayout();
            this.ResumeLayout(false);

        }
        private Panel signInPanel;
        private Label usernameSignInLabel;
        private TextBox usernameSignInTextBox;
        private Label passwordSignInLabel;
        private TextBox passwordSignInTextBox;
        private Button signInPanelButton;
        #endregion
    }
}