namespace FlightReservationSystem
{
    partial class AddFlight
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
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).BeginInit();
            contentSplitContainer.Panel1.SuspendLayout();
            contentSplitContainer.SuspendLayout();
            SuspendLayout();
            // 
            // contentSplitContainer
            // 
            contentSplitContainer.Size = new Size(800, 450);
            contentSplitContainer.SplitterDistance = 156;
            // 
            // signInButton
            // 
            signInButton.Size = new Size(156, 57);
            // 
            // signUpButton
            // 
            signUpButton.Size = new Size(156, 57);
            // 
            // helpButton
            // 
            helpButton.Location = new Point(0, 387);
            helpButton.Size = new Size(156, 63);
            // 
            // exploreFlightsButton
            // 
            exploreFlightsButton.Size = new Size(156, 57);
            // 
            // AddFlight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Name = "AddFlight";
            Text = "AddFlight";
            contentSplitContainer.Panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)contentSplitContainer).EndInit();
            contentSplitContainer.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
    }
}