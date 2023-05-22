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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges4 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges5 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges6 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges7 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges8 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges9 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges10 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.AnimatorNS.Animation animation1 = new Guna.UI2.AnimatorNS.Animation();
            contentSplitContainer = new SplitContainer();
            SignOutButton = new Guna.UI2.WinForms.Guna2Button();
            helpButton = new Guna.UI2.WinForms.Guna2Button();
            exploreFlightsButton = new Guna.UI2.WinForms.Guna2Button();
            signUpButton = new Guna.UI2.WinForms.Guna2Button();
            signInButton = new Guna.UI2.WinForms.Guna2Button();
            UpdateReservation = new Button();
            UpdateAircraft = new Button();
            AddAircraft = new Button();
            AddFlight = new Button();
            UpdateFlight = new Button();
            UpdateInfo = new Button();
            bookFlightButton = new Button();
            guna2Transition = new Guna.UI2.WinForms.Guna2Transition();
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            resources.ApplyResources(contentSplitContainer, "contentSplitContainer");
            guna2Transition.SetDecoration(contentSplitContainer, Guna.UI2.AnimatorNS.DecorationType.None);
            contentSplitContainer.Name = "contentSplitContainer";
            // 
            // contentSplitContainer.Panel1
            // 
            resources.ApplyResources(contentSplitContainer.Panel1, "contentSplitContainer.Panel1");
            contentSplitContainer.Panel1.BackColor = SystemColors.MenuHighlight;
            contentSplitContainer.Panel1.Controls.Add(helpButton);
            contentSplitContainer.Panel1.Controls.Add(exploreFlightsButton);
            guna2Transition.SetDecoration(contentSplitContainer.Panel1, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // contentSplitContainer.Panel2
            // 
            resources.ApplyResources(contentSplitContainer.Panel2, "contentSplitContainer.Panel2");
            guna2Transition.SetDecoration(contentSplitContainer.Panel2, Guna.UI2.AnimatorNS.DecorationType.None);
            // 
            // SignOutButton
            // 
            resources.ApplyResources(SignOutButton, "SignOutButton");
            SignOutButton.Animated = true;
            SignOutButton.BackColor = Color.Transparent;
            SignOutButton.BorderColor = Color.Transparent;
            SignOutButton.Cursor = Cursors.Hand;
            SignOutButton.CustomizableEdges = customizableEdges1;
            guna2Transition.SetDecoration(SignOutButton, Guna.UI2.AnimatorNS.DecorationType.None);
            SignOutButton.DisabledState.BorderColor = Color.DarkGray;
            SignOutButton.DisabledState.CustomBorderColor = Color.DarkGray;
            SignOutButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            SignOutButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            SignOutButton.FillColor = Color.Transparent;
            SignOutButton.FocusedColor = Color.Transparent;
            SignOutButton.ForeColor = SystemColors.HighlightText;
            SignOutButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            SignOutButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            SignOutButton.HoverState.Image = (Image)resources.GetObject("resource.Image");
            SignOutButton.Image = (Image)resources.GetObject("SignOutButton.Image");
            SignOutButton.ImageAlign = HorizontalAlignment.Left;
            SignOutButton.Name = "SignOutButton";
            SignOutButton.PressedColor = Color.White;
            SignOutButton.ShadowDecoration.BorderRadius = 20;
            SignOutButton.ShadowDecoration.Color = Color.Transparent;
            SignOutButton.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SignOutButton.TextAlign = HorizontalAlignment.Left;
            SignOutButton.Click += SignOutButton_Click;
            // 
            // helpButton
            // 
            resources.ApplyResources(helpButton, "helpButton");
            helpButton.Animated = true;
            helpButton.BackColor = Color.Transparent;
            helpButton.BorderColor = Color.Transparent;
            helpButton.Cursor = Cursors.Hand;
            helpButton.CustomizableEdges = customizableEdges3;
            guna2Transition.SetDecoration(helpButton, Guna.UI2.AnimatorNS.DecorationType.None);
            helpButton.DisabledState.BorderColor = Color.DarkGray;
            helpButton.DisabledState.CustomBorderColor = Color.DarkGray;
            helpButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            helpButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            helpButton.FillColor = Color.Transparent;
            helpButton.FocusedColor = Color.Transparent;
            helpButton.ForeColor = SystemColors.HighlightText;
            helpButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            helpButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            helpButton.HoverState.Image = (Image)resources.GetObject("resource.Image1");
            helpButton.Image = Properties.Resources.HelpWhite;
            helpButton.ImageAlign = HorizontalAlignment.Left;
            helpButton.Name = "helpButton";
            helpButton.PressedColor = Color.White;
            helpButton.ShadowDecoration.BorderRadius = 20;
            helpButton.ShadowDecoration.Color = Color.Transparent;
            helpButton.ShadowDecoration.CustomizableEdges = customizableEdges4;
            helpButton.TextAlign = HorizontalAlignment.Left;
            // 
            // exploreFlightsButton
            // 
            resources.ApplyResources(exploreFlightsButton, "exploreFlightsButton");
            exploreFlightsButton.Animated = true;
            exploreFlightsButton.BackColor = Color.Transparent;
            exploreFlightsButton.BorderColor = Color.Transparent;
            exploreFlightsButton.Cursor = Cursors.Hand;
            exploreFlightsButton.CustomizableEdges = customizableEdges5;
            guna2Transition.SetDecoration(exploreFlightsButton, Guna.UI2.AnimatorNS.DecorationType.None);
            exploreFlightsButton.DisabledState.BorderColor = Color.DarkGray;
            exploreFlightsButton.DisabledState.CustomBorderColor = Color.DarkGray;
            exploreFlightsButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            exploreFlightsButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            exploreFlightsButton.FillColor = Color.Transparent;
            exploreFlightsButton.FocusedColor = Color.Transparent;
            exploreFlightsButton.ForeColor = SystemColors.HighlightText;
            exploreFlightsButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            exploreFlightsButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            exploreFlightsButton.HoverState.Image = (Image)resources.GetObject("resource.Image2");
            exploreFlightsButton.Image = (Image)resources.GetObject("exploreFlightsButton.Image");
            exploreFlightsButton.ImageAlign = HorizontalAlignment.Left;
            exploreFlightsButton.Name = "exploreFlightsButton";
            exploreFlightsButton.PressedColor = Color.White;
            exploreFlightsButton.ShadowDecoration.BorderRadius = 20;
            exploreFlightsButton.ShadowDecoration.Color = Color.Transparent;
            exploreFlightsButton.ShadowDecoration.CustomizableEdges = customizableEdges6;
            exploreFlightsButton.TextAlign = HorizontalAlignment.Left;
            exploreFlightsButton.Click += exploreFlightsButton_Click;
            // 
            // signUpButton
            // 
            resources.ApplyResources(signUpButton, "signUpButton");
            signUpButton.Animated = true;
            signUpButton.BackColor = Color.Transparent;
            signUpButton.BorderColor = Color.Transparent;
            signUpButton.Cursor = Cursors.Hand;
            signUpButton.CustomizableEdges = customizableEdges7;
            guna2Transition.SetDecoration(signUpButton, Guna.UI2.AnimatorNS.DecorationType.None);
            signUpButton.DisabledState.BorderColor = Color.DarkGray;
            signUpButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signUpButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signUpButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signUpButton.FillColor = Color.Transparent;
            signUpButton.FocusedColor = Color.Transparent;
            signUpButton.ForeColor = SystemColors.HighlightText;
            signUpButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            signUpButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            signUpButton.HoverState.Image = (Image)resources.GetObject("resource.Image3");
            signUpButton.Image = (Image)resources.GetObject("signUpButton.Image");
            signUpButton.ImageAlign = HorizontalAlignment.Left;
            signUpButton.Name = "signUpButton";
            signUpButton.PressedColor = Color.White;
            signUpButton.ShadowDecoration.BorderRadius = 20;
            signUpButton.ShadowDecoration.Color = Color.Transparent;
            signUpButton.ShadowDecoration.CustomizableEdges = customizableEdges8;
            signUpButton.TextAlign = HorizontalAlignment.Left;
            signUpButton.Click += signUpButton_Click;
            // 
            // signInButton
            // 
            resources.ApplyResources(signInButton, "signInButton");
            signInButton.Animated = true;
            signInButton.BackColor = Color.Transparent;
            signInButton.BorderColor = Color.Transparent;
            signInButton.Cursor = Cursors.Hand;
            signInButton.CustomizableEdges = customizableEdges9;
            guna2Transition.SetDecoration(signInButton, Guna.UI2.AnimatorNS.DecorationType.None);
            signInButton.DisabledState.BorderColor = Color.DarkGray;
            signInButton.DisabledState.CustomBorderColor = Color.DarkGray;
            signInButton.DisabledState.FillColor = Color.FromArgb(169, 169, 169);
            signInButton.DisabledState.ForeColor = Color.FromArgb(141, 141, 141);
            signInButton.FillColor = Color.Transparent;
            signInButton.FocusedColor = Color.Transparent;
            signInButton.ForeColor = SystemColors.HighlightText;
            signInButton.HoverState.FillColor = SystemColors.ButtonHighlight;
            signInButton.HoverState.ForeColor = SystemColors.MenuHighlight;
            signInButton.HoverState.Image = (Image)resources.GetObject("resource.Image4");
            signInButton.Image = (Image)resources.GetObject("signInButton.Image");
            signInButton.ImageAlign = HorizontalAlignment.Left;
            signInButton.Name = "signInButton";
            signInButton.PressedColor = Color.White;
            signInButton.ShadowDecoration.BorderRadius = 20;
            signInButton.ShadowDecoration.Color = Color.Transparent;
            signInButton.ShadowDecoration.CustomizableEdges = customizableEdges10;
            signInButton.TextAlign = HorizontalAlignment.Left;
            signInButton.Click += signInButton_Click;
            // 
            // UpdateReservation
            // 
            resources.ApplyResources(UpdateReservation, "UpdateReservation");
            UpdateReservation.BackColor = SystemColors.ButtonHighlight;
            UpdateReservation.Cursor = Cursors.Hand;
            guna2Transition.SetDecoration(UpdateReservation, Guna.UI2.AnimatorNS.DecorationType.None);
            UpdateReservation.ForeColor = SystemColors.HotTrack;
            UpdateReservation.Name = "UpdateReservation";
            UpdateReservation.UseVisualStyleBackColor = false;
            UpdateReservation.Click += UpdateReservation_Click;
            // 
            // UpdateAircraft
            // 
            resources.ApplyResources(UpdateAircraft, "UpdateAircraft");
            UpdateAircraft.BackColor = SystemColors.ButtonHighlight;
            UpdateAircraft.Cursor = Cursors.Hand;
            guna2Transition.SetDecoration(UpdateAircraft, Guna.UI2.AnimatorNS.DecorationType.None);
            UpdateAircraft.ForeColor = SystemColors.HotTrack;
            UpdateAircraft.Name = "UpdateAircraft";
            UpdateAircraft.UseVisualStyleBackColor = false;
            UpdateAircraft.Click += UpdateAircraft_Click;
            // 
            // AddAircraft
            // 
            resources.ApplyResources(AddAircraft, "AddAircraft");
            AddAircraft.BackColor = SystemColors.ButtonHighlight;
            AddAircraft.Cursor = Cursors.Hand;
            guna2Transition.SetDecoration(AddAircraft, Guna.UI2.AnimatorNS.DecorationType.None);
            AddAircraft.ForeColor = SystemColors.HotTrack;
            AddAircraft.Name = "AddAircraft";
            AddAircraft.UseVisualStyleBackColor = false;
            AddAircraft.Click += AddAircraft_Click;
            // 
            // AddFlight
            // 
            resources.ApplyResources(AddFlight, "AddFlight");
            AddFlight.BackColor = SystemColors.ButtonHighlight;
            AddFlight.Cursor = Cursors.Hand;
            guna2Transition.SetDecoration(AddFlight, Guna.UI2.AnimatorNS.DecorationType.None);
            AddFlight.ForeColor = SystemColors.HotTrack;
            AddFlight.Name = "AddFlight";
            AddFlight.UseVisualStyleBackColor = false;
            AddFlight.Click += AddFlight_Click;
            // 
            // UpdateFlight
            // 
            resources.ApplyResources(UpdateFlight, "UpdateFlight");
            UpdateFlight.BackColor = SystemColors.ButtonHighlight;
            UpdateFlight.Cursor = Cursors.Hand;
            guna2Transition.SetDecoration(UpdateFlight, Guna.UI2.AnimatorNS.DecorationType.None);
            UpdateFlight.ForeColor = SystemColors.HotTrack;
            UpdateFlight.Name = "UpdateFlight";
            UpdateFlight.UseVisualStyleBackColor = false;
            UpdateFlight.Click += UpdateFlight_Click;
            // 
            // UpdateInfo
            // 
            resources.ApplyResources(UpdateInfo, "UpdateInfo");
            UpdateInfo.BackColor = SystemColors.ButtonHighlight;
            UpdateInfo.Cursor = Cursors.Hand;
            guna2Transition.SetDecoration(UpdateInfo, Guna.UI2.AnimatorNS.DecorationType.None);
            UpdateInfo.ForeColor = SystemColors.HotTrack;
            UpdateInfo.Name = "UpdateInfo";
            UpdateInfo.UseVisualStyleBackColor = false;
            UpdateInfo.Click += UpdateInfo_Click;
            // 
            // bookFlightButton
            // 
            resources.ApplyResources(bookFlightButton, "bookFlightButton");
            bookFlightButton.BackColor = SystemColors.ButtonHighlight;
            bookFlightButton.Cursor = Cursors.Hand;
            guna2Transition.SetDecoration(bookFlightButton, Guna.UI2.AnimatorNS.DecorationType.None);
            bookFlightButton.ForeColor = SystemColors.HotTrack;
            bookFlightButton.Name = "bookFlightButton";
            bookFlightButton.UseVisualStyleBackColor = false;
            bookFlightButton.Click += bookFlightButton_Click;
            // 
            // guna2Transition
            // 
            guna2Transition.Cursor = null;
            animation1.AnimateOnlyDifferences = true;
            animation1.BlindCoeff = (PointF)resources.GetObject("animation1.BlindCoeff");
            animation1.LeafCoeff = 0F;
            animation1.MaxTime = 1F;
            animation1.MinTime = 0F;
            animation1.MosaicCoeff = (PointF)resources.GetObject("animation1.MosaicCoeff");
            animation1.MosaicShift = (PointF)resources.GetObject("animation1.MosaicShift");
            animation1.MosaicSize = 0;
            animation1.Padding = new Padding(0);
            animation1.RotateCoeff = 0F;
            animation1.RotateLimit = 0F;
            animation1.ScaleCoeff = (PointF)resources.GetObject("animation1.ScaleCoeff");
            animation1.SlideCoeff = (PointF)resources.GetObject("animation1.SlideCoeff");
            animation1.TimeCoeff = 0F;
            animation1.TransparencyCoeff = 0F;
            guna2Transition.DefaultAnimation = animation1;
            guna2Transition.Interval = 5;
            // 
            // MainMenu
            // 
            resources.ApplyResources(this, "$this");
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(contentSplitContainer);
            guna2Transition.SetDecoration(this, Guna.UI2.AnimatorNS.DecorationType.BottomMirror);
            FormBorderStyle = FormBorderStyle.FixedToolWindow;
            HelpButton = true;
            Name = "MainMenu";
            contentSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        protected SplitContainer contentSplitContainer;
        protected Button bookFlightButton;
        protected Button UpdateInfo;

        #endregion
        protected Button UpdateAircraft;
        protected Button AddAircraft;
        protected Button AddFlight;
        protected Button UpdateFlight;
        protected Button UpdateReservation;
        protected Guna.UI2.WinForms.Guna2Button signInButton;
        protected Guna.UI2.WinForms.Guna2Button signUpButton;
        protected Guna.UI2.WinForms.Guna2Button exploreFlightsButton;
        protected Guna.UI2.WinForms.Guna2Button helpButton;
        protected Guna.UI2.WinForms.Guna2Button SignOutButton;
    }
}