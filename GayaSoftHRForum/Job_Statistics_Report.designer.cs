namespace GayaSoftHRForum
{
    partial class Job_Statistics_Report
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Job_Statistics_Report));
            this.cmbbxJobTitle = new System.Windows.Forms.ComboBox();
            this.chklistStatus = new System.Windows.Forms.CheckedListBox();
            this.dtFromdate = new System.Windows.Forms.DateTimePicker();
            this.dtTodate = new System.Windows.Forms.DateTimePicker();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.grdJobStatastics = new System.Windows.Forms.DataGridView();
            this.btnGenerate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobStatastics)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbbxJobTitle
            // 
            this.cmbbxJobTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxJobTitle.FormattingEnabled = true;
            this.cmbbxJobTitle.Location = new System.Drawing.Point(26, 115);
            this.cmbbxJobTitle.Name = "cmbbxJobTitle";
            this.cmbbxJobTitle.Size = new System.Drawing.Size(221, 37);
            this.cmbbxJobTitle.TabIndex = 0;
            this.cmbbxJobTitle.Text = "Select Job Title";
            // 
            // chklistStatus
            // 
            this.chklistStatus.BackColor = System.Drawing.Color.LightGray;
            this.chklistStatus.CheckOnClick = true;
            this.chklistStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chklistStatus.FormattingEnabled = true;
            this.chklistStatus.Items.AddRange(new object[] {
            "Assigned",
            "Interview Scheduled",
            "Not Attended",
            "Interview Rescheduled",
            "Interviewed",
            "On Hold",
            "Rejected",
            "Selected",
            "Offered",
            "Offer Accepted",
            "Placed"});
            this.chklistStatus.Location = new System.Drawing.Point(1055, 181);
            this.chklistStatus.Name = "chklistStatus";
            this.chklistStatus.Size = new System.Drawing.Size(314, 252);
            this.chklistStatus.TabIndex = 1;
            this.chklistStatus.ItemCheck += new System.Windows.Forms.ItemCheckEventHandler(this.chklistStatus_ItemCheck);
            this.chklistStatus.Click += new System.EventHandler(this.chklistStatus_Click);
            this.chklistStatus.SelectedIndexChanged += new System.EventHandler(this.chklistStatus_SelectedIndexChanged);
            // 
            // dtFromdate
            // 
            this.dtFromdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtFromdate.Location = new System.Drawing.Point(364, 112);
            this.dtFromdate.Name = "dtFromdate";
            this.dtFromdate.Size = new System.Drawing.Size(273, 36);
            this.dtFromdate.TabIndex = 2;
            // 
            // dtTodate
            // 
            this.dtTodate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtTodate.Location = new System.Drawing.Point(738, 112);
            this.dtTodate.Name = "dtTodate";
            this.dtTodate.Size = new System.Drawing.Size(281, 36);
            this.dtTodate.TabIndex = 3;
            // 
            // chart1
            // 
            chartArea4.AxisX.MajorGrid.Enabled = false;
            chartArea4.AxisY.MajorGrid.Enabled = false;
            chartArea4.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart1.Legends.Add(legend4);
            this.chart1.Location = new System.Drawing.Point(26, 181);
            this.chart1.Name = "chart1";
            series4.ChartArea = "ChartArea1";
            series4.Legend = "Legend1";
            series4.Name = "Candidate_Count";
            this.chart1.Series.Add(series4);
            this.chart1.Size = new System.Drawing.Size(1005, 341);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            this.chart1.Click += new System.EventHandler(this.chart1_Click);
            // 
            // grdJobStatastics
            // 
            this.grdJobStatastics.AllowUserToAddRows = false;
            this.grdJobStatastics.BackgroundColor = System.Drawing.Color.Azure;
            this.grdJobStatastics.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdJobStatastics.Location = new System.Drawing.Point(26, 605);
            this.grdJobStatastics.Name = "grdJobStatastics";
            this.grdJobStatastics.RowHeadersVisible = false;
            this.grdJobStatastics.RowHeadersWidth = 51;
            this.grdJobStatastics.RowTemplate.Height = 24;
            this.grdJobStatastics.Size = new System.Drawing.Size(1394, 273);
            this.grdJobStatastics.TabIndex = 5;
            // 
            // btnGenerate
            // 
            this.btnGenerate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerate.Location = new System.Drawing.Point(1055, 112);
            this.btnGenerate.Name = "btnGenerate";
            this.btnGenerate.Size = new System.Drawing.Size(178, 40);
            this.btnGenerate.TabIndex = 8;
            this.btnGenerate.Text = "Generate Chart";
            this.btnGenerate.UseVisualStyleBackColor = true;
            this.btnGenerate.Click += new System.EventHandler(this.btnGenerate_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(262, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 29);
            this.label1.TabIndex = 9;
            this.label1.Text = "From";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(690, 119);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 29);
            this.label2.TabIndex = 10;
            this.label2.Text = "To";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(67, 548);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 29);
            this.label3.TabIndex = 60;
            this.label3.Text = "Export";
            // 
            // button1
            // 
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.Location = new System.Drawing.Point(185, 529);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(81, 69);
            this.button1.TabIndex = 59;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Job_Statistics_Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(1469, 890);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnGenerate);
            this.Controls.Add(this.grdJobStatastics);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.dtTodate);
            this.Controls.Add(this.dtFromdate);
            this.Controls.Add(this.chklistStatus);
            this.Controls.Add(this.cmbbxJobTitle);
            this.Name = "Job_Statistics_Report";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Job_Statistics_Report_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdJobStatastics)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxJobTitle;
        private System.Windows.Forms.CheckedListBox chklistStatus;
        private System.Windows.Forms.DateTimePicker dtFromdate;
        private System.Windows.Forms.DateTimePicker dtTodate;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView grdJobStatastics;
        private System.Windows.Forms.Button btnGenerate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button1;
    }
}