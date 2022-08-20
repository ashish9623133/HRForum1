namespace GayaSoftHRForum
{
    partial class frmAddCandidate
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
            this.personalInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationQualificationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.educationQualificationToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.employmentDetailsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.preferranceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // personalInformationToolStripMenuItem
            // 
            this.personalInformationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.personalInformationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.personalInformationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.personalInformationToolStripMenuItem.Name = "personalInformationToolStripMenuItem";
            this.personalInformationToolStripMenuItem.Size = new System.Drawing.Size(245, 30);
            this.personalInformationToolStripMenuItem.Text = "Personal Information";
            this.personalInformationToolStripMenuItem.Click += new System.EventHandler(this.personalInformationToolStripMenuItem_Click);
            // 
            // educationQualificationToolStripMenuItem
            // 
            this.educationQualificationToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.educationQualificationToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.educationQualificationToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.educationQualificationToolStripMenuItem.Name = "educationQualificationToolStripMenuItem";
            this.educationQualificationToolStripMenuItem.Size = new System.Drawing.Size(272, 30);
            this.educationQualificationToolStripMenuItem.Text = "Education Qualification";
            this.educationQualificationToolStripMenuItem.Click += new System.EventHandler(this.educationQualificationToolStripMenuItem_Click);
            // 
            // educationQualificationToolStripMenuItem1
            // 
            this.educationQualificationToolStripMenuItem1.BackColor = System.Drawing.Color.Transparent;
            this.educationQualificationToolStripMenuItem1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.educationQualificationToolStripMenuItem1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.educationQualificationToolStripMenuItem1.Name = "educationQualificationToolStripMenuItem1";
            this.educationQualificationToolStripMenuItem1.Size = new System.Drawing.Size(219, 30);
            this.educationQualificationToolStripMenuItem1.Text = "Upload Documents";
            this.educationQualificationToolStripMenuItem1.Click += new System.EventHandler(this.educationQualificationToolStripMenuItem1_Click);
            // 
            // employmentDetailsToolStripMenuItem
            // 
            this.employmentDetailsToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.employmentDetailsToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.employmentDetailsToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.employmentDetailsToolStripMenuItem.Name = "employmentDetailsToolStripMenuItem";
            this.employmentDetailsToolStripMenuItem.Size = new System.Drawing.Size(229, 30);
            this.employmentDetailsToolStripMenuItem.Text = "Employment details";
            this.employmentDetailsToolStripMenuItem.Click += new System.EventHandler(this.employmentDetailsToolStripMenuItem_Click);
            // 
            // preferranceToolStripMenuItem
            // 
            this.preferranceToolStripMenuItem.BackColor = System.Drawing.Color.Transparent;
            this.preferranceToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.preferranceToolStripMenuItem.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.preferranceToolStripMenuItem.Name = "preferranceToolStripMenuItem";
            this.preferranceToolStripMenuItem.Size = new System.Drawing.Size(150, 30);
            this.preferranceToolStripMenuItem.Text = "Preferrance";
            this.preferranceToolStripMenuItem.Click += new System.EventHandler(this.preferranceToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.GripStyle = System.Windows.Forms.ToolStripGripStyle.Visible;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.personalInformationToolStripMenuItem,
            this.educationQualificationToolStripMenuItem,
            this.educationQualificationToolStripMenuItem1,
            this.employmentDetailsToolStripMenuItem,
            this.preferranceToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1467, 34);
            this.menuStrip1.TabIndex = 59;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // frmAddCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1467, 720);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "frmAddCandidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Candidate";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripMenuItem personalInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationQualificationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem educationQualificationToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem employmentDetailsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem preferranceToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}

