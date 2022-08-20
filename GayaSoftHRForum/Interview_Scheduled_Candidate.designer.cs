namespace GayaSoftHRForum
{
    partial class Interview_Scheduled_Candidate
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
            this.lblInterview_Scheduled_Candidate = new System.Windows.Forms.Label();
            this.grdInterviewScheduledCandidate = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdInterviewScheduledCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInterview_Scheduled_Candidate
            // 
            this.lblInterview_Scheduled_Candidate.AutoSize = true;
            this.lblInterview_Scheduled_Candidate.BackColor = System.Drawing.Color.Transparent;
            this.lblInterview_Scheduled_Candidate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblInterview_Scheduled_Candidate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInterview_Scheduled_Candidate.Location = new System.Drawing.Point(12, 37);
            this.lblInterview_Scheduled_Candidate.Name = "lblInterview_Scheduled_Candidate";
            this.lblInterview_Scheduled_Candidate.Size = new System.Drawing.Size(380, 31);
            this.lblInterview_Scheduled_Candidate.TabIndex = 0;
            this.lblInterview_Scheduled_Candidate.Text = "Interview Scheduled Candidate";
            // 
            // grdInterviewScheduledCandidate
            // 
            this.grdInterviewScheduledCandidate.AllowUserToAddRows = false;
            this.grdInterviewScheduledCandidate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.grdInterviewScheduledCandidate.BackgroundColor = System.Drawing.Color.Azure;
            this.grdInterviewScheduledCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdInterviewScheduledCandidate.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdInterviewScheduledCandidate.Location = new System.Drawing.Point(-1, 124);
            this.grdInterviewScheduledCandidate.Name = "grdInterviewScheduledCandidate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdInterviewScheduledCandidate.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdInterviewScheduledCandidate.RowHeadersWidth = 51;
            this.grdInterviewScheduledCandidate.RowTemplate.Height = 24;
            this.grdInterviewScheduledCandidate.Size = new System.Drawing.Size(801, 252);
            this.grdInterviewScheduledCandidate.TabIndex = 1;
            // 
            // Interview_Scheduled_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.grdInterviewScheduledCandidate);
            this.Controls.Add(this.lblInterview_Scheduled_Candidate);
            this.Name = "Interview_Scheduled_Candidate";
            this.Text = "Interview_Schedule_Candidate";
            this.Load += new System.EventHandler(this.Interview_Scheduled_Candidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdInterviewScheduledCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterview_Scheduled_Candidate;
        private System.Windows.Forms.DataGridView grdInterviewScheduledCandidate;
    }
}