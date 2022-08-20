namespace GayaSoftHRForum
{
    partial class Jobs
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Jobs));
            this.label3 = new System.Windows.Forms.Label();
            this.gridviewJobAdd = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnaddjob = new System.Windows.Forms.Button();
            this.btnimport = new System.Windows.Forms.Button();
            this.txtserchjob = new System.Windows.Forms.TextBox();
            this.lblsearch = new System.Windows.Forms.Label();
            this.CmbbxFilter_job_Stream = new System.Windows.Forms.ComboBox();
            this.cmbbxFilterJob = new System.Windows.Forms.ComboBox();
            this.btnfilter = new System.Windows.Forms.Button();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn2 = new System.Windows.Forms.DataGridViewImageColumn();
            this.dataGridViewImageColumn3 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button2 = new System.Windows.Forms.Button();
            this.lblExport = new System.Windows.Forms.Label();
            this.btnExport = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.gridviewJobAdd)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label3.Location = new System.Drawing.Point(31, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 25);
            this.label3.TabIndex = 5;
            this.label3.Text = "Show All Job List";
            // 
            // gridviewJobAdd
            // 
            this.gridviewJobAdd.AllowUserToAddRows = false;
            this.gridviewJobAdd.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.gridviewJobAdd.BackgroundColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewJobAdd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.gridviewJobAdd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridviewJobAdd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.gridviewJobAdd.DefaultCellStyle = dataGridViewCellStyle2;
            this.gridviewJobAdd.Location = new System.Drawing.Point(12, 113);
            this.gridviewJobAdd.Name = "gridviewJobAdd";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.gridviewJobAdd.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.gridviewJobAdd.RowHeadersWidth = 51;
            this.gridviewJobAdd.RowTemplate.Height = 30;
            this.gridviewJobAdd.Size = new System.Drawing.Size(1238, 554);
            this.gridviewJobAdd.TabIndex = 6;
            this.gridviewJobAdd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.gridviewJobAdd_CellContentClick);
            // 
            // Column1
            // 
            this.Column1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column1.HeaderText = "Action";
            this.Column1.Image = ((System.Drawing.Image)(resources.GetObject("Column1.Image")));
            this.Column1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.Width = 52;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column2.HeaderText = "Edit";
            this.Column2.Image = ((System.Drawing.Image)(resources.GetObject("Column2.Image")));
            this.Column2.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.Width = 38;
            // 
            // Column3
            // 
            this.Column3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.Column3.HeaderText = "Delete";
            this.Column3.Image = ((System.Drawing.Image)(resources.GetObject("Column3.Image")));
            this.Column3.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Zoom;
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.Width = 55;
            // 
            // btnaddjob
            // 
            this.btnaddjob.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnaddjob.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnaddjob.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnaddjob.Location = new System.Drawing.Point(46, 51);
            this.btnaddjob.Name = "btnaddjob";
            this.btnaddjob.Size = new System.Drawing.Size(92, 33);
            this.btnaddjob.TabIndex = 7;
            this.btnaddjob.Text = "Add Job ";
            this.btnaddjob.UseVisualStyleBackColor = false;
            this.btnaddjob.Click += new System.EventHandler(this.btnaddjob_Click);
            // 
            // btnimport
            // 
            this.btnimport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnimport.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnimport.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnimport.Location = new System.Drawing.Point(377, 51);
            this.btnimport.Name = "btnimport";
            this.btnimport.Size = new System.Drawing.Size(92, 33);
            this.btnimport.TabIndex = 8;
            this.btnimport.Text = "Import";
            this.btnimport.UseVisualStyleBackColor = false;
            this.btnimport.Click += new System.EventHandler(this.btnimport_Click);
            // 
            // txtserchjob
            // 
            this.txtserchjob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtserchjob.Location = new System.Drawing.Point(574, 58);
            this.txtserchjob.Name = "txtserchjob";
            this.txtserchjob.Size = new System.Drawing.Size(194, 26);
            this.txtserchjob.TabIndex = 11;
            this.txtserchjob.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.txtserchjob.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtserchjob_KeyPress);
            // 
            // lblsearch
            // 
            this.lblsearch.AutoSize = true;
            this.lblsearch.BackColor = System.Drawing.Color.Transparent;
            this.lblsearch.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblsearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblsearch.Location = new System.Drawing.Point(501, 58);
            this.lblsearch.Name = "lblsearch";
            this.lblsearch.Size = new System.Drawing.Size(67, 22);
            this.lblsearch.TabIndex = 12;
            this.lblsearch.Text = "Search";
            // 
            // CmbbxFilter_job_Stream
            // 
            this.CmbbxFilter_job_Stream.DropDownHeight = 108;
            this.CmbbxFilter_job_Stream.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CmbbxFilter_job_Stream.FormattingEnabled = true;
            this.CmbbxFilter_job_Stream.IntegralHeight = false;
            this.CmbbxFilter_job_Stream.Location = new System.Drawing.Point(776, 58);
            this.CmbbxFilter_job_Stream.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.CmbbxFilter_job_Stream.Name = "CmbbxFilter_job_Stream";
            this.CmbbxFilter_job_Stream.Size = new System.Drawing.Size(194, 28);
            this.CmbbxFilter_job_Stream.TabIndex = 14;
            this.CmbbxFilter_job_Stream.SelectedIndexChanged += new System.EventHandler(this.CmbbxFilter_job_Stream_SelectedIndexChanged);
            // 
            // cmbbxFilterJob
            // 
            this.cmbbxFilterJob.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxFilterJob.FormattingEnabled = true;
            this.cmbbxFilterJob.Location = new System.Drawing.Point(985, 58);
            this.cmbbxFilterJob.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbbxFilterJob.Name = "cmbbxFilterJob";
            this.cmbbxFilterJob.Size = new System.Drawing.Size(194, 28);
            this.cmbbxFilterJob.TabIndex = 16;
            this.cmbbxFilterJob.SelectedIndexChanged += new System.EventHandler(this.cmbbxFilterJob_SelectedIndexChanged);
            // 
            // btnfilter
            // 
            this.btnfilter.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnfilter.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnfilter.ForeColor = System.Drawing.Color.White;
            this.btnfilter.Location = new System.Drawing.Point(815, 11);
            this.btnfilter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnfilter.Name = "btnfilter";
            this.btnfilter.Size = new System.Drawing.Size(93, 33);
            this.btnfilter.TabIndex = 17;
            this.btnfilter.Text = "Filter";
            this.btnfilter.UseVisualStyleBackColor = false;
            this.btnfilter.Click += new System.EventHandler(this.btnfilter_Click);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn1.HeaderText = "Action";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.MinimumWidth = 6;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // dataGridViewImageColumn2
            // 
            this.dataGridViewImageColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn2.HeaderText = "Edit";
            this.dataGridViewImageColumn2.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn2.Image")));
            this.dataGridViewImageColumn2.MinimumWidth = 6;
            this.dataGridViewImageColumn2.Name = "dataGridViewImageColumn2";
            // 
            // dataGridViewImageColumn3
            // 
            this.dataGridViewImageColumn3.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.dataGridViewImageColumn3.HeaderText = "Delete";
            this.dataGridViewImageColumn3.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn3.Image")));
            this.dataGridViewImageColumn3.MinimumWidth = 6;
            this.dataGridViewImageColumn3.Name = "dataGridViewImageColumn3";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(776, 12);
            this.button2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(27, 32);
            this.button2.TabIndex = 50;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblExport
            // 
            this.lblExport.AutoSize = true;
            this.lblExport.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExport.ForeColor = System.Drawing.Color.White;
            this.lblExport.Location = new System.Drawing.Point(215, 60);
            this.lblExport.Name = "lblExport";
            this.lblExport.Size = new System.Drawing.Size(54, 17);
            this.lblExport.TabIndex = 55;
            this.lblExport.Text = "Export";
            // 
            // btnExport
            // 
            this.btnExport.Image = ((System.Drawing.Image)(resources.GetObject("btnExport.Image")));
            this.btnExport.Location = new System.Drawing.Point(285, 37);
            this.btnExport.Name = "btnExport";
            this.btnExport.Size = new System.Drawing.Size(61, 56);
            this.btnExport.TabIndex = 54;
            this.btnExport.UseVisualStyleBackColor = true;
            this.btnExport.Click += new System.EventHandler(this.btnExport_Click_1);
            // 
            // Jobs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1270, 679);
            this.Controls.Add(this.lblExport);
            this.Controls.Add(this.btnExport);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnfilter);
            this.Controls.Add(this.cmbbxFilterJob);
            this.Controls.Add(this.CmbbxFilter_job_Stream);
            this.Controls.Add(this.lblsearch);
            this.Controls.Add(this.txtserchjob);
            this.Controls.Add(this.btnimport);
            this.Controls.Add(this.btnaddjob);
            this.Controls.Add(this.gridviewJobAdd);
            this.Controls.Add(this.label3);
            this.Name = "Jobs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Jobs";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Jobs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridviewJobAdd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView gridviewJobAdd;
        private System.Windows.Forms.Button btnaddjob;
        private System.Windows.Forms.Button btnimport;
        private System.Windows.Forms.TextBox txtserchjob;
        private System.Windows.Forms.Label lblsearch;
        private System.Windows.Forms.ComboBox CmbbxFilter_job_Stream;
        private System.Windows.Forms.ComboBox cmbbxFilterJob;
        private System.Windows.Forms.Button btnfilter;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn2;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn3;
        private System.Windows.Forms.DataGridViewImageColumn Column1;
        private System.Windows.Forms.DataGridViewImageColumn Column2;
        private System.Windows.Forms.DataGridViewImageColumn Column3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblExport;
        private System.Windows.Forms.Button btnExport;
    }
}