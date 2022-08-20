namespace GayaSoftHRForum
{
    partial class frmEducationInformation
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
            this.lbleducation = new System.Windows.Forms.Label();
            this.lblTotalExperience = new System.Windows.Forms.Label();
            this.cmbbxSpecialization = new System.Windows.Forms.ComboBox();
            this.lblSpecialization = new System.Windows.Forms.Label();
            this.cmbbxQualification = new System.Windows.Forms.ComboBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.btnSaveEducation = new System.Windows.Forms.Button();
            this.lblAddQualification = new System.Windows.Forms.Label();
            this.lblAddSpecialization = new System.Windows.Forms.Label();
            this.lblExperience = new System.Windows.Forms.Label();
            this.rdbbtnFresher = new System.Windows.Forms.RadioButton();
            this.rdbbtnExperienced = new System.Windows.Forms.RadioButton();
            this.btnUpdatePI = new System.Windows.Forms.Button();
            this.cmbbxTotAlExperience = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // lbleducation
            // 
            this.lbleducation.AutoSize = true;
            this.lbleducation.BackColor = System.Drawing.Color.Transparent;
            this.lbleducation.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbleducation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lbleducation.Location = new System.Drawing.Point(675, 37);
            this.lbleducation.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbleducation.Name = "lbleducation";
            this.lbleducation.Size = new System.Drawing.Size(303, 32);
            this.lbleducation.TabIndex = 31;
            this.lbleducation.Text = "Education Qualification";
            this.lbleducation.Click += new System.EventHandler(this.lbleducation_Click);
            // 
            // lblTotalExperience
            // 
            this.lblTotalExperience.AutoSize = true;
            this.lblTotalExperience.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalExperience.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblTotalExperience.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblTotalExperience.Location = new System.Drawing.Point(380, 321);
            this.lblTotalExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTotalExperience.Name = "lblTotalExperience";
            this.lblTotalExperience.Size = new System.Drawing.Size(186, 26);
            this.lblTotalExperience.TabIndex = 36;
            this.lblTotalExperience.Text = "Total Experience";
            // 
            // cmbbxSpecialization
            // 
            this.cmbbxSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxSpecialization.FormattingEnabled = true;
            this.cmbbxSpecialization.Location = new System.Drawing.Point(1106, 115);
            this.cmbbxSpecialization.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxSpecialization.Name = "cmbbxSpecialization";
            this.cmbbxSpecialization.Size = new System.Drawing.Size(160, 33);
            this.cmbbxSpecialization.TabIndex = 35;
            this.cmbbxSpecialization.SelectedIndexChanged += new System.EventHandler(this.cmbbxSpecialization_SelectedIndexChanged);
            this.cmbbxSpecialization.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbxSpecialization_MouseClick);
            // 
            // lblSpecialization
            // 
            this.lblSpecialization.AutoSize = true;
            this.lblSpecialization.BackColor = System.Drawing.Color.Transparent;
            this.lblSpecialization.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblSpecialization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblSpecialization.Location = new System.Drawing.Point(918, 122);
            this.lblSpecialization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSpecialization.Name = "lblSpecialization";
            this.lblSpecialization.Size = new System.Drawing.Size(154, 26);
            this.lblSpecialization.TabIndex = 34;
            this.lblSpecialization.Text = "Specialization";
            this.lblSpecialization.Click += new System.EventHandler(this.lblSpecialization_Click);
            // 
            // cmbbxQualification
            // 
            this.cmbbxQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxQualification.FormattingEnabled = true;
            this.cmbbxQualification.Location = new System.Drawing.Point(594, 119);
            this.cmbbxQualification.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxQualification.Name = "cmbbxQualification";
            this.cmbbxQualification.Size = new System.Drawing.Size(160, 33);
            this.cmbbxQualification.TabIndex = 33;
            this.cmbbxQualification.SelectedIndexChanged += new System.EventHandler(this.cmbbxQualification_SelectedIndexChanged);
            this.cmbbxQualification.MouseClick += new System.Windows.Forms.MouseEventHandler(this.cmbbxQualification_MouseClick);
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.BackColor = System.Drawing.Color.Transparent;
            this.lblQualification.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblQualification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQualification.Location = new System.Drawing.Point(380, 122);
            this.lblQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(147, 26);
            this.lblQualification.TabIndex = 32;
            this.lblQualification.Text = "Qualification";
            // 
            // btnSaveEducation
            // 
            this.btnSaveEducation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveEducation.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnSaveEducation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveEducation.Location = new System.Drawing.Point(905, 444);
            this.btnSaveEducation.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveEducation.Name = "btnSaveEducation";
            this.btnSaveEducation.Size = new System.Drawing.Size(248, 52);
            this.btnSaveEducation.TabIndex = 43;
            this.btnSaveEducation.Text = "Next ";
            this.btnSaveEducation.UseVisualStyleBackColor = false;
            this.btnSaveEducation.Click += new System.EventHandler(this.btnSaveEducation_Click);
            // 
            // lblAddQualification
            // 
            this.lblAddQualification.AutoSize = true;
            this.lblAddQualification.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAddQualification.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQualification.Location = new System.Drawing.Point(763, 119);
            this.lblAddQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddQualification.Name = "lblAddQualification";
            this.lblAddQualification.Size = new System.Drawing.Size(30, 31);
            this.lblAddQualification.TabIndex = 87;
            this.lblAddQualification.Text = "+";
            this.lblAddQualification.Click += new System.EventHandler(this.lblAddQualification_Click);
            // 
            // lblAddSpecialization
            // 
            this.lblAddSpecialization.AutoSize = true;
            this.lblAddSpecialization.BackColor = System.Drawing.Color.DodgerBlue;
            this.lblAddSpecialization.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblAddSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddSpecialization.Location = new System.Drawing.Point(1274, 115);
            this.lblAddSpecialization.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddSpecialization.Name = "lblAddSpecialization";
            this.lblAddSpecialization.Size = new System.Drawing.Size(30, 31);
            this.lblAddSpecialization.TabIndex = 88;
            this.lblAddSpecialization.Text = "+";
            this.lblAddSpecialization.Click += new System.EventHandler(this.lblAddSpecialization_Click);
            // 
            // lblExperience
            // 
            this.lblExperience.AutoSize = true;
            this.lblExperience.BackColor = System.Drawing.Color.Transparent;
            this.lblExperience.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblExperience.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblExperience.Location = new System.Drawing.Point(380, 222);
            this.lblExperience.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblExperience.Name = "lblExperience";
            this.lblExperience.Size = new System.Drawing.Size(128, 26);
            this.lblExperience.TabIndex = 91;
            this.lblExperience.Text = "Experience";
            // 
            // rdbbtnFresher
            // 
            this.rdbbtnFresher.AutoSize = true;
            this.rdbbtnFresher.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnFresher.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.rdbbtnFresher.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbbtnFresher.Location = new System.Drawing.Point(594, 218);
            this.rdbbtnFresher.Margin = new System.Windows.Forms.Padding(4);
            this.rdbbtnFresher.Name = "rdbbtnFresher";
            this.rdbbtnFresher.Size = new System.Drawing.Size(114, 30);
            this.rdbbtnFresher.TabIndex = 92;
            this.rdbbtnFresher.TabStop = true;
            this.rdbbtnFresher.Text = "Fresher";
            this.rdbbtnFresher.UseVisualStyleBackColor = false;
            // 
            // rdbbtnExperienced
            // 
            this.rdbbtnExperienced.AutoSize = true;
            this.rdbbtnExperienced.BackColor = System.Drawing.Color.Transparent;
            this.rdbbtnExperienced.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.rdbbtnExperienced.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rdbbtnExperienced.Location = new System.Drawing.Point(716, 218);
            this.rdbbtnExperienced.Margin = new System.Windows.Forms.Padding(4);
            this.rdbbtnExperienced.Name = "rdbbtnExperienced";
            this.rdbbtnExperienced.Size = new System.Drawing.Size(162, 30);
            this.rdbbtnExperienced.TabIndex = 93;
            this.rdbbtnExperienced.TabStop = true;
            this.rdbbtnExperienced.Text = "Experienced";
            this.rdbbtnExperienced.UseVisualStyleBackColor = false;
            // 
            // btnUpdatePI
            // 
            this.btnUpdatePI.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnUpdatePI.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.btnUpdatePI.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnUpdatePI.Location = new System.Drawing.Point(466, 444);
            this.btnUpdatePI.Margin = new System.Windows.Forms.Padding(4);
            this.btnUpdatePI.Name = "btnUpdatePI";
            this.btnUpdatePI.Size = new System.Drawing.Size(288, 52);
            this.btnUpdatePI.TabIndex = 95;
            this.btnUpdatePI.Text = "Update and Next ";
            this.btnUpdatePI.UseVisualStyleBackColor = false;
            this.btnUpdatePI.Click += new System.EventHandler(this.btnUpdatePI_Click);
            // 
            // cmbbxTotAlExperience
            // 
            this.cmbbxTotAlExperience.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbbxTotAlExperience.FormattingEnabled = true;
            this.cmbbxTotAlExperience.Location = new System.Drawing.Point(594, 321);
            this.cmbbxTotAlExperience.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxTotAlExperience.Name = "cmbbxTotAlExperience";
            this.cmbbxTotAlExperience.Size = new System.Drawing.Size(199, 33);
            this.cmbbxTotAlExperience.TabIndex = 96;
            // 
            // frmEducationInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1763, 660);
            this.Controls.Add(this.cmbbxTotAlExperience);
            this.Controls.Add(this.btnUpdatePI);
            this.Controls.Add(this.rdbbtnExperienced);
            this.Controls.Add(this.rdbbtnFresher);
            this.Controls.Add(this.lblExperience);
            this.Controls.Add(this.lblAddSpecialization);
            this.Controls.Add(this.lblAddQualification);
            this.Controls.Add(this.btnSaveEducation);
            this.Controls.Add(this.lblTotalExperience);
            this.Controls.Add(this.cmbbxSpecialization);
            this.Controls.Add(this.lblSpecialization);
            this.Controls.Add(this.cmbbxQualification);
            this.Controls.Add(this.lblQualification);
            this.Controls.Add(this.lbleducation);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmEducationInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEducationInformation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmEducationInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbleducation;
        private System.Windows.Forms.Label lblTotalExperience;
        private System.Windows.Forms.ComboBox cmbbxSpecialization;
        private System.Windows.Forms.Label lblSpecialization;
        private System.Windows.Forms.ComboBox cmbbxQualification;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Button btnSaveEducation;
        private System.Windows.Forms.Label lblAddQualification;
        private System.Windows.Forms.Label lblAddSpecialization;
        private System.Windows.Forms.Label lblExperience;
        private System.Windows.Forms.RadioButton rdbbtnFresher;
        private System.Windows.Forms.RadioButton rdbbtnExperienced;
        private System.Windows.Forms.Button btnUpdatePI;
        private System.Windows.Forms.ComboBox cmbbxTotAlExperience;
    }
}