namespace UpgradedTimers
{
    partial class mainForm
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
            this.groupLocations = new System.Windows.Forms.GroupBox();
            this.locationsPlaceholder = new System.Windows.Forms.Label();
            this.groupActions = new System.Windows.Forms.GroupBox();
            this.groupExtractTimes = new System.Windows.Forms.GroupBox();
            this.extractPlaceholder = new System.Windows.Forms.Label();
            this.groupLocations.SuspendLayout();
            this.groupActions.SuspendLayout();
            this.groupExtractTimes.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupLocations
            // 
            this.groupLocations.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupLocations.Controls.Add(this.locationsPlaceholder);
            this.groupLocations.ForeColor = System.Drawing.Color.LightGray;
            this.groupLocations.Location = new System.Drawing.Point(21, 21);
            this.groupLocations.Name = "groupLocations";
            this.groupLocations.Size = new System.Drawing.Size(259, 372);
            this.groupLocations.TabIndex = 0;
            this.groupLocations.TabStop = false;
            this.groupLocations.Text = " Locations ";
            // 
            // locationsPlaceholder
            // 
            this.locationsPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.locationsPlaceholder.Location = new System.Drawing.Point(1, 40);
            this.locationsPlaceholder.Name = "locationsPlaceholder";
            this.locationsPlaceholder.Size = new System.Drawing.Size(257, 29);
            this.locationsPlaceholder.TabIndex = 0;
            this.locationsPlaceholder.Text = "Placeholder";
            this.locationsPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.locationsPlaceholder.Visible = false;
            // 
            // groupActions
            // 
            this.groupActions.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupActions.Controls.Add(this.groupExtractTimes);
            this.groupActions.ForeColor = System.Drawing.Color.LightGray;
            this.groupActions.Location = new System.Drawing.Point(295, 21);
            this.groupActions.Name = "groupActions";
            this.groupActions.Size = new System.Drawing.Size(313, 372);
            this.groupActions.TabIndex = 1;
            this.groupActions.TabStop = false;
            this.groupActions.Text = " Actions ";
            // 
            // groupExtractTimes
            // 
            this.groupExtractTimes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupExtractTimes.Controls.Add(this.extractPlaceholder);
            this.groupExtractTimes.ForeColor = System.Drawing.Color.LightGray;
            this.groupExtractTimes.Location = new System.Drawing.Point(1, 24);
            this.groupExtractTimes.Name = "groupExtractTimes";
            this.groupExtractTimes.Size = new System.Drawing.Size(311, 180);
            this.groupExtractTimes.TabIndex = 2;
            this.groupExtractTimes.TabStop = false;
            this.groupExtractTimes.Text = " Extract times ";
            // 
            // extractPlaceholder
            // 
            this.extractPlaceholder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(50)))));
            this.extractPlaceholder.Location = new System.Drawing.Point(1, 21);
            this.extractPlaceholder.Name = "extractPlaceholder";
            this.extractPlaceholder.Size = new System.Drawing.Size(309, 29);
            this.extractPlaceholder.TabIndex = 1;
            this.extractPlaceholder.Text = "Placeholder";
            this.extractPlaceholder.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.extractPlaceholder.Visible = false;
            // 
            // mainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(35)))), ((int)(((byte)(40)))));
            this.ClientSize = new System.Drawing.Size(631, 417);
            this.Controls.Add(this.groupActions);
            this.Controls.Add(this.groupLocations);
            this.Font = new System.Drawing.Font("Bahnschrift Light", 11F);
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(647, 456);
            this.Name = "mainForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "UpgradedTimers";
            this.Load += new System.EventHandler(this.mainForm_Load);
            this.groupLocations.ResumeLayout(false);
            this.groupActions.ResumeLayout(false);
            this.groupExtractTimes.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupLocations;
        private System.Windows.Forms.Label locationsPlaceholder;
        private System.Windows.Forms.GroupBox groupActions;
        private System.Windows.Forms.GroupBox groupExtractTimes;
        private System.Windows.Forms.Label extractPlaceholder;
    }
}

