namespace GayaSoftHRForum
{
    partial class Assigned_Candidate
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Assigned_Candidate));
            this.lblAssignedCandidate = new System.Windows.Forms.Label();
            this.grdAssignedCandidate = new System.Windows.Forms.DataGridView();
            this.Schedule = new System.Windows.Forms.DataGridViewButtonColumn();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Job_Title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Company_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignedCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAssignedCandidate
            // 
            this.lblAssignedCandidate.AutoSize = true;
            this.lblAssignedCandidate.BackColor = System.Drawing.Color.Transparent;
            this.lblAssignedCandidate.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAssignedCandidate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAssignedCandidate.Location = new System.Drawing.Point(35, 31);
            this.lblAssignedCandidate.Name = "lblAssignedCandidate";
            this.lblAssignedCandidate.Size = new System.Drawing.Size(306, 38);
            this.lblAssignedCandidate.TabIndex = 0;
            this.lblAssignedCandidate.Text = "Assigned Candidate";
            this.lblAssignedCandidate.Click += new System.EventHandler(this.lblAssignedCandidate_Click);
            // 
            // grdAssignedCandidate
            // 
            this.grdAssignedCandidate.AllowUserToAddRows = false;
            this.grdAssignedCandidate.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grdAssignedCandidate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.grdAssignedCandidate.BackgroundColor = System.Drawing.Color.Azure;
            this.grdAssignedCandidate.ColumnHeadersHeight = 30;
            this.grdAssignedCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Schedule,
            this.CandidateID,
            this.Full_Name,
            this.Job_Title,
            this.Company_Name,
            this.Email_ID,
            this.Contact_No,
            this.Status});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdAssignedCandidate.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdAssignedCandidate.Location = new System.Drawing.Point(12, 165);
            this.grdAssignedCandidate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.grdAssignedCandidate.Name = "grdAssignedCandidate";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdAssignedCandidate.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdAssignedCandidate.RowHeadersWidth = 51;
            this.grdAssignedCandidate.RowTemplate.Height = 24;
            this.grdAssignedCandidate.Size = new System.Drawing.Size(1352, 224);
            this.grdAssignedCandidate.TabIndex = 1;
            this.grdAssignedCandidate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssignedCandidate_CellClick);
            this.grdAssignedCandidate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdAssignedCandidate_CellContentClick);
            // 
            // Schedule
            // 
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(2);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.Teal;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            this.Schedule.DefaultCellStyle = dataGridViewCellStyle1;
            this.Schedule.HeaderText = "Schedule";
            this.Schedule.MinimumWidth = 6;
            this.Schedule.Name = "Schedule";
            this.Schedule.Text = "Schedule Interview";
            this.Schedule.ToolTipText = "Schedule Interview";
            this.Schedule.UseColumnTextForButtonValue = true;
            // 
            // CandidateID
            // 
            this.CandidateID.DataPropertyName = "Candidate_ID";
            this.CandidateID.HeaderText = "Candidate ID";
            this.CandidateID.MinimumWidth = 6;
            this.CandidateID.Name = "CandidateID";
            // 
            // Full_Name
            // 
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.HeaderText = "Full Name";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            // 
            // Job_Title
            // 
            this.Job_Title.DataPropertyName = "Job_Title";
            this.Job_Title.HeaderText = "Job Title";
            this.Job_Title.MinimumWidth = 6;
            this.Job_Title.Name = "Job_Title";
            // 
            // Company_Name
            // 
            this.Company_Name.DataPropertyName = "Company_Name";
            this.Company_Name.HeaderText = "Company Name";
            this.Company_Name.MinimumWidth = 6;
            this.Company_Name.Name = "Company_Name";
            // 
            // Email_ID
            // 
            this.Email_ID.DataPropertyName = "Email_ID";
            this.Email_ID.HeaderText = "Email ID";
            this.Email_ID.MinimumWidth = 6;
            this.Email_ID.Name = "Email_ID";
            // 
            // Contact_No
            // 
            this.Contact_No.DataPropertyName = "Contact_No";
            this.Contact_No.HeaderText = "Contact No";
            this.Contact_No.MinimumWidth = 6;
            this.Contact_No.Name = "Contact_No";
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(31, 108);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 39);
            this.button2.TabIndex = 49;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Assigned_Candidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1368, 572);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.grdAssignedCandidate);
            this.Controls.Add(this.lblAssignedCandidate);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Assigned_Candidate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Assigned_Candidate";
            this.Load += new System.EventHandler(this.Assigned_Candidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdAssignedCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblAssignedCandidate;
        private System.Windows.Forms.DataGridView grdAssignedCandidate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewButtonColumn Schedule;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Job_Title;
        private System.Windows.Forms.DataGridViewTextBoxColumn Company_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
    }
}