namespace GayaSoftHRForum
{
    partial class frmAddSpecialization
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
            this.cmbbxQualificationAddSpec = new System.Windows.Forms.ComboBox();
            this.lblQualification = new System.Windows.Forms.Label();
            this.lblAddQualification = new System.Windows.Forms.Label();
            this.btnSaveSpecialization = new System.Windows.Forms.Button();
            this.txtSpecializationName = new System.Windows.Forms.TextBox();
            this.lblQualificationName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbbxQualificationAddSpec
            // 
            this.cmbbxQualificationAddSpec.FormattingEnabled = true;
            this.cmbbxQualificationAddSpec.Location = new System.Drawing.Point(200, 79);
            this.cmbbxQualificationAddSpec.Margin = new System.Windows.Forms.Padding(4);
            this.cmbbxQualificationAddSpec.Name = "cmbbxQualificationAddSpec";
            this.cmbbxQualificationAddSpec.Size = new System.Drawing.Size(180, 24);
            this.cmbbxQualificationAddSpec.TabIndex = 35;
            // 
            // lblQualification
            // 
            this.lblQualification.AutoSize = true;
            this.lblQualification.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQualification.Location = new System.Drawing.Point(28, 79);
            this.lblQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualification.Name = "lblQualification";
            this.lblQualification.Size = new System.Drawing.Size(147, 26);
            this.lblQualification.TabIndex = 34;
            this.lblQualification.Text = "Qualification";
            // 
            // lblAddQualification
            // 
            this.lblAddQualification.AutoSize = true;
            this.lblAddQualification.BackColor = System.Drawing.Color.Transparent;
            this.lblAddQualification.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddQualification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddQualification.Location = new System.Drawing.Point(92, 9);
            this.lblAddQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddQualification.Name = "lblAddQualification";
            this.lblAddQualification.Size = new System.Drawing.Size(233, 31);
            this.lblAddQualification.TabIndex = 42;
            this.lblAddQualification.Text = "Add Specialization";
            // 
            // btnSaveSpecialization
            // 
            this.btnSaveSpecialization.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveSpecialization.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSpecialization.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveSpecialization.Location = new System.Drawing.Point(153, 193);
            this.btnSaveSpecialization.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveSpecialization.Name = "btnSaveSpecialization";
            this.btnSaveSpecialization.Size = new System.Drawing.Size(108, 39);
            this.btnSaveSpecialization.TabIndex = 45;
            this.btnSaveSpecialization.Text = "Save";
            this.btnSaveSpecialization.UseVisualStyleBackColor = false;
            this.btnSaveSpecialization.Click += new System.EventHandler(this.btnSaveSpecialization_Click);
            // 
            // txtSpecializationName
            // 
            this.txtSpecializationName.Location = new System.Drawing.Point(200, 133);
            this.txtSpecializationName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSpecializationName.Name = "txtSpecializationName";
            this.txtSpecializationName.Size = new System.Drawing.Size(180, 22);
            this.txtSpecializationName.TabIndex = 47;
            // 
            // lblQualificationName
            // 
            this.lblQualificationName.AutoSize = true;
            this.lblQualificationName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQualificationName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQualificationName.Location = new System.Drawing.Point(28, 133);
            this.lblQualificationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualificationName.Name = "lblQualificationName";
            this.lblQualificationName.Size = new System.Drawing.Size(71, 26);
            this.lblQualificationName.TabIndex = 46;
            this.lblQualificationName.Text = "Name";
            this.lblQualificationName.Click += new System.EventHandler(this.lblQualificationName_Click);
            // 
            // frmAddSpecialization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(432, 257);
            this.Controls.Add(this.txtSpecializationName);
            this.Controls.Add(this.lblQualificationName);
            this.Controls.Add(this.btnSaveSpecialization);
            this.Controls.Add(this.lblAddQualification);
            this.Controls.Add(this.cmbbxQualificationAddSpec);
            this.Controls.Add(this.lblQualification);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddSpecialization";
            this.Text = "frmAddSpecialization";
            this.Load += new System.EventHandler(this.frmAddSpecialization_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbbxQualificationAddSpec;
        private System.Windows.Forms.Label lblQualification;
        private System.Windows.Forms.Label lblAddQualification;
        private System.Windows.Forms.Button btnSaveSpecialization;
        private System.Windows.Forms.TextBox txtSpecializationName;
        private System.Windows.Forms.Label lblQualificationName;
    }
}