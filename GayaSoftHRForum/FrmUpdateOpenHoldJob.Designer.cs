namespace GayaSoftHRForum
{
    partial class FrmUpdateOpenHoldJob
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
            this.DgvOpenHoldJob = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.btnclose = new System.Windows.Forms.Button();
            this.btnhold = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpenHoldJob)).BeginInit();
            this.SuspendLayout();
            // 
            // DgvOpenHoldJob
            // 
            this.DgvOpenHoldJob.AllowUserToAddRows = false;
            this.DgvOpenHoldJob.BackgroundColor = System.Drawing.Color.Azure;
            this.DgvOpenHoldJob.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgvOpenHoldJob.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DgvOpenHoldJob.DefaultCellStyle = dataGridViewCellStyle1;
            this.DgvOpenHoldJob.Location = new System.Drawing.Point(0, 134);
            this.DgvOpenHoldJob.Margin = new System.Windows.Forms.Padding(4);
            this.DgvOpenHoldJob.Name = "DgvOpenHoldJob";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DgvOpenHoldJob.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DgvOpenHoldJob.RowHeadersWidth = 51;
            this.DgvOpenHoldJob.Size = new System.Drawing.Size(1256, 185);
            this.DgvOpenHoldJob.TabIndex = 0;
            this.DgvOpenHoldJob.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DgvOpenHoldJob_CellContentClick);
            // 
            // Action
            // 
            this.Action.HeaderText = "Select";
            this.Action.MinimumWidth = 6;
            this.Action.Name = "Action";
            this.Action.Width = 125;
            // 
            // btnclose
            // 
            this.btnclose.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnclose.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnclose.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnclose.Location = new System.Drawing.Point(460, 416);
            this.btnclose.Margin = new System.Windows.Forms.Padding(4);
            this.btnclose.Name = "btnclose";
            this.btnclose.Size = new System.Drawing.Size(109, 47);
            this.btnclose.TabIndex = 2;
            this.btnclose.Text = "Close";
            this.btnclose.UseVisualStyleBackColor = false;
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnhold
            // 
            this.btnhold.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnhold.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnhold.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnhold.Location = new System.Drawing.Point(702, 416);
            this.btnhold.Margin = new System.Windows.Forms.Padding(4);
            this.btnhold.Name = "btnhold";
            this.btnhold.Size = new System.Drawing.Size(111, 47);
            this.btnhold.TabIndex = 3;
            this.btnhold.Text = "Hold";
            this.btnhold.UseVisualStyleBackColor = false;
            this.btnhold.Click += new System.EventHandler(this.btnhold_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label1.Location = new System.Drawing.Point(43, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(229, 31);
            this.label1.TabIndex = 4;
            this.label1.Text = "Update Job Status";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // FrmUpdateOpenHoldJob
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1256, 554);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnhold);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.DgvOpenHoldJob);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FrmUpdateOpenHoldJob";
            this.Text = "FrmUpdateOpenHoldJob";
            this.Load += new System.EventHandler(this.FrmOpenHoldJob_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DgvOpenHoldJob)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView DgvOpenHoldJob;
        private System.Windows.Forms.Button btnclose;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Action;
        private System.Windows.Forms.Button btnhold;
        private System.Windows.Forms.Label label1;
    }
}