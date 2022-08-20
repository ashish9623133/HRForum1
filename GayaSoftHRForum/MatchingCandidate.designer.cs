namespace GayaSoftHRForum
{
    partial class MatchingCandidate
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MatchingCandidate));
            this.lblMatching_Candidate = new System.Windows.Forms.Label();
            this.grdMatchingCandidate = new System.Windows.Forms.DataGridView();
            this.Select_Candidate = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.CandidateID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Full_Name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Email_ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contact_No = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Resume = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnAssign_Candidate = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdMatchingCandidate)).BeginInit();
            this.SuspendLayout();
            // 
            // lblMatching_Candidate
            // 
            this.lblMatching_Candidate.AutoSize = true;
            this.lblMatching_Candidate.BackColor = System.Drawing.Color.Transparent;
            this.lblMatching_Candidate.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblMatching_Candidate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblMatching_Candidate.Location = new System.Drawing.Point(12, 20);
            this.lblMatching_Candidate.Name = "lblMatching_Candidate";
            this.lblMatching_Candidate.Size = new System.Drawing.Size(254, 31);
            this.lblMatching_Candidate.TabIndex = 0;
            this.lblMatching_Candidate.Text = "Matching Candidate";
            // 
            // grdMatchingCandidate
            // 
            this.grdMatchingCandidate.AllowUserToAddRows = false;
            this.grdMatchingCandidate.BackgroundColor = System.Drawing.Color.Azure;
            this.grdMatchingCandidate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdMatchingCandidate.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Select_Candidate,
            this.CandidateID,
            this.Full_Name,
            this.Email_ID,
            this.Contact_No,
            this.Position,
            this.Resume});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.Beige;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdMatchingCandidate.DefaultCellStyle = dataGridViewCellStyle1;
            this.grdMatchingCandidate.Location = new System.Drawing.Point(3, 128);
            this.grdMatchingCandidate.Name = "grdMatchingCandidate";
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Azure;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdMatchingCandidate.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.grdMatchingCandidate.RowHeadersWidth = 51;
            this.grdMatchingCandidate.RowTemplate.Height = 24;
            this.grdMatchingCandidate.Size = new System.Drawing.Size(795, 320);
            this.grdMatchingCandidate.TabIndex = 2;
            this.grdMatchingCandidate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMatchingCandidate_CellClick);
            this.grdMatchingCandidate.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdMatchingCandidate_CellContentClick);
            // 
            // Select_Candidate
            // 
            this.Select_Candidate.HeaderText = "Select All";
            this.Select_Candidate.MinimumWidth = 6;
            this.Select_Candidate.Name = "Select_Candidate";
            this.Select_Candidate.Width = 125;
            // 
            // CandidateID
            // 
            this.CandidateID.DataPropertyName = "Candidate_ID";
            this.CandidateID.HeaderText = "Candidate ID";
            this.CandidateID.MinimumWidth = 6;
            this.CandidateID.Name = "CandidateID";
            this.CandidateID.Width = 125;
            // 
            // Full_Name
            // 
            this.Full_Name.DataPropertyName = "Full_Name";
            this.Full_Name.HeaderText = "Full Name";
            this.Full_Name.MinimumWidth = 6;
            this.Full_Name.Name = "Full_Name";
            this.Full_Name.Width = 125;
            // 
            // Email_ID
            // 
            this.Email_ID.DataPropertyName = "Email_ID";
            this.Email_ID.HeaderText = "Email ID";
            this.Email_ID.MinimumWidth = 6;
            this.Email_ID.Name = "Email_ID";
            this.Email_ID.Width = 125;
            // 
            // Contact_No
            // 
            this.Contact_No.DataPropertyName = "Contact_No";
            this.Contact_No.HeaderText = "Contact No";
            this.Contact_No.MinimumWidth = 6;
            this.Contact_No.Name = "Contact_No";
            this.Contact_No.Width = 125;
            // 
            // Position
            // 
            this.Position.DataPropertyName = "Position";
            this.Position.HeaderText = "Position";
            this.Position.MinimumWidth = 6;
            this.Position.Name = "Position";
            this.Position.Width = 125;
            // 
            // Resume
            // 
            this.Resume.DataPropertyName = "Resume";
            this.Resume.HeaderText = "Resume";
            this.Resume.MinimumWidth = 6;
            this.Resume.Name = "Resume";
            this.Resume.Width = 125;
            // 
            // btnAssign_Candidate
            // 
            this.btnAssign_Candidate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnAssign_Candidate.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnAssign_Candidate.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAssign_Candidate.Location = new System.Drawing.Point(18, 77);
            this.btnAssign_Candidate.Name = "btnAssign_Candidate";
            this.btnAssign_Candidate.Size = new System.Drawing.Size(108, 36);
            this.btnAssign_Candidate.TabIndex = 3;
            this.btnAssign_Candidate.Text = "Assign Candidate";
            this.btnAssign_Candidate.UseVisualStyleBackColor = false;
            this.btnAssign_Candidate.Click += new System.EventHandler(this.btnAssign_Candidate_Click);
            // 
            // button2
            // 
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(141, 77);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(36, 39);
            this.button2.TabIndex = 49;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // MatchingCandidate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAssign_Candidate);
            this.Controls.Add(this.grdMatchingCandidate);
            this.Controls.Add(this.lblMatching_Candidate);
            this.Name = "MatchingCandidate";
            this.Text = "MatchingCandidate";
            this.Load += new System.EventHandler(this.MatchingCandidate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grdMatchingCandidate)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMatching_Candidate;
        private System.Windows.Forms.DataGridView grdMatchingCandidate;
        private System.Windows.Forms.Button btnAssign_Candidate;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Select_Candidate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CandidateID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Full_Name;
        private System.Windows.Forms.DataGridViewTextBoxColumn Email_ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contact_No;
        private System.Windows.Forms.DataGridViewTextBoxColumn Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn Resume;
    }
}