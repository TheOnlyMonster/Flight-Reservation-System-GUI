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
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges12 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges13 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges14 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges15 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges16 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges17 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges18 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges19 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges20 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SignInForm));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            signInPanel = new Panel();
            showPasswordCheckBox = new Guna.UI2.WinForms.Guna2CheckBox();
            usernameSignInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            passwordSignInTextBox = new Guna.UI2.WinForms.Guna2TextBox();
            signInPanelButton = new Guna.UI2.WinForms.Guna2Button();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.Panel2.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            signInPanel.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            // 
            // contentSplitContainer.Panel2
            // 
            contentSplitContainer.Panel2.Controls.Add(signInPanel);
            // 
            // signInPanel
            // 
            signInPanel.BackgroundImage = (Image)resources.GetObject("signInPanel.BackgroundImage");
            signInPanel.BackgroundImageLayout = ImageLayout.Stretch;
            signInPanel.Controls.Add(showPasswordCheckBox);
            signInPanel.Controls.Add(usernameSignInTextBox);
            signInPanel.Controls.Add(passwordSignInTextBox);
            signInPanel.Controls.Add(signInPanelButton);
            signInPanel.Dock = DockStyle.Fill;
            signInPanel.Location = new Point(0, 0);
            signInPanel.Name = "signInPanel";
            signInPanel.Size = new Size(1188, 756);
            signInPanel.TabIndex = 0;
            // 
            // showPasswordCheckBox
            // 
            showPasswordCheckBox.AutoSize = true;
            showPasswordCheckBox.BackColor = Color.Transparent;
            showPasswordCheckBox.CheckedState.BorderColor = Color.FromArgb(94, 148, 255);
            showPasswordCheckBox.CheckedState.BorderRadius = 0;
            showPasswordCheckBox.CheckedState.BorderThickness = 0;
            showPasswordCheckBox.CheckedState.FillColor = Color.FromArgb(94, 148, 255);
            showPasswordCheckBox.Location = new Point(161, 352);
            showPasswordCheckBox.Name = "showPasswordCheckBox";
            showPasswordCheckBox.Size = new Size(108, 19);
            showPasswordCheckBox.TabIndex = 18;
            showPasswordCheckBox.Text = "Show Password";
            showPasswordCheckBox.UncheckedState.BorderColor = Color.FromArgb(125, 137, 149);
            showPasswordCheckBox.UncheckedState.BorderRadius = 0;
            showPasswordCheckBox.UncheckedState.BorderThickness = 0;
            showPasswordCheckBox.UncheckedState.FillColor = Color.FromArgb(125, 137, 149);
            showPasswordCheckBox.UseVisualStyleBackColor = false;
            showPasswordCheckBox.CheckedChanged += ShowPassword_CheckedChanged;
            // 
            // usernameSignInTextBox
            // 
            usernameSignInTextBox.BackColor = Color.Transparent;
            usernameSignInTextBox.BorderColor = SystemColors.MenuHighlight;
            usernameSignInTextBox.BorderRadius = 20;
            usernameSignInTextBox.CustomizableEdges = customizableEdges1;
            usernameSignInTextBox.DefaultText = "";
            usernameSignInTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            usernameSignInTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            usernameSignInTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            usernameSignInTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            usernameSignInTextBox.FocusedState.BorderColor = SystemColors.MenuHighlight;
            usernameSignInTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            usernameSignInTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            usernameSignInTextBox.Location = new Point(124, 256);
            usernameSignInTextBox.Name = "usernameSignInTextBox";
            usernameSignInTextBox.PasswordChar = '\0';
            usernameSignInTextBox.PlaceholderForeColor = Color.Gray;
            usernameSignInTextBox.PlaceholderText = "Enter Your Email Address";
            usernameSignInTextBox.SelectedText = "";
            usernameSignInTextBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            usernameSignInTextBox.Size = new Size(200, 36);
            usernameSignInTextBox.TabIndex = 5;
            // 
            // passwordSignInTextBox
            // 
            passwordSignInTextBox.BackColor = Color.Transparent;
            passwordSignInTextBox.BorderColor = SystemColors.MenuHighlight;
            passwordSignInTextBox.BorderRadius = 20;
            passwordSignInTextBox.CustomizableEdges = customizableEdges3;
            passwordSignInTextBox.DefaultText = "";
            passwordSignInTextBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            passwordSignInTextBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            passwordSignInTextBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            passwordSignInTextBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            passwordSignInTextBox.FocusedState.BorderColor = SystemColors.MenuHighlight;
            passwordSignInTextBox.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            passwordSignInTextBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            passwordSignInTextBox.Location = new Point(124, 310);
            passwordSignInTextBox.Name = "passwordSignInTextBox";
            passwordSignInTextBox.PlaceholderForeColor = Color.Gray;
            passwordSignInTextBox.PlaceholderText = "Enter Your Password";
            passwordSignInTextBox.SelectedText = "";
            passwordSignInTextBox.ShadowDecoration.CustomizableEdges = customizableEdges4;
            passwordSignInTextBox.Size = new Size(200, 36);
            passwordSignInTextBox.TabIndex = 6;
            passwordSignInTextBox.UseSystemPasswordChar = true;
            // 
            // signInPanelButton
            // 
            signInPanelButton.Animated = true;
            signInPanelButton.BackColor = Color.Transparent;
            signInPanelButton.BorderColor = Color.Transparent;
            signInPanelButton.BorderRadius = 20;
            signInPanelButton.Cursor = Cursors.Hand;
            signInPanelButton.CustomizableEdges = customizableEdges5;
            signInPanelButton.DisabledState.BorderColor = Color.DarkGray;
            signInPanelButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signInPanelButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signInPanelButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signInPanelButton.FillColor = Color.WhiteSmoke;
            signInPanelButton.FocusedColor = Color.Transparent;
            signInPanelButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            signInPanelButton.ForeColor = SystemColors.Desktop;
            signInPanelButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            signInPanelButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            signInPanelButton.HoverState.Image = (Image)resources.GetObject("resource.Image");
            signInPanelButton.Image = (Image)resources.GetObject("signInPanelButton.Image");
            signInPanelButton.ImageAlign = HorizontalAlignment.Left;
            signInPanelButton.Location = new Point(148, 386);
            signInPanelButton.Name = "signInPanelButton";
            signInPanelButton.Padding = new Padding(5);
            signInPanelButton.PressedColor = Color.White;
            signInPanelButton.ShadowDecoration.BorderRadius = 20;
            signInPanelButton.ShadowDecoration.Color = Color.Transparent;
            signInPanelButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            signInPanelButton.Size = new Size(144, 37);
            signInPanelButton.TabIndex = 7;
            signInPanelButton.Text = "Submit";
            signInPanelButton.Click += SignInPanelButton_Click;
            // 
            // SignInForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Name = "SignInForm";
            Text = "Sign In";
            contentSplitContainer.Panel1.ResumeLayout(false);
            contentSplitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            signInPanel.ResumeLayout(false);
            signInPanel.PerformLayout();
            ResumeLayout(false);
        }

        private Panel signInPanel;
        #endregion

        private Guna.UI2.WinForms.Guna2TextBox usernameSignInTextBox;
        private Guna.UI2.WinForms.Guna2TextBox passwordSignInTextBox;
        protected Guna.UI2.WinForms.Guna2Button signInPanelButton;
        private Guna.UI2.WinForms.Guna2CheckBox showPasswordCheckBox;
    }
}