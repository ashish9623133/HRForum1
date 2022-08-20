namespace GayaSoftHRForum
{
    partial class Frm_Team_Performance_Report
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Team_Performance_Report));
            this.Team_Performance_Report = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.cbbxteammember = new System.Windows.Forms.ComboBox();
            this.dtpstartdate = new System.Windows.Forms.DateTimePicker();
            this.dtpenddate = new System.Windows.Forms.DateTimePicker();
            this.chbxstatus = new System.Windows.Forms.CheckedListBox();
            this.DGVStatusTotal = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Team_Performance_Report)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatusTotal)).BeginInit();
            this.SuspendLayout();
            // 
            // Team_Performance_Report
            // 
            this.Team_Performance_Report.BorderlineColor = System.Drawing.SystemColors.ButtonHighlight;
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.Team_Performance_Report.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.Team_Performance_Report.Legends.Add(legend4);
            this.Team_Performance_Report.Location = new System.Drawing.Point(16, 127);
            this.Team_Performance_Report.Margin = new System.Windows.Forms.Padding(4);
            this.Team_Performance_Report.Name = "Team_Performance_Report";
            series4.ChartArea = "ChartArea1";
            series4.IsValueShownAsLabel = true;
            series4.Legend = "Legend1";
            series4.Name = "Team_Performance_Report";
            this.Team_Performance_Report.Series.Add(series4);
            this.Team_Performance_Report.Size = new System.Drawing.Size(1154, 442);
            this.Team_Performance_Report.TabIndex = 0;
            this.Team_Performance_Report.Text = "Team_Performance_Report";
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1319, 39);
            this.btnGenerate.Margin = new System.Windows.Forms.Padding(4);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(138, 45);
            this.btnGenerate.TabIndex = 1;
            this.btnGenerate.Text = "Generate";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // cbbxteammember
            // 
            this.cbbxteammember.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbxteammember.FormattingEnabled = true;
            this.cbbxteammember.Location = new System.Drawing.Point(33, 40);
            this.cbbxteammember.Margin = new System.Windows.Forms.Padding(4);
            this.cbbxteammember.Name = "cbbxteammember";
            this.cbbxteammember.Size = new System.Drawing.Size(222, 37);
            this.cbbxteammember.TabIndex = 2;
            // 
            // dtpstartdate
            // 
            this.dtpstartdate.CustomFormat = "YYYY-MM-DD";
            this.dtpstartdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpstartdate.Location = new System.Drawing.Point(370, 39);
            this.dtpstartdate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpstartdate.Name = "dtpstartdate";
            this.dtpstartdate.Size = new System.Drawing.Size(265, 36);
            this.dtpstartdate.TabIndex = 3;
            this.dtpstartdate.Value = new System.DateTime(2022, 1, 1, 0, 0, 0, 0);
            // 
            // dtpenddate
            // 
            this.dtpenddate.CustomFormat = "YYYY-MM-DD";
            this.dtpenddate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpenddate.Location = new System.Drawing.Point(722, 41);
            this.dtpenddate.Margin = new System.Windows.Forms.Padding(4);
            this.dtpenddate.Name = "dtpenddate";
            this.dtpenddate.Size = new System.Drawing.Size(265, 36);
            this.dtpenddate.TabIndex = 4;
            // 
            // chbxstatus
            // 
            this.chbxstatus.BackColor = System.Drawing.Color.LightGray;
            this.chbxstatus.CheckOnClick = true;
            this.chbxstatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chbxstatus.FormattingEnabled = true;
            this.chbxstatus.Items.AddRange(new object[] {
            "placed",
            "Assigned",
            "On_Hold",
            "Rejected",
            "Selected",
            "Offered",
            "Interviewed",
            "Offer_Accepted",
            "Interview_Not_Attended",
            "Interview_Scheduled",
            "Interview_Rescheduled"});
            this.chbxstatus.Location = new System.Drawing.Point(1227, 127);
            this.chbxstatus.Margin = new System.Windows.Forms.Padding(4);
            this.chbxstatus.Name = "chbxstatus";
            this.chbxstatus.Size = new System.Drawing.Size(327, 314);
            this.chbxstatus.TabIndex = 2;
            this.chbxstatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chbxstatus_ItemCheck);
            this.chbxstatus.SelectedIndexChanged += new System.EventHandler(this.chbxstatus_SelectedIndexChanged);
            // 
            // DGVStatusTotal
            // 
            this.DGVStatusTotal.AllowUserToAddRows = false;
            this.DGVStatusTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DGVStatusTotal.BackgroundColor = System.Drawing.Color.Azure;
            this.DGVStatusTotal.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVStatusTotal.Location = new System.Drawing.Point(16, 660);
            this.DGVStatusTotal.Margin = new System.Windows.Forms.Padding(4);
            this.DGVStatusTotal.Name = "DGVStatusTotal";
            this.DGVStatusTotal.RowHeadersWidth = 51;
            this.DGVStatusTotal.Size = new System.Drawing.Size(1556, 249);
            this.DGVStatusTotal.TabIndex = 5;
            this.DGVStatusTotal.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVStatusTotal_CellContentClick);
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(126, 583);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 69);
            this.button1.TabIndex = 55;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(28, 610);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 29);
            this.label1.TabIndex = 56;
            this.label1.Text = "Export";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(269, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 29);
            this.label2.TabIndex = 57;
            this.label2.Text = "From";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(663, 43);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 29);
            this.label3.TabIndex = 58;
            this.label3.Text = "To";
            // 
            // Frm_Team_Performance_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1608, 922);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DGVStatusTotal);
            this.Controls.Add(this.chbxstatus);
            this.Controls.Add(this.dtpenddate);
            this.Controls.Add(this.dtpstartdate);
            this.Controls.Add(this.cbbxteammember);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.Team_Performance_Report);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Frm_Team_Performance_Report";
            this.Text = "Frm_Team_Performance_Report";
            this.Load += new System.EventHandler(this.Frm_Team_Performance_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Team_Performance_Report)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVStatusTotal)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart Team_Performance_Report;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.ComboBox cbbxteammember;
        private System.Windows.Forms.DateTimePicker dtpstartdate;
        private System.Windows.Forms.DateTimePicker dtpenddate;
        private System.Windows.Forms.CheckedListBox chbxstatus;
        private System.Windows.Forms.DataGridView DGVStatusTotal;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}