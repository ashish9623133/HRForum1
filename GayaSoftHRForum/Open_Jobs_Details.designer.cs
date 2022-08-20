namespace GayaSoftHRForum
{
    partial class Open_Jobs_Details
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Open_Jobs_Details));
            this.lblOpenJobsDetails = new System.Windows.Forms.Label();
            this.grdOpenJobsDetails = new System.Windows.Forms.DataGridView();
            this.CandidatePipeline = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdOpenJobsDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblOpenJobsDetails
            // 
            this.lblOpenJobsDetails.AutoSize = true;
            this.lblOpenJobsDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblOpenJobsDetails.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold);
            this.lblOpenJobsDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblOpenJobsDetails.Location = new System.Drawing.Point(12, 9);
            this.lblOpenJobsDetails.Name = "lblOpenJobsDetails";
            this.lblOpenJobsDetails.Size = new System.Drawing.Size(231, 32);
            this.lblOpenJobsDetails.TabIndex = 0;
            this.lblOpenJobsDetails.Text = "Open Jobs Details";
            // 
            // grdOpenJobsDetails
            // 
            this.grdOpenJobsDetails.AllowUserToAddRows = false;
            this.grdOpenJobsDetails.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdOpenJobsDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdOpenJobsDetails.BackgroundColor = System.Drawing.Color.Azure;
            this.grdOpenJobsDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdOpenJobsDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CandidatePipeline});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdOpenJobsDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdOpenJobsDetails.Location = new System.Drawing.Point(0, 84);
            this.grdOpenJobsDetails.Name = "grdOpenJobsDetails";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdOpenJobsDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdOpenJobsDetails.RowHeadersWidth = 51;
            this.grdOpenJobsDetails.RowTemplate.Height = 24;
            this.grdOpenJobsDetails.Size = new System.Drawing.Size(1144, 437);
            this.grdOpenJobsDetails.TabIndex = 1;
            this.grdOpenJobsDetails.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOpenJobsDetails_CellClick);
            this.grdOpenJobsDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdOpenJobsDetails_CellContentClick);
            // 
            // CandidatePipeline
            // 
            this.CandidatePipeline.HeaderText = "Candidate Pipeline";
            this.CandidatePipeline.MinimumWidth = 6;
            this.CandidatePipeline.Name = "CandidatePipeline";
            this.CandidatePipeline.Text = "Candidate Pipeline";
            this.CandidatePipeline.UseColumnTextForButtonValue = true;
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(752, 39);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 39);
            this.button2.TabIndex = 49;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Open_Jobs_Details
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1156, 533);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grdOpenJobsDetails);
            this.Controls.Add(this.lblOpenJobsDetails);
            this.Name = "Open_Jobs_Details";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Open_Jobs_Details";
            this.Load += new System.EventHandler(this.Open_Jobs_Details_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdOpenJobsDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblOpenJobsDetails;
        private System.Windows.Forms.DataGridView grdOpenJobsDetails;
        private System.Windows.Forms.DataGridViewButtonColumn CandidatePipeline;
        private System.Windows.Forms.Button button2;
    }
}