namespace GayaSoftHRForum
{
    partial class InterviewDetails
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
            this.lblInterviewDetails = new System.Windows.Forms.Label();
            this.dataGridViewInterviewDetails = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterviewDetails)).BeginInit();
            this.SuspendLayout();
            // 
            // lblInterviewDetails
            // 
            this.lblInterviewDetails.AutoSize = true;
            this.lblInterviewDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblInterviewDetails.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblInterviewDetails.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblInterviewDetails.Location = new System.Drawing.Point(12, 32);
            this.lblInterviewDetails.Name = "lblInterviewDetails";
            this.lblInterviewDetails.Size = new System.Drawing.Size(214, 31);
            this.lblInterviewDetails.TabIndex = 0;
            this.lblInterviewDetails.Text = "Interview Details";
            // 
            // dataGridViewInterviewDetails
            // 
            this.dataGridViewInterviewDetails.BackgroundColor = System.Drawing.Color.Azure;
            this.dataGridViewInterviewDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewInterviewDetails.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridViewInterviewDetails.Location = new System.Drawing.Point(1, 97);
            this.dataGridViewInterviewDetails.Name = "dataGridViewInterviewDetails";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewInterviewDetails.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridViewInterviewDetails.RowHeadersWidth = 51;
            this.dataGridViewInterviewDetails.RowTemplate.Height = 24;
            this.dataGridViewInterviewDetails.Size = new System.Drawing.Size(1552, 275);
            this.dataGridViewInterviewDetails.TabIndex = 1;
            this.dataGridViewInterviewDetails.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewInterviewDetails_CellContentClick);
            // 
            // InterviewDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1565, 590);
            this.Controls.Add(this.dataGridViewInterviewDetails);
            this.Controls.Add(this.lblInterviewDetails);
            this.Name = "InterviewDetails";
            this.Text = "Interview Details";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.InterviewDetails_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewInterviewDetails)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblInterviewDetails;
        private System.Windows.Forms.DataGridView dataGridViewInterviewDetails;
    }
}