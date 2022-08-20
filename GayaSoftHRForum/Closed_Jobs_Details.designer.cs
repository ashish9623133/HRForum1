namespace GayaSoftHRForum
{
    partial class Closed_Jobs_Details
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grdClosedJobDetails = new System.Windows.Forms.DataGridView();
            this.Re_Open_Job = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lblClosed_Jobs_Details = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdClosedJobDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // grdClosedJobDetails
            // 
            this.grdClosedJobDetails.AllowUserToAddRows = false;
            this.grdClosedJobDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdClosedJobDetails.BackgroundColor = System.Drawing.Color.Azure;
            this.grdClosedJobDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdClosedJobDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Re_Open_Job});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdClosedJobDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdClosedJobDetails.Location = new System.Drawing.Point(-1, 78);
            this.grdClosedJobDetails.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdClosedJobDetails.Name = "grdClosedJobDetails";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdClosedJobDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdClosedJobDetails.RowHeadersWidth = 51;
            this.grdClosedJobDetails.RowTemplate.Height = 24;
            this.grdClosedJobDetails.Size = new System.Drawing.Size(1203, 418);
            this.grdClosedJobDetails.TabIndex = 0;
            this.grdClosedJobDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClosedJobDetails_CellClick);
            this.grdClosedJobDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdClosedJobDetails_CellContentClick);
            // 
            // Re_Open_Job
            // 
            this.Re_Open_Job.HeaderText = "Action";
            this.Re_Open_Job.MinimumWidth = 6;
            this.Re_Open_Job.Name = "Re_Open_Job";
            this.Re_Open_Job.Text = "Re-Open";
            this.Re_Open_Job.UseColumnTextForButtonValue = true;
            this.Re_Open_Job.Width = 50;
            // 
            // lblClosed_Jobs_Details
            // 
            this.lblClosed_Jobs_Details.AutoSize = true;
            this.lblClosed_Jobs_Details.BackColor = System.Drawing.Color.Transparent;
            this.lblClosed_Jobs_Details.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblClosed_Jobs_Details.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblClosed_Jobs_Details.Location = new System.Drawing.Point(12, 9);
            this.lblClosed_Jobs_Details.Name = "lblClosed_Jobs_Details";
            this.lblClosed_Jobs_Details.Size = new System.Drawing.Size(244, 31);
            this.lblClosed_Jobs_Details.TabIndex = 1;
            this.lblClosed_Jobs_Details.Text = "Closed Jobs Details";
            // 
            // Closed_Jobs_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1201, 556);
            this.Controls.Add(this.lblClosed_Jobs_Details);
            this.Controls.Add(this.grdClosedJobDetails);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Closed_Jobs_Details";
            this.Text = "Closed_Jobs_Details";
            this.Load += new System.EventHandler(this.Closed_Jobs_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdClosedJobDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdClosedJobDetails;
        private System.Windows.Forms.Label lblClosed_Jobs_Details;
        private System.Windows.Forms.DataGridViewButtonColumn Re_Open_Job;
    }
}