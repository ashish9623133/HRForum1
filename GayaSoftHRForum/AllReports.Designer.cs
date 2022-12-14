namespace GayaSoftHRForum
{
    partial class AllReports
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.teamPerformanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.candidateLifecycleReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clientPerformanceReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.jabStatisticsReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.teamPerformanceReportToolStripMenuItem,
            this.candidateLifecycleReportToolStripMenuItem,
            this.clientPerformanceReportToolStripMenuItem,
            this.jabStatisticsReportToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1028, 30);
            this.menuStrip1.TabIndex = 4;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // teamPerformanceReportToolStripMenuItem
            // 
            this.teamPerformanceReportToolStripMenuItem.Name = "teamPerformanceReportToolStripMenuItem";
            this.teamPerformanceReportToolStripMenuItem.Size = new System.Drawing.Size(240, 26);
            this.teamPerformanceReportToolStripMenuItem.Text = "Team Performance Report";
            this.teamPerformanceReportToolStripMenuItem.Click += new System.EventHandler(this.teamPerformanceReportToolStripMenuItem_Click);
            // 
            // candidateLifecycleReportToolStripMenuItem
            // 
            this.candidateLifecycleReportToolStripMenuItem.Name = "candidateLifecycleReportToolStripMenuItem";
            this.candidateLifecycleReportToolStripMenuItem.Size = new System.Drawing.Size(246, 26);
            this.candidateLifecycleReportToolStripMenuItem.Text = "Candidate Lifecycle Report";
            this.candidateLifecycleReportToolStripMenuItem.Click += new System.EventHandler(this.candidateLifecycleReportToolStripMenuItem_Click);
            // 
            // clientPerformanceReportToolStripMenuItem
            // 
            this.clientPerformanceReportToolStripMenuItem.Name = "clientPerformanceReportToolStripMenuItem";
            this.clientPerformanceReportToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.clientPerformanceReportToolStripMenuItem.Text = "Client Performance Report";
            this.clientPerformanceReportToolStripMenuItem.Click += new System.EventHandler(this.clientPerformanceReportToolStripMenuItem_Click);
            // 
            // jabStatisticsReportToolStripMenuItem
            // 
            this.jabStatisticsReportToolStripMenuItem.Name = "jabStatisticsReportToolStripMenuItem";
            this.jabStatisticsReportToolStripMenuItem.Size = new System.Drawing.Size(193, 26);
            this.jabStatisticsReportToolStripMenuItem.Text = "Job Statistics Report";
            this.jabStatisticsReportToolStripMenuItem.Click += new System.EventHandler(this.jabStatisticsReportToolStripMenuItem_Click);
            // 
            // AllReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1028, 609);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "AllReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AllReports";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.AllReports_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem teamPerformanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem candidateLifecycleReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clientPerformanceReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem jabStatisticsReportToolStripMenuItem;
    }
}