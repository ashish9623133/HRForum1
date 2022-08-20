namespace GayaSoftHRForum
{
    partial class frmCandidatelifecyclereport
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
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCandidatelifecyclereport));
            this.btngeneratechart = new System.Windows.Forms.Button();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grdview = new System.Windows.Forms.DataGridView();
            this.checklist = new System.Windows.Forms.CheckedListBox();
            this.dtformat1 = new System.Windows.Forms.DateTimePicker();
            this.dtformat2 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).BeginInit();
            this.SuspendLayout();
            // 
            // btngeneratechart
            // 
            this.btngeneratechart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btngeneratechart.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btngeneratechart.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btngeneratechart.Location = new System.Drawing.Point(691, 21);
            this.btngeneratechart.Margin = new System.Windows.Forms.Padding(2);
            this.btngeneratechart.Name = "btngeneratechart";
            this.btngeneratechart.Size = new System.Drawing.Size(104, 28);
            this.btngeneratechart.TabIndex = 3;
            this.btngeneratechart.Text = "Generate Chart";
            this.btngeneratechart.UseVisualStyleBackColor = false;
            this.btngeneratechart.Click += new System.EventHandler(this.btngeneratechart_Click);
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(86, 82);
            this.chart1.Margin = new System.Windows.Forms.Padding(2);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Candidate_Count";
            series1.XValueMember = "Status";
            series1.YValueMembers = "dupe_cnt";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(727, 256);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            this.chart1.MouseClick += new System.Windows.Forms.MouseEventHandler(this.chart1_MouseClick);
            // 
            // grdview
            // 
            this.grdview.BackgroundColor = System.Drawing.Color.Azure;
            this.grdview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdview.GridColor = System.Drawing.Color.Azure;
            this.grdview.Location = new System.Drawing.Point(86, 422);
            this.grdview.Margin = new System.Windows.Forms.Padding(2);
            this.grdview.Name = "grdview";
            this.grdview.RowHeadersWidth = 51;
            this.grdview.RowTemplate.Height = 24;
            this.grdview.Size = new System.Drawing.Size(727, 142);
            this.grdview.TabIndex = 6;
            // 
            // checklist
            // 
            this.checklist.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.checklist.FormattingEnabled = true;
            this.checklist.Location = new System.Drawing.Point(22, 11);
            this.checklist.Margin = new System.Windows.Forms.Padding(2);
            this.checklist.Name = "checklist";
            this.checklist.Size = new System.Drawing.Size(91, 64);
            this.checklist.TabIndex = 17;
            this.checklist.SelectedIndexChanged += new System.EventHandler(this.checkedListBox1_SelectedIndexChanged);
            // 
            // dtformat1
            // 
            this.dtformat1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtformat1.Location = new System.Drawing.Point(168, 21);
            this.dtformat1.Margin = new System.Windows.Forms.Padding(2);
            this.dtformat1.Name = "dtformat1";
            this.dtformat1.Size = new System.Drawing.Size(233, 30);
            this.dtformat1.TabIndex = 18;
            // 
            // dtformat2
            // 
            this.dtformat2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtformat2.Location = new System.Drawing.Point(435, 21);
            this.dtformat2.Margin = new System.Windows.Forms.Padding(2);
            this.dtformat2.Name = "dtformat2";
            this.dtformat2.Size = new System.Drawing.Size(227, 30);
            this.dtformat2.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(228, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(61, 56);
            this.button1.TabIndex = 58;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(133, 355);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 25);
            this.label1.TabIndex = 59;
            this.label1.Text = "Export";
            // 
            // frmCandidatelifecyclereport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(968, 595);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dtformat2);
            this.Controls.Add(this.dtformat1);
            this.Controls.Add(this.checklist);
            this.Controls.Add(this.grdview);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.btngeneratechart);
            this.ForeColor = System.Drawing.Color.DarkGray;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCandidatelifecyclereport";
            this.Text = "frmCandidateLifecyclereport";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Form1_MouseClick);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btngeneratechart;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView grdview;
        private System.Windows.Forms.CheckedListBox checklist;
        private System.Windows.Forms.DateTimePicker dtformat1;
        private System.Windows.Forms.DateTimePicker dtformat2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
    }
}

