namespace GayaSoftHRForum
{
    partial class frmAddQualification
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
            this.btnSaveQualification = new System.Windows.Forms.Button();
            this.txtQualificationName = new System.Windows.Forms.TextBox();
            this.lblQualificationName = new System.Windows.Forms.Label();
            this.lblAddQualification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSaveQualification
            // 
            this.btnSaveQualification.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(123)))), ((int)(((byte)(119)))));
            this.btnSaveQualification.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveQualification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSaveQualification.Location = new System.Drawing.Point(123, 147);
            this.btnSaveQualification.Margin = new System.Windows.Forms.Padding(4);
            this.btnSaveQualification.Name = "btnSaveQualification";
            this.btnSaveQualification.Size = new System.Drawing.Size(106, 43);
            this.btnSaveQualification.TabIndex = 44;
            this.btnSaveQualification.Text = "Save";
            this.btnSaveQualification.UseVisualStyleBackColor = false;
            this.btnSaveQualification.Click += new System.EventHandler(this.btnSaveState_Click);
            // 
            // txtQualificationName
            // 
            this.txtQualificationName.Location = new System.Drawing.Point(173, 92);
            this.txtQualificationName.Margin = new System.Windows.Forms.Padding(4);
            this.txtQualificationName.Name = "txtQualificationName";
            this.txtQualificationName.Size = new System.Drawing.Size(160, 22);
            this.txtQualificationName.TabIndex = 43;
            // 
            // lblQualificationName
            // 
            this.lblQualificationName.AutoSize = true;
            this.lblQualificationName.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.lblQualificationName.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblQualificationName.Location = new System.Drawing.Point(40, 88);
            this.lblQualificationName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblQualificationName.Name = "lblQualificationName";
            this.lblQualificationName.Size = new System.Drawing.Size(71, 26);
            this.lblQualificationName.TabIndex = 42;
            this.lblQualificationName.Text = "Name";
            // 
            // lblAddQualification
            // 
            this.lblAddQualification.AutoSize = true;
            this.lblAddQualification.BackColor = System.Drawing.Color.Transparent;
            this.lblAddQualification.Font = new System.Drawing.Font("Times New Roman", 16F, System.Drawing.FontStyle.Bold);
            this.lblAddQualification.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.lblAddQualification.Location = new System.Drawing.Point(72, 26);
            this.lblAddQualification.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblAddQualification.Name = "lblAddQualification";
            this.lblAddQualification.Size = new System.Drawing.Size(225, 31);
            this.lblAddQualification.TabIndex = 41;
            this.lblAddQualification.Text = "Add Qualification";
            // 
            // frmAddQualification
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(99)))), ((int)(((byte)(99)))), ((int)(((byte)(99)))));
            this.ClientSize = new System.Drawing.Size(371, 203);
            this.Controls.Add(this.btnSaveQualification);
            this.Controls.Add(this.txtQualificationName);
            this.Controls.Add(this.lblQualificationName);
            this.Controls.Add(this.lblAddQualification);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAddQualification";
            this.Text = "frmAddQualification";
            this.Load += new System.EventHandler(this.frmAddQualification_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSaveQualification;
        private System.Windows.Forms.TextBox txtQualificationName;
        private System.Windows.Forms.Label lblQualificationName;
        private System.Windows.Forms.Label lblAddQualification;
    }
}