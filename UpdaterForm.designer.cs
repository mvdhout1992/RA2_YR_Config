namespace RA2_YR_Config
{
    partial class UpdaterForm
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdaterForm));
            this.TotalProgressBar = new System.Windows.Forms.ProgressBar();
            this.FileProgressBar = new System.Windows.Forms.ProgressBar();
            this.TotalProgressLabel = new System.Windows.Forms.Label();
            this.FileProgressLabel = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // 
            // TotalProgressBar
            // 
            this.TotalProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TotalProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(70)))), ((int)(((byte)(61)))));
            this.TotalProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.TotalProgressBar.Location = new System.Drawing.Point(29, 121);
            this.TotalProgressBar.Name = "TotalProgressBar";
            this.TotalProgressBar.Size = new System.Drawing.Size(423, 23);
            this.TotalProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.TotalProgressBar.TabIndex = 0;
            // 
            // FileProgressBar
            // 
            this.FileProgressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.FileProgressBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(95)))), ((int)(((byte)(70)))), ((int)(((byte)(61)))));
            this.FileProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.FileProgressBar.Location = new System.Drawing.Point(29, 64);
            this.FileProgressBar.Name = "FileProgressBar";
            this.FileProgressBar.Size = new System.Drawing.Size(423, 23);
            this.FileProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.FileProgressBar.TabIndex = 1;
            // 
            // TotalProgressLabel
            // 
            this.TotalProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.TotalProgressLabel.AutoSize = true;
            this.TotalProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.TotalProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.TotalProgressLabel.Location = new System.Drawing.Point(26, 103);
            this.TotalProgressLabel.MaximumSize = new System.Drawing.Size(430, 14);
            this.TotalProgressLabel.Name = "TotalProgressLabel";
            this.TotalProgressLabel.Size = new System.Drawing.Size(78, 13);
            this.TotalProgressLabel.TabIndex = 2;
            this.TotalProgressLabel.Text = "Total Progress:";
            // 
            // FileProgressLabel
            // 
            this.FileProgressLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.FileProgressLabel.AutoSize = true;
            this.FileProgressLabel.BackColor = System.Drawing.Color.Transparent;
            this.FileProgressLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(206)))), ((int)(((byte)(166)))), ((int)(((byte)(107)))));
            this.FileProgressLabel.Location = new System.Drawing.Point(26, 46);
            this.FileProgressLabel.MaximumSize = new System.Drawing.Size(430, 14);
            this.FileProgressLabel.Name = "FileProgressLabel";
            this.FileProgressLabel.Size = new System.Drawing.Size(63, 13);
            this.FileProgressLabel.TabIndex = 3;
            this.FileProgressLabel.Text = "Current File:";
            // 
            // UpdaterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 170);
            this.Controls.Add(this.TotalProgressLabel);
            this.Controls.Add(this.FileProgressBar);
            this.Controls.Add(this.TotalProgressBar);
            this.Controls.Add(this.FileProgressLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(480, 170);
            this.MinimumSize = new System.Drawing.Size(480, 170);
            this.Name = "UpdaterForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Update";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UpdaterForm_FormClosing);
            this.Load += new System.EventHandler(this.UpdaterForm_Load);
            this.Controls.SetChildIndex(this.FileProgressLabel, 0);
            this.Controls.SetChildIndex(this.TotalProgressBar, 0);
            this.Controls.SetChildIndex(this.FileProgressBar, 0);
            this.Controls.SetChildIndex(this.TotalProgressLabel, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar TotalProgressBar;
        private System.Windows.Forms.ProgressBar FileProgressBar;
        private System.Windows.Forms.Label TotalProgressLabel;
        private System.Windows.Forms.Label FileProgressLabel;
    }
}