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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges11 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            this.signInPanel = new System.Windows.Forms.Panel();
            this.usernameSignInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.passwordSignInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            this.signInPanelButton = new Guna.UI2.WinForms.Guna2Button();
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
            // 
            // signInPanel
            // 
            this.signInPanel.BackgroundImage = global::FlightReservationSystem.Properties.Resources.signInBackground;
            this.signInPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.signInPanel.Controls.Add(this.usernameSignInTextBox);
            this.signInPanel.Controls.Add(this.passwordSignInTextBox);
            this.signInPanel.Controls.Add(this.signInPanelButton);
            this.signInPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signInPanel.Location = new System.Drawing.Point(0, 0);
            this.signInPanel.Name = "signInPanel";
            this.signInPanel.Size = new System.Drawing.Size(1188, 756);
            this.signInPanel.TabIndex = 0;
            // 
            // usernameSignInTextBox
            // 
            this.usernameSignInTextBox.BackColor = System.Drawing.Color.Transparent;
            this.usernameSignInTextBox.BorderRadius = 20;
            this.usernameSignInTextBox.CustomizableEdges = customizableEdges1;
            this.usernameSignInTextBox.DefaultText = "";
            this.usernameSignInTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.usernameSignInTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.usernameSignInTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameSignInTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.usernameSignInTextBox.FocusedState.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.usernameSignInTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameSignInTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.usernameSignInTextBox.Location = new System.Drawing.Point(505, 291);
            this.usernameSignInTextBox.Name = "usernameSignInTextBox";
            this.usernameSignInTextBox.PasswordChar = '\0';
            this.usernameSignInTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.usernameSignInTextBox.PlaceholderText = "Enter Your Email Address";
            this.usernameSignInTextBox.SelectedText = "";
            this.usernameSignInTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            this.usernameSignInTextBox.Size = new System.Drawing.Size(200, 36);
            this.usernameSignInTextBox.TabIndex = 5;
            // 
            // passwordSignInTextBox
            // 
            this.passwordSignInTextBox.BackColor = System.Drawing.Color.Transparent;
            this.passwordSignInTextBox.BorderRadius = 20;
            this.passwordSignInTextBox.CustomizableEdges = customizableEdges3;
            this.passwordSignInTextBox.DefaultText = "";
            this.passwordSignInTextBox.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.passwordSignInTextBox.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.passwordSignInTextBox.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordSignInTextBox.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.passwordSignInTextBox.FocusedState.BorderColor = System.Drawing.SystemColors.MenuHighlight;
            this.passwordSignInTextBox.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordSignInTextBox.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.passwordSignInTextBox.Location = new System.Drawing.Point(505, 345);
            this.passwordSignInTextBox.Name = "passwordSignInTextBox";
            this.passwordSignInTextBox.PasswordChar = '\0';
            this.passwordSignInTextBox.PlaceholderForeColor = System.Drawing.Color.Gray;
            this.passwordSignInTextBox.PlaceholderText = "Enter Your Password";
            this.passwordSignInTextBox.SelectedText = "";
            this.passwordSignInTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            this.passwordSignInTextBox.Size = new System.Drawing.Size(200, 36);
            this.passwordSignInTextBox.TabIndex = 6;
            // 
            // AddButton
            // 
            this.signInPanelButton.Animated = true;
            this.signInPanelButton.BackColor = System.Drawing.Color.Transparent;
            this.signInPanelButton.BorderColor = System.Drawing.Color.Transparent;
            this.signInPanelButton.BorderRadius = 20;
            this.signInPanelButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.signInPanelButton.CustomizableEdges = customizableEdges5;
            this.signInPanelButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.signInPanelButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.signInPanelButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.signInPanelButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.signInPanelButton.FillColor = System.Drawing.Color.Transparent;
            this.signInPanelButton.FocusedColor = System.Drawing.Color.Transparent;
            this.signInPanelButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.signInPanelButton.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.signInPanelButton.HoverState.FillColor = System.Drawing.SystemColors.ButtonHighlight;
            this.signInPanelButton.HoverState.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.signInPanelButton.HoverState.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.signInPanelButton.Image = global::FlightReservationSystem.Properties.Resources.FlightWhite;
            this.signInPanelButton.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.signInPanelButton.Location = new System.Drawing.Point(532, 402);
            this.signInPanelButton.Name = "AddButton";
            this.signInPanelButton.Padding = new System.Windows.Forms.Padding(5);
            this.signInPanelButton.PressedColor = System.Drawing.Color.White;
            this.signInPanelButton.ShadowDecoration.BorderRadius = 20;
            this.signInPanelButton.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.signInPanelButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            this.signInPanelButton.Size = new System.Drawing.Size(144, 37);
            this.signInPanelButton.TabIndex = 7;
            this.signInPanelButton.Text = "Submit";
            this.signInPanelButton.Click += new System.EventHandler(this.signInPanelButton_Click);
            // 
            // SignInForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1477, 756);
            this.Name = "SignInForm";
            this.Text = "SignInForm";
            this.contentSplitContainer.Panel1.ResumeLayout(false);
            this.contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.contentSplitContainer)).EndInit();
            this.contentSplitContainer.ResumeLayout(false);
            this.signInPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        private Panel signInPanel;
        #endregion

        private Guna.UI2.WinForms.Guna2TextBox usernameSignInTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordSignInTextBox;
        protected Guna.UI2.WinForms.Guna2Button signInPanelButton;
    }
}